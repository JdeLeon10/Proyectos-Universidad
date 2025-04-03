using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases.Listas
{
    public class clsLista
    {
        public clsNodoLista primero;
        public clsNodoLista ultimo;

        public clsLista()
        {
            primero = null;
            ultimo = null;
        }

        public void insertarElementoCabezaLista(int t)
        {
            clsNodoLista nuevo;
            nuevo = new clsNodoLista(t);
            nuevo.enlace = primero;
            primero = nuevo;
        }
        public int totalCartas()
        {
            int total = 0;
            clsNodoLista cartas;
            for (cartas = primero; cartas != null; cartas = cartas.enlace)
            {
                total = total + cartas.dato;
            }

            return total;
        }
    }
}
