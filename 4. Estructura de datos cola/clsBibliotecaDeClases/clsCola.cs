namespace clsBibliotecaDeClases
{
    public class clsCola
    {
        public clsNodo frente;
        public clsNodo fin;

        public clsCola()
        {
            frente = null;
            fin = null;
        }

        // Verificacion del estado de la cola
        public Boolean colaVacia()
        {
            return frente == null;
        }

        // Acceso al primer elemento de la cola
        public object frenteCola()
        {
            if (colaVacia())
            {
                throw new Exception("Error: Cola vacia");
            }
            return (frente.Nombre);
        }

        public void insertarElemento(string nombre)
        {
            clsNodo a;
            a = new clsNodo(nombre);
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

        public void retirarElemento()
        {
            object aux;
            if (!colaVacia())
            {
                aux = frente.Nombre;
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
