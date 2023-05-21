using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 programa que determine si una persona es mayor de edad o no 
 teninendo en cuenta el año actual y el año de nacimineto.
 
 */

namespace Programa_DeterminaEdad
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //variables 

            int año = 0,añoact=2022,añonaci=0,edad;

            //Bienvenido

            Console.WriteLine("\t\t\t"+"BIENVENIDO PROGRAMA PARA CALCULAR SI ES MAYOR DE EDAD O NO"+"\n\n");

            //entrada de datos
            Console.Write("Ingrese su año de nacimiento....: ");
            año = int.Parse(Console.ReadLine());

            //sentencia if else 
            edad =  añoact-año;
            
            // si edad mayor o igual a 18  es mayor de edad 
            if (edad >= 18)
            { 

                //salida de datos 
           
                Console.Write("su edad es ---> " + edad);
                Console.Write("usted es mayor de edad ");

            }
          
           // si no el usuario es menor de edad 
            else 
            {
                Console.Write("su edad es ---> " + edad);
                Console.Write("menor de edad");

            }//fin else


            Console.ReadLine();
        }//fin main 
    }//fin class
}//fin namespaces
