using clsLab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLabTorneo
{
    public partial class winJugador : Form
    {
        public winJugador()
        {
            InitializeComponent();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = CBNombreEquipo.SelectedIndex;
                if (posicion == -1)
                {
                    MessageBox.Show("Selecciona un equipo");
                }
                else
                {
                    Program.Globales.Torneo.AgregarJugador(posicion, txtNombreJugador.Text, int.Parse(txtNoCamisola.Text));
                    Program.Globales.Jugadores.Add(new clsJugador(txtNombreJugador.Text, int.Parse(txtNoCamisola.Text), CBNombreEquipo.Text)); // 
                    MessageBox.Show("Jugador Agregado");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void winJugador_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.Globales.Torneo.Equipos.Length; i++)
            {
                if (Program.Globales.Torneo.Equipos[i] == null)
                {
                    break;
                }
                else
                {
                    CBNombreEquipo.Items.Add(Program.Globales.Torneo.Equipos[i].NombreEquipo);
                }
            }
        }
    }
}
