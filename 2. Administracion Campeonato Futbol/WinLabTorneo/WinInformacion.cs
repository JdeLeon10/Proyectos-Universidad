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
    public partial class WinInformacion : Form
    {
        public WinInformacion()
        {
            InitializeComponent();
        }

        private void WinInformacion_Load(object sender, EventArgs e)
        {
            foreach (clsJugador jugador in Program.Globales.Jugadores)
            {

                this.dataInfo.Rows.Add(jugador.NombreJugador, jugador.NombreEquipo, jugador.NoCamisola, jugador.CTarjetasAmarillas, jugador.CTarjetasRojas, jugador.CGoles);
            }
        }
    }
}
