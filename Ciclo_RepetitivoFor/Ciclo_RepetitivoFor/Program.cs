using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 programa que permita ver los numero naturales comprendidos
 entre o y 100
 
 */

namespace Ciclo_RepetitivoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
          


            //bienvenido
            Console.Write("\t\t\t"+"PROGRAMA PARA VER NUMEROS 0 AL 100" + "\n\n");

            //sentencia for para imprimir desde 0 al 100
            for (int i = 0; i <= 100; i++) 
            {
                //salida de datos 
                Console.Write(i);
            
            }//fin for 


            Console.ReadLine();

        }//fin main
    }//fin class
}//fin namespaces
