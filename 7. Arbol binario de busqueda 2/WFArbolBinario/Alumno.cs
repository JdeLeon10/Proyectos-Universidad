using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFArbolBinario
{
    public class Alumno : Comparador
    {
        string carne { get; set; }
        string estudiante { get; set; }
        string correoElectronico { get; set; }
        int parcial1 { get; set; }
        int parcial2 { get; set; }
        int zona { get; set; }
        int final { get; set; }
        int total { get; set; }

        public Alumno(string carne, string estudiante, string correoElectronico, int parcial1, int parcial2, int zona, int final, int total)
        {
            this.carne = carne;
            this.estudiante = estudiante;
            this.correoElectronico = correoElectronico;
            this.parcial1 = parcial1;
            this.parcial2 = parcial2;
            this.zona = zona;
            this.final = final;
            this.total = total;
        }

        bool Comparador.igualQue(object q)
        {
            Alumno p2 = (Alumno)q;
            return carne == p2.carne;
        }

        bool Comparador.menorQue(object q)
        {
            throw new NotImplementedException();
        }

        bool Comparador.menorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        bool Comparador.mayorQue(object q)
        {
            throw new NotImplementedException();
        }

        bool Comparador.mayorIgualQue(object q)
        {
            throw new NotImplementedException();
        }

        public override string ToString() // sobrescribe el metodo ToString
        {
            return "Hola"; // "(" + nombreTarea + " - " + duracionTarea + " - " + porcentajeAvance + " - " + programadorAsignado + ")";
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
