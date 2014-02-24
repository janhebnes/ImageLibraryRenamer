using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageLibraryRenamer
{
    using System.Diagnostics;
    using System.IO;

    public class ImageRelocator
    {
        public struct RelocateImagesParams
        {
            private readonly string _searchPattern;

            private readonly string _datePattern;

            private readonly bool _useExifDataToGetDate;

            private readonly bool _useFileDateIfNoExif;

            private readonly bool _recursive;

            private readonly bool _testMode;

            public RelocateImagesParams(
                string searchPattern,
                string datePattern,
                bool useExifDataToGetDate,
                bool useFileDateIfNoExif,
                bool Recursive,
                bool TestMode)
                : this()
            {
                {
                    _searchPattern = searchPattern;
                    _datePattern = datePattern;
                    _useExifDataToGetDate = useExifDataToGetDate;
                    _useFileDateIfNoExif = useFileDateIfNoExif;
                    _recursive = Recursive;
                    _testMode = TestMode;
                    SkipTopLevel = true;
                    SkipNumeric = false;
                    SkipFolders = null;
                    Logger = null;
                }

            }

            public string SearchPattern
            {
                get
                {
                    return _searchPattern;
                }
            }

            public string DatePattern
            {
                get
                {
                    return _datePattern;
                }
            }

            public bool UseExifDataToGetDate
            {
                get
                {
                    return _useExifDataToGetDate;
                }
            }

            public bool UseFileDateIfNoExif
            {
                get
                {
                    return _useFileDateIfNoExif;
                }
            }

            public bool Recursive
            {
                get
                {
                    return _recursive;
                }
            }

            public bool TestMode
            {
                get
                {
                    return _testMode;
                }
            }

            public ActivityLogger Logger { get; set; }

            public bool SkipTopLevel { get; set; }

            public bool SkipNumeric { get; set; }

            public string SkipFolders { get; set; }

            public bool SkipIfFolderHasXmpFile { get; set; }

            public bool SkipIfFolderNameAlreadyHasDate { get; set; }
        }

        
        public Dictionary<string, string> RenameQueue = new Dictionary<string, string>();
        private RelocateImagesParams options;

        public ImageRelocator(RelocateImagesParams options)
        {
            this.options = options;
        }

        public void ParseImageDates(string directoryName)
        {
            if (string.IsNullOrWhiteSpace(directoryName) || !Directory.Exists(directoryName))
            {
                options.Logger.FatalLog(status: directoryName + " directory does not exist");
                return;
            }

            var directoryInfo = new DirectoryInfo(directoryName);

            if (directoryInfo.Name.StartsWith("."))
            {
                options.Logger.Log(string.Format("(Skipping hidden folder {0})", directoryName));
                return;
            }

            options.Logger.Log("Checking " + directoryName + " ");

            var files = directoryInfo.GetFiles(options.SearchPattern).ToList();

            if (options.SkipTopLevel)
            {
                options.SkipTopLevel = false;
                options.Logger.Log("Skipping top level: " + directoryInfo.Name);

                ParseSubDirectories(directoryInfo);
                return;
            }

            if (options.SkipNumeric && IsNumber(directoryInfo.Name))
            {
                options.Logger.Log("Skipping numeric: " + directoryInfo.Name);

                ParseSubDirectories(directoryInfo);
                return;
            }

            if (options.SkipFolders.Contains(directoryInfo.Name))
            {
                options.Logger.Log("Skipping: " + directoryInfo.Name);
                return;
            }

            if (options.SkipIfFolderHasXmpFile && files.Any(f => f.Extension == ".xmp"))
            {
                options.Logger.Log("Skipping: " + directoryInfo.Name);

                ParseSubDirectories(directoryInfo);
                return;
            }

            
            foreach (var file in files)
            {
                DateTime? exifDate = null;
                DateTime? fileCreateDate = null;

                options.Logger.LogAppendToLast(".");

                if (options.UseExifDataToGetDate)
                {
                    exifDate = ImageViewer.GetTakenTime(file.FullName);

                    if (exifDate != null && exifDate.Value.Year > 1994) // exif invented in 1995
                    {
                        options.Logger.Log("Found EXIF date: " + exifDate);
                    }
                }

                if (!options.UseFileDateIfNoExif) continue;

                if (fileCreateDate == null || file.CreationTime < fileCreateDate)
                {
                    fileCreateDate = file.CreationTime;
                }

                if (fileCreateDate == null || file.LastWriteTime < fileCreateDate)
                {
                    fileCreateDate = file.LastWriteTime;
                }

                if (fileCreateDate == null || file.LastAccessTime < fileCreateDate)
                {
                    fileCreateDate = file.LastAccessTime;
                }

                if (exifDate == null && fileCreateDate == null)
                {
                    options.Logger.Log("[SKIPPING] No dates found.");
                    continue;
                }

                DateTime folderDate = exifDate != null ? exifDate.Value : fileCreateDate.Value;
                string pattern = options.DatePattern.Replace("[folder]", "[]");

                string dateString = folderDate.ToString(pattern);

                if (dateString.Contains(directoryInfo.Name))
                {
                    options.Logger.Log("[SKIPPING] folder name already contains the same date");
                    continue;
                }

                if (dateString.Contains(directoryInfo.Name.Split(' ').First()))
                {
                    options.Logger.Log("[SKIPPING] folder name already contains the same date");
                    continue;
                }

                // The File as a date and the current folder does not match this date

                var nearestTarget = GetNearestTargetDirectory(directoryInfo, folderDate);
                if (nearestTarget == null)
                {
                    nearestTarget = GetNearestTargetDirectory(directoryInfo.Parent, folderDate);
                }

                if (nearestTarget == null)
                {
                    options.Logger.Log("[SKIPPING] target folder name matching date could not be detected");
                    continue;
                }

                string newPath = Path.Combine(nearestTarget.FullName, file.FullName);

                if (File.Exists(newPath))
                {
                    options.Logger.Log("[SKIPPING] target file allready exists at " + newPath);
                    continue;
                }

                options.Logger.Log(string.Format("[RELOCATE] {0} >> {1}", file.FullName, newPath));


                RenameQueue.Add(file.FullName, newPath);

            }

            
            
            ParseSubDirectories(directoryInfo);
        }

        private void ParseSubDirectories(DirectoryInfo directoryInfo)
        {
            var directories = directoryInfo.GetDirectories().ToList();

            if (options.Recursive)
            {
                directories.ForEach(d =>
                {
                    string directoryName = d.FullName;
                    ParseImageDates(directoryName);
                });
            }
        }

        private DirectoryInfo GetNearestTargetDirectory(DirectoryInfo directoryInfo, DateTime exifDate)
        {
            var directories = directoryInfo.Parent.GetDirectories().ToList();

            if (directories.Exists(d => d.Name.StartsWith((exifDate.ToString("yyyy-MM-dd")))))
            {
                return directories.FirstOrDefault(d => d.Name.StartsWith((exifDate.ToString("yyyy-MM-dd"))));
            }

            if (directories.Exists(d => d.Name.StartsWith((exifDate.ToString("yyyy-MM")))))
            {
                return directories.FirstOrDefault(d => d.Name.StartsWith((exifDate.ToString("yyyy-MM"))));
            }

            return null;
        }


        public bool IsNumber(String value)
        {
            return !value.ToCharArray().Where(x => !Char.IsDigit(x)).Any();
        }

        public void RenameFolders()
        {
            RenameQueue.Reverse().ToList().ForEach(pair =>
            {
                try
                {
                    Debug.WriteLine(pair.Key + " >> " + pair.Value);
                    Directory.Move(pair.Key, pair.Value);
                }
                catch (Exception ex)
                {
                    options.Logger.FatalLog(ex.ToString());
                }
            });
        }
    }
}