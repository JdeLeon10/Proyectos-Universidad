using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsBibliotecaDeClases
{
    public class clsNodo
    {
        public string Nombre {  get; set; }
        public clsNodo Siguiente { get; set; }

        public clsNodo(string nombre)
        {
            Nombre = nombre;
            Siguiente = null;
        }
    }
}
