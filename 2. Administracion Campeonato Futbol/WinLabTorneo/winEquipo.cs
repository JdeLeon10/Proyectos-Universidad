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
    public partial class winEquipo : Form
    {
        public winEquipo()
        {
            InitializeComponent();
        }

        private void btnAgregarEquipo_Click(object sender, EventArgs e)
        {
            Program.Globales.Torneo.AgregarEquipo(txtNombreEquipo.Text);
            MessageBox.Show("Equipo Agregado");
            Close();
        }
    }
}
