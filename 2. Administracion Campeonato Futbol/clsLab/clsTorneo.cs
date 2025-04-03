using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsLab
{
    public class clsTorneo
    {
        public string NombreTorneo { get; set; }
        public clsEquipo[] Equipos { get; private set; }

        public clsTorneo(string nombretorneo) // constructor con parametro solicitados
        {
            NombreTorneo = nombretorneo;
            Equipos = new clsEquipo[19]; // inicializacion de array
        }

        public void AgregarEquipo(string nombreequipo) // metodo para agregar un equipo
        {
            clsEquipo equipo = new clsEquipo(nombreequipo);
            for (int i = 0; i < Equipos.Length; i++)
            {
                if (Equipos[i] == null)
                {
                    Equipos[i] = equipo;
                    break;
                }
            }
        }

        public void AgregarJugador(int equipo, string nombrejugador, int nocamisola) // metodo para agregar un jugador
        {
            clsJugador jugador = new clsJugador(nombrejugador, nocamisola);
            for (int i = 0; i < Equipos[equipo].Jugadores.Length; i++)
            {
                if (Equipos[equipo].Jugadores[i] == null)
                {
                    Equipos[equipo].Jugadores[i] = jugador;
                    break;
                }
            }
        }
    }
}
