using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFArbolBinario
{

    class NodoAvl : Nodo // Herencia implicita de noto simple
    {

        public int fe; // Factor equilibrio
        public NodoAvl(Object valor):base(valor) //Constructor
        {
            fe = 0;
        }

        public NodoAvl(Object valor, NodoAvl ramaIzdo, NodoAvl ramaDcho):base(ramaIzdo, valor, ramaDcho)
        {
            fe = 0;
        }
    }
}
