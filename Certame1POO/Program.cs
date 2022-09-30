using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPVG;
namespace Certame1POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClaseEmpleado empleado = new ClaseEmpleado();
            ClaseDepartamento departamento = new ClaseDepartamento();
            ClaseJefe jefe = new ClaseJefe();

            Console.WriteLine("Ingrese un Emplado");
            Console.WriteLine("Rut :");
            empleado.rut = Console.ReadLine();

            Console.WriteLine("Nombre:");
            empleado.nombre = Console.ReadLine();

            Console.WriteLine("Seleccione un cargo:");
            menu();
            int op  = int.Parse(Console.ReadLine());
             
            switch (op)
            {
                case 0:
                    empleado.cargo = "Mantencion";
                    break;
                case 1:
                    empleado.cargo = "Programador";
                    break;
                case 2:
                    empleado.cargo = "Redes";
                    break;
                default:
                    break;
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Datos Empleado          :");
            Console.WriteLine("Rut    :" + empleado.rut);
            Console.WriteLine("Nombre :" + empleado.nombre);
            Console.WriteLine("Cargo  :" + empleado.cargo);
            Console.WriteLine("Datos Jefe del Empleado :");
            Console.WriteLine("Rut    :" + jefe.rut);
            Console.WriteLine("Nombre :" + jefe.nombre);
            Console.WriteLine("Datos del Departamento  :");
            Console.WriteLine("Nombre    :" + departamento.nombre);
            Console.WriteLine("Direccion :" + departamento.direccion);
            Console.ReadKey();
        }
        static void menu()
        {
            Console.WriteLine("Seleccione el puesto del empleado");
            Console.WriteLine("0 => Mantencion");
            Console.WriteLine("1 => Programador");
            Console.WriteLine("2 => Redes");


        }
    }
}
