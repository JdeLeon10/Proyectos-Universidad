using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFArbolBinario
{
    
    class Nodo
    {
        protected Object dato;
        protected Nodo izdo;
        protected Nodo dcho;

        /// <summary>
        /// Método Constructor del nodo el cual recibe un valor y asign
        /// asigna nulos a los hijos
        /// </summary>
        /// <param name="valor">hhhhhhhhhhhhh</param>
        public Nodo(Object valor) // constructor que recibe un object para poder utilizarlo con cualquier cosa / proyecto
        {
            dato = valor;
            izdo = dcho = null;
        }

        // Los constructores tienen el mismo nombre que la clase y no retornan nada
        public Nodo(Nodo ramaIzdo, Object valor, Nodo ramaDcho)
        {
            this.dato=valor;
            izdo = ramaIzdo;
            dcho = ramaDcho;
        }

        // operaciones de acceso
        public Object valorNodo()
        { 
            return dato; // Devuelve el objeto dato
        }

        public Nodo subarbolIzdo() { return izdo; }
        public Nodo subarbolDcho() { return dcho; }


        public void nuevoValor(Object d) // Reemplazar un valor existente, serviria para hacer un mantenimiento en el arbol
        {
            dato = d; 
        }

        // void se utiliza porque es una funcion que no retornara nada, operaciones vacias
        public void ramaIzdo(Nodo n) { izdo = n; } // Asignar un nuevo nodo al lado izquierdo
        public void ramaDcho(Nodo n) { dcho = n; } // Asignar un nuevo nodo al lado derecho
        public string visitar()
        {
            return dato.ToString(); // al ser tipo object podra reutilizarse en cualquier proyecto
        }

    }
}
