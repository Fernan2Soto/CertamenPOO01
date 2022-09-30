using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPVG
{
    public class ClaseDepartamento
    {
        public string nombre { get; set; }
        public string direccion { get; set; }

        public ClaseDepartamento()
        {
            nombre = "Informatica";
            direccion = "CAlle 12 edificio 15";
        }
    }
}
