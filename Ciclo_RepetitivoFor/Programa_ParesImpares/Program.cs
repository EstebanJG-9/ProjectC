using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  programa que imprima los pares entre  0 y 200
 */

namespace Programa_Pares
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //bienvenida 

            Console.Write("\t\t\t"+"PROGRAMA PARA IMPIRMIR PARES ENTRE 0 AL 200"+"\n\n");

           
            // sentencia for para imprimir  desde el 0 al 200
            for (int i = 0; i <= 200; i = i + 2)  // I=i  +2 me permite hacer la operacion de pares
            {
                //result = i % 2;
                //salida de datos 
                Console.Write(i);

            }//fin for 


            Console.ReadLine();
        }//fin main 
    }//fin class
}//fin namespaces
