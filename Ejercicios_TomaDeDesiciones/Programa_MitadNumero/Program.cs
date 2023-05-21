using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  programa que determine la mitad de un numero 
  ingresado por el usuario es mayor o menor a 100
 */
namespace Programa_MitadNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int num=100,mitad;

            //Bienvenida 
            Console.Write("\t\t\t"+" DETERMINAR LA MITAD DE UN NUMERO "+"\n\n");

            //entrada de datos 
            Console.Write("Ingrese un numero .....:");
            num = int.Parse(Console.ReadLine());

            //operacion para determinar la mitad del numero 
            mitad = num / 2;


            //sentencia if para determinar si el numero es mayor o menor a 100

            if (num <  100) {
                 
                //salida de datos con el numero menor 
                Console.Write("la mita es -->"+" " + mitad );
                Console.Write("el numero es menor  a 100 ");

            }//fin if 
            else if (num > 100) {

                //salida de datos con el numero mayor 
                Console.Write("la mita es -->" + " " + mitad);
                Console.Write("el numero es mayor a 100   ");


            }//fin else if 

            Console.ReadLine();
        }//fin main
    }//fin class
}//fin namespaces
