using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace AR3DModelerAppTester
{
    public partial class ImageRotator : Form
    {
        System.Threading.Thread iconAnimation;
        string[] fileName;
        Image<Bgra, byte>[] image = null;
        int currentPosition = 0;
        int currentImagePosition = 0;

        public ImageRotator()
        {
            InitializeComponent();
            iconAnimation = new System.Threading.Thread(IconAnimation);
            iconAnimation.Start();
        }

        private void txtRotateCustom_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkRotate180_CheckedChanged(object sender, EventArgs e)
        {
            chkRotate90.Checked = false;
            chkRotateCustom.Checked = false;

            txtRotateCustom.Enabled = false;
        }

        private void chkSingleImage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSingleImage.Checked)
            {
                chkMultipleImages.Checked = false;

                btnRotateAll.Enabled = false;
                
            }
            else
            {
                chkMultipleImages.Checked = true;
            }
        }
        
        private void chkMultipleImages_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMultipleImages.Checked)
            {
                chkSingleImage.Checked = false;
            }
            else
            {
                chkSingleImage.Enabled = true;
            }
        }

        void IconAnimation()
        {
            // Get bitmap files
            string[] iconAnimationFile = Directory.GetFiles(Application.StartupPath + "\\Sources", "*.png");

            // Manual filling
            for (int i = 0; i < iconAnimationFile.Length; i++)
            {
                iconAnimationFile[i] = Application.StartupPath + "\\Sources\\" + (i + 1).ToString() + ".png";
            }


            // Load bitmap to memory
            Bitmap[] sourceIcon = new Bitmap[iconAnimationFile.Length];
            for (int iconNumber = 0; iconNumber < iconAnimationFile.Length; iconNumber++)
            {
                sourceIcon[iconNumber] = new Bitmap(iconAnimationFile[iconNumber]);
            }
            Icon[] icon = new Icon[sourceIcon.Length];
            for (int iconNumber = 0; iconNumber < sourceIcon.Length; iconNumber++)
            {
                IntPtr Hicon = sourceIcon[iconNumber].GetHicon();
                icon[iconNumber] = Icon.FromHandle(Hicon);
            }

            // Begin animating
            int position = 0;
            do
            {
                ThreadHelperClass.SetIcon(this, this, icon[position]);
                position++;
                if (position == icon.Length)
                {
                    position = 0;
                }
                System.Threading.Thread.Sleep(1000 / 30);
            } while (true);
        }

        private void chkRotateLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRotateLeft.Checked)
            {
                chkRotateRight.Checked = false;
            }
            else
            {
                chkRotateRight.Checked = true;

            }
        }

        private void chkRotateRight_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRotateRight.Checked)
            {
                chkRotateLeft.Checked = false;
            }
            else
            {
                chkRotateLeft.Checked = true;
            }
        }

        private void chkRotate90_CheckedChanged(object sender, EventArgs e)
        {
            chkRotate180.Checked = false;
            chkRotateCustom.Checked = false;

            txtRotateCustom.Enabled = false;
        }

        private void chkRotateCustom_CheckedChanged(object sender, EventArgs e)
        {
            chkRotate180.Checked = false;
            chkRotate90.Checked = false;

            txtRotateCustom.Enabled = true;
        }

        private void ImageRotator_FormClosing(object sender, FormClosingEventArgs e)
        {
            iconAnimation.Abort();
        }

        private void btnBrowseLocation_Click(object sender, EventArgs e)
        {
            if (chkSingleImage.Checked)
            {
                if (dlgSelectImage.ShowDialog() == DialogResult.OK)
                {
                    txtImageLocation.Text = dlgSelectImage.FileName;
                    imgPreviewImage.ImageLocation = txtImageLocation.Text;

                    btnRotate.Enabled = true;
                    btnSave.Enabled = true;
                }
            }
            else
            {
                if (dlgSelectFolderTarget.ShowDialog() == DialogResult.OK)
                {
                    txtImageLocation.Text = dlgSelectFolderTarget.SelectedPath;
                    if (Directory.GetFiles(dlgSelectFolderTarget.SelectedPath).Length != 0)
                    {
                        LoadImages(dlgSelectFolderTarget.SelectedPath);
                        imgPreviewImage.Image = image[0].Bitmap;
                        lblImageNumber.Text = "Image 1 of " + fileName.Length;
                    }
                    
                    
                    if (image.Length <= 1)
                    {
                        btnPrevious.Enabled = false;
                        btnNext.Enabled = false;
                    }
                    else
                    {
                        btnPrevious.Enabled = true;
                        btnNext.Enabled = true;
                    }
                }
            }
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            double angle = 0;
            if (chkRotateRight.Checked)
            {
                angle = 90d;
            }
            else if (chkRotateLeft.Checked)
            {
                angle = -90d;
            }
            else
            {
                try
                {
                    angle = Convert.ToDouble(txtRotateCustom.Text);
                }
                catch (Exception err)
                {
                    DialogResult result = MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtImageTargetLocation.Text != string.Empty)
            {
                if (chkMultipleImages.Checked)
                {
                    imgResultImage.Image.Save(txtImageTargetLocation.Text + "\\" + Path.GetFileName(fileName[currentPosition]));
                }
                else
                {
                    imgResultImage.Image.Save(txtImageTargetLocation.Text + "\\" + Path.GetFileName(txtImageTargetLocation.Text));
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPosition < image.Length)
            {
                currentPosition++;
                if (currentPosition == image.Length)
                {
                    currentPosition = 0;
                }
                imgPreviewImage.Image = image[currentPosition].Bitmap;
                lblImageNumber.Text = "Image " + (currentPosition + 1) + " of " + (image.Length);
            }
            else
            {
                btnNext.Enabled = false;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        private void btnRotateAll_Click(object sender, EventArgs e)
        {

        }

        void LoadImages(string path)
        {
            if (image != null)
            {
                for (int i = 0; i < image.Length; i++)
                {
                    image[i].Dispose();
                }
                image = null;
            }

            string[] searchPatterns = new[] { "*.jpg", "*.jpeg", "*.jpe", "*.jif", "*.jfif", "*.jfi", "*.webp", "*.gif", "*.png", "*.apng", "*.bmp", "*.dib", "*.tiff", "*.tif", "*.svg", "*.svgz", "*.ico", "*.xbm" };
            List<string> files = new List<string>();
            foreach (var pattern in searchPatterns)
            {
                if (Directory.GetFiles(path, pattern).Length != 0)
                {
                    files.AddRange(Directory.GetFiles(path, pattern));
                }
            }
            fileName = files.ToArray<string>();
            image = new Image<Bgra, byte>[fileName.Length];
            for (int fileNumber = 0; fileNumber < fileName.Length; fileNumber++)
            {
                image[fileNumber] = new Image<Bgra, byte>(fileName[fileNumber]);
            }
        }
    }
}
