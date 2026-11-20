using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Planta
    {
        public int idPlanta { get; set; }

        public int codigoPlanta {  get; set; }

        public string NombreComun { get; set; }
        public string Variedad { get; set; }
        public bool Activo { get; set; }
    }
}
