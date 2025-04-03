using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebInformacionDocenteJdL.Models
{
    public class Contacto
    {
        public int lIntIdContacto { get; set; }
        public string lStrNombres { get; set; }
        public string lStrApellidos { get; set; }
        public string lStrTelefono { get; set; }
        public string lStrCorreo { get; set; }
        public decimal lDblSalario { get; set; }
        public DateTime lStrFechaNacimiento { get; set; }
    }
}