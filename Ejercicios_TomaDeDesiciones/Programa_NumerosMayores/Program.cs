using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 programa  que determine cual es el numero mayor entre dos numeros 
 */
namespace Programa_NumerosMayores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int num1 = 0, num2=0,mayor=0;

            //Bienvenida
            Console.Write("\t\t\t"+"BIENVENIDO PROGRAMA PARA CALCULAR UN NUMERO MAYOR"+"\n\n");

            //entrada de datos
            Console.Write("Ingrese su primer numero ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su segundo numero ");
            num2 = int.Parse(Console.ReadLine());


            //sentencia if else 
            //si numero 1 es mayor a numero 2 el numero 1 es el mayor 
            if (num1 > num2) {

                Console.Write("el numero mayor es ---->  "+ "  " +num1 );
            
            
            
            }//fin  if 
            // si numero 1 es menor a numero 2 el numero mayor seria el numero 2
            else if (num1 < num2)
            { 
                //asalida de datos 
                Console.Write("el numero mayor es ---->  " + "  " + num2);
            }//fin else if 

            Console.ReadLine();
        }//fin main
    }//fin class
}//fin namespaces
