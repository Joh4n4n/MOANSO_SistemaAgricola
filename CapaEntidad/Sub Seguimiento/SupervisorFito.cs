using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Sub_Seguimiento
{
    public class EntSupervisor : Empleado
    {
        public int CodigoSupervisor { get; set; }
        public string NivelAutorizacion { get; set; }
    
    }
}
