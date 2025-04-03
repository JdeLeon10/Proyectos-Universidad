using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFArbolBinario
{
    class Pais : Comparador
    {
        string nombre;
        string continente;
        int habitantes;

        public Pais(string nombre, string continente, int habitantes)
        { 
            this.nombre = nombre;
            this.continente = continente;
            this.habitantes = habitantes;
        }

        bool Comparador.igualQue(object q)
        {
            Pais q2 = (Pais)q;
            return this.nombre == q2.nombre;
        }

        bool Comparador.mayorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        bool Comparador.mayorQue(object q)
        {
            throw new NotImplementedException();
        }

        bool Comparador.menorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        bool Comparador.menorQue(object q)
        {
            throw new NotImplementedException();
        }
    }
}
