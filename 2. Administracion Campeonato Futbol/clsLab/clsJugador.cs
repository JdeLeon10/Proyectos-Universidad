using static System.Runtime.InteropServices.JavaScript.JSType;

namespace clsLab
{
    public class clsJugador
    {
        public string NombreJugador { get; set; }
        public int NoCamisola { get; set; }
        public int CTarjetasAmarillas { get; private set; } = 0;
        public int CTarjetasRojas { get; private set; } = 0;
        public int CGoles { get; private set; } = 0;
        public string NombreEquipo { get; set; }

        public clsJugador(string nombrejugador, int nocamisola) // constructor con parametros solicitados
        {
            NombreJugador = nombrejugador;
            NoCamisola = nocamisola;
        }

        public clsJugador(string nombrejugador, int nocamisola, string nombreequipo) // constructor con parametros solicitados
        {
            NombreJugador = nombrejugador;
            NoCamisola = nocamisola;
            NombreEquipo = nombreequipo;
        }

        public void IncrementarTarjetasAmarillas(int numerotarjetas) // metodo para sumar tarjetas amarillas
        {
            CTarjetasAmarillas = CTarjetasAmarillas + numerotarjetas;
        }

        public void IncrementarTarjetasRojas(int numerotarjetas) // metodo para sumar tarjetas rojas
        {
            CTarjetasRojas = CTarjetasRojas + numerotarjetas;
        }

        public void IncrementarGoles(int numerogoles) // metodo para sumar cantidad de goles anotados
        {
            CGoles = CGoles + numerogoles;
        }
    }
}
