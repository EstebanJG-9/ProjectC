using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ejem_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaracion de variables 
            int dato,modulo;
           



            Console.WriteLine("\t\t\t CICLOS  CONDICIONALES \n\n");
            Console.WriteLine("\tdeterminar si un numeroingresado por teclado es PAR o IMPAR \n");

            // captura de dato
            Console.Write("ingrese un numero......");

            dato = int.Parse(Console.ReadLine());  //captura de datos  , con el parseo 

            //validacion del dato 
            modulo = dato % 2;


            if ( dato % 2  == 0 ) //(dato% 2==0)  //(modulo ==0)
            {
                Console.WriteLine("el numero "+dato+"si es PAR");
            
            }//fin if
            else 
            {
                Console.WriteLine("el numero " + dato +  "  si es IMPAR");
            }//fin else 





            //pausa 
            Console.Read();

        }//fin main 
    }//fin class program
}// fin namespace
