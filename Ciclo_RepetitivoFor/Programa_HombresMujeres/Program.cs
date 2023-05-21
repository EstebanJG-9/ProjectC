using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  programa  que permita determinar cuantos
  estudiantes son  hombres y mujeres hay en un curso 
  de 25 estududiantes .
 */

namespace Programa_HombresMujeres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int  contador = 0;
                string genero = "";
            
            //bienvenida 
            Console.Write("\t\t\t" + "PROGRAMA PARA DETERMINAR HOMBRES Y MUJERES " + "\n\n");


            //ciclo for para impirmir 20 estudiantes
            for (int i = 1; i <= 25; i++)
            {

                //entrada de datos 
                Console.Write("Ingrese su sexo ....:");
                genero = Console.ReadLine();
             

                //sentencia if para valida si  son mayores de edad 
                if (genero  == "masculino")
                {

                    Console.WriteLine("la cantida de hombre son -->"+" " + contador);
                    //operacion 
                    contador  = contador + 1;
                    //salida de datos 
               


                }//fin if else
                else {


                    Console.WriteLine("la cantida de mujeres  son -->" + " " + contador);
                    //operacion 
                    contador = contador + 1;


                }//fin else 


            }//fin for


            Console.ReadLine();



        }//fin main
    }//fin class
}//fin namespaces
