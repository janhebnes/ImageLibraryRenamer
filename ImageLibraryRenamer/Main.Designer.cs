namespace ImageLibraryRenamer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnGo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkUseEXIFDataToGetDate = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatePattern = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Test = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSkipFolders = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFileNamePattern = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPickFolder = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.chkSkipIfFolderNameAlreadyHasDate = new System.Windows.Forms.CheckBox();
            this.chkSkipIfXmp = new System.Windows.Forms.CheckBox();
            this.chkSkipNumeric = new System.Windows.Forms.CheckBox();
            this.chkSkipTopLevel = new System.Windows.Forms.CheckBox();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.chkRecusrive = new System.Windows.Forms.CheckBox();
            this.chkUseFileDateIfNoEXIF = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEmbedPicasaProperties = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numDateDifference = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnParseFolderNames = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.chkIgnoreFoldersNotMatchingDatePatternImageRelocator = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDatePatternImageRelocator = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkPreviewImageRelocator = new System.Windows.Forms.CheckBox();
            this.chkUseFileDateIfNoEXIFImageRelocator = new System.Windows.Forms.CheckBox();
            this.btnRelocateImages = new System.Windows.Forms.Button();
            this.chkUseEXIFDataToGetDateImageRelocator = new System.Windows.Forms.CheckBox();
            this.ckhRecursiveImageRelocator = new System.Windows.Forms.CheckBox();
            this.chkCreateMissingTargetFolderImageRelocator = new System.Windows.Forms.CheckBox();
            this.tabControl.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDateDifference)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(258, 289);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(185, 65);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Rename my folders!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            // 
            // chkUseEXIFDataToGetDate
            // 
            this.chkUseEXIFDataToGetDate.AutoSize = true;
            this.chkUseEXIFDataToGetDate.Checked = true;
            this.chkUseEXIFDataToGetDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseEXIFDataToGetDate.Location = new System.Drawing.Point(30, 203);
            this.chkUseEXIFDataToGetDate.Name = "chkUseEXIFDataToGetDate";
            this.chkUseEXIFDataToGetDate.Size = new System.Drawing.Size(159, 17);
            this.chkUseEXIFDataToGetDate.TabIndex = 4;
            this.chkUseEXIFDataToGetDate.Text = "Use EXIF Data To Get Date";
            this.chkUseEXIFDataToGetDate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rename Pattern";
            // 
            // txtDatePattern
            // 
            this.txtDatePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatePattern.Location = new System.Drawing.Point(125, 128);
            this.txtDatePattern.Name = "txtDatePattern";
            this.txtDatePattern.Size = new System.Drawing.Size(248, 20);
            this.txtDatePattern.TabIndex = 5;
            this.txtDatePattern.Text = "yyyy-MM-dd [folder]";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(470, 388);
            this.tabControl.TabIndex = 7;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.Test);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.txtSkipFolders);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.txtFileNamePattern);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.btnPickFolder);
            this.tabPage5.Controls.Add(this.txtPath);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(462, 362);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Common";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test.Location = new System.Drawing.Point(22, 16);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(305, 24);
            this.Test.TabIndex = 23;
            this.Test.Text = "These settings apply to all the tools:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Skip Folders";
            // 
            // txtSkipFolders
            // 
            this.txtSkipFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSkipFolders.Location = new System.Drawing.Point(112, 134);
            this.txtSkipFolders.Name = "txtSkipFolders";
            this.txtSkipFolders.Size = new System.Drawing.Size(248, 20);
            this.txtSkipFolders.TabIndex = 21;
            this.txtSkipFolders.Text = "Photo Stream,Picasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Filename Pattern";
            // 
            // txtFileNamePattern
            // 
            this.txtFileNamePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileNamePattern.Location = new System.Drawing.Point(114, 98);
            this.txtFileNamePattern.Name = "txtFileNamePattern";
            this.txtFileNamePattern.Size = new System.Drawing.Size(248, 20);
            this.txtFileNamePattern.TabIndex = 19;
            this.txtFileNamePattern.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Initial Folder";
            // 
            // btnPickFolder
            // 
            this.btnPickFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPickFolder.Location = new System.Drawing.Point(377, 68);
            this.btnPickFolder.Name = "btnPickFolder";
            this.btnPickFolder.Size = new System.Drawing.Size(42, 22);
            this.btnPickFolder.TabIndex = 16;
            this.btnPickFolder.Text = "...";
            this.btnPickFolder.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(114, 70);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(248, 20);
            this.txtPath.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 362);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.Location = new System.Drawing.Point(3, 3);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(456, 356);
            this.lbStatus.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.chkSkipIfFolderNameAlreadyHasDate);
            this.tabPage1.Controls.Add(this.chkSkipIfXmp);
            this.tabPage1.Controls.Add(this.chkSkipNumeric);
            this.tabPage1.Controls.Add(this.chkSkipTopLevel);
            this.tabPage1.Controls.Add(this.chkPreview);
            this.tabPage1.Controls.Add(this.chkRecusrive);
            this.tabPage1.Controls.Add(this.chkUseFileDateIfNoEXIF);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnGo);
            this.tabPage1.Controls.Add(this.txtDatePattern);
            this.tabPage1.Controls.Add(this.chkUseEXIFDataToGetDate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 362);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Folder Renamer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(18, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(425, 96);
            this.label8.TabIndex = 18;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // chkSkipIfFolderNameAlreadyHasDate
            // 
            this.chkSkipIfFolderNameAlreadyHasDate.AutoSize = true;
            this.chkSkipIfFolderNameAlreadyHasDate.Checked = true;
            this.chkSkipIfFolderNameAlreadyHasDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipIfFolderNameAlreadyHasDate.Location = new System.Drawing.Point(27, 268);
            this.chkSkipIfFolderNameAlreadyHasDate.Name = "chkSkipIfFolderNameAlreadyHasDate";
            this.chkSkipIfFolderNameAlreadyHasDate.Size = new System.Drawing.Size(173, 17);
            this.chkSkipIfFolderNameAlreadyHasDate.TabIndex = 17;
            this.chkSkipIfFolderNameAlreadyHasDate.Text = "Skip If Name Already Has Date";
            this.chkSkipIfFolderNameAlreadyHasDate.UseVisualStyleBackColor = true;
            // 
            // chkSkipIfXmp
            // 
            this.chkSkipIfXmp.AutoSize = true;
            this.chkSkipIfXmp.Checked = true;
            this.chkSkipIfXmp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipIfXmp.Location = new System.Drawing.Point(195, 236);
            this.chkSkipIfXmp.Name = "chkSkipIfXmp";
            this.chkSkipIfXmp.Size = new System.Drawing.Size(162, 17);
            this.chkSkipIfXmp.TabIndex = 16;
            this.chkSkipIfXmp.Text = "Skip if .xmp sidecar files fond";
            this.chkSkipIfXmp.UseVisualStyleBackColor = true;
            // 
            // chkSkipNumeric
            // 
            this.chkSkipNumeric.AutoSize = true;
            this.chkSkipNumeric.Checked = true;
            this.chkSkipNumeric.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipNumeric.Location = new System.Drawing.Point(30, 236);
            this.chkSkipNumeric.Name = "chkSkipNumeric";
            this.chkSkipNumeric.Size = new System.Drawing.Size(162, 17);
            this.chkSkipNumeric.TabIndex = 13;
            this.chkSkipNumeric.Text = "Skip Numeric Folders (Years)";
            this.chkSkipNumeric.UseVisualStyleBackColor = true;
            // 
            // chkSkipTopLevel
            // 
            this.chkSkipTopLevel.AutoSize = true;
            this.chkSkipTopLevel.Checked = true;
            this.chkSkipTopLevel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSkipTopLevel.Location = new System.Drawing.Point(195, 171);
            this.chkSkipTopLevel.Name = "chkSkipTopLevel";
            this.chkSkipTopLevel.Size = new System.Drawing.Size(193, 17);
            this.chkSkipTopLevel.TabIndex = 12;
            this.chkSkipTopLevel.Text = "Skip top level folder (\"My Pictures\")";
            this.chkSkipTopLevel.UseVisualStyleBackColor = true;
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPreview.Location = new System.Drawing.Point(27, 305);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(192, 17);
            this.chkPreview.TabIndex = 11;
            this.chkPreview.Text = "Test Mode (Read Only Mode)";
            this.chkPreview.UseVisualStyleBackColor = true;
            // 
            // chkRecusrive
            // 
            this.chkRecusrive.AutoSize = true;
            this.chkRecusrive.Checked = true;
            this.chkRecusrive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecusrive.Location = new System.Drawing.Point(31, 171);
            this.chkRecusrive.Name = "chkRecusrive";
            this.chkRecusrive.Size = new System.Drawing.Size(119, 17);
            this.chkRecusrive.TabIndex = 10;
            this.chkRecusrive.Text = "Recurse Directories";
            this.chkRecusrive.UseVisualStyleBackColor = true;
            // 
            // chkUseFileDateIfNoEXIF
            // 
            this.chkUseFileDateIfNoEXIF.AutoSize = true;
            this.chkUseFileDateIfNoEXIF.Checked = true;
            this.chkUseFileDateIfNoEXIF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseFileDateIfNoEXIF.Location = new System.Drawing.Point(195, 203);
            this.chkUseFileDateIfNoEXIF.Name = "chkUseFileDateIfNoEXIF";
            this.chkUseFileDateIfNoEXIF.Size = new System.Drawing.Size(158, 17);
            this.chkUseFileDateIfNoEXIF.TabIndex = 7;
            this.chkUseFileDateIfNoEXIF.Text = "Use file date if no EXIF date";
            this.chkUseFileDateIfNoEXIF.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnEmbedPicasaProperties);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(462, 362);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Picasa Embeder";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(19, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(425, 175);
            this.label5.TabIndex = 4;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // btnEmbedPicasaProperties
            // 
            this.btnEmbedPicasaProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmbedPicasaProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmbedPicasaProperties.Location = new System.Drawing.Point(234, 305);
            this.btnEmbedPicasaProperties.Name = "btnEmbedPicasaProperties";
            this.btnEmbedPicasaProperties.Size = new System.Drawing.Size(222, 49);
            this.btnEmbedPicasaProperties.TabIndex = 1;
            this.btnEmbedPicasaProperties.Text = "Embed Picasa Dates";
            this.btnEmbedPicasaProperties.UseVisualStyleBackColor = true;
            this.btnEmbedPicasaProperties.Click += new System.EventHandler(this.btnEmbedPicasaProperties_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.numDateDifference);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.btnParseFolderNames);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(462, 362);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Folder Name Parser";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // numDateDifference
            // 
            this.numDateDifference.Location = new System.Drawing.Point(30, 204);
            this.numDateDifference.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numDateDifference.Name = "numDateDifference";
            this.numDateDifference.Size = new System.Drawing.Size(120, 20);
            this.numDateDifference.TabIndex = 9;
            this.numDateDifference.Value = new decimal(new int[] {
            365,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Only update date if difference between actual and folder date is more than:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 122);
            this.label6.TabIndex = 6;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // btnParseFolderNames
            // 
            this.btnParseFolderNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParseFolderNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParseFolderNames.Location = new System.Drawing.Point(227, 298);
            this.btnParseFolderNames.Name = "btnParseFolderNames";
            this.btnParseFolderNames.Size = new System.Drawing.Size(222, 49);
            this.btnParseFolderNames.TabIndex = 5;
            this.btnParseFolderNames.Text = "Parse Folder Names";
            this.btnParseFolderNames.UseVisualStyleBackColor = true;
            this.btnParseFolderNames.Click += new System.EventHandler(this.btnParseFolderNames_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.chkCreateMissingTargetFolderImageRelocator);
            this.tabPage6.Controls.Add(this.ckhRecursiveImageRelocator);
            this.tabPage6.Controls.Add(this.chkIgnoreFoldersNotMatchingDatePatternImageRelocator);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Controls.Add(this.txtDatePatternImageRelocator);
            this.tabPage6.Controls.Add(this.label9);
            this.tabPage6.Controls.Add(this.chkPreviewImageRelocator);
            this.tabPage6.Controls.Add(this.chkUseFileDateIfNoEXIFImageRelocator);
            this.tabPage6.Controls.Add(this.btnRelocateImages);
            this.tabPage6.Controls.Add(this.chkUseEXIFDataToGetDateImageRelocator);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(462, 362);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Image Relocator";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // chkIgnoreFoldersNotMatchingDatePatternImageRelocator
            // 
            this.chkIgnoreFoldersNotMatchingDatePatternImageRelocator.AutoSize = true;
            this.chkIgnoreFoldersNotMatchingDatePatternImageRelocator.Checked = true;
            this.chkIgnoreFoldersNotMatchingDatePatternImageRelocator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIgnoreFoldersNotMatchingDatePatternImageRelocator.Location = new System.Drawing.Point(196, 181);
            this.chkIgnoreFoldersNotMatchingDatePatternImageRelocator.Name = "chkIgnoreFoldersNotMatchingDatePatternImageRelocator";
            this.chkIgnoreFoldersNotMatchingDatePatternImageRelocator.Size = new System.Drawing.Size(213, 17);
            this.chkIgnoreFoldersNotMatchingDatePatternImageRelocator.TabIndex = 26;
            this.chkIgnoreFoldersNotMatchingDatePatternImageRelocator.Text = "Skip folders not matching Date Patterns";
            this.chkIgnoreFoldersNotMatchingDatePatternImageRelocator.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Allowed Folder Date Patterns (| separator)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtDatePatternImageRelocator
            // 
            this.txtDatePatternImageRelocator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatePatternImageRelocator.Location = new System.Drawing.Point(236, 156);
            this.txtDatePatternImageRelocator.Name = "txtDatePatternImageRelocator";
            this.txtDatePatternImageRelocator.Size = new System.Drawing.Size(198, 20);
            this.txtDatePatternImageRelocator.TabIndex = 24;
            this.txtDatePatternImageRelocator.Text = "yyyy-MM-dd [folder]|yyyy-MM [folder]";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(19, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(425, 132);
            this.label9.TabIndex = 23;
            this.label9.Text = resources.GetString("label9.Text");
            // 
            // chkPreviewImageRelocator
            // 
            this.chkPreviewImageRelocator.AutoSize = true;
            this.chkPreviewImageRelocator.Checked = true;
            this.chkPreviewImageRelocator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreviewImageRelocator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPreviewImageRelocator.Location = new System.Drawing.Point(31, 230);
            this.chkPreviewImageRelocator.Name = "chkPreviewImageRelocator";
            this.chkPreviewImageRelocator.Size = new System.Drawing.Size(192, 17);
            this.chkPreviewImageRelocator.TabIndex = 22;
            this.chkPreviewImageRelocator.Text = "Test Mode (Read Only Mode)";
            this.chkPreviewImageRelocator.UseVisualStyleBackColor = true;
            // 
            // chkUseFileDateIfNoEXIFImageRelocator
            // 
            this.chkUseFileDateIfNoEXIFImageRelocator.AutoSize = true;
            this.chkUseFileDateIfNoEXIFImageRelocator.Checked = true;
            this.chkUseFileDateIfNoEXIFImageRelocator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseFileDateIfNoEXIFImageRelocator.Location = new System.Drawing.Point(196, 203);
            this.chkUseFileDateIfNoEXIFImageRelocator.Name = "chkUseFileDateIfNoEXIFImageRelocator";
            this.chkUseFileDateIfNoEXIFImageRelocator.Size = new System.Drawing.Size(158, 17);
            this.chkUseFileDateIfNoEXIFImageRelocator.TabIndex = 21;
            this.chkUseFileDateIfNoEXIFImageRelocator.Text = "Use file date if no EXIF date";
            this.chkUseFileDateIfNoEXIFImageRelocator.UseVisualStyleBackColor = true;
            // 
            // btnRelocateImages
            // 
            this.btnRelocateImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelocateImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelocateImages.Location = new System.Drawing.Point(22, 289);
            this.btnRelocateImages.Name = "btnRelocateImages";
            this.btnRelocateImages.Size = new System.Drawing.Size(422, 51);
            this.btnRelocateImages.TabIndex = 19;
            this.btnRelocateImages.Text = "Relocate my Images!";
            this.btnRelocateImages.UseVisualStyleBackColor = true;
            this.btnRelocateImages.Click += new System.EventHandler(this.btnRelocateImages_Click);
            // 
            // chkUseEXIFDataToGetDateImageRelocator
            // 
            this.chkUseEXIFDataToGetDateImageRelocator.AutoSize = true;
            this.chkUseEXIFDataToGetDateImageRelocator.Checked = true;
            this.chkUseEXIFDataToGetDateImageRelocator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUseEXIFDataToGetDateImageRelocator.Location = new System.Drawing.Point(31, 203);
            this.chkUseEXIFDataToGetDateImageRelocator.Name = "chkUseEXIFDataToGetDateImageRelocator";
            this.chkUseEXIFDataToGetDateImageRelocator.Size = new System.Drawing.Size(159, 17);
            this.chkUseEXIFDataToGetDateImageRelocator.TabIndex = 20;
            this.chkUseEXIFDataToGetDateImageRelocator.Text = "Use EXIF Data To Get Date";
            this.chkUseEXIFDataToGetDateImageRelocator.UseVisualStyleBackColor = true;
            // 
            // ckhRecursiveImageRelocator
            // 
            this.ckhRecursiveImageRelocator.AutoSize = true;
            this.ckhRecursiveImageRelocator.Checked = true;
            this.ckhRecursiveImageRelocator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckhRecursiveImageRelocator.Location = new System.Drawing.Point(31, 180);
            this.ckhRecursiveImageRelocator.Name = "ckhRecursiveImageRelocator";
            this.ckhRecursiveImageRelocator.Size = new System.Drawing.Size(163, 17);
            this.ckhRecursiveImageRelocator.TabIndex = 27;
            this.ckhRecursiveImageRelocator.Text = "Recursive inside main folders";
            this.ckhRecursiveImageRelocator.UseVisualStyleBackColor = true;
            // 
            // chkCreateMissingTargetFolderImageRelocator
            // 
            this.chkCreateMissingTargetFolderImageRelocator.AutoSize = true;
            this.chkCreateMissingTargetFolderImageRelocator.Checked = true;
            this.chkCreateMissingTargetFolderImageRelocator.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateMissingTargetFolderImageRelocator.Location = new System.Drawing.Point(31, 253);
            this.chkCreateMissingTargetFolderImageRelocator.Name = "chkCreateMissingTargetFolderImageRelocator";
            this.chkCreateMissingTargetFolderImageRelocator.Size = new System.Drawing.Size(158, 17);
            this.chkCreateMissingTargetFolderImageRelocator.TabIndex = 28;
            this.chkCreateMissingTargetFolderImageRelocator.Text = "Create missing target folders";
            this.chkCreateMissingTargetFolderImageRelocator.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 388);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "Photo Folder Renamer";
            this.tabControl.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDateDifference)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkUseEXIFDataToGetDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatePattern;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkUseFileDateIfNoEXIF;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.CheckBox chkRecusrive;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.CheckBox chkSkipTopLevel;
        private System.Windows.Forms.CheckBox chkSkipNumeric;
        private System.Windows.Forms.CheckBox chkSkipIfXmp;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEmbedPicasaProperties;
        private System.Windows.Forms.CheckBox chkSkipIfFolderNameAlreadyHasDate;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.NumericUpDown numDateDifference;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnParseFolderNames;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label Test;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSkipFolders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileNamePattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPickFolder;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkPreviewImageRelocator;
        private System.Windows.Forms.CheckBox chkUseFileDateIfNoEXIFImageRelocator;
        private System.Windows.Forms.Button btnRelocateImages;
        private System.Windows.Forms.CheckBox chkUseEXIFDataToGetDateImageRelocator;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDatePatternImageRelocator;
        private System.Windows.Forms.CheckBox chkIgnoreFoldersNotMatchingDatePatternImageRelocator;
        private System.Windows.Forms.CheckBox ckhRecursiveImageRelocator;
        private System.Windows.Forms.CheckBox chkCreateMissingTargetFolderImageRelocator;
    }
}

