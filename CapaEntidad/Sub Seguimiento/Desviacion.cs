using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Sub_Seguimiento
{
    public class Desviacion
    {
        public int IdDesviacion { get; set; }

        public int IdEvaluacion { get; set; }

        public int IdTipoIncidencia { get; set; }

        public string Descripcion { get; set; }

        public DateTime fecRegistro { get; set; }
    }
}
