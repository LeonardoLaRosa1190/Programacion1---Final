using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.ApplicationModel.VoiceCommands;

namespace sys_LeonardoLaRosa
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            
        }

        private void peajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abre el formulario correspondiente cuando se pulsa el boton en el Menú
            frmPeaje frmPeaje = new frmPeaje();
            frmPeaje.ShowDialog();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrabajadores frmTrabajadores = new frmTrabajadores();
            frmTrabajadores.ShowDialog();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            menuStrp.Focus();
        }
    }
    
}
