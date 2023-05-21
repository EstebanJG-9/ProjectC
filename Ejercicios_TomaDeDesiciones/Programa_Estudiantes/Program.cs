using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/*
  programa para saber si un estudiante del enrrique olaya herrera
  requiere refrigerio,por disposicion  de la secretaria de educacion
   requieren refrigerio los estudiantes de sexto hacia abajo.
 */

namespace Programa_Estudiantes
{ 
          internal class Program
    {
        static void Main(string[] args)
        {
            //variables

            String  nombre;
            int grado;
            String disposicion  ;
    

            //Bienvenida
            Console.Write("\t\t\t"+"Colegio Enrrique Olaya "+"\n\n");

            //entrada de datos

            Console.Write("Ingrese el Nombre del estudiante...:");
            nombre = Console.ReadLine();

            //menu para selcionar el grado del estudiante 
            Console.WriteLine("╠═════════════════════╦═════════════════════╣");
            Console.WriteLine("║  1. Sexto           ║  2. Tercero         ║");
            Console.WriteLine("╠═════════════════════╬═════════════════════╣");
            Console.WriteLine("║  3. Quinto          ║  4. Segundo         ║");
            Console.WriteLine("╠═════════════════════╬═════════════════════╣");
            Console.WriteLine("║  5. Cuarto          ║  6. Primero         ║");
            Console.WriteLine("╚═════════════════════╩═════════════════════╝");
            Console.Write("Selecione el grado del estudiante ...:");
            grado = int.Parse( Console.ReadLine());
            Console.Clear();

            //sentencia switch case  nos permite verificar por grado la asignacion 


            switch (grado)
            {
                //opcion 1
                case 1:
        
                    // salida de datos 

                    Console.WriteLine("Estudiante : " + " " + nombre);
                    Console.WriteLine("Grado  :  Sexto " );
                    Console.WriteLine("Asignado para refrigerio");
                  ;
                    break;
                    //opcion 2
                case 2:
                    
                    // salida de datos 

                    Console.WriteLine("Estudiante : " + " " + nombre);
                    Console.WriteLine("Grado  :  Quinto ");
                    Console.WriteLine("Asignado para refrigerio");

                    break;
                    //opcion 3
                case 3:

                    //salida de datos 

                    Console.WriteLine("Estudiante : " + " " + nombre);
                    Console.WriteLine("Grado  : Cuarto ");
                    Console.WriteLine("Asignado para refrigerio");

                    break;
                    //opcion 4
                case 4:

                    //salida de datos

                    Console.WriteLine("Estudiante : " + " " + nombre);
                    Console.WriteLine("Grado  :  Tercero ");
                    Console.WriteLine("Asignado para refrigerio");

                    break;
                    //opcion 5
                case 5:
                    
                    //salida de datos

                    Console.WriteLine("Estudiante : " + " " + nombre);
                    Console.WriteLine("Grado  :  Segundo ");
                    Console.WriteLine("Asignado para refrigerio");

                    break;
                    //opcion 6
                case 6:
                    //salida de datos 

                    Console.WriteLine("Estudiante : " + " " + nombre);
                    Console.WriteLine("Grado  :  Primero ");
                    Console.WriteLine("Asignado para refrigerio");

                    break;

                default:
                    break;
            }

               


 

            Console.ReadLine();
        }//fin main
    }//fin class}
}//fin namespaces