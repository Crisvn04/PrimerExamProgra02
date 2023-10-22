using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerExamProgra02
{
    public class ClsEmpleado
    {
        //Atributos
        static int cant ;
        static int indice = 0;
        static private int[] cedula = new int[cant];
        static private string[] nombre = new string[cant];
        static private string[] direccion = new string[cant];
        static private int[] telefono = new int[cant];
        static private int[] salario = new int[cant];

        public ClsEmpleado() //Constructor
        {
            indice = 0;
            cant = 10;
            cedula = Enumerable.Repeat(0, 5).ToArray();
            nombre = Enumerable.Repeat("", 5).ToArray();
            direccion = Enumerable.Repeat("", 5).ToArray();
            telefono = Enumerable.Repeat(0, 5).ToArray();
            salario = Enumerable.Repeat(0, 5).ToArray();
        }

        //Metodos
         public string inicializar()
        {
            try
            {
                cedula = Enumerable.Repeat(0, 5).ToArray();
                nombre = Enumerable.Repeat("", 5).ToArray();
                direccion = Enumerable.Repeat("", 5).ToArray();
                telefono = Enumerable.Repeat(0, 5).ToArray();
                salario = Enumerable.Repeat(0, 5).ToArray();
                indice = 0;
                cant = 5;
            }
            catch (Exception)
            {

                return "No se pudo inicializar ";
            }

            return "Arreglos inicializados ";
        }

       static public void ListadoEmpleados()
        {
            for (int   i = 0; i < indice; i++)
            {
                 Console.WriteLine($"Cedula: {cedula[i]} Nombre: {nombre[i]} Direccion: {direccion[i]} Telefono: {telefono[i]} Salario: {salario[i]}  ");
                         
            }
        }

      static public void PromedioSalarios()
      {
            double PromedioSalarios = salario.Average();
      }
      
      static public void SalarioMinMax()
        {
            double salarioBajo = salario.Min();
            double salarioAlto = salario.Max();
        }

      public static  void consultar()
      {
            Console.WriteLine("Ingrese el numero de cedula");
            string c = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < cant; i++)
            {
                if (c.Equals(cedula[i]))
                {
                    Console.WriteLine($"Cedula: {cedula[i]}");
                    existe = true;
                    break;
                }
            }
            if (existe==false)
            {
                Console.WriteLine($"La cedula {c} no existe ");
            }

      }


         public void Agregar()
         {
            
            char respuesta = ' ';
            do
            {
                Console.Clear();
                Console.Write($"Digite la cedula {indice}:"); int.TryParse(Console.ReadLine(), out cedula[indice]);
                Console.WriteLine($"Digite el nombre {indice}: "); nombre[indice] = Console.ReadLine();
                Console.WriteLine($"Digite la direccion {indice}: "); direccion[indice] = Console.ReadLine();
                Console.WriteLine($"Digite el telefono {indice}: "); int.TryParse(Console.ReadLine(), out telefono[indice]);
                Console.WriteLine($"Digite el salario {indice}: "); int.TryParse(Console.ReadLine(), out salario[indice]);
                Console.WriteLine($"Desea continuar S/N ");
                respuesta=Console.ReadLine().ToUpper()[0];
                indice++;
                if (!respuesta.Equals('N') && !respuesta.Equals('S'))
                {
                    Console.WriteLine("Opcion incorrecta");
                    break;
                }


            } while (respuesta!= 'N');
                          
            
         }

        public void Modificar()
        {
            Console.WriteLine("Ingrese el numero de cedula del empleado que quiere modificar: ");
            string c = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < cant; i++)
            {
                if (c.Equals(cedula[i]))
                {
                    Console.Clear();
                    Console.WriteLine($"Digite el nombre: "); nombre[indice] = Console.ReadLine();
                    Console.WriteLine($"Digite la direccion: "); direccion[indice] = Console.ReadLine();
                    Console.WriteLine($"Digite el telefono: "); int.TryParse(Console.ReadLine(), out telefono[indice]);
                    Console.WriteLine($"Digite el salario: "); int.TryParse(Console.ReadLine(), out salario[indice]);
                    existe = true;
                    break;
                }
            }
            if (existe == false)
            {
                Console.WriteLine($"La cedula {c} no existe ");
            }
        }
        
        public void Borrar()
        {
            Console.WriteLine("Ingrese la cedula que quiere borrar");
            string opcionAeliminar=Console.ReadLine();

            
        }










        













    }
}
