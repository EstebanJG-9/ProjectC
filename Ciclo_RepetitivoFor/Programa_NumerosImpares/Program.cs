using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  programa que imprima los impares desde el 201 hasta el 499
 
 */

namespace Programa_NumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //bienvenida 
            Console.Write("\t\t\t"+"PROGRAMA PARA IMPRIMIR IMPARES ENTRE  201 Y  499"+"\n\n");

            //ciclo for para empezar desde el 201 hasta el 499 
            for (int i  = 201; i <=499; i ++) {

                //sentencia if para  si la variable i con le modulo dos es igual a uno es impar 
                if (i % 2 == 1) {

                    //salida de datos
                    Console.WriteLine(i);
                
                }//fin if 
            
            
            }//fin for 
            Console.ReadLine();

        }//fin main
    }//fin class
}//fin namespaces
