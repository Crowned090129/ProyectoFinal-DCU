using System;
using System.Windows.Forms;

namespace BusApp.Presentation.Fw
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void bgPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLoginFaceAutenticatror frm = new frmLoginFaceAutenticatror();
            frm.ShowDialog();

            if (Program.activoUsuario)
            {
                frmAutobuses conductor = new frmAutobuses();
                conductor.ShowDialog();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegisterFaceAutenticator frm = new frmRegisterFaceAutenticator();
            frm.ShowDialog();

            if (Program.activoUsuario)
            {
                frmAutobuses conductor = new frmAutobuses();
                conductor.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
