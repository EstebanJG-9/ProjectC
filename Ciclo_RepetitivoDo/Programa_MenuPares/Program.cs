using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
  
programa que muestre unu menu al usuario que se 
repita las veces que sea necesario hasta que escoja la opcion 
salir , las opciones son :


    1. numeros pares entre 100 ciclo for
    2. multiplos de 4 ciclo while
    3. tabla de multiplicar de un numero hasta el 10
    4. salir 
 
 */

namespace Programa_MenuPares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables
            int opc ,j=0;

            //bienvenida 
            Console.Write("\t\t\t" + "MENU DE MULTIPLES OPCIONES /PARES/MULTIPLOS " + "\nn");


            do {


                Console.WriteLine("# 1 numeros pares entre 100 ciclo for  ");
                Console.WriteLine("# 2 multiplos de 4 ciclo while");
                Console.WriteLine("# 3 tabla de multiplicar de un numero hasta el 10 ");
                Console.WriteLine("# 4 salir ");

                //entrada de datos
                Console.Write("Selecione la opcion que desea realizar ....:");
                opc = int.Parse(Console.ReadLine());

                switch (opc) {

                    //opcion1
                    case 1:
                        Console.Write("PARES ENTRE HASTA EL 100");

                        //ciclo for para determinar los pares 
                        for (int i = 2; i <= 100; i = i + 2)
                        {

                            //operacion
                            i += 2;
                            //  i = i % 2;

                            Console.Write("los pares son --> " + " " + i);
                        }//fin for 

                        break;

                        //opcion2
                    case 2: 

                        //entrada de datos 
                        Console.WriteLine("MULTIPLOS DE 4 ");
                        Console.WriteLine(" que tabla quiere ver ...  ");
                        int tabla2 = int.Parse(Console.ReadLine());

                        while (j < 11)
                        {
                            int rta2 = j * tabla2;
                            Console.WriteLine(tabla2 + " * " + j + " = " + rta2);
                            j = j + 1;
                        }//fin while 


                        break;

                        //opcion3
                    case 3:
                        Console.WriteLine("MULTIPLOS hasta el 100  ");
                        Console.WriteLine(" que tabla quiere ver ...  ");
                        int tabla3 = int.Parse(Console.ReadLine());

                        while (j < 100)
                        {
                            int rta2 = j * tabla3;
                            Console.WriteLine(tabla3 + " * " + j + " = " + rta2);
                            j = j + 1;
                        }//fin while 

                        break;

                    default:
                        break;
                
                
                
                }//fin switch





            }//fin do 
            while (opc != 4);


            Console.ReadLine();

        }//fin main 
    }//fin class
}//fin namespaces 
