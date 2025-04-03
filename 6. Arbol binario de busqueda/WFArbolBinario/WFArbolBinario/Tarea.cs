using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFArbolBinario
{
    class Tarea : Comparador
    {
        string nombreTarea { get; set; }
        int duracionTarea { get; set; }
        int porcentajeAvance { get; set; }
        string programadorAsignado { get; set; }

        public Tarea(string nombreTarea, int duracionTarea, int porcentajeAvance, string programadorAsignado)
        //public Tarea(int duracionTarea)

        {
            this.nombreTarea = nombreTarea;
            this.duracionTarea = duracionTarea;
            this.porcentajeAvance = porcentajeAvance;
            this.programadorAsignado = programadorAsignado;
        }

        bool Comparador.igualQue(object q)
        {
            Tarea p2 = (Tarea)q;
            return duracionTarea == p2.duracionTarea;
        }

        bool Comparador.mayorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        bool Comparador.mayorQue(object q)
        {
            Tarea p2 = (Tarea)q;
            return duracionTarea > p2.duracionTarea;
        }

        bool Comparador.menorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        bool Comparador.menorQue(object q)
        {
            Tarea p2 = (Tarea)q;
            return duracionTarea < p2.duracionTarea;
        }

        public override string ToString() // sobrescribe el metodo ToString
        {
            return "(" + nombreTarea + " - " + duracionTarea + " - " + porcentajeAvance + " - " + programadorAsignado + ")";
        }
    }
}
