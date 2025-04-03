using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases.Pilas
{
    public class clsPila
    {
        public clsNodoPila cima;

        public clsPila()
        {
            cima = null;
        }

        public Boolean pilaVacia()
        {
            return cima == null;
        }

        public void insertarElementoPila(int valor)
        {
            clsNodoPila nuevo;
            nuevo = new clsNodoPila(valor);
            nuevo.Siguiente = cima;
            cima = nuevo;
        }

        public void retirarElementoPila()
        {
            object aux;
            if (!pilaVacia())
            {
                aux = cima.carta;
                cima = cima.Siguiente;
            }
            else
            {
                throw new Exception("Eliminar de una cola vacia");
            }
        }

        public int cimaPila()
        {
            if (pilaVacia())
            {
                throw new Exception("Pila vacia, no se puede leer cima.");
            }
            return cima.carta;
        }

        public void limpiarPila()
        {
            clsNodoPila t;
            while (!pilaVacia())
            {
                t = cima;
                cima = cima.Siguiente;
                t.Siguiente = null;
            }
        }
    }
}