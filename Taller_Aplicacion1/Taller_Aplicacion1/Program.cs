using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  juanesteban 
 */
namespace Programa_Suma
{
    internal class Program
    {
        static void Main(string[] args) { 
            // variables  asignadas para las suma 
             int num1 = 0,num2=0,sum=0;

            //mensaje de bienvenida al area de suma 
           
            Console.WriteLine("\t\t\t"+"BIENVENIDO AL AREA DE SUMA "+"\n\n");

            //ingreso de datos 

            Console.Write("Ingrese su primer numero ......: " );
            num1 = int.Parse(Console.ReadLine());


            Console.Write("Ingrese su segundo  numero ......: " );
            num2 = int.Parse(Console.ReadLine());

            //operaciones 
            sum = num1 + num2;

            //salida de datos 
            Console.WriteLine("el resultado de su suma es  -----> "+ sum);










            Console.ReadLine();

        }//fin main 
        
    
    } // fin class
}// fin namespace 
