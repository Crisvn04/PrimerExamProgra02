using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamProgra02
{
    internal class ClsSubmenu
    {
        static int opcion = 0;
        public static void Subreportes()
        {
           
            do
            {
                Console.WriteLine("1-Consultar Empleados ");
                Console.WriteLine("2-Lista de todos los empleados ");
                Console.WriteLine("3-Promedio de salarios");
                Console.WriteLine("4-Salario mas bajo y mas alto");
                Console.WriteLine("5-Salir");
                Console.Write("Ingrese una opcion: ");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: ClsEmpleado.consultar(); break;
                    case 2: ClsEmpleado.ListadoEmpleados(); break;
                    case 3: ClsEmpleado.PromedioSalarios(); break;
                    case 4: ClsEmpleado.SalarioMinMax();   break;
                    case 5: break;

                    default:
                        break;
                }

            } while (opcion != 5);
            
        }
    }
    
}
