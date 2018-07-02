using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPC;
using ImageProcessor;
using System.Threading;
using System.IO;

namespace AR3DModelerAppTester
{
    public partial class ModelerForm : Form
    {
        public ModelerForm()
        {
            InitializeComponent();
        }

        private void ModelerForm_Load(object sender, EventArgs e)
        {

        }

        BackgroundWorker worker1;

        Thread modeler = null;
        void ModelerThread()
        {
            
            ThreadHelperClass.SetText(this, lblStatusValue, "Requesting the HUB resolution...");

            bool isExitRequested = false;
            char receivedCode;

            NamedPipesServer imageNotifier = new NamedPipesServer();
            MMF ImageData;
            Bitmap imageReceived;

            #region Screen Resolution Request
            int width;
            int height;
            // Connect for first time check for resolution used by main program
            NamedPipesServer server = new NamedPipesServer();
            server.CreateNewServerPipe("res-pipe", NamedPipesServer.PipeDirection.DirectionInOut, NamedPipesServer.SendMode.MessageMode);
            server.WaitForConnection();
            string resolution = server.ReadMessage();

            // Separate screen width and height
            string[] res = resolution.Split('x');
            width = Convert.ToInt32(res[0]);
            height = Convert.ToInt32(res[1]);

            string receivedResolution = "Connected client resolution: " + width + " x " + height;
            ThreadHelperClass.SetText(this, lblStatusValue, "HUB's resolution received");
            ThreadHelperClass.SetText(this, lblScreenResolutionValue, receivedResolution);
            #endregion Screen Resolution Request

            bool isFirstTime = true;
            do
            {
                ThreadHelperClass.SetText(this, lblStatusValue, "Waiting new notification...");

                try
                {
                    // Memory-mapped file access
                    server.CreateNewServerPipe("ImageNotifier", NamedPipesServer.PipeDirection.DirectionInOut, NamedPipesServer.SendMode.ByteMode);
                    server.WaitForConnection();
                    if (server.ReadByte() == (char)'y')
                    {
                        ThreadHelperClass.SetText(this, lblStatusValue, "Receiving image...");
                        byte[] file = null;
                        Console.WriteLine('y');
                        // Load image from Memory-mapped file and display as texture for model.
                        MMF mappedFile = new MMF();
                        mappedFile.OpenExisting("MapTest");
                        file = Convert.FromBase64String(mappedFile.ReadContent(MMF.DataType.DataString));


                        using (var ms = new MemoryStream(file))
                        {
                            imageReceived = new Bitmap(ms);
                        }
                        ThreadHelperClass.SetImage(this, imgTesterPreviewImage, imageReceived);
                    }


                }
                catch (Exception err)
                {
                    throw;
                }
                server.Disconnect();
                server.ClosePipe();

                //try
                //{

                //    imageNotifier.CreateNewServerPipe("test-pipe", NamedPipesServer.PipeDirection.DirectionInOut, NamedPipesServer.SendMode.ByteMode);
                //    imageNotifier.WaitForConnection();

                //    receivedCode = (char)imageNotifier.ReadByte();
                //    imageNotifier.WaitForPipeDrain();
                //    if (receivedCode == 'x')
                //        isExitRequested = true;
                //    else
                //        isExitRequested = false;

                //    if (receivedCode == 'y')
                //    {
                //        ThreadHelperClass.SetText(this, lblStatusValue, "New notification. Receiving...");
                //        byte[] file = null;
                //        // Load image from Memory-mapped file
                //        MMF mappedFile = new MMF();
                //        mappedFile.OpenExisting("MapTest");
                //        file = Convert.FromBase64String(mappedFile.ReadContent(MMF.DataType.DataString));


                //        using (var ms = new MemoryStream(file))
                //        {
                //            imageReceived = new Bitmap(ms);
                //        }

                //        ThreadHelperClass.SetImage(this, previewImage, imageReceived);
                //    }
                //}
                //catch (Exception err)
                //{

                //    throw;
                //}
                //server.Disconnect();
                //server.ClosePipe();

            } while (!isExitRequested);
        }

        private void btnStartReceiving_Click(object sender, EventArgs e)
        {
            lblStatusValue.Text = "Starting thread";
            modeler = new System.Threading.Thread(ModelerThread);
            modeler.Start();
            lblStatusValue.Text = "Thread started";
        }

        private void btnStopReceiving_Click(object sender, EventArgs e)
        {
            modeler.Abort();

            lblStatusValue.Text = "Modeler thread aborted.";
        }

        private void ModelerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (modeler.IsAlive)
            {
                modeler.Abort();
            }
        }

        private void previewImage_Click(object sender, EventArgs e)
        {

        }
    }
}
