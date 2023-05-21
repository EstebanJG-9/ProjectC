using FakeItEasy;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  programa que permita determinar si una letra es o no vocal 

 */

namespace Programa_DeterminaLetraVocal
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            String letra;
            String vocal ;

            //Bienvenida 

            Console.Write("\t\t\t"+" PREGRAMA PARA DETERMINAR VOCALES"+"\n\n");

            //entrada de datos
            Console.Write("Ingrese un letra ");
            letra =  Console.ReadLine();
       

            // sentencia switch case para validar si la letra ingresada es una  vocal 
            switch(letra )
            {
                // letra a 
                case "a":
                    // salida de datos 
                    Console.WriteLine("la letra ingresada --> "+" " +letra );
                    Console.WriteLine("es una vocal ");

                    break;
                    //letra e 
                case "e":
                    //salida de datos 
                    Console.WriteLine("la letra ingresada --> " + " " + letra);
                    Console.WriteLine("es una vocal ");

                    break;
                    //letra i 
                case "i":
                    //salida de datos 
                    Console.WriteLine("la letra ingresada --> " + " " + letra);
                    Console.WriteLine("es una vocal ");

                    break;
                    //letra o 
                case "o":
                    //salida de datos 
                    Console.WriteLine("la letra ingresada --> " + " " + letra);
                    Console.WriteLine("es una vocal ");

                    break;
                    //letra u 
                case "u":
                    //salida de datos 
                    Console.WriteLine("la letra ingresada --> " + " " + letra);
                    Console.WriteLine("es una vocal ");

                    break;

                default:
                    //si no es vocal nos envia al mensaje po default 
                    Console.Write("No es un vocal ");
                    break;

            }


            Console.ReadLine();
        }//fin main 
    }//fin class
}//fin namespaces
