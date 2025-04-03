using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsLab
{
    public class clsEquipo
    {
        public string NombreEquipo { get; set; }
        public clsJugador[] Jugadores { get; set; }

        public clsEquipo(string nombreequipo) // constructor con parametro solicitados
        {
            NombreEquipo = nombreequipo;
            Jugadores = new clsJugador[21]; // inicializacion de array
        }
    }
}
