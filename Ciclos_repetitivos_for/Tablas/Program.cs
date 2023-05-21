using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablas
{
    internal class Program
    {
        private static char opc2;

        static void Main(string[] args)
        {
            /*
             pregunta repetitiva
             */

            int opc;
            
            do
            {

                // Console.Write(" quiere ver este mensaje otra vez .....oprima 1 ");// tecla diferente a uno
                Console.Clear();
                Console.Write(" que tabla quiere ver ...  ");
                int tabla = int.Parse(Console.ReadLine());

                for (int i = 1; i < 11; i++)
                {
                    //operacion 
                    int rta = i * tabla;
                    Console.WriteLine(tabla + " * " + i + " = " + rta);

                }//fin for
                 // Console.Write("\t\t\nquiere ver otra tabla oprima 1 .......: ");
                 // opc = int.Parse(Console.ReadLine());
                  Console.Write("\t\t\nquiere ver otra tabla oprima s u otra tecla para salir .......: ");
                String opc2 = Console.ReadLine();
            } while (opc2 != 's');

            Console.Write("chao ");
        
            /*
             -tabla de multiplicar que el usuario quiera 
             -imprimir del 1 al 10 
             */
            /*
            Console.Write(" que tabla quiere ver ...  ");
            int tabla = int.Parse(Console.ReadLine());

            for (int i =1 ;i< 11 ;i++ )
            {
                //operacion 
                int rta = i * tabla;
                Console.WriteLine(tabla+ " * "+i+ " = "+ rta);

            }//fin for

            Console.ReadLine();
            */


            Console.ReadLine();

        }//fin main
    }//fin class
}// fin namespace 
