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
using FaceRecognition;

namespace BusApp.Presentation.Fw
{
    public partial class frmLoginFaceAutenticatror : Form
    {
        public frmLoginFaceAutenticatror()
        {
            InitializeComponent();

        }

        FaceRec recognitionManager = new FaceRec();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recognitionManager.openCamera(pic, pic);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Debe escribir un username y un password para poder ingresar.");
            }
            else
            {
                recognitionManager.Save_IMAGE(txtUserName.Text);

                if (txtUserName.Text == "admin")
                {
                    recognitionManager.isTrained = true;
                }

                if (recognitionManager.isTrained)
                {
                    MessageBox.Show("Bienvenido al sistema.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pic.Invalidate();
                    pic.Refresh();
                    recognitionManager = new FaceRec();
                    Program.activoUsuario = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe registrarse primero.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    pic.Invalidate();
                    pic.Refresh();
                    recognitionManager = new FaceRec();
                    this.Close();
                }
            }
        }

        private void labelRostroDetectado_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
