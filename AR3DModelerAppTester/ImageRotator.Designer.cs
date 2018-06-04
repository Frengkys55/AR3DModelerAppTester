namespace AR3DModelerAppTester
{
    partial class ImageRotator
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
            this.lblSelectMode = new System.Windows.Forms.Label();
            this.chkSingleImage = new System.Windows.Forms.CheckBox();
            this.chkMultipleImages = new System.Windows.Forms.CheckBox();
            this.lblRotatingMode = new System.Windows.Forms.Label();
            this.chkRotateLeft = new System.Windows.Forms.CheckBox();
            this.chkRotateRight = new System.Windows.Forms.CheckBox();
            this.chkCrop = new System.Windows.Forms.CheckBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.chkRotate90 = new System.Windows.Forms.RadioButton();
            this.chkRotate180 = new System.Windows.Forms.RadioButton();
            this.txtImageLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.chkRotateCustom = new System.Windows.Forms.RadioButton();
            this.txtRotateCustom = new System.Windows.Forms.TextBox();
            this.btnBrowseLocation = new System.Windows.Forms.Button();
            this.btnBrowseTarget = new System.Windows.Forms.Button();
            this.txtImageTargetLocation = new System.Windows.Forms.TextBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.imgPreviewImage = new System.Windows.Forms.PictureBox();
            this.imgResultImage = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnRotateAll = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.dlgSelectImage = new System.Windows.Forms.OpenFileDialog();
            this.dlgSelectFolderLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.dlgSelectFolderTarget = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblImageNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgPreviewImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResultImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectMode
            // 
            this.lblSelectMode.AutoSize = true;
            this.lblSelectMode.Location = new System.Drawing.Point(12, 9);
            this.lblSelectMode.Name = "lblSelectMode";
            this.lblSelectMode.Size = new System.Drawing.Size(66, 13);
            this.lblSelectMode.TabIndex = 0;
            this.lblSelectMode.Text = "Select mode";
            // 
            // chkSingleImage
            // 
            this.chkSingleImage.AutoSize = true;
            this.chkSingleImage.Location = new System.Drawing.Point(15, 26);
            this.chkSingleImage.Name = "chkSingleImage";
            this.chkSingleImage.Size = new System.Drawing.Size(86, 17);
            this.chkSingleImage.TabIndex = 1;
            this.chkSingleImage.Text = "Single image";
            this.chkSingleImage.UseVisualStyleBackColor = true;
            this.chkSingleImage.CheckedChanged += new System.EventHandler(this.chkSingleImage_CheckedChanged);
            // 
            // chkMultipleImages
            // 
            this.chkMultipleImages.AutoSize = true;
            this.chkMultipleImages.Checked = true;
            this.chkMultipleImages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMultipleImages.Location = new System.Drawing.Point(107, 26);
            this.chkMultipleImages.Name = "chkMultipleImages";
            this.chkMultipleImages.Size = new System.Drawing.Size(98, 17);
            this.chkMultipleImages.TabIndex = 2;
            this.chkMultipleImages.Text = "Multiple images";
            this.chkMultipleImages.UseVisualStyleBackColor = true;
            this.chkMultipleImages.CheckedChanged += new System.EventHandler(this.chkMultipleImages_CheckedChanged);
            // 
            // lblRotatingMode
            // 
            this.lblRotatingMode.AutoSize = true;
            this.lblRotatingMode.Location = new System.Drawing.Point(209, 9);
            this.lblRotatingMode.Name = "lblRotatingMode";
            this.lblRotatingMode.Size = new System.Drawing.Size(76, 13);
            this.lblRotatingMode.TabIndex = 3;
            this.lblRotatingMode.Text = "Rotating mode";
            // 
            // chkRotateLeft
            // 
            this.chkRotateLeft.AutoSize = true;
            this.chkRotateLeft.Checked = true;
            this.chkRotateLeft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRotateLeft.Location = new System.Drawing.Point(212, 26);
            this.chkRotateLeft.Name = "chkRotateLeft";
            this.chkRotateLeft.Size = new System.Drawing.Size(44, 17);
            this.chkRotateLeft.TabIndex = 5;
            this.chkRotateLeft.Text = "Left";
            this.chkRotateLeft.UseVisualStyleBackColor = true;
            this.chkRotateLeft.CheckedChanged += new System.EventHandler(this.chkRotateLeft_CheckedChanged);
            // 
            // chkRotateRight
            // 
            this.chkRotateRight.AutoSize = true;
            this.chkRotateRight.Location = new System.Drawing.Point(262, 25);
            this.chkRotateRight.Name = "chkRotateRight";
            this.chkRotateRight.Size = new System.Drawing.Size(51, 17);
            this.chkRotateRight.TabIndex = 6;
            this.chkRotateRight.Text = "Right";
            this.chkRotateRight.UseVisualStyleBackColor = true;
            this.chkRotateRight.CheckedChanged += new System.EventHandler(this.chkRotateRight_CheckedChanged);
            // 
            // chkCrop
            // 
            this.chkCrop.AutoSize = true;
            this.chkCrop.Location = new System.Drawing.Point(530, 25);
            this.chkCrop.Name = "chkCrop";
            this.chkCrop.Size = new System.Drawing.Size(48, 17);
            this.chkCrop.TabIndex = 7;
            this.chkCrop.Text = "Crop";
            this.chkCrop.UseVisualStyleBackColor = true;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(330, 9);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(34, 13);
            this.lblAngle.TabIndex = 8;
            this.lblAngle.Text = "Angle";
            // 
            // chkRotate90
            // 
            this.chkRotate90.AutoSize = true;
            this.chkRotate90.Checked = true;
            this.chkRotate90.Location = new System.Drawing.Point(334, 26);
            this.chkRotate90.Name = "chkRotate90";
            this.chkRotate90.Size = new System.Drawing.Size(37, 17);
            this.chkRotate90.TabIndex = 9;
            this.chkRotate90.TabStop = true;
            this.chkRotate90.Text = "90";
            this.chkRotate90.UseVisualStyleBackColor = true;
            this.chkRotate90.CheckedChanged += new System.EventHandler(this.chkRotate90_CheckedChanged);
            // 
            // chkRotate180
            // 
            this.chkRotate180.AutoSize = true;
            this.chkRotate180.Location = new System.Drawing.Point(377, 26);
            this.chkRotate180.Name = "chkRotate180";
            this.chkRotate180.Size = new System.Drawing.Size(43, 17);
            this.chkRotate180.TabIndex = 10;
            this.chkRotate180.Text = "180";
            this.chkRotate180.UseVisualStyleBackColor = true;
            this.chkRotate180.CheckedChanged += new System.EventHandler(this.chkRotate180_CheckedChanged);
            // 
            // txtImageLocation
            // 
            this.txtImageLocation.Location = new System.Drawing.Point(12, 70);
            this.txtImageLocation.Name = "txtImageLocation";
            this.txtImageLocation.Size = new System.Drawing.Size(273, 20);
            this.txtImageLocation.TabIndex = 11;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(9, 54);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 12;
            this.lblLocation.Text = "Location";
            // 
            // chkRotateCustom
            // 
            this.chkRotateCustom.AutoSize = true;
            this.chkRotateCustom.Location = new System.Drawing.Point(426, 28);
            this.chkRotateCustom.Name = "chkRotateCustom";
            this.chkRotateCustom.Size = new System.Drawing.Size(14, 13);
            this.chkRotateCustom.TabIndex = 13;
            this.chkRotateCustom.TabStop = true;
            this.chkRotateCustom.UseVisualStyleBackColor = true;
            this.chkRotateCustom.CheckedChanged += new System.EventHandler(this.chkRotateCustom_CheckedChanged);
            // 
            // txtRotateCustom
            // 
            this.txtRotateCustom.Enabled = false;
            this.txtRotateCustom.Location = new System.Drawing.Point(446, 25);
            this.txtRotateCustom.Name = "txtRotateCustom";
            this.txtRotateCustom.Size = new System.Drawing.Size(41, 20);
            this.txtRotateCustom.TabIndex = 14;
            this.txtRotateCustom.TextChanged += new System.EventHandler(this.txtRotateCustom_TextChanged);
            // 
            // btnBrowseLocation
            // 
            this.btnBrowseLocation.Location = new System.Drawing.Point(289, 68);
            this.btnBrowseLocation.Name = "btnBrowseLocation";
            this.btnBrowseLocation.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLocation.TabIndex = 15;
            this.btnBrowseLocation.Text = "Browse";
            this.btnBrowseLocation.UseVisualStyleBackColor = true;
            this.btnBrowseLocation.Click += new System.EventHandler(this.btnBrowseLocation_Click);
            // 
            // btnBrowseTarget
            // 
            this.btnBrowseTarget.Location = new System.Drawing.Point(289, 118);
            this.btnBrowseTarget.Name = "btnBrowseTarget";
            this.btnBrowseTarget.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTarget.TabIndex = 16;
            this.btnBrowseTarget.Text = "Browse";
            this.btnBrowseTarget.UseVisualStyleBackColor = true;
            // 
            // txtImageTargetLocation
            // 
            this.txtImageTargetLocation.Location = new System.Drawing.Point(12, 120);
            this.txtImageTargetLocation.Name = "txtImageTargetLocation";
            this.txtImageTargetLocation.Size = new System.Drawing.Size(271, 20);
            this.txtImageTargetLocation.TabIndex = 17;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(9, 104);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(38, 13);
            this.lblTarget.TabIndex = 18;
            this.lblTarget.Text = "Target";
            // 
            // imgPreviewImage
            // 
            this.imgPreviewImage.Image = global::AR3DModelerAppTester.Properties.Resources.GambarTidakTersedia;
            this.imgPreviewImage.InitialImage = global::AR3DModelerAppTester.Properties.Resources.GambarTidakTersedia;
            this.imgPreviewImage.Location = new System.Drawing.Point(12, 175);
            this.imgPreviewImage.Name = "imgPreviewImage";
            this.imgPreviewImage.Size = new System.Drawing.Size(352, 197);
            this.imgPreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPreviewImage.TabIndex = 19;
            this.imgPreviewImage.TabStop = false;
            // 
            // imgResultImage
            // 
            this.imgResultImage.Image = global::AR3DModelerAppTester.Properties.Resources.GambarTidakTersedia;
            this.imgResultImage.Location = new System.Drawing.Point(386, 175);
            this.imgResultImage.Name = "imgResultImage";
            this.imgResultImage.Size = new System.Drawing.Size(352, 197);
            this.imgResultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgResultImage.TabIndex = 20;
            this.imgResultImage.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Enabled = false;
            this.btnPrevious.Location = new System.Drawing.Point(12, 379);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 21;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Location = new System.Drawing.Point(93, 379);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 22;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRotateAll
            // 
            this.btnRotateAll.Enabled = false;
            this.btnRotateAll.Location = new System.Drawing.Point(208, 379);
            this.btnRotateAll.Name = "btnRotateAll";
            this.btnRotateAll.Size = new System.Drawing.Size(75, 23);
            this.btnRotateAll.TabIndex = 23;
            this.btnRotateAll.Text = "Rotate all";
            this.btnRotateAll.UseVisualStyleBackColor = true;
            this.btnRotateAll.Click += new System.EventHandler(this.btnRotateAll_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.Enabled = false;
            this.btnRotate.Location = new System.Drawing.Point(289, 379);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(75, 23);
            this.btnRotate.TabIndex = 24;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.Image = global::AR3DModelerAppTester.Properties.Resources.untitled;
            this.imgLogo.Location = new System.Drawing.Point(569, 68);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(170, 89);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 25;
            this.imgLogo.TabStop = false;
            // 
            // dlgSelectImage
            // 
            this.dlgSelectImage.FileName = "openFileDialog1";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(386, 379);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblImageNumber
            // 
            this.lblImageNumber.AutoSize = true;
            this.lblImageNumber.Location = new System.Drawing.Point(12, 156);
            this.lblImageNumber.Name = "lblImageNumber";
            this.lblImageNumber.Size = new System.Drawing.Size(66, 13);
            this.lblImageNumber.TabIndex = 27;
            this.lblImageNumber.Text = "Image 0 of 0";
            // 
            // ImageRotator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 419);
            this.Controls.Add(this.lblImageNumber);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnRotateAll);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.imgResultImage);
            this.Controls.Add(this.imgPreviewImage);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.txtImageTargetLocation);
            this.Controls.Add(this.btnBrowseTarget);
            this.Controls.Add(this.btnBrowseLocation);
            this.Controls.Add(this.txtRotateCustom);
            this.Controls.Add(this.chkRotateCustom);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.txtImageLocation);
            this.Controls.Add(this.chkRotate180);
            this.Controls.Add(this.chkRotate90);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.chkCrop);
            this.Controls.Add(this.chkRotateRight);
            this.Controls.Add(this.chkRotateLeft);
            this.Controls.Add(this.lblRotatingMode);
            this.Controls.Add(this.chkMultipleImages);
            this.Controls.Add(this.chkSingleImage);
            this.Controls.Add(this.lblSelectMode);
            this.Name = "ImageRotator";
            this.Text = "Image Rotator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageRotator_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.imgPreviewImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgResultImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectMode;
        private System.Windows.Forms.CheckBox chkSingleImage;
        private System.Windows.Forms.CheckBox chkMultipleImages;
        private System.Windows.Forms.Label lblRotatingMode;
        private System.Windows.Forms.CheckBox chkRotateLeft;
        private System.Windows.Forms.CheckBox chkRotateRight;
        private System.Windows.Forms.CheckBox chkCrop;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.RadioButton chkRotate90;
        private System.Windows.Forms.RadioButton chkRotate180;
        private System.Windows.Forms.TextBox txtImageLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.RadioButton chkRotateCustom;
        private System.Windows.Forms.TextBox txtRotateCustom;
        private System.Windows.Forms.Button btnBrowseLocation;
        private System.Windows.Forms.Button btnBrowseTarget;
        private System.Windows.Forms.TextBox txtImageTargetLocation;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.PictureBox imgPreviewImage;
        private System.Windows.Forms.PictureBox imgResultImage;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnRotateAll;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.OpenFileDialog dlgSelectImage;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectFolderLocation;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectFolderTarget;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblImageNumber;
    }
}