using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 peograma para calcular el promedio de 5 numeros 
 
 */
namespace Programa_CalcularPromedio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;
            double suma, promedio;

            //bienvenida
            Console.Write("\t\t\t" + "BIENVENIDO  AL AREA DE PROMEDIOS " + "\n\n");

            //entrada de datos 
            Console.Write("Ingrese su primer numero....:");
            num1=int.Parse(Console.ReadLine());

            Console.Write("Ingrese su segundo numero....:");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su tercer numero....: ");
            num3 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su cuarto numero....:");
            num4 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su quinto  numero....: ");
            num5 = int.Parse(Console.ReadLine());

            //operaciones 

            suma= num1 + num2 + num3 + num4 + num5;
            promedio = suma / 5;

            //salida de datos 
            Console.WriteLine("El promedio  es ---> " + promedio);


            Console.ReadLine();

        }//fin main 
    }//fin class
}//fin namespace
