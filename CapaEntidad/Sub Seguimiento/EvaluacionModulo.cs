using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntEvaluacionModulo
    {
        public int idEvaluacion { get; set; }

        public int idProgramacion { get; set; }

        public string observaciones { get; set; }

        public DateTime fecEvaluacion { get; set; }
        public int PlantasEvaluadas { get; set; }
        public int PlantasAfectadas { get; set; }
        public int Perdidas { get; set; }


    }
}
