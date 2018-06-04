namespace AR3DModelerAppTester
{
    partial class CreateNewImageTemplate
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSingleImage = new System.Windows.Forms.CheckBox();
            this.chkMultipleImages = new System.Windows.Forms.CheckBox();
            this.txtSourceImageLocation = new System.Windows.Forms.TextBox();
            this.txtTargetImageLocation = new System.Windows.Forms.TextBox();
            this.lblSourceImageLocation = new System.Windows.Forms.Label();
            this.lblTargetImageLocation = new System.Windows.Forms.Label();
            this.lblThresholdMode = new System.Windows.Forms.Label();
            this.chkAutomatic = new System.Windows.Forms.CheckBox();
            this.chkManual = new System.Windows.Forms.CheckBox();
            this.dlgBrowseSourceFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgOpenSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgBrowseTargetFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.imgPreviewImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseSourceFolder = new System.Windows.Forms.Button();
            this.btnBrowseTargetFolder = new System.Windows.Forms.Button();
            this.trkThresholdValue = new System.Windows.Forms.TrackBar();
            this.txtThresholdValue = new System.Windows.Forms.TextBox();
            this.btnSetThresholdValue = new System.Windows.Forms.Button();
            this.imgResultImage = new System.Windows.Forms.PictureBox();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkNormal = new System.Windows.Forms.CheckBox();
            this.chkInverted = new System.Windows.Forms.CheckBox();
            this.btnConvertAll = new System.Windows.Forms.Button();
            this.lblPreviewImagePosition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreviewImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThresholdValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AR3DModelerAppTester.Properties.Resources.untitled;
            this.pictureBox1.Location = new System.Drawing.Point(748, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select mode";
            // 
            // chkSingleImage
            // 
            this.chkSingleImage.AutoSize = true;
            this.chkSingleImage.Location = new System.Drawing.Point(13, 26);
            this.chkSingleImage.Name = "chkSingleImage";
            this.chkSingleImage.Size = new System.Drawing.Size(86, 17);
            this.chkSingleImage.TabIndex = 2;
            this.chkSingleImage.Text = "Single image";
            this.chkSingleImage.UseVisualStyleBackColor = true;
            this.chkSingleImage.CheckedChanged += new System.EventHandler(this.chkSingleImage_CheckedChanged);
            // 
            // chkMultipleImages
            // 
            this.chkMultipleImages.AutoSize = true;
            this.chkMultipleImages.Location = new System.Drawing.Point(106, 26);
            this.chkMultipleImages.Name = "chkMultipleImages";
            this.chkMultipleImages.Size = new System.Drawing.Size(98, 17);
            this.chkMultipleImages.TabIndex = 3;
            this.chkMultipleImages.Text = "Multiple images";
            this.chkMultipleImages.UseVisualStyleBackColor = true;
            this.chkMultipleImages.CheckedChanged += new System.EventHandler(this.chkMultipleImages_CheckedChanged);
            // 
            // txtSourceImageLocation
            // 
            this.txtSourceImageLocation.Location = new System.Drawing.Point(13, 78);
            this.txtSourceImageLocation.Name = "txtSourceImageLocation";
            this.txtSourceImageLocation.Size = new System.Drawing.Size(274, 20);
            this.txtSourceImageLocation.TabIndex = 4;
            // 
            // txtTargetImageLocation
            // 
            this.txtTargetImageLocation.Location = new System.Drawing.Point(13, 123);
            this.txtTargetImageLocation.Name = "txtTargetImageLocation";
            this.txtTargetImageLocation.Size = new System.Drawing.Size(274, 20);
            this.txtTargetImageLocation.TabIndex = 5;
            // 
            // lblSourceImageLocation
            // 
            this.lblSourceImageLocation.AutoSize = true;
            this.lblSourceImageLocation.Location = new System.Drawing.Point(10, 62);
            this.lblSourceImageLocation.Name = "lblSourceImageLocation";
            this.lblSourceImageLocation.Size = new System.Drawing.Size(112, 13);
            this.lblSourceImageLocation.TabIndex = 6;
            this.lblSourceImageLocation.Text = "Source image location";
            // 
            // lblTargetImageLocation
            // 
            this.lblTargetImageLocation.AutoSize = true;
            this.lblTargetImageLocation.Location = new System.Drawing.Point(10, 107);
            this.lblTargetImageLocation.Name = "lblTargetImageLocation";
            this.lblTargetImageLocation.Size = new System.Drawing.Size(109, 13);
            this.lblTargetImageLocation.TabIndex = 7;
            this.lblTargetImageLocation.Text = "Target image location";
            // 
            // lblThresholdMode
            // 
            this.lblThresholdMode.AutoSize = true;
            this.lblThresholdMode.Location = new System.Drawing.Point(211, 9);
            this.lblThresholdMode.Name = "lblThresholdMode";
            this.lblThresholdMode.Size = new System.Drawing.Size(83, 13);
            this.lblThresholdMode.TabIndex = 8;
            this.lblThresholdMode.Text = "Threshold mode";
            // 
            // chkAutomatic
            // 
            this.chkAutomatic.AutoSize = true;
            this.chkAutomatic.Location = new System.Drawing.Point(214, 26);
            this.chkAutomatic.Name = "chkAutomatic";
            this.chkAutomatic.Size = new System.Drawing.Size(73, 17);
            this.chkAutomatic.TabIndex = 9;
            this.chkAutomatic.Text = "Automatic";
            this.chkAutomatic.UseVisualStyleBackColor = true;
            this.chkAutomatic.CheckedChanged += new System.EventHandler(this.chkAutomatic_CheckedChanged);
            // 
            // chkManual
            // 
            this.chkManual.AutoSize = true;
            this.chkManual.Location = new System.Drawing.Point(307, 26);
            this.chkManual.Name = "chkManual";
            this.chkManual.Size = new System.Drawing.Size(61, 17);
            this.chkManual.TabIndex = 10;
            this.chkManual.Text = "Manual";
            this.chkManual.UseVisualStyleBackColor = true;
            this.chkManual.CheckedChanged += new System.EventHandler(this.chkManual_CheckedChanged);
            // 
            // dlgOpenSourceFile
            // 
            this.dlgOpenSourceFile.Title = "Browse for image";
            // 
            // imgPreviewImage
            // 
            this.imgPreviewImage.Image = global::AR3DModelerAppTester.Properties.Resources.GambarTidakTersedia;
            this.imgPreviewImage.Location = new System.Drawing.Point(15, 190);
            this.imgPreviewImage.Name = "imgPreviewImage";
            this.imgPreviewImage.Size = new System.Drawing.Size(353, 201);
            this.imgPreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPreviewImage.TabIndex = 11;
            this.imgPreviewImage.TabStop = false;
            // 
            // btnBrowseSourceFolder
            // 
            this.btnBrowseSourceFolder.Location = new System.Drawing.Point(293, 76);
            this.btnBrowseSourceFolder.Name = "btnBrowseSourceFolder";
            this.btnBrowseSourceFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSourceFolder.TabIndex = 12;
            this.btnBrowseSourceFolder.Text = "Browse";
            this.btnBrowseSourceFolder.UseVisualStyleBackColor = true;
            this.btnBrowseSourceFolder.Click += new System.EventHandler(this.btnBrowseSourceFolder_Click);
            // 
            // btnBrowseTargetFolder
            // 
            this.btnBrowseTargetFolder.Location = new System.Drawing.Point(293, 121);
            this.btnBrowseTargetFolder.Name = "btnBrowseTargetFolder";
            this.btnBrowseTargetFolder.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTargetFolder.TabIndex = 13;
            this.btnBrowseTargetFolder.Text = "Browse";
            this.btnBrowseTargetFolder.UseVisualStyleBackColor = true;
            this.btnBrowseTargetFolder.Click += new System.EventHandler(this.btnBrowseTargetFolder_Click);
            // 
            // trkThresholdValue
            // 
            this.trkThresholdValue.LargeChange = 1;
            this.trkThresholdValue.Location = new System.Drawing.Point(374, 78);
            this.trkThresholdValue.Maximum = 255;
            this.trkThresholdValue.Name = "trkThresholdValue";
            this.trkThresholdValue.Size = new System.Drawing.Size(413, 45);
            this.trkThresholdValue.TabIndex = 14;
            this.trkThresholdValue.Scroll += new System.EventHandler(this.trkThresholdValue_Scroll);
            // 
            // txtThresholdValue
            // 
            this.txtThresholdValue.Location = new System.Drawing.Point(793, 78);
            this.txtThresholdValue.Name = "txtThresholdValue";
            this.txtThresholdValue.Size = new System.Drawing.Size(31, 20);
            this.txtThresholdValue.TabIndex = 15;
            // 
            // btnSetThresholdValue
            // 
            this.btnSetThresholdValue.Location = new System.Drawing.Point(830, 76);
            this.btnSetThresholdValue.Name = "btnSetThresholdValue";
            this.btnSetThresholdValue.Size = new System.Drawing.Size(31, 23);
            this.btnSetThresholdValue.TabIndex = 16;
            this.btnSetThresholdValue.Text = "Set";
            this.btnSetThresholdValue.UseVisualStyleBackColor = true;
            this.btnSetThresholdValue.Click += new System.EventHandler(this.btnSetThresholdValue_Click);
            // 
            // imgResultImage
            // 
            this.imgResultImage.Image = global::AR3DModelerAppTester.Properties.Resources.GambarTidakTersedia;
            this.imgResultImage.Location = new System.Drawing.Point(389, 190);
            this.imgResultImage.Name = "imgResultImage";
            this.imgResultImage.Size = new System.Drawing.Size(353, 201);
            this.imgResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgResultImage.TabIndex = 17;
            this.imgResultImage.TabStop = false;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Enabled = false;
            this.btnSaveImage.Location = new System.Drawing.Point(389, 397);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 18;
            this.btnSaveImage.Text = "Save";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(96, 398);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(15, 398);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 20;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(293, 397);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 21;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Threshold image type";
            // 
            // chkNormal
            // 
            this.chkNormal.AutoSize = true;
            this.chkNormal.Checked = true;
            this.chkNormal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNormal.Location = new System.Drawing.Point(392, 26);
            this.chkNormal.Name = "chkNormal";
            this.chkNormal.Size = new System.Drawing.Size(59, 17);
            this.chkNormal.TabIndex = 23;
            this.chkNormal.Text = "Normal";
            this.chkNormal.UseVisualStyleBackColor = true;
            this.chkNormal.CheckedChanged += new System.EventHandler(this.chkNormal_CheckedChanged);
            // 
            // chkInverted
            // 
            this.chkInverted.AutoSize = true;
            this.chkInverted.Location = new System.Drawing.Point(458, 26);
            this.chkInverted.Name = "chkInverted";
            this.chkInverted.Size = new System.Drawing.Size(65, 17);
            this.chkInverted.TabIndex = 24;
            this.chkInverted.Text = "Inverted";
            this.chkInverted.UseVisualStyleBackColor = true;
            this.chkInverted.CheckedChanged += new System.EventHandler(this.chkInverted_CheckedChanged);
            // 
            // btnConvertAll
            // 
            this.btnConvertAll.Location = new System.Drawing.Point(212, 398);
            this.btnConvertAll.Name = "btnConvertAll";
            this.btnConvertAll.Size = new System.Drawing.Size(75, 23);
            this.btnConvertAll.TabIndex = 25;
            this.btnConvertAll.Text = "Convert all";
            this.btnConvertAll.UseVisualStyleBackColor = true;
            this.btnConvertAll.Click += new System.EventHandler(this.btnConvertAll_Click);
            // 
            // lblPreviewImagePosition
            // 
            this.lblPreviewImagePosition.AutoSize = true;
            this.lblPreviewImagePosition.Location = new System.Drawing.Point(13, 171);
            this.lblPreviewImagePosition.Name = "lblPreviewImagePosition";
            this.lblPreviewImagePosition.Size = new System.Drawing.Size(66, 13);
            this.lblPreviewImagePosition.TabIndex = 26;
            this.lblPreviewImagePosition.Text = "Image 0 of 0";
            // 
            // CreateNewImageTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 430);
            this.Controls.Add(this.lblPreviewImagePosition);
            this.Controls.Add(this.btnConvertAll);
            this.Controls.Add(this.chkInverted);
            this.Controls.Add(this.chkNormal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSaveImage);
            this.Controls.Add(this.imgResultImage);
            this.Controls.Add(this.btnSetThresholdValue);
            this.Controls.Add(this.txtThresholdValue);
            this.Controls.Add(this.trkThresholdValue);
            this.Controls.Add(this.btnBrowseTargetFolder);
            this.Controls.Add(this.btnBrowseSourceFolder);
            this.Controls.Add(this.imgPreviewImage);
            this.Controls.Add(this.chkManual);
            this.Controls.Add(this.chkAutomatic);
            this.Controls.Add(this.lblThresholdMode);
            this.Controls.Add(this.lblTargetImageLocation);
            this.Controls.Add(this.lblSourceImageLocation);
            this.Controls.Add(this.txtTargetImageLocation);
            this.Controls.Add(this.txtSourceImageLocation);
            this.Controls.Add(this.chkMultipleImages);
            this.Controls.Add(this.chkSingleImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateNewImageTemplate";
            this.Text = "CreateNewImageTemplate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateNewImageTemplate_FormClosing);
            this.Load += new System.EventHandler(this.CreateNewImageTemplate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreviewImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkThresholdValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResultImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSingleImage;
        private System.Windows.Forms.CheckBox chkMultipleImages;
        private System.Windows.Forms.TextBox txtSourceImageLocation;
        private System.Windows.Forms.TextBox txtTargetImageLocation;
        private System.Windows.Forms.Label lblSourceImageLocation;
        private System.Windows.Forms.Label lblTargetImageLocation;
        private System.Windows.Forms.Label lblThresholdMode;
        private System.Windows.Forms.CheckBox chkAutomatic;
        private System.Windows.Forms.CheckBox chkManual;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowseSourceFolder;
        private System.Windows.Forms.OpenFileDialog dlgOpenSourceFile;
        private System.Windows.Forms.FolderBrowserDialog dlgBrowseTargetFolder;
        private System.Windows.Forms.PictureBox imgPreviewImage;
        private System.Windows.Forms.Button btnBrowseSourceFolder;
        private System.Windows.Forms.Button btnBrowseTargetFolder;
        private System.Windows.Forms.TrackBar trkThresholdValue;
        private System.Windows.Forms.TextBox txtThresholdValue;
        private System.Windows.Forms.Button btnSetThresholdValue;
        private System.Windows.Forms.PictureBox imgResultImage;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkNormal;
        private System.Windows.Forms.CheckBox chkInverted;
        private System.Windows.Forms.Button btnConvertAll;
        private System.Windows.Forms.Label lblPreviewImagePosition;
    }
}