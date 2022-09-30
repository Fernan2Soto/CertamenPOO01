using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPVG
{
    public class ClaseEmpleado
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public string cargo { get; set; }
        public ClaseJefe jefe { get; set; }


        public ClaseEmpleado(string rut, string nombre, string cargo)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.cargo = cargo;
            jefe = new ClaseJefe();
        }

        public ClaseEmpleado()
        {
        }
    }
}
