using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPC;
using System.IO;
using System.Diagnostics;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.Util;
using Emgu.CV.Structure;
using System.IO.Pipes;

namespace AR3DModelerAppTester
{
    public partial class Kursor3DModuleForm : Form
    {
        #region Cursor 3D Informations

        Thread receiverThread;
        Thread iconAnimation;

        #endregion Cursor 3D Informations

        public Kursor3DModuleForm()
        {
            InitializeComponent();
            iconAnimation = new Thread(IconAnimation);
            iconAnimation.Start();
        }

        private void txtFolderLocation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (sampleImageFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtFolderLocation.Text = sampleImageFolderBrowser.SelectedPath;
                btnStartSending.Enabled = true;
                btnStopSending.Enabled = false;
            }
            else
            {
                btnStartSending.Enabled = false;
                btnStopSending.Enabled = false;
            }
        }

        private void btnStartSending_Click(object sender, EventArgs e)
        {
            lblStatusValue.Text = "Waiting for sender thread to start...";
            btnStartSending.Enabled = false;
            btnStopSending.Enabled = true;

            cursor3DSourceImage = txtFolderLocation.Text;

            kursor3DTestThread = new Thread(Kursor3DTestThread);
            kursor3DTestThread.Start();
        }

        private void btnStopSending_Click(object sender, EventArgs e)
        {
            lblStatusValue.Text = "Waiting for sender thread to stop...";
            btnStartSending.Enabled = true;
            btnStopSending.Enabled = false;

            kursor3DTestThread.Abort();
        }

        // Kursor3D Testing thread setup
        Thread kursor3DTestThread;
        string cursor3DSourceImage = string.Empty;

        void Kursor3DTestThread()
        {
            // TODO: Implement actAsModelerModule
            ThreadHelperClass.SetText(this, lblStatusValue, "Thread started. Loading images from selected folder to memory...");

            ThreadHelperClass.SetText(this, lblStatusValue, "Thread started. Loading images from selected folder to memory...");

            #region Test image loader
            Bitmap[] sourceImage;
            string[] Files = Directory.GetFiles(cursor3DSourceImage, "*.png");
            sourceImage = new Bitmap[Files.Length];
            for (int fileNumber = 0; fileNumber < Files.Length; fileNumber++)
            {
                sourceImage[fileNumber] = new Bitmap(Files[fileNumber]);
            }
            #endregion Test image loader

            ThreadHelperClass.SetText(this, lblStatusValue, "Images loaded. " + Files.Length + " files were added to memory");

            bool isExitRequested = false;
            MMF mappedFile = new MMF();
            mappedFile.CreateNewFile("Kursor3DSourceImage", 10000000);
            int position = 0;

            do
            {
                Stopwatch overalPerformance = new Stopwatch();
                overalPerformance.Start();

                // Create preview of loaded image
                ThreadHelperClass.SetImage(this, picImagePreview, sourceImage[position]);
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
                    sourceImage[position].Save(ms, sourceImage[position].RawFormat);
                    tempImage = ms.ToArray();
                }
                #endregion Image converter

                imageConversionWatcher.Stop();
                ThreadHelperClass.SetText(this, lblImageConversionPerformaceValue, imageConversionWatcher.ElapsedMilliseconds.ToString() + "ms");

                Stopwatch MMFWatcher = new Stopwatch();
                MMFWatcher.Start();
                // Write the image to memory-mapped file
                mappedFile.AddInformation(Convert.ToBase64String(tempImage));
                MMFWatcher.Stop();
                ThreadHelperClass.SetText(this, lblMMFPerformanceValue, MMFWatcher.ElapsedMilliseconds.ToString() + "ms");

                ThreadHelperClass.SetText(this, lblStatusValue, "File writen. Sending notification to Cursor 3D");
                
                // Notify Kursor3D Module about the image
                SendReport("Kursor3DImageNotifier");

                ThreadHelperClass.SetText(this, lblStatusValue, "Module connected. Now waiting for the module to complete the process");
                
                // Wait for receiver thread to complete
                if (receiverThread.IsAlive)
                {
                    receiverThread.Join();
                }
                receiverThread = null;
                #region UI setter
                ThreadHelperClass.SetText(this, lblStatusValue, "Module has finished the work. Writing the received values");
                ThreadHelperClass.SetText(this, lblXPositionValue, x.ToString());
                ThreadHelperClass.SetText(this, lblYPositionValue, y.ToString());
                ThreadHelperClass.SetText(this, lblZPositionValue, z.ToString());
                ThreadHelperClass.SetText(this, lblGestureTypeValue, gestureType);
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
        double x = 0;
        double y = 0;
        double z = 0;
        string gestureType = string.Empty;

        // For debugging purposes
        long kursor3DOverallPerformance = 0;
        long kursor3DFindHandPerformance = 0;
        long kursor3DFindDepthPerformance = 0;
        long kursor3DgestureRecognitionPerformance = 0;
        

        // Receiver Thread
        void ResultReceiver()
        {
            try
            {
                string receivedValues = string.Empty;

                #region Reveiving code
                using (NamedPipeServerStream pipeServer = new NamedPipeServerStream("CursorProcessCompleteNotifier", PipeDirection.In))
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
                #endregion REceiving code
                string[] receivedValue = receivedValues.Split('|');
                
                x = Convert.ToDouble(receivedValue[0]);
                y = Convert.ToDouble(receivedValue[1]);
                z = Convert.ToDouble(receivedValue[2]);
                gestureType = receivedValue[3];

                // For debugging purposes
                kursor3DOverallPerformance = Convert.ToInt64(receivedValue[4]);
                kursor3DFindHandPerformance = Convert.ToInt64(receivedValue[5]);
                kursor3DFindDepthPerformance = Convert.ToInt64(receivedValue[6]);
                kursor3DgestureRecognitionPerformance = Convert.ToInt64(receivedValue[7]);
            }
            catch (Exception err)
            {

            }
        }
        #endregion Receiver thread
        #endregion Notifier threat

        // Programatically change icon and creating a simple animation
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
                Thread.Sleep(1000/30);
            } while (true);
        }

        private void Kursor3DModuleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            iconAnimation.Abort();
        }

        void DefaultErrorWriter(Exception e)
        {
            Console.WriteLine("\nError found after trying to send notification to sender.\n");
            Console.WriteLine("Line that causing the problem is:");
            Console.WriteLine(e.Source);
            Console.WriteLine("Below is the stack trace of the cause.");
            Console.WriteLine(e.StackTrace);
            Console.WriteLine("\nWish you good luck to solve it");
        }

        private void Kursor3DModuleForm_Load(object sender, EventArgs e)
        {

        }
    }
}