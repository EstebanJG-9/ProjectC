using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*
   programa que permita ingresa un numero cualquiera
   y luego mostrar el siguiente menu :


  1. determinar si es positivo o negativo 
  2. determinar si es par o es impar 


  el programa debe realizar las operacion que el usuario
  selecione del menu .
 
 */

namespace Programa_MenuParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int opc=0,num=0,resul=0;

            //bienvenida

            Console.Write("\t\t\t"+"MENU DE OPERACIONES DE # IMPAR PAR +/-"+"\n\n");

            //entrada de datos 
            //menu de selecion 

            Console.WriteLine("# 1  Determinar  si es positivo o negativo ");
            Console.WriteLine("# 2  Determinar  si es par o Impar  ");
           
            Console.Write("Selecione la opcion que desea realizar ");
            opc = int.Parse(Console.ReadLine());

            //sentencia switch case 
            switch (opc)
            {

                case 1:
                    Console.Write("Ingrese un numero.....:");
                    num = int.Parse(Console.ReadLine());
                    //sentencia if para determinar si es positivo o negrativo
                     if (num > 0)
                    {
                        Console.Write("EL numero ingresado ---> " + " " + num + " Es positivo ");
                    }//fin if

                    else
                    {
                        Console.Write("EL numero ingresado ---> " + " " + num + " Es Negativo");
                    }//fin else 


                    break;

                case 2:
                    Console.Write("Ingrese un numero.....:");
                    num = int.Parse(Console.ReadLine());
                    resul = num % 2;
                    //sentnecia if else para determinar si es par o impar 
                    if (resul == num)
                    {
                        Console.Write("EL numero ingresado ---> " + num + " " + " es par ");
                    }//fin if

                    else
                    {
                        Console.Write("EL numero ingresado ---> " + num + " " + " es Impar ");
                    }//fin else 


                    break;
                default:
                    break;
                       


            }//fin switch


             Console.ReadLine();
             


        }//fin main 
    }// fin class
}//fin namespaces
