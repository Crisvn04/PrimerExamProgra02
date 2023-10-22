using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamProgra02
{
    internal class ClsMenu
    {
        //Atributo
        static int opcion = 0;

       static  public void Menu()
        {
            ClsEmpleado empleado = new ClsEmpleado();   
           opcion = 0;
            do
            {
                Console.WriteLine("1-inicializar");
                Console.WriteLine("2-Agregar");
                Console.WriteLine("3-Consultar");
                Console.WriteLine("4-Modificar");
                Console.WriteLine("5-Borrar");
                Console.WriteLine("6-Reportes");
                Console.WriteLine("7-Salir");
                Console.Write("Ingrese un valor: ");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1: Console.WriteLine(empleado.inicializar()); break;
                    case 2:empleado.Agregar(); break;
                    case 3:ClsEmpleado.consultar(); break;
                    case 4:empleado.Modificar(); break;
                    case 5:empleado.Borrar(); break;
                    case 6:ClsSubmenu.Subreportes(); break;
                    case 7: break;  


                    default:
                        break;
                }

            } while (opcion!= 7);

        }
    }
}
