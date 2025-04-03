using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WFArbolBinario.LaboratorioABB2
{
    public class Proyecto : Comparador
    {
        public string nombre {  get; set; }
        public string descripcion { get; set; }
        public Cliente cliente { get; set; }
        public DateTime fecha { get; set; }

        public Proyecto(string nombre, string descripcion, Cliente cliente, DateTime fecha)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cliente = cliente;
            this.fecha = fecha;
        }

        public bool igualQue(object q)
        {
            /* Vehiculo q2 = (Vehiculo)q;
            return this.noPlaca == q2.noPlaca; */
            Proyecto q2 = (Proyecto)q;
            return this.nombre == q2.nombre;
        }

        public bool menorQue(object q)
        {
            /* Vehiculo q2 = (Vehiculo)q;
            if (this.noPlaca.CompareTo(q2.noPlaca) < 0)
                return true;
            else
                return false; */
            Proyecto q2 = (Proyecto)q;
            if (this.nombre.CompareTo(q2.nombre) < 0)
                return true;
            else
                return false; throw new NotImplementedException();
        }

        public bool menorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool mayorQue(object q)
        {
            /* Vehiculo q2 = (Vehiculo)q;
            if (this.noPlaca.CompareTo(q2.noPlaca) > 0)
                return true;
            else
                return false;*/
            Proyecto q2 = (Proyecto)q;
            if (this.nombre.CompareTo(q2.nombre) > 0)
                return true;
            else
                return false;
        }

        public bool mayorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public bool igualQue(string q)
        {
            return this.nombre == q;
        }

        public bool menorQue(string q)
        {
            if (this.nombre.CompareTo(q) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool mayorQue(string q)
        {
            if (this.nombre.CompareTo(q) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
