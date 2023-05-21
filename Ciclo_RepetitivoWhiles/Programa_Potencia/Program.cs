using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 programa que encuentre el resultado de la operacion
 potencia donde el usuario ingresa el  valor de la base y el exponente 
 
 */

namespace Programa_Potencia
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int bas=0,espo = 0,resul=0;
            int i =
                   1;

            //bienvenida 

            Console.Write("\t\t\t" + "PROGRAMA PARA CALCULAR N PRIMEROS NATURALES" + "\n\n");

            Console.Write("Ingrese la base ...:");
            bas=int.Parse(Console.ReadLine());

            Console.Write("Ingrese el exponenete  ...:");
            espo = int.Parse(Console.ReadLine());


            while (i<=espo) {

                resul = resul * bas;

                i++;
            }//fin while

            Console.WriteLine("respuesta es --- " + resul);


            Console.ReadLine();
        }//fin main 
    }//fin class
}//fin namespaces
