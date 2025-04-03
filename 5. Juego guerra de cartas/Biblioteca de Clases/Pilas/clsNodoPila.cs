using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases.Pilas
{
    public class clsNodoPila
    {
        public int carta;
        public clsNodoPila Siguiente;

        public clsNodoPila(int valor)
        {
            carta = valor;
            Siguiente = null;
        }
    }
}
