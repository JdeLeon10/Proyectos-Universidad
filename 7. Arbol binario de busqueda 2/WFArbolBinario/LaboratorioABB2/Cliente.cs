using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFArbolBinario.LaboratorioABB2
{
    public class Cliente
    {
        string nit {  get; set; }
        string nombre { get; set; }
        string direccion {  get; set; }

        public Cliente(string nit, string nombre, string direccion)
        {
            this.nit = nit;
            this.nombre = nombre;
            this.direccion = direccion;
        }

        public override string ToString() // sobrescribe el metodo ToString
        {
            return "(" + nit + " - " + nombre + " - " + direccion + ")";
        }
    }
}
