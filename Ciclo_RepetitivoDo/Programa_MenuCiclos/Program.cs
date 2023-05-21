using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
programa que muestre un menu al usuarios que se repira las
veces que sea necesario , hasta que el escoja la opcion para
salir , las opciones son :


  1. calcular el factorial de un numero usando siclo for 
  2. calcular la potencia usando un ciclo while
  3.  salir 
 
 */

namespace Programa_MenuCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opc = 0,factorial =1,num ,j=1,bas=0,expo=0,result=1;
            //variables


            //bienvenida 
            Console.Write("\t\t\t" + "MENU CICLOS" + "\nn");

            do {

                Console.WriteLine("# 1 calcular el factorial de un numero usando siclo for  ");
                Console.WriteLine("# 2 calcular la potencia usando un ciclo while");
                Console.WriteLine("# 3 salir ");

                //entrada de datos
                Console.Write("Selecione la opcion que desea realizar ....:");
                opc = int.Parse(Console.ReadLine());

                switch (opc) {
                  
                    //opcion 1
                    case 1:
                        //entrada de datos 
                        Console.Write("FACTORIAL ");
                        Console.Write("Ingrese un numero ...:");
                        num = int.Parse(Console.ReadLine());

                        //ciclo for para calcular el factorial n 
                        for (int i = 1; i <=num; i++) 
                        {

                            factorial = factorial * i;
                        
                        
                        }//fin for
                        //salida de datos 
                        Console.WriteLine("el factorial es --> "+ " " +factorial);

                        break;

                        //opcion 2
                    case 2:
                        //entrada de datos
                        Console.Write("POTENCIA ");
                        Console.Write("Ingrese la base ...:");
                        bas = int.Parse(Console.ReadLine());

                        Console.Write("Ingrese el exponente ...:");
                        expo = int.Parse(Console.ReadLine());

                        //ciclowhilepara balidar la bpotencia 
                        while (j <= expo) {

                            result = result  * bas;
                            j ++;
                        
                        }//fin while

                        result = 1 / result;

                        Console.WriteLine("la potencia es --> " +" " +result);

                        break;
                    default:
                        break;
                            
                
                
                
                }//fin switch


                //fin do 
            } while (opc != 3);





           Console.ReadLine();



        }//fin main
    }//fin class
}//fin namespaces
