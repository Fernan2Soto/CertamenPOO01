using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPVG
{
    public class ClaseJefe
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public ClaseDepartamento departamento { get; set; }

        public ClaseJefe()
        {
            rut = "15234643-2";
            nombre = "Juan Perez";
            departamento = new ClaseDepartamento();
        }
    }
}
