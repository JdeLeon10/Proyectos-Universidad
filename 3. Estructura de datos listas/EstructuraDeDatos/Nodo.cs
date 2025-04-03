using BibliotecaDeClases;

namespace EstructuraDeDatos
{
    public class Nodo
    {
        public Persona dato;
        public Nodo enlace;

        public Nodo(Persona vDato)
        {
            dato = vDato;
            enlace = null;
        }
    }
}
