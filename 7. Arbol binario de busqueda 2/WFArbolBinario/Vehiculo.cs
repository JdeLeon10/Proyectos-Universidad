using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFArbolBinario
{
    class Vehiculo : Comparador // Logica debe centrarse en igual, mayor y menor que
    {
        string noPlaca;
        int modelo;
        string marca;

        public Vehiculo(string noPlaca, int modelo, string marca)
        {
            this.noPlaca = noPlaca;
            this.modelo = modelo;
            this.marca = marca;
        }

        bool Comparador.igualQue(object q)
        {
            Vehiculo q2 = (Vehiculo)q;
            return this.noPlaca == q2.noPlaca; // Valida si los numeros de placa son iguales, si son iguales retorna true
        }

        bool Comparador.mayorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        bool Comparador.mayorQue(object q) // Compara dos vehiculos con su numero de placa aunque sea texto
        {
            Vehiculo q2 = (Vehiculo)q;
            if (this.noPlaca.CompareTo(q2.noPlaca) > 0) 
                return true;
            else
                return false;
        }

        bool Comparador.menorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        bool Comparador.menorQue(object q)
        {
            Vehiculo q2 = (Vehiculo)q;
            if (this.noPlaca.CompareTo(q2.noPlaca) < 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "(" + noPlaca + " - " + modelo +  " - " + marca + ")";
        }

        public bool igualQue(string q)
        {
            throw new NotImplementedException();
        }

        public bool menorQue(string q)
        {
            throw new NotImplementedException();
        }

        public bool mayorQue(string q)
        {
            throw new NotImplementedException();
        }
    }
}
