using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases.Colas
{
    public class clsNodoCola
    {
        public int carta;
        public clsNodoCola Siguiente;

        public clsNodoCola(int valor)
        {
            carta = valor;
            Siguiente = null;
        }
    }
}
