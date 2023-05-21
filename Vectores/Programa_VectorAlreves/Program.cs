using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   programa que permita llenar un vector de 18 
   posiciones y despues mostrarlo al reves .

*/

namespace Programa_VectorAlreves
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            int tam = 0;

            //bienvenida
            Console.Write("\t\t\t" + "PROGRAMA PARA MOSTAR AL REVES DATOS DEL VECTOR  " + "\n\n");

            //Tamaño del vector 

            Console.Write("Ingrese el tamaño del vector....:");
            tam = int.Parse(Console.ReadLine());

            // declaracion de vector
            int[] vector = new int[tam];


            for (int i = 0; i < tam; i++) {

                Console.Write("Ingrese un numero ");
                vector[i] = int.Parse(Console.ReadLine());   


            
            
            }//fin for   

            Console.Write("\t\t\t" + "VALORES INVERSOS " + "\n\n");

            int logitud = vector.Length;
            for (int i = logitud -1;i >= 0;i--)  {

                Console.WriteLine("Vector al reves ---> "+ " " + vector[i]);
            
            
            
            }//fin for 


            Console.ReadLine();
        }//fin main
    }//fin class
}//fin namespaces
