using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsLab;

namespace WinLabTorneo
{
    public partial class winTorneo : Form
    {
        public winTorneo()
        {
            InitializeComponent();
        }

        private void btnAgregarTorneo_Click(object sender, EventArgs e)
        {
            Program.Globales.Torneo = new clsTorneo(txtNombreTorneo.Text);
            MessageBox.Show("Torneo Agregado");
            Close();
        }
    }
}
