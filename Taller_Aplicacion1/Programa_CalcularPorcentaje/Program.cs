using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  programa para calcular el  20% de cualquier numero 
 */
namespace Programa_CalcularPorcentaje
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            int num1 = 0;
            double porcen = 0.20,result=0;

            //bienvenida 

            Console.Write("\t\t\t"+"BEINVENIDO AL AREA DE PROCENTAJES"+"\n\n");

            //ingreso de datos
            Console.Write("Ingrese el numero que desea calcular ....:");
            num1 = int.Parse(Console.ReadLine());

            //operacion 

            result = num1 * porcen;

            //salida de datos 
            Console.WriteLine("el porcentaje de :"+num1 +" es " +" " +result);


            Console.ReadLine();

        }//fin main 
    }//fin class
}// fin namespace 
