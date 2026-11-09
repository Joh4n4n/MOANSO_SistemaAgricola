using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntProgramacionSemanal
    {
        public int IdProgramacion { get; set; }

        public int IdEvaluador { get; set; }

        public DateTime fechaInicio { get; set; }

        public DateTime fechafin {  get; set; }

        public string estado { get; set; }
    }
}
