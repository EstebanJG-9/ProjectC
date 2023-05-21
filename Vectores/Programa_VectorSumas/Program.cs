using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  programa que permita sumar todos los valores 
  ingresador en un vector de 12 posiciones ,los
  valores deben ser ingresados por el usuario . 
 
 */

namespace Programa_VectorSumas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            int tam = 0,suma=0;

            //bienvenida 

            Console.Write("\t\t\t" + "PROGRAMA PARA SUMAR VALORES  " + "\n\n");

            //tamaño de vector 

            Console.Write("Ingrese el tamaño del vector...:");
            tam=int.Parse(Console.ReadLine());  
            
            //declaracion de vector 
            int[] vector = new int[tam];


            for (int i = 0; i < tam; i++) {

                Console.Write("Ingrese los valores a sumar ...: ");
                vector[i] = int.Parse(Console.ReadLine());
            
            
            }//fin for

            Console.Write("\t\t\t" + "SUMA DE LOS VALORES " + "\n\n");
            for (int i =0;i<tam;i++) {

                suma = suma + vector[i];

                Console.WriteLine("la suma es --> " +" " +suma);
            }//fin for



            Console.ReadLine();
        }//fin main
    }//fin class
}//fin namespaces
