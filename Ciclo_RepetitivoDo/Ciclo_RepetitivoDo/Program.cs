using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  
programa que muestre unu menu al usuario que se 
repita las veces que sea necesesario , hasta que el escoja la
opcion paara salir , las opciones del menu deben permitir

    1. ingresar 2 numeros
    2. realizar la suma 
    3. reslizar la resta 
    4. realizar la multiplicacion
    5. realizar la division
    6. salir del programa 
 
 */

namespace Ciclo_RepetitivoDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int opc = 0, num1, num2, result;


            //bienvenida
            Console.Write("\t\t\t" + "MENU DE OPERACIONES" + "\nn");

            //sentencia do para repetir todo lo que se encuentre en los corechetes
            do
            {

                Console.WriteLine("# 1 Realizar  la suma  ");
                Console.WriteLine("# 2 Realizar la resta ");
                Console.WriteLine("# 3 Realizar la multiplicacion");
                Console.WriteLine("# 4 Realizar la Division");
                Console.WriteLine("# 5 Salir del Programa");

                //entrada de datos
                Console.Write("Selecione la opcion que desea realizar ....:");
                opc = int.Parse(Console.ReadLine());


           

                //sentencia switch case para el menu 

                switch (opc)
                {

                    case 1:
                        //entrada de datos 
                        Console.Write("SUMA ");
                        Console.Write("Ingrese su primer numero ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese su segundo numero  numero ");
                        num2 = int.Parse(Console.ReadLine());

                        //operacion
                        result = num1 + num2;

                        //salida de datos 
                        Console.WriteLine("El resultado es --> " + " " + result);

                        break;
                    case 2:
                        //entrada de datos
                        Console.Write("RESTA ");
                        Console.Write("Ingrese su primer numero ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese su segundo numero  numero ");
                        num2 = int.Parse(Console.ReadLine());

                        //operacion
                        result = num1 - num2;

                        //salida de datos 
                        Console.WriteLine("El resultado es --> " + " " + result);

                        break;
                    case 3:
                        //entrada de datos
                        Console.Write("MULTIPLICACION ");
                        Console.Write("Ingrese su primer numero ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese su segundo numero  numero ");
                        num2 = int.Parse(Console.ReadLine());

                        //operacion
                        result = num1 * num2;

                        //salida de datos 
                        Console.WriteLine("El resultado es --> " + " " + result);

                        break;
                    case 4:
                        //entrada de datos
                        Console.Write("DIVISION ");
                        Console.Write("Ingrese su primer numero ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese su segundo numero  numero ");
                        num2 = int.Parse(Console.ReadLine());

                        //operacion
                        result = num1 / num2;

                        //salida de datos 
                        Console.WriteLine("El resultado es --> " + " " + result);

                        break;
                  



                }//fin switch

            //fin do 
            }while (opc != 5);//fin while al selecionar el 5 se cierra el programa 

            Console.ReadLine();
        }//fin main
    }//fin class
}//fin namespaces
