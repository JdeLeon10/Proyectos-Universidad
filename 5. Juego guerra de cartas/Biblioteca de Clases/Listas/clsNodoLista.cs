using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases.Listas
{
    public class clsNodoLista
    {
        public int dato;
        public clsNodoLista enlace;

        public clsNodoLista(int t)
        {
            dato = t;
            enlace = null;
        }
    }
}
