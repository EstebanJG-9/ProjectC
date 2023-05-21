using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 programa que reciba un listado de n numeros
 ingreasdos por el usuario y luego determine el numero 
 mayor  y el numero menor de entre todos los datos
  ingresados 
 
 */

namespace Programa_N_MayorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables

            int numerototal=0,i=1,mayor=0,menor=0,num=0;

        

            //bienvenida 

            Console.Write("\t\t\t" + "PROGRAMA PARA CALCULAR N PRIMEROS NATURALES" + "\n\n");

            //entrada de datos 

  

            Console.Write("ingrese el numero...:");
            num = int.Parse(Console.ReadLine());

            while (  num <=3  )
            {
                num = num + 1;
            

                if (i==1) {

                    mayor = num;
                    menor = num;
                
                
                }//if 

                else
                {

                }//fin else

                if (num > mayor) {

                    mayor = num;
                
                
                }//fin if

                if (num < menor) {

                    menor = num;
                }//fin if 


            }//fin while 



            Console.WriteLine("el numero mayor es --> "+ " " +mayor);
            Console.WriteLine("el numero menor  es --> " + " " +menor);

            Console.ReadLine();

        }//fin main
    }//fin class
}//fin namespaces
