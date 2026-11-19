using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntPerdidaPlanta
    {
        public int idPerdida {  get; set; }

        public int idEvaluacion { get; set; }

        public int CantidadPerdida  { get; set; }

        public string causa {  get; set; }

        public string observacion { get; set; }
    }
}
