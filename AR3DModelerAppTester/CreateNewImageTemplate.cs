using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using ImageProcessor;
using System.IO;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace AR3DModelerAppTester
{
    public partial class CreateNewImageTemplate : Form
    {
        Mat[] image = null;
        int currentPosition = 0;
        string[] fileName = null;
        System.Threading.Thread iconAnimation;
        public CreateNewImageTemplate()
        {
            InitializeComponent();
            iconAnimation = new System.Threading.Thread(IconAnimation);
            iconAnimation.Start();
        }

        private void CreateNewImageTemplate_Load(object sender, EventArgs e)
        {
            chkMultipleImages.Checked = true;
            chkAutomatic.Checked = true;
            
        }

        private void chkAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutomatic.Checked)
            {
                chkManual.Checked = false;
                trkThresholdValue.Enabled = false;
                txtThresholdValue.Enabled = false;
                btnSetThresholdValue.Enabled = false;
                btnConvert.Enabled = true;
                btnConvertAll.Enabled = true;
            }
            else
            {
                chkManual.Checked = true;
                trkThresholdValue.Enabled = true;
                txtThresholdValue.Enabled = true;
                btnSetThresholdValue.Enabled = false;
                btnConvert.Enabled = false;
                btnConvertAll.Enabled = true;
            }
        }

        private void chkSingleImage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSingleImage.Checked)
            {
                chkMultipleImages.Checked = false;
                btnNext.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                chkMultipleImages.Checked = true;
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
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
                chkSingleImage.Checked = true;
            }
        }

        private void chkManual_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManual.Checked)
            {
                chkAutomatic.Checked = false;
                trkThresholdValue.Enabled = true;
                txtThresholdValue.Enabled = true;
                btnSetThresholdValue.Enabled = true;
                btnConvert.Enabled = false;
                btnConvertAll.Enabled = true;
            }
            else
            {
                chkAutomatic.Checked = true;
                trkThresholdValue.Enabled = false;
                txtThresholdValue.Enabled = false;
                btnSetThresholdValue.Enabled = false;
                btnConvert.Enabled = true;
                btnConvertAll.Enabled = true;
            }
        }

        
        private void btnBrowseSourceFolder_Click(object sender, EventArgs e)
        {
            if (chkSingleImage.Checked)
            {
                if (dlgOpenSourceFile.ShowDialog() == DialogResult.OK)
                {
                    txtSourceImageLocation.Text = dlgOpenSourceFile.FileName;
                    imgPreviewImage.ImageLocation = txtSourceImageLocation.Text;
                }
            }
            else
            {
                if (dlgBrowseSourceFolder.ShowDialog() == DialogResult.OK)
                {
                    if (image != null)
                    {
                        if (image.Length == 1)
                        {
                            image[0].Dispose();
                        }
                        else
                        {
                            for (int i = 0; i < image.Length; i++)
                            {
                                image[i].Dispose();
                            }
                        }
                        image = null;
                    }

                    if (image == null)
                    {
                        txtSourceImageLocation.Text = dlgBrowseSourceFolder.SelectedPath;
                        fileName = Directory.GetFiles(dlgBrowseSourceFolder.SelectedPath, "*.png");
                        image = new Mat[fileName.Length];
                        for (int fileNumber = 0; fileNumber < fileName.Length; fileNumber++)
                        {
                            image[fileNumber] = CvInvoke.Imread(fileName[fileNumber], Emgu.CV.CvEnum.ImreadModes.Color);
                        }
                        imgPreviewImage.Image = image[0].Bitmap;
                        currentPosition = 0;
                        lblPreviewImagePosition.Text = "Image 1 of " + image.Length;
                    }
                    
                }
            }
        }

        private void trkThresholdValue_Scroll(object sender, EventArgs e)
        {
            txtThresholdValue.Text = trkThresholdValue.Value.ToString();
            if (chkSingleImage.Checked)
            {   
                if (chkNormal.Checked)
                {
                    imgResultImage.Image = ImageProcessor.ImageProcessor.RecolorMonochrome(new Bitmap(txtSourceImageLocation.Text), (double)trkThresholdValue.Value, trkThresholdValue.Maximum);
                }
                else
                {
                    imgResultImage.Image = ImageProcessor.ImageProcessor.RecolorMonochromeInverted(new Bitmap(txtSourceImageLocation.Text), (double)trkThresholdValue.Value, trkThresholdValue.Maximum);
                }
            }
            else
            {
                if (chkNormal.Checked)
                {
                    imgResultImage.Image = ImageProcessor.ImageProcessor.RecolorMonochrome(image[currentPosition].Bitmap, (double)trkThresholdValue.Value, trkThresholdValue.Maximum);
                }
                else
                {
                    imgResultImage.Image = ImageProcessor.ImageProcessor.RecolorMonochromeInverted(image[currentPosition].Bitmap, (double)trkThresholdValue.Value, trkThresholdValue.Maximum);
                }
            }
            
        }

        private void btnSetThresholdValue_Click(object sender, EventArgs e)
        {
            int thresholdValue = 0;
            try
            {
                 thresholdValue = Convert.ToInt32(txtThresholdValue.Text);
            }
            catch (Exception err)
            {
                
            }
            if (thresholdValue >= 0 && thresholdValue < 256)
            {
                
                trkThresholdValue.Value = thresholdValue;
                if (chkNormal.Checked)
                {
                    imgResultImage.Image = ImageProcessor.ImageProcessor.RecolorMonochrome(new Bitmap(txtSourceImageLocation.Text), (double)trkThresholdValue.Value, trkThresholdValue.Maximum);
                }
                else
                {
                    imgResultImage.Image = ImageProcessor.ImageProcessor.RecolorMonochromeInverted(new Bitmap(txtSourceImageLocation.Text), (double)trkThresholdValue.Value, trkThresholdValue.Maximum);
                }
            }
            
        }

        private void btnBrowseTargetFolder_Click(object sender, EventArgs e)
        {
            if (dlgBrowseTargetFolder.ShowDialog() == DialogResult.OK)
            {
                txtTargetImageLocation.Text = dlgBrowseTargetFolder.SelectedPath;
                btnSaveImage.Enabled = true;
            }
        }

        
        private void chkInverted_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInverted.Checked)
            {
                chkNormal.Checked = false;
            }
            else
            {
                chkNormal.Checked = true;
            }
        }

        private void chkNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNormal.Checked)
            {
                chkInverted.Checked = false;
            }
            else
            {
                chkInverted.Checked = true;
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (txtTargetImageLocation.Text != string.Empty)
            {
                if (chkMultipleImages.Checked)
                {
                    imgResultImage.Image.Save(txtTargetImageLocation.Text + "\\" + Path.GetFileName(fileName[currentPosition]));
                }
                else
                {
                    imgResultImage.Image.Save(txtTargetImageLocation.Text + "\\" + Path.GetFileName(txtSourceImageLocation.Text));
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (chkNormal.Checked)
            {
                Mat image = null;
                
                if (chkMultipleImages.Checked)
                {
                    image = new Mat(this.image[currentPosition].Rows, this.image[currentPosition].Cols, DepthType.Cv8U, 1);
                    CvInvoke.CvtColor(this.image[currentPosition], image, ColorConversion.Bgr2Gray);
                }
                else
                {
                    image = new Mat(txtSourceImageLocation.Text, ImreadModes.Grayscale);
                }

                Mat resultImage = new Mat(image.Rows, image.Cols, Emgu.CV.CvEnum.DepthType.Cv8U, 1);
                
                CvInvoke.AdaptiveThreshold(image, resultImage, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, 75, 25);

                imgResultImage.Image = resultImage.Bitmap;
            }
            else
            {
                Mat image = null;
                
                if (chkMultipleImages.Checked)
                {
                    image = new Mat(this.image[currentPosition].Rows, this.image[currentPosition].Cols, DepthType.Cv8U, 1);
                    CvInvoke.CvtColor(this.image[currentPosition], image, ColorConversion.Bgr2Gray);

                }
                else
                {
                    image = new Mat(txtSourceImageLocation.Text, Emgu.CV.CvEnum.ImreadModes.Grayscale);
                }

                Mat resultImage = new Mat(image.Rows, image.Cols, Emgu.CV.CvEnum.DepthType.Cv8U, 1);

                CvInvoke.AdaptiveThreshold(image, resultImage, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.BinaryInv, 75, 25);

                imgResultImage.Image = resultImage.Bitmap;
            }
        }

        private void btnConvertAll_Click(object sender, EventArgs e)
        {
            ConvertMode convertMode;
            ImageMode imageMode;
            ThresholdImageType thresholdType;

            if (chkNormal.Checked)
            {
                thresholdType = ThresholdImageType.Normal;
            }
            else
            {
                thresholdType = ThresholdImageType.Inverted;
            }

            if (chkAutomatic.Checked)
            {
                convertMode = ConvertMode.Automatic;
            }
            else
            {
                convertMode = ConvertMode.Manual;
                threshold = trkThresholdValue.Value;
            }
            
            System.Threading.Thread ConvertAllThread = new System.Threading.Thread(() => { ConvertImages(convertMode, thresholdType, txtTargetImageLocation.Text); });
            ConvertAllThread.Start();
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
                lblPreviewImagePosition.Text = "Image " + (currentPosition + 1) + " of " + (image.Length);
            }
            else
            {
                btnNext.Enabled = false;
            }
            
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
            if (currentPosition >= 0)
            {
                currentPosition--;
                if (currentPosition < 0)
                {
                    currentPosition = image.Length - 1;
                }
                imgPreviewImage.Image = image[currentPosition].Bitmap;
                lblPreviewImagePosition.Text = "Image " + (currentPosition + 1) + " of " + (image.Length);
            }
            else
            {
                //btnPrevious.Enabled = false;
            }
        }

        public enum ImageMode
        {
            Single,
            Multiple
        }
        public enum ConvertMode
        {
            Automatic,
            Manual
        }
        public enum ThresholdImageType
        {
            Normal,
            Inverted
        }

        public int threshold = 0;
        void ConvertImages(ConvertMode convertMode, ThresholdImageType type, string SavePath)
        {
            for (int imagePosition = 0; imagePosition < fileName.Length; imagePosition++)
            {
                ThreadHelperClass.SetImage(this, imgPreviewImage, this.image[imagePosition].Bitmap);

                ThreadHelperClass.SetText(this, lblPreviewImagePosition, "Image " + (imagePosition + 1) + " of " + this.image.Length);

                Mat image = new Mat(this.image[imagePosition].Rows, this.image[imagePosition].Cols, DepthType.Cv8U, 1);

                CvInvoke.CvtColor(this.image[imagePosition], image, ColorConversion.Bgr2Gray);

                Mat resultImage = new Mat(image.Rows, image.Cols, Emgu.CV.CvEnum.DepthType.Cv8U, 1);
                if (convertMode == ConvertMode.Automatic)
                {
                    if (type == ThresholdImageType.Normal)
                    {
                        CvInvoke.AdaptiveThreshold(image, resultImage, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary, 75, 25);
                    }
                    else
                    {
                        CvInvoke.AdaptiveThreshold(image, resultImage, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.BinaryInv, 75, 25);
                    }
                }
                else
                {
                    if (type == ThresholdImageType.Normal)
                    {
                        resultImage = new Image<Bgra, byte>(ImageProcessor.ImageProcessor.RecolorMonochrome(image.Bitmap, threshold)).Mat;
                    }
                    else
                    {
                        resultImage = new Image<Bgra, byte>(ImageProcessor.ImageProcessor.RecolorMonochromeInverted(image.Bitmap, threshold)).Mat;
                    }
                }


                ThreadHelperClass.SetImage(this, imgResultImage, resultImage.Bitmap);

                resultImage.Bitmap.Save(SavePath + "\\" + Path.GetFileName(fileName[imagePosition]));
                image.Dispose();
                resultImage.Dispose();

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

        private void CreateNewImageTemplate_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (iconAnimation.IsAlive)
            {
                iconAnimation.Abort();
            }
        }
    }
}
