using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AR3DModelerAppTester
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHMDModule_Click(object sender, EventArgs e)
        {
            HMDModuleForm hmdModuleForm = new HMDModuleForm();
            hmdModuleForm.ShowDialog();
        }

        private void ImagePanel_Click(object sender, EventArgs e)
        {

        }

        bool isMouseDown = false;
        Point lasLocation;
        private void ImagePanel_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lasLocation = e.Location;
        }
        private void ImagePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point((this.Location.X - lasLocation.X) + e.X, (this.Location.Y - lasLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void ImagePanel_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var color = Color.LightBlue;
            BackColor = color;
            TransparencyKey = color;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //var sb = new SolidBrush(Color.FromArgb(50, this.BackColor));
            //e.Graphics.FillRectangle(sb, this.DisplayRectangle);
        }

        private void btnHUBModule_Click(object sender, EventArgs e)
        {
            HUBModuleForm HUB = new HUBModuleForm();
            HUB.ShowDialog();
        }

        private void btnKursor3DModule_Click(object sender, EventArgs e)
        {
            Kursor3DModuleForm Kursor3D = new Kursor3DModuleForm();
            Kursor3D.ShowDialog();
        }

        private void btnModelerModule_Click(object sender, EventArgs e)
        {
            ModelerForm Modeler = new ModelerForm();
            Modeler.ShowDialog();
        }

        private void btnPTAMModule_Click(object sender, EventArgs e)
        {
            PTAMModuleForm PTAM = new PTAMModuleForm();
            PTAM.ShowDialog();
        }

        private void btnCreateNewTemplate_Click(object sender, EventArgs e)
        {
            CreateNewImageTemplate ImageTemplate = new CreateNewImageTemplate();
            ImageTemplate.ShowDialog();
        }

        private void btnImageRotator_Click(object sender, EventArgs e)
        {
            ImageRotator imageRotator = new ImageRotator();
            imageRotator.ShowDialog();
        }
    }
}
