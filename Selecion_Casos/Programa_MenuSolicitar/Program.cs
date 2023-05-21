using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
  programa que muestre un menu que tenga las siguientes
opciones:


    1. pasa o no la materia ?

    2. es mayor o menor de edad 


caso 1 : solicitar 3 notas y determinar si el  promedio 
es mayor a 3,0  en ese caso el estudiante pasa.

caso 2 . se debe solicitar el año de nacimiento y el 
año actual y determinar si es o no mayor de edad .
 */

namespace Programa_MenuSolicitar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            int opc = 0;
            double nota1=0,nota2=0, nota3,prom=0,result=0,añoact=0,añonaci=0;

            //Bienvenida
            Console.Write("\t\t"+"MENU PARA VER CALIFICACIONES Y EDAD "+"\n\n");

            //menu 
            Console.WriteLine("# 1  Determinar  Promedio de Estudiante");
            Console.WriteLine("# 2  Determinar Edad");
            Console.Write("Seleciones la Opcion que desea realizar ...:");
            opc = int.Parse(Console.ReadLine());

            //sentencia switch case  para escoger la opcion 1 o 2
            switch (opc) {

                //opcion1
                case 1:
                    //entrada de datos 
                    Console.Write("Ingrese su primer calificacion ...:");
                    nota1 = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese su segunda calificacion ...:");
                    nota2 = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese su tercera  calificacion ...:");
                    nota3 = int.Parse(Console.ReadLine());

                    //operacion
                    result = nota1 + nota2 + nota3 ;
                    prom = result / 3;

                    //sentencia if else para determinar si  el promedio es 3.0 el alumno aprueba 
                    if (prom>=30) {
                         //salida de datos 
                        Console.Write("su promedio es ---> "+  " " + prom);
                        Console.Write("Estudiante APROVO ");
                    
                    }//fin if 
                    
                    //si no 
                    else
                    {
                        //salida de datos 
                        Console.Write("su promedio es ---> " + " " + prom);
                        Console.Write("Estudiante NO APROVO ");
                    }


                    break;

                    //opcion 2
                    case 2:
                   
                    //entrada de datos 
                    Console.Write("Ingrese su año de nacimiento ...:");
                    añonaci = int.Parse(Console.ReadLine());

                    Console.Write("Ingrese el año actual  ...:");
                    añoact = int.Parse(Console.ReadLine());

                    //operacion 
                    result = añoact - añonaci;

                    //sentencia if else para determinar si es mayor de edad 
                    if (result >= 18) {

                        //salida de datos
                        Console.WriteLine("Su edad es ---> " + " " + result);
                        Console.WriteLine("es mayor de edad ");

                    }//fin if 

                    //si no 
                    else
                    {

                        //salida de datos 
                        Console.WriteLine("Su edad es ---> " + " " + result);
                        Console.WriteLine("no es mayor de edad ");

                    }//fin else 
          

                    break;

                default:
                    break;


            }//fin switch

            Console.ReadLine();
        }//fin main
    }//fin class
}//fin namespaces
