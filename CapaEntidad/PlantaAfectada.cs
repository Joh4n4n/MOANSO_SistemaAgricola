using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPlantaAfectada
    {
        public int idAfectacion { get; set; }

        public int IdEvaluacion { get; set; }

        public string tipo {  get; set; }

        public int NivelSeveridad { get; set; }

        public string codigoLote { get; set; }
    }
}
