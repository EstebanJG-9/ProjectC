using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 programa para calcula la edad con la fecha de nacimiento 
 y fecha actual 
 */
namespace Programa_CalcularEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            int añonac = 0,edad=0,añoactu=2022;

            //bienvenidos

            Console.Write("\t\t\t"+"BIENVENIDO AL AREA PARA CALCULAR SU EDAD "+"\n\n");

            //ingreso de datos 
            Console.Write("Ingrese su  año de nacimiento ....: ");
            añonac = int.Parse(Console.ReadLine());

            //operaciones
            edad = añoactu - añonac;

            //salida de datos 

            Console.WriteLine("Su edad es ----> "+edad  +"Años ");


            Console.ReadLine();
        }//fin main 
    } //fin class
}//fin namespace 
