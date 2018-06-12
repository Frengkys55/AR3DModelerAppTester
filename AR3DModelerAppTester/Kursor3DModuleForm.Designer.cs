namespace AR3DModelerAppTester
{
    partial class Kursor3DModuleForm
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
            this.lblImagePreview = new System.Windows.Forms.Label();
            this.lblSampleImageFolder = new System.Windows.Forms.Label();
            this.txtFolderLocation = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.sampleImageFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.picImagePreview = new System.Windows.Forms.PictureBox();
            this.btnStartSending = new System.Windows.Forms.Button();
            this.btnStopSending = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblXPosition = new System.Windows.Forms.Label();
            this.lblYPosition = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblZPosition = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGestureTypeValue = new System.Windows.Forms.Label();
            this.lblXPositionValue = new System.Windows.Forms.Label();
            this.lblYPositionValue = new System.Windows.Forms.Label();
            this.lblZPositionValue = new System.Windows.Forms.Label();
            this.lblMMFPerformance = new System.Windows.Forms.Label();
            this.lblMMFPerformanceValue = new System.Windows.Forms.Label();
            this.lblOveralPerformance = new System.Windows.Forms.Label();
            this.lblOveralPerformanceValue = new System.Windows.Forms.Label();
            this.lblKursor3DModulePerformance = new System.Windows.Forms.Label();
            this.lblKursor3DOverallPerformance = new System.Windows.Forms.Label();
            this.lblKursor3DOverallPerformanceValue = new System.Windows.Forms.Label();
            this.lblKursor3DFindHandThreadPerformance = new System.Windows.Forms.Label();
            this.lblKursor3DFindHandThreadPerformanceValue = new System.Windows.Forms.Label();
            this.lblKursor3DFindDepthThreadPerformance = new System.Windows.Forms.Label();
            this.lblKursor3DFindDepthThreadPerformanceValue = new System.Windows.Forms.Label();
            this.lblKursor3DGestureRecognitionThreadPerformance = new System.Windows.Forms.Label();
            this.lblKursor3DGestureRecognitionThreadPerformanceValue = new System.Windows.Forms.Label();
            this.lblImageConversionPerformance = new System.Windows.Forms.Label();
            this.lblImageConversionPerformaceValue = new System.Windows.Forms.Label();
            this.lblTestersPerformanceDetail = new System.Windows.Forms.Label();
            this.lblNextImageLoadingPerformance = new System.Windows.Forms.Label();
            this.lblNextImageLoadingPerformanceValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImagePreview
            // 
            this.lblImagePreview.AutoSize = true;
            this.lblImagePreview.Location = new System.Drawing.Point(13, 13);
            this.lblImagePreview.Name = "lblImagePreview";
            this.lblImagePreview.Size = new System.Drawing.Size(77, 13);
            this.lblImagePreview.TabIndex = 0;
            this.lblImagePreview.Text = "Image Preview";
            // 
            // lblSampleImageFolder
            // 
            this.lblSampleImageFolder.AutoSize = true;
            this.lblSampleImageFolder.Location = new System.Drawing.Point(13, 234);
            this.lblSampleImageFolder.Name = "lblSampleImageFolder";
            this.lblSampleImageFolder.Size = new System.Drawing.Size(111, 13);
            this.lblSampleImageFolder.TabIndex = 2;
            this.lblSampleImageFolder.Text = "Sample Images Folder";
            // 
            // txtFolderLocation
            // 
            this.txtFolderLocation.Location = new System.Drawing.Point(16, 251);
            this.txtFolderLocation.Name = "txtFolderLocation";
            this.txtFolderLocation.Size = new System.Drawing.Size(246, 20);
            this.txtFolderLocation.TabIndex = 3;
            this.txtFolderLocation.TextChanged += new System.EventHandler(this.txtFolderLocation_TextChanged);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(268, 248);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // picImagePreview
            // 
            this.picImagePreview.ErrorImage = global::AR3DModelerAppTester.Properties.Resources.GambarTidakTersedia;
            this.picImagePreview.Image = global::AR3DModelerAppTester.Properties.Resources.untitled;
            this.picImagePreview.Location = new System.Drawing.Point(16, 30);
            this.picImagePreview.Name = "picImagePreview";
            this.picImagePreview.Size = new System.Drawing.Size(327, 190);
            this.picImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagePreview.TabIndex = 1;
            this.picImagePreview.TabStop = false;
            // 
            // btnStartSending
            // 
            this.btnStartSending.Enabled = false;
            this.btnStartSending.Location = new System.Drawing.Point(16, 278);
            this.btnStartSending.Name = "btnStartSending";
            this.btnStartSending.Size = new System.Drawing.Size(161, 23);
            this.btnStartSending.TabIndex = 5;
            this.btnStartSending.Text = "Start sending";
            this.btnStartSending.UseVisualStyleBackColor = true;
            this.btnStartSending.Click += new System.EventHandler(this.btnStartSending_Click);
            // 
            // btnStopSending
            // 
            this.btnStopSending.Enabled = false;
            this.btnStopSending.Location = new System.Drawing.Point(182, 278);
            this.btnStopSending.Name = "btnStopSending";
            this.btnStopSending.Size = new System.Drawing.Size(161, 23);
            this.btnStopSending.TabIndex = 6;
            this.btnStopSending.Text = "Stop sending";
            this.btnStopSending.UseVisualStyleBackColor = true;
            this.btnStopSending.Click += new System.EventHandler(this.btnStopSending_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 308);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Location = new System.Drawing.Point(60, 308);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(0, 13);
            this.lblStatusValue.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Received values";
            // 
            // lblXPosition
            // 
            this.lblXPosition.AutoSize = true;
            this.lblXPosition.Location = new System.Drawing.Point(377, 51);
            this.lblXPosition.Name = "lblXPosition";
            this.lblXPosition.Size = new System.Drawing.Size(23, 13);
            this.lblXPosition.TabIndex = 10;
            this.lblXPosition.Text = "X =";
            // 
            // lblYPosition
            // 
            this.lblYPosition.AutoSize = true;
            this.lblYPosition.Location = new System.Drawing.Point(377, 64);
            this.lblYPosition.Name = "lblYPosition";
            this.lblYPosition.Size = new System.Drawing.Size(23, 13);
            this.lblYPosition.TabIndex = 11;
            this.lblYPosition.Text = "Y =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cursor position:";
            // 
            // lblZPosition
            // 
            this.lblZPosition.AutoSize = true;
            this.lblZPosition.Location = new System.Drawing.Point(377, 77);
            this.lblZPosition.Name = "lblZPosition";
            this.lblZPosition.Size = new System.Drawing.Size(23, 13);
            this.lblZPosition.TabIndex = 13;
            this.lblZPosition.Text = "Z =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gesture type:";
            // 
            // lblGestureTypeValue
            // 
            this.lblGestureTypeValue.AutoSize = true;
            this.lblGestureTypeValue.Location = new System.Drawing.Point(509, 50);
            this.lblGestureTypeValue.Name = "lblGestureTypeValue";
            this.lblGestureTypeValue.Size = new System.Drawing.Size(0, 13);
            this.lblGestureTypeValue.TabIndex = 15;
            // 
            // lblXPositionValue
            // 
            this.lblXPositionValue.AutoSize = true;
            this.lblXPositionValue.Location = new System.Drawing.Point(407, 50);
            this.lblXPositionValue.Name = "lblXPositionValue";
            this.lblXPositionValue.Size = new System.Drawing.Size(13, 13);
            this.lblXPositionValue.TabIndex = 16;
            this.lblXPositionValue.Text = "0";
            // 
            // lblYPositionValue
            // 
            this.lblYPositionValue.AutoSize = true;
            this.lblYPositionValue.Location = new System.Drawing.Point(407, 63);
            this.lblYPositionValue.Name = "lblYPositionValue";
            this.lblYPositionValue.Size = new System.Drawing.Size(13, 13);
            this.lblYPositionValue.TabIndex = 17;
            this.lblYPositionValue.Text = "0";
            // 
            // lblZPositionValue
            // 
            this.lblZPositionValue.AutoSize = true;
            this.lblZPositionValue.Location = new System.Drawing.Point(407, 77);
            this.lblZPositionValue.Name = "lblZPositionValue";
            this.lblZPositionValue.Size = new System.Drawing.Size(13, 13);
            this.lblZPositionValue.TabIndex = 18;
            this.lblZPositionValue.Text = "0";
            // 
            // lblMMFPerformance
            // 
            this.lblMMFPerformance.AutoSize = true;
            this.lblMMFPerformance.Location = new System.Drawing.Point(377, 224);
            this.lblMMFPerformance.Name = "lblMMFPerformance";
            this.lblMMFPerformance.Size = new System.Drawing.Size(168, 13);
            this.lblMMFPerformance.TabIndex = 19;
            this.lblMMFPerformance.Text = "Memory-mapped files performance";
            // 
            // lblMMFPerformanceValue
            // 
            this.lblMMFPerformanceValue.AutoSize = true;
            this.lblMMFPerformanceValue.Location = new System.Drawing.Point(377, 237);
            this.lblMMFPerformanceValue.Name = "lblMMFPerformanceValue";
            this.lblMMFPerformanceValue.Size = new System.Drawing.Size(26, 13);
            this.lblMMFPerformanceValue.TabIndex = 20;
            this.lblMMFPerformanceValue.Text = "0ms";
            // 
            // lblOveralPerformance
            // 
            this.lblOveralPerformance.AutoSize = true;
            this.lblOveralPerformance.Location = new System.Drawing.Point(377, 168);
            this.lblOveralPerformance.Name = "lblOveralPerformance";
            this.lblOveralPerformance.Size = new System.Drawing.Size(102, 13);
            this.lblOveralPerformance.TabIndex = 21;
            this.lblOveralPerformance.Text = "Overall performance";
            // 
            // lblOveralPerformanceValue
            // 
            this.lblOveralPerformanceValue.AutoSize = true;
            this.lblOveralPerformanceValue.Location = new System.Drawing.Point(377, 181);
            this.lblOveralPerformanceValue.Name = "lblOveralPerformanceValue";
            this.lblOveralPerformanceValue.Size = new System.Drawing.Size(26, 13);
            this.lblOveralPerformanceValue.TabIndex = 22;
            this.lblOveralPerformanceValue.Text = "0ms";
            // 
            // lblKursor3DModulePerformance
            // 
            this.lblKursor3DModulePerformance.AutoSize = true;
            this.lblKursor3DModulePerformance.Location = new System.Drawing.Point(550, 153);
            this.lblKursor3DModulePerformance.Name = "lblKursor3DModulePerformance";
            this.lblKursor3DModulePerformance.Size = new System.Drawing.Size(182, 13);
            this.lblKursor3DModulePerformance.TabIndex = 23;
            this.lblKursor3DModulePerformance.Text = "Kursor3D Module performance detail:";
            // 
            // lblKursor3DOverallPerformance
            // 
            this.lblKursor3DOverallPerformance.AutoSize = true;
            this.lblKursor3DOverallPerformance.Location = new System.Drawing.Point(550, 168);
            this.lblKursor3DOverallPerformance.Name = "lblKursor3DOverallPerformance";
            this.lblKursor3DOverallPerformance.Size = new System.Drawing.Size(106, 13);
            this.lblKursor3DOverallPerformance.TabIndex = 24;
            this.lblKursor3DOverallPerformance.Text = "Overall Performance:";
            // 
            // lblKursor3DOverallPerformanceValue
            // 
            this.lblKursor3DOverallPerformanceValue.AutoSize = true;
            this.lblKursor3DOverallPerformanceValue.Location = new System.Drawing.Point(550, 181);
            this.lblKursor3DOverallPerformanceValue.Name = "lblKursor3DOverallPerformanceValue";
            this.lblKursor3DOverallPerformanceValue.Size = new System.Drawing.Size(26, 13);
            this.lblKursor3DOverallPerformanceValue.TabIndex = 25;
            this.lblKursor3DOverallPerformanceValue.Text = "0ms";
            // 
            // lblKursor3DFindHandThreadPerformance
            // 
            this.lblKursor3DFindHandThreadPerformance.AutoSize = true;
            this.lblKursor3DFindHandThreadPerformance.Location = new System.Drawing.Point(550, 195);
            this.lblKursor3DFindHandThreadPerformance.Name = "lblKursor3DFindHandThreadPerformance";
            this.lblKursor3DFindHandThreadPerformance.Size = new System.Drawing.Size(157, 13);
            this.lblKursor3DFindHandThreadPerformance.TabIndex = 26;
            this.lblKursor3DFindHandThreadPerformance.Text = "FindHand() thread performance:";
            // 
            // lblKursor3DFindHandThreadPerformanceValue
            // 
            this.lblKursor3DFindHandThreadPerformanceValue.AutoSize = true;
            this.lblKursor3DFindHandThreadPerformanceValue.Location = new System.Drawing.Point(550, 208);
            this.lblKursor3DFindHandThreadPerformanceValue.Name = "lblKursor3DFindHandThreadPerformanceValue";
            this.lblKursor3DFindHandThreadPerformanceValue.Size = new System.Drawing.Size(26, 13);
            this.lblKursor3DFindHandThreadPerformanceValue.TabIndex = 27;
            this.lblKursor3DFindHandThreadPerformanceValue.Text = "0ms";
            // 
            // lblKursor3DFindDepthThreadPerformance
            // 
            this.lblKursor3DFindDepthThreadPerformance.AutoSize = true;
            this.lblKursor3DFindDepthThreadPerformance.Location = new System.Drawing.Point(550, 221);
            this.lblKursor3DFindDepthThreadPerformance.Name = "lblKursor3DFindDepthThreadPerformance";
            this.lblKursor3DFindDepthThreadPerformance.Size = new System.Drawing.Size(160, 13);
            this.lblKursor3DFindDepthThreadPerformance.TabIndex = 28;
            this.lblKursor3DFindDepthThreadPerformance.Text = "FindDepth() thread performance:";
            // 
            // lblKursor3DFindDepthThreadPerformanceValue
            // 
            this.lblKursor3DFindDepthThreadPerformanceValue.AutoSize = true;
            this.lblKursor3DFindDepthThreadPerformanceValue.Location = new System.Drawing.Point(550, 234);
            this.lblKursor3DFindDepthThreadPerformanceValue.Name = "lblKursor3DFindDepthThreadPerformanceValue";
            this.lblKursor3DFindDepthThreadPerformanceValue.Size = new System.Drawing.Size(26, 13);
            this.lblKursor3DFindDepthThreadPerformanceValue.TabIndex = 29;
            this.lblKursor3DFindDepthThreadPerformanceValue.Text = "0ms";
            // 
            // lblKursor3DGestureRecognitionThreadPerformance
            // 
            this.lblKursor3DGestureRecognitionThreadPerformance.AutoSize = true;
            this.lblKursor3DGestureRecognitionThreadPerformance.Location = new System.Drawing.Point(550, 250);
            this.lblKursor3DGestureRecognitionThreadPerformance.Name = "lblKursor3DGestureRecognitionThreadPerformance";
            this.lblKursor3DGestureRecognitionThreadPerformance.Size = new System.Drawing.Size(205, 13);
            this.lblKursor3DGestureRecognitionThreadPerformance.TabIndex = 30;
            this.lblKursor3DGestureRecognitionThreadPerformance.Text = "GestureRecognition() thread performance:";
            // 
            // lblKursor3DGestureRecognitionThreadPerformanceValue
            // 
            this.lblKursor3DGestureRecognitionThreadPerformanceValue.AutoSize = true;
            this.lblKursor3DGestureRecognitionThreadPerformanceValue.Location = new System.Drawing.Point(550, 263);
            this.lblKursor3DGestureRecognitionThreadPerformanceValue.Name = "lblKursor3DGestureRecognitionThreadPerformanceValue";
            this.lblKursor3DGestureRecognitionThreadPerformanceValue.Size = new System.Drawing.Size(26, 13);
            this.lblKursor3DGestureRecognitionThreadPerformanceValue.TabIndex = 31;
            this.lblKursor3DGestureRecognitionThreadPerformanceValue.Text = "0ms";
            // 
            // lblImageConversionPerformance
            // 
            this.lblImageConversionPerformance.AutoSize = true;
            this.lblImageConversionPerformance.Location = new System.Drawing.Point(377, 250);
            this.lblImageConversionPerformance.Name = "lblImageConversionPerformance";
            this.lblImageConversionPerformance.Size = new System.Drawing.Size(156, 13);
            this.lblImageConversionPerformance.TabIndex = 32;
            this.lblImageConversionPerformance.Text = "Image conversion performance:";
            // 
            // lblImageConversionPerformaceValue
            // 
            this.lblImageConversionPerformaceValue.AutoSize = true;
            this.lblImageConversionPerformaceValue.Location = new System.Drawing.Point(377, 263);
            this.lblImageConversionPerformaceValue.Name = "lblImageConversionPerformaceValue";
            this.lblImageConversionPerformaceValue.Size = new System.Drawing.Size(26, 13);
            this.lblImageConversionPerformaceValue.TabIndex = 33;
            this.lblImageConversionPerformaceValue.Text = "0ms";
            // 
            // lblTestersPerformanceDetail
            // 
            this.lblTestersPerformanceDetail.AutoSize = true;
            this.lblTestersPerformanceDetail.Location = new System.Drawing.Point(377, 153);
            this.lblTestersPerformanceDetail.Name = "lblTestersPerformanceDetail";
            this.lblTestersPerformanceDetail.Size = new System.Drawing.Size(137, 13);
            this.lblTestersPerformanceDetail.TabIndex = 34;
            this.lblTestersPerformanceDetail.Text = "Tester\'s performance detail:";
            // 
            // lblNextImageLoadingPerformance
            // 
            this.lblNextImageLoadingPerformance.AutoSize = true;
            this.lblNextImageLoadingPerformance.Location = new System.Drawing.Point(380, 195);
            this.lblNextImageLoadingPerformance.Name = "lblNextImageLoadingPerformance";
            this.lblNextImageLoadingPerformance.Size = new System.Drawing.Size(159, 13);
            this.lblNextImageLoadingPerformance.TabIndex = 35;
            this.lblNextImageLoadingPerformance.Text = "Next image loading performance";
            // 
            // lblNextImageLoadingPerformanceValue
            // 
            this.lblNextImageLoadingPerformanceValue.AutoSize = true;
            this.lblNextImageLoadingPerformanceValue.Location = new System.Drawing.Point(380, 207);
            this.lblNextImageLoadingPerformanceValue.Name = "lblNextImageLoadingPerformanceValue";
            this.lblNextImageLoadingPerformanceValue.Size = new System.Drawing.Size(26, 13);
            this.lblNextImageLoadingPerformanceValue.TabIndex = 36;
            this.lblNextImageLoadingPerformanceValue.Text = "0ms";
            // 
            // Kursor3DModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(759, 331);
            this.Controls.Add(this.lblNextImageLoadingPerformanceValue);
            this.Controls.Add(this.lblNextImageLoadingPerformance);
            this.Controls.Add(this.lblTestersPerformanceDetail);
            this.Controls.Add(this.lblImageConversionPerformaceValue);
            this.Controls.Add(this.lblImageConversionPerformance);
            this.Controls.Add(this.lblKursor3DGestureRecognitionThreadPerformanceValue);
            this.Controls.Add(this.lblKursor3DGestureRecognitionThreadPerformance);
            this.Controls.Add(this.lblKursor3DFindDepthThreadPerformanceValue);
            this.Controls.Add(this.lblKursor3DFindDepthThreadPerformance);
            this.Controls.Add(this.lblKursor3DFindHandThreadPerformanceValue);
            this.Controls.Add(this.lblKursor3DFindHandThreadPerformance);
            this.Controls.Add(this.lblKursor3DOverallPerformanceValue);
            this.Controls.Add(this.lblKursor3DOverallPerformance);
            this.Controls.Add(this.lblKursor3DModulePerformance);
            this.Controls.Add(this.lblOveralPerformanceValue);
            this.Controls.Add(this.lblOveralPerformance);
            this.Controls.Add(this.lblMMFPerformanceValue);
            this.Controls.Add(this.lblMMFPerformance);
            this.Controls.Add(this.lblZPositionValue);
            this.Controls.Add(this.lblYPositionValue);
            this.Controls.Add(this.lblXPositionValue);
            this.Controls.Add(this.lblGestureTypeValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblZPosition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblYPosition);
            this.Controls.Add(this.lblXPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatusValue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStopSending);
            this.Controls.Add(this.btnStartSending);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtFolderLocation);
            this.Controls.Add(this.lblSampleImageFolder);
            this.Controls.Add(this.picImagePreview);
            this.Controls.Add(this.lblImagePreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Kursor3DModuleForm";
            this.Text = "Cursor 3D Module Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kursor3DModuleForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImagePreview;
        private System.Windows.Forms.PictureBox picImagePreview;
        private System.Windows.Forms.Label lblSampleImageFolder;
        private System.Windows.Forms.TextBox txtFolderLocation;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.FolderBrowserDialog sampleImageFolderBrowser;
        private System.Windows.Forms.Button btnStartSending;
        private System.Windows.Forms.Button btnStopSending;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblXPosition;
        private System.Windows.Forms.Label lblYPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblZPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGestureTypeValue;
        private System.Windows.Forms.Label lblXPositionValue;
        private System.Windows.Forms.Label lblYPositionValue;
        private System.Windows.Forms.Label lblZPositionValue;
        private System.Windows.Forms.Label lblMMFPerformance;
        private System.Windows.Forms.Label lblMMFPerformanceValue;
        private System.Windows.Forms.Label lblOveralPerformance;
        private System.Windows.Forms.Label lblOveralPerformanceValue;
        private System.Windows.Forms.Label lblKursor3DModulePerformance;
        private System.Windows.Forms.Label lblKursor3DOverallPerformance;
        private System.Windows.Forms.Label lblKursor3DOverallPerformanceValue;
        private System.Windows.Forms.Label lblKursor3DFindHandThreadPerformance;
        private System.Windows.Forms.Label lblKursor3DFindHandThreadPerformanceValue;
        private System.Windows.Forms.Label lblKursor3DFindDepthThreadPerformance;
        private System.Windows.Forms.Label lblKursor3DFindDepthThreadPerformanceValue;
        private System.Windows.Forms.Label lblKursor3DGestureRecognitionThreadPerformance;
        private System.Windows.Forms.Label lblKursor3DGestureRecognitionThreadPerformanceValue;
        private System.Windows.Forms.Label lblImageConversionPerformance;
        private System.Windows.Forms.Label lblImageConversionPerformaceValue;
        private System.Windows.Forms.Label lblTestersPerformanceDetail;
        private System.Windows.Forms.Label lblNextImageLoadingPerformance;
        private System.Windows.Forms.Label lblNextImageLoadingPerformanceValue;
    }
}