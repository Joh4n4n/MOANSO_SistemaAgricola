using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad.Sub_Seguimiento
{
    public class CaracteristicasEvaluacion
    {
        public int IdCaracteristica {  get; set; }

        public string NombreCaracteristica { get; set; }

        public string Valor { get; set; }
        public string UnidadMedida { get; set; }
    }
}
