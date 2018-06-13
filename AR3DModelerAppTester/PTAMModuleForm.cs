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
using IPC;
using Emgu.CV;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using System.Threading;
using Emgu.CV.CvEnum;
using System.Diagnostics;
using System.IO.Pipes;

namespace AR3DModelerAppTester
{
    public partial class PTAMModuleForm : Form
    {

        #region Testing informations

        

        #region Inter-Process Communication informations

        #region PTAM Named Pipe sending channel

        string PTAMModuleNamedPipeSendingChannel = string.Empty;
        string PTAMModuleNamedPipeReceivingChannel = string.Empty;

        #endregion PTAM Named Pipe sending channel

        #region PTAM Memory-Mapped File name

        string PTAMModuleSourceImageFileName = string.Empty;

        #endregion PTAM Memory-Mapped File name
        
        #endregion Inter-Process Communication informations

        #region Source images
        Mat[] PTAMSourceImages;
        Thread mainFunction;
        #endregion Source images

        #region PTAM received informations

        #region Pose

        #region Position

        int receivedXPosition = 0;
        int receivedYPosition = 0;
        int receivedZPosition = 0;

        #endregion Position

        #region Orientation

        int receivedXOrientation = 0;
        int receivedYOrientation = 0;
        int receivedZOrientation = 0;

        #endregion Orientation

        #endregion Pose

        #region Created points
        int totalPointsCreated = 0;
        #endregion Created points

        #endregion PTAM received informations

        #region Performance informations

        #region PTAM Module performance informations

        long PTAMOverallPerformance = 0;
        long PTAMTrackingPerformance = 0;
        long PTAMMappingPerformance = 0;
        long PTAMImageConversionPerformance = 0;
        long PTAMMemoryMappedFileReadingPerformance = 0;

        #endregion PTAM Module performance informations

        #region Tester performance informations

        long testerOverallPerformance = 0;
        long testerMemoryMappedFilePerformance = 0;
        long testerImageConversionPerformance = 0;

        #endregion Tester performance informations

        #endregion Performance informations

        #region Inter-Process Communication objects
        MMF PTAMModuleSourceImageFile = new MMF();
        #endregion Inter-Process Communication objects

        #region Thread objects
        Thread iconAnimation;
        Thread sampleImageLoader;
        Thread receiverThread;
        #endregion Thread objects

        #region Other settings
        bool isSampleImageFolderEmpty = false;
        int imagePosition = 0;
        #endregion Other settings

        #endregion Testing informations

        public PTAMModuleForm()
        {
            InitializeComponent();
            iconAnimation = new Thread(IconAnimation);
            iconAnimation.Start();
        }

        private void btnSampleImagesFolderLocationSetter_Click(object sender, EventArgs e)
        {
            if (txtSampleImagesFolderLocation.Text == string.Empty || !Directory.Exists(txtSampleImagesFolderLocation.Text))
            {
                var dialogResult = dlgSampleImagesFolderLocation.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtSampleImagesFolderLocation.Text = dlgSampleImagesFolderLocation.SelectedPath;
                    btnStartSending.Enabled = true;
                    btnStopSending.Enabled = false;
                }
                else
                {
                    if (dialogResult == DialogResult.Cancel)
                    {
                        if (txtSampleImagesFolderLocation.Text != string.Empty)
                        {
                            if (Directory.Exists(txtSampleImagesFolderLocation.Text))
                            {
                                btnStartSending.Enabled = true;
                                btnStopSending.Enabled = false;
                            }
                            else
                            {
                                btnStopSending.Enabled = false;
                                btnStopSending.Enabled = false;
                            }
                        }
                        else
                        {
                            btnStartSending.Enabled = false;
                            btnStopSending.Enabled = false;
                        }
                    }
                }
            }
            else if (txtSampleImagesFolderLocation.Text != string.Empty && btnStartSending.Enabled == true)
            {
                var dialogResult = dlgSampleImagesFolderLocation.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    txtSampleImagesFolderLocation.Text = dlgSampleImagesFolderLocation.SelectedPath;
                    btnStartSending.Enabled = true;
                    btnStopSending.Enabled = false;
                }
                else
                {
                    if (dialogResult == DialogResult.Cancel)
                    {
                        if (txtSampleImagesFolderLocation.Text != string.Empty)
                        {
                            if (Directory.Exists(txtSampleImagesFolderLocation.Text))
                            {
                                btnStartSending.Enabled = true;
                                btnStopSending.Enabled = false;
                            }
                            else
                            {
                                btnStopSending.Enabled = false;
                                btnStopSending.Enabled = false;
                            }
                        }
                        else
                        {
                            btnStartSending.Enabled = false;
                            btnStopSending.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                if (Directory.Exists(txtSampleImagesFolderLocation.Text))
                {
                    btnStartSending.Enabled = true;
                    btnStopSending.Enabled = false;
                }
                else
                {
                    btnStopSending.Enabled = false;
                    btnStopSending.Enabled = false;
                }
            }
        }

        private void btnStartSending_Click(object sender, EventArgs e)
        {
            if (txtSampleImagesFolderLocation.Text == string.Empty)
            {
                return;
            }
            if (!Directory.Exists(txtSampleImagesFolderLocation.Text))
            {
                return;
            }

            lblStatusValue.Text = "Starting sending thread...";
            StartMainFunction();
            lblStatusValue.Text = "Thread started.";
        }

        void SourceImagesLoader(string folderLocation)
        {
            string[] fileNames = Directory.GetFiles(folderLocation, "*.png");

            if (fileNames.Length == 0)
            {
                isSampleImageFolderEmpty = true;
                return;
            }

            // Dispose old images and load new images if PTAMSourceImages is not null
            if (PTAMSourceImages != null)
            {
                for (int imageNumber = 0; imageNumber < fileNames.Length; imageNumber++)
                {
                    PTAMSourceImages[imageNumber].Dispose();
                }
            }

            PTAMSourceImages = new Mat[fileNames.Length];
            for (int imageNumber = 0; imageNumber < fileNames.Length; imageNumber++)
            {
                PTAMSourceImages[imageNumber] = new Mat(fileNames[imageNumber], ImreadModes.AnyColor);
            }

            ThreadHelperClass.SetImage(this, imgImagePreview, PTAMSourceImages[0].Bitmap);
        }

        void StartMainFunction()
        {
            mainFunction = new Thread(MainFunction);
            mainFunction.Start();
        }

        void StopMainFunction()
        {
            if (mainFunction.IsAlive)
            {
                mainFunction.Abort();
            }
        }

        void MainFunction()
        {
            ThreadHelperClass.SetText(this, lblStatusValue, "Loading sample images to memory...");
            SourceImagesLoader(txtSampleImagesFolderLocation.Text);

            if (isSampleImageFolderEmpty)
            {
                ThreadHelperClass.SetText(this, lblStatus, "The selected folder has no images or the images is not supported");
            }
            else
            {
                ThreadHelperClass.SetText(this, lblStatusValue, "Loading finished. " + PTAMSourceImages.Length + " images  were loaded into memory.");
            }
            Thread.Sleep(100);
            ThreadHelperClass.SetText(this, lblStatusValue, "Preparing for sending...");

            bool isExitRequested = false;
            MMF mappedFile = new MMF();
            mappedFile.CreateNewFile("PTAMHUBNotifierChannel", 10000000);
            int position = 0;

            do
            {
                Stopwatch overalPerformance = new Stopwatch();
                overalPerformance.Start();

                // Create preview of loaded image
                ThreadHelperClass.SetImage(this, imgImagePreview, sourceImage[position]);
                ThreadHelperClass.SetText(this, lblStatusValue, "Now previewing image: " + Files[position]);
                position++;
                if (position == Files.Length)
                {
                    position = 0;
                }

                #region Receiver threat
                receiverThread = new Thread(ResultReceiver);
                receiverThread.Start();
                #endregion Receiver threat

                ThreadHelperClass.SetText(this, lblStatusValue, "Writing image to memory-mapped file");

                // Convert image to array and save to tempImage
                Stopwatch imageConversionWatcher = new Stopwatch();
                imageConversionWatcher.Start();

                #region Image converter
                byte[] tempImage;
                using (var ms = new MemoryStream())
                {
                    PTAMSourceImages[position].Bitmap.Save(ms, PTAMSourceImages[position].Bitmap.RawFormat);
                    tempImage = ms.ToArray();
                }
                #endregion Image converter

                imageConversionWatcher.Stop();
                ThreadHelperClass.SetText(this, lblImageConversionPerformanceValue, imageConversionWatcher.ElapsedMilliseconds.ToString() + "ms");

                Stopwatch MMFWatcher = new Stopwatch();
                MMFWatcher.Start();
                // Write the image to memory-mapped file
                mappedFile.AddInformation(Convert.ToBase64String(tempImage));
                MMFWatcher.Stop();
                ThreadHelperClass.SetText(this, lblMemoryMappedFilePerformanceValue, MMFWatcher.ElapsedMilliseconds.ToString() + "ms");

                ThreadHelperClass.SetText(this, lblStatusValue, "File writen. Sending notification to Cursor 3D");

                // Notify Kursor3D Module about the image
                SendReport(PTAMModuleNamedPipeSendingChannel);

                ThreadHelperClass.SetText(this, lblStatusValue, "Module connected. Now waiting for the module to complete the process");

                // Wait for receiver thread to complete
                if (receiverThread.IsAlive)
                {
                    receiverThread.Join();
                }
                receiverThread = null;
                #region UI setter

                ThreadHelperClass.SetText(this, lblStatusValue, "Module has finished the work. Writing the received values");

                #region Pose

                #region Position
                ThreadHelperClass.SetText(this, lblPositionXValue, receivedXPosition.ToString());
                ThreadHelperClass.SetText(this, lblPositionYValue, receivedYPosition.ToString());
                ThreadHelperClass.SetText(this, lblPositionZValue, receivedZPosition.ToString());
                #endregion Position
                #region Orientation
                ThreadHelperClass.SetText(this, lblOrientationXValue, receivedXOrientation.ToString());
                ThreadHelperClass.SetText(this, lblOrientationYValue, receivedYOrientation.ToString());
                ThreadHelperClass.SetText(this, lblOrientationZValue, receivedZOrientation.ToString());
                #endregion Orientation
                #endregion Pose
                overalPerformance.Stop();
                ThreadHelperClass.SetText(this, lblOveralPerformanceValue, overalPerformance.ElapsedMilliseconds.ToString() + "ms");
                ThreadHelperClass.SetText(this, lblKursor3DOverallPerformanceValue, kursor3DOverallPerformance.ToString() + "ms");
                ThreadHelperClass.SetText(this, lblKursor3DFindHandThreadPerformanceValue, kursor3DFindHandPerformance.ToString() + "ms");
                ThreadHelperClass.SetText(this, lblKursor3DFindDepthThreadPerformanceValue, kursor3DFindDepthPerformance.ToString() + "ms");
                ThreadHelperClass.SetText(this, lblKursor3DGestureRecognitionThreadPerformanceValue, kursor3DgestureRecognitionPerformance.ToString() + "ms");
                #endregion UI setter
            } while (!isExitRequested);

        }

        #region Notifier threat
        #region Sender function
        protected void SendReport(string PipeName)
        {
            using (NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", PipeName, PipeDirection.Out))
            {
                pipeClient.Connect();
                using (StreamWriter sw = new StreamWriter(pipeClient))
                {
                    sw.AutoFlush = true;
                    sw.WriteLine("y");
                }
            }

            #region Old named pipe client notifier
            //try
            //{
            //    NamedPipeClient client = new NamedPipeClient(PipeName);
            //    if (!client.CheckConnection())
            //    {
            //        client.ConnectToServer();
            //    }

            //    client.WriteToServer((byte)'y');
            //    client.WaitForPipeDrain();
            //    client.DisconnectToServer();
            //}
            //catch (Exception err)
            //{
            //    DefaultErrorWriter(err);
            //}
            #endregion Old named pipe client notifier
        }
        #endregion Sender function
        #region Receiver thread
        
        // Receiver Thread
        void ResultReceiver()
        {
            try
            {
                string receivedValues = string.Empty;

                #region Reveiving code
                using (NamedPipeServerStream pipeServer = new NamedPipeServerStream(PTAMModuleNamedPipeReceivingChannel, PipeDirection.In))
                {
                    pipeServer.WaitForConnection();
                    try
                    {
                        using (StreamReader sr = new StreamReader(pipeServer))
                        {
                            string temp;
                            while ((temp = sr.ReadLine()) != null)
                            {
                                receivedValues = temp;
                            }
                        }
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine("ERROR: {0}", e.Message);
                    }
                }
                #endregion Receiving code
                string[] receivedValue = receivedValues.Split('|');

                receivedXPosition = Convert.ToInt32(receivedValue[0]);
                receivedYPosition = Convert.ToInt32(receivedValue[1]);
                receivedZPosition = Convert.ToInt32(receivedValue[2]);

                receivedXOrientation = Convert.ToInt32(receivedValue[3]);
                receivedYOrientation = Convert.ToInt32(receivedValue[4]);
                receivedZOrientation = Convert.ToInt32(receivedValue[5]);

                totalPointsCreated = Convert.ToInt32(receivedValue[6]);

                PTAMOverallPerformance = Convert.ToInt64(receivedValue[7]);
                PTAMTrackingPerformance = Convert.ToInt64(receivedValue[8]);
                PTAMMappingPerformance = Convert.ToInt64(receivedValue[9]);
                PTAMImageConversionPerformance = Convert.ToInt64(receivedValue[10]);
                PTAMMemoryMappedFileReadingPerformance = Convert.ToInt64(receivedValue[11]);
            }
            catch (Exception err)
            {

            }
        }
        #endregion Receiver thread
        #endregion Notifier threat

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
                Thread.Sleep(1000 / 30);
            } while (true);
        }

        private void PTAMModuleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            iconAnimation.Abort();

            // Dispose old images and load new images if PTAMSourceImages is not null
            if (PTAMSourceImages != null)
            {
                for (int imageNumber = 0; imageNumber < PTAMSourceImages.Length; imageNumber++)
                {
                    PTAMSourceImages[imageNumber].Dispose();
                }
            }
        }
    }
}
