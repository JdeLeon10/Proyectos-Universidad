using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases.Colas
{
    public class clsCola
    {
        public clsNodoCola frente;
        public clsNodoCola fin;

        public clsCola()
        {
            frente = null;
            fin = null;
        }

        public Boolean colaVacia()
        {
            return frente == null;
        }

        public object frenteCola()
        {
            if (colaVacia())
            {
                throw new Exception("Error: Cola vacia");
            }
            return (frente.carta);
        }

        public void insertarElementoCola(int valor)
        {
            clsNodoCola a;
            a = new clsNodoCola(valor);
            if (colaVacia())
            {
                frente = a;
            }
            else
            {
                fin.Siguiente = a;
            }
            fin = a;
        }

        public void retirarElementoCola()
        {
            object aux;
            if (!colaVacia())
            {
                aux = frente.carta;
                frente = frente.Siguiente;
            }
            else
            {
                throw new Exception("Eliminar de una cola vacia");
            }
        }

        public void borrarCola()
        {
            for (; frente != null;)
            {
                frente = frente.Siguiente;
            }
        }
    }
}
