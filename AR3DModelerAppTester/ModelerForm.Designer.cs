namespace AR3DModelerAppTester
{
    partial class ModelerForm
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
            this.previewImage = new System.Windows.Forms.PictureBox();
            this.lblPreviewPanel = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblScreenResolution = new System.Windows.Forms.Label();
            this.lblScreenResolutionValue = new System.Windows.Forms.Label();
            this.btnStartReceiving = new System.Windows.Forms.Button();
            this.btnStopReceiving = new System.Windows.Forms.Button();
            this.threadNamedPipeServer = new System.ComponentModel.BackgroundWorker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // previewImage
            // 
            this.previewImage.Image = global::AR3DModelerAppTester.Properties.Resources.GambarTidakTersedia;
            this.previewImage.InitialImage = global::AR3DModelerAppTester.Properties.Resources.GambarTidakTersedia;
            this.previewImage.Location = new System.Drawing.Point(13, 39);
            this.previewImage.Name = "previewImage";
            this.previewImage.Size = new System.Drawing.Size(718, 409);
            this.previewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewImage.TabIndex = 0;
            this.previewImage.TabStop = false;
            // 
            // lblPreviewPanel
            // 
            this.lblPreviewPanel.AutoSize = true;
            this.lblPreviewPanel.Location = new System.Drawing.Point(13, 13);
            this.lblPreviewPanel.Name = "lblPreviewPanel";
            this.lblPreviewPanel.Size = new System.Drawing.Size(45, 13);
            this.lblPreviewPanel.TabIndex = 1;
            this.lblPreviewPanel.Text = "Preview";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(737, 115);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(41, 13);
            this.lblServer.TabIndex = 2;
            this.lblServer.Text = "Server:";
            // 
            // lblScreenResolution
            // 
            this.lblScreenResolution.AutoSize = true;
            this.lblScreenResolution.Location = new System.Drawing.Point(737, 39);
            this.lblScreenResolution.Name = "lblScreenResolution";
            this.lblScreenResolution.Size = new System.Drawing.Size(92, 13);
            this.lblScreenResolution.TabIndex = 3;
            this.lblScreenResolution.Text = "Screen resolution:";
            // 
            // lblScreenResolutionValue
            // 
            this.lblScreenResolutionValue.AutoSize = true;
            this.lblScreenResolutionValue.Location = new System.Drawing.Point(737, 52);
            this.lblScreenResolutionValue.Name = "lblScreenResolutionValue";
            this.lblScreenResolutionValue.Size = new System.Drawing.Size(54, 13);
            this.lblScreenResolutionValue.TabIndex = 4;
            this.lblScreenResolutionValue.Text = "0px X 0px";
            // 
            // btnStartReceiving
            // 
            this.btnStartReceiving.Location = new System.Drawing.Point(740, 131);
            this.btnStartReceiving.Name = "btnStartReceiving";
            this.btnStartReceiving.Size = new System.Drawing.Size(136, 23);
            this.btnStartReceiving.TabIndex = 5;
            this.btnStartReceiving.Text = "Start receiving";
            this.btnStartReceiving.UseVisualStyleBackColor = true;
            this.btnStartReceiving.Click += new System.EventHandler(this.btnStartReceiving_Click);
            // 
            // btnStopReceiving
            // 
            this.btnStopReceiving.Location = new System.Drawing.Point(740, 161);
            this.btnStopReceiving.Name = "btnStopReceiving";
            this.btnStopReceiving.Size = new System.Drawing.Size(136, 23);
            this.btnStopReceiving.TabIndex = 6;
            this.btnStopReceiving.Text = "Stop receiving";
            this.btnStopReceiving.UseVisualStyleBackColor = true;
            this.btnStopReceiving.Click += new System.EventHandler(this.btnStopReceiving_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(13, 506);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status:";
            // 
            // lblStatusValue
            // 
            this.lblStatusValue.AutoSize = true;
            this.lblStatusValue.Location = new System.Drawing.Point(60, 505);
            this.lblStatusValue.Name = "lblStatusValue";
            this.lblStatusValue.Size = new System.Drawing.Size(0, 13);
            this.lblStatusValue.TabIndex = 8;
            this.lblStatusValue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ModelerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 531);
            this.Controls.Add(this.lblStatusValue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStopReceiving);
            this.Controls.Add(this.btnStartReceiving);
            this.Controls.Add(this.lblScreenResolutionValue);
            this.Controls.Add(this.lblScreenResolution);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.lblPreviewPanel);
            this.Controls.Add(this.previewImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ModelerForm";
            this.Text = "ModelerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ModelerForm_FormClosed);
            this.Load += new System.EventHandler(this.ModelerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox previewImage;
        private System.Windows.Forms.Label lblPreviewPanel;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblScreenResolution;
        private System.Windows.Forms.Label lblScreenResolutionValue;
        private System.Windows.Forms.Button btnStartReceiving;
        private System.Windows.Forms.Button btnStopReceiving;
        private System.ComponentModel.BackgroundWorker threadNamedPipeServer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
    }
}