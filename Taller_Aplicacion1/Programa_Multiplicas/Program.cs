using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

/*
 programa para multiplicar 3 numeros 
 
 */

namespace Programa_Multiplicar
{
    internal class Program
    {
        static void Main(string[] args)

        {

           //variables

            int num1=0,num2=0,num3=0 ,result=0 ;
           
            //bienvenida
            Console.Write("\t\t\t"+"BIENVENIDOS AL AREA DE MULTIPLICACION"+"\n\n");

            //ingreso de datos 
            Console.Write("Ingrese su primer numero....: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su segundo numero....: " );
            num2 = int.Parse(Console.ReadLine());


            Console.Write("Ingrese su tercer  numero ....:" );
            num3 = int.Parse(Console.ReadLine());

            //operacion de multiplicaciones 
            result = num1 * num2 * num3;

            //salida de datos 

            Console.WriteLine("El resultado de la multiplicacion es ----> "+result);





            Console.ReadLine();
        }//fin main 
    }//fin class
}//fin namespace 
