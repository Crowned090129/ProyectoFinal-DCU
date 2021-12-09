using BusApp.Data.Managers;
using System;
using System.Windows.Forms;
using BusApp.Common;

namespace TestWorkSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AdmFaceRecognition rec = new AdmFaceRecognition();

        private void btnTestButton_Click(object sender, EventArgs e)
        {
            ConductorManager manager = new ConductorManager("CONDUCTOR_GET");
            var x = manager.Get("CBA0000007");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            rec.OpenCamera(pcBox1, pictureBox2);
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            rec.SaveImage(textBox1.Text);
        }

        private void btnDetect_Click(object sender, EventArgs e)
        {
            rec.Recognition();
        }
    }
}
