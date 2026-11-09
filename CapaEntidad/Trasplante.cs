using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class EntTrasplante
    {
        public int idTrasplante { get; set; }

        public string codigoLote {  get; set; }

        public string tipocultivo { get; set; }

        public DateTime fecTrasplante { get; set; }

        public int cantidadInicial { get; set; }
    }
}
