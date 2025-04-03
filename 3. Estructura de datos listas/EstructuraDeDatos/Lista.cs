using BibliotecaDeClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraDeDatos
{
    public class Lista
    {
        public Nodo primero;
        public Nodo ultimo;

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void insertarCabezaLista(Persona vDato)
        {
            Nodo nuevo;
            nuevo = new Nodo(vDato);
            nuevo.enlace = primero;
            primero = nuevo;
        }

        public Lista insertarUltimo(Nodo ultimo, Persona entrada)
        {
            ultimo.enlace = new Nodo(entrada);
            ultimo = ultimo.enlace;
            return this;
        }

        public Lista insertarLista(Persona testigo, Persona entrada)
        {
            Nodo nuevo, anterior;
            anterior = buscarLista(testigo);
            if (anterior != null)
            {
                nuevo = new Nodo(entrada);
                nuevo.enlace = anterior.enlace;
                anterior.enlace = nuevo;
            }
            return this;
        }

        public Nodo buscarLista(Persona destino)
        {
            Nodo indice;
            for (indice = primero; indice != null; indice = indice.enlace)
            {
                if (destino.Equals(indice.dato))
                {
                    return indice;
                }
            }
            return null;
        }

        public void eliminar(Persona entrada)
        {
            Nodo actual, anterior;
            Boolean encontrado;
            //inicializa los apuntadores
            actual = primero;
            anterior = null;
            encontrado = false;
            // búsqueda del nodo y del anterior
            while ((actual != null) && (!encontrado))
            {
                //encontrado (actual. Dato == entrada);
                encontrado = (actual.dato.Equals(entrada));
                //con objetos:
                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.enlace;
                }
            }

            // Enlace del nodo anterior con el siguiente
            if (actual != null)
            {
                // Distingue entre que el nodo sea el cabecera,
                // o del resto de la lista
                if (actual == primero)
                {
                    primero = actual.enlace;
                }
                else
                {
                    anterior.enlace = actual.enlace;
                }
                actual = null; // no es necesario al ser una variable local
            }
        }

        public Persona personaMasJoven()
        {
            if (primero == null)
            {
                return null;
            }
            Nodo actual = primero;
            Persona personaMasJoven = actual.dato;
            while (actual.enlace != null)
            {
                actual = actual.enlace;

                if (actual.dato.Edad < personaMasJoven.Edad)
                {
                    personaMasJoven = actual.dato;
                }
            }
            return personaMasJoven;
        }

        public Persona personaMasVieja()
        {
            if (primero == null)
            {
                return null;
            }
            Nodo actual = primero;
            Persona personaMasVieja = actual.dato;
            while (actual.enlace != null)
            {
                actual = actual.enlace;

                if (actual.dato.Edad > personaMasVieja.Edad)
                {
                    personaMasVieja = actual.dato;
                }
            }
            return personaMasVieja;
        }
    }
}
