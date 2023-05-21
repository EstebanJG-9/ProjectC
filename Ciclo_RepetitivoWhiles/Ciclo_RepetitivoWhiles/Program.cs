using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
programa que calcule la suma de los n primeros 
numeros naturales donde n es un numero digitado por 
el usuario 
 */
namespace Ciclo_RepetitivoWhiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int num = 0,contador=0,suma=0;

            //bienvenida 

            Console.Write("\t\t\t"+"PROGRAMA PARA CALCULAR N PRIMEROS NATURALES"+"\n\n");

            //entrada de datos 

            Console.Write("Ingres un numero ....:");
            num = int.Parse(Console.ReadLine());

          // ciclo while 
            while ( contador <= num ) {

                //operaciones 
                suma = suma + contador;
                contador = contador + 1;
            
            
            }//fin while

            //salida de datos 
            Console.WriteLine("la suma es --> " + " " + suma);


            Console.ReadLine();
        }//fin main 
    }//fin class
}//fin names paces
