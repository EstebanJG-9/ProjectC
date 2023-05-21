using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 programa que  permita determinar cuantos estudiantes
 son mayores de eda en un grupo de 20 estudinates
 */
namespace Programa_Calcular20Edades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            int  edad =0 ,mayores =0;

            //bienvenida 
            Console.Write("\t\t\t" + "PROGRAMA PARA DETERMINAR LA EDAD DE 20 ESTUDIANTES" + "\n\n");


            //ciclo for para impirmir 20 estudiantes
            for (int i = 1; i <= 20; i++) {

                //entrada de datos 
                Console.Write("Ingrese su edad....:");
                edad = int.Parse(Console.ReadLine());

                //sentencia if para valida si  son mayores de edad 
                if (edad >= 18)
                {

                    //operacion 
                    mayores = mayores + 1;
                    //salida de datos 
                    Console.WriteLine("la cantidad de estudiantes mayores de edad son -> " + " " + mayores);


                }//fin if else
            
            
            }//fin for


            Console.ReadLine();

        }//fin main
    }//fin class
}//fin namespaces
