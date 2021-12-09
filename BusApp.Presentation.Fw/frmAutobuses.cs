using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using BusApp.Common;

namespace BusApp.Presentation.Fw
{
    public partial class frmAutobuses : Form
    {
        public frmAutobuses()
        {
            InitializeComponent();
        }

        private bool mouseDown;
        private Point lastLocation;

        private void frmConductor_Load(object sender, EventArgs e)
        {

            AdmBus n = new AdmBus();
            dataGridView1.DataSource = n.GetAutoBuses();
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmConductor_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void frmConductor_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) 
            {
                this.Location = new Point(this.Location.X - lastLocation.X + e.X, this.Location.Y - lastLocation.Y + e.Y);
            }
        }

        private void frmConductor_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
