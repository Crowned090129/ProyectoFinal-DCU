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
    public partial class frmRegisterFaceAutenticator : Form
    {
        public frmRegisterFaceAutenticator()
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
            if (txtUserName1.Text == "" || txtPass1.Text == "")
            {
                MessageBox.Show("Debe escribir un username y un password para poder registrarse.");
            }
            else
            {
                if (txtUserName1.Text.Trim() != txtUserName2.Text.Trim())
                {
                    MessageBox.Show("Los campos UserName deben ser iguales.");
                }
                else
                {
                    if (txtPass1.Text.Trim() != txtPass2.Text.Trim())
                    {
                        MessageBox.Show("Los campos Password deben ser iguales.");
                    }
                    else
                    {

                        recognitionManager.Save_IMAGE(txtUserName1.Text);

                        recognitionManager.isTrained = true;

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
                            MessageBox.Show("Intentelo de nuevo.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            pic.Invalidate();
                            pic.Refresh();
                            recognitionManager = new FaceRec();
                            this.Close();
                        }
                    }
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
