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

        public int idTrasplante { get; set; }

        public DateTime fecEvaluacion { get; set; }
        public double porcentajePerdida { get; set; }

        public string estado { get; set; }
        
   
    }
}
