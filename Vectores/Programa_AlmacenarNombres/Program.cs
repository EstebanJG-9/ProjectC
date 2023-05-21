using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  
programa que permita solicitar 15 nombre almacenarlos
en un vector y luego los muestre en  el orden ingresado.
 
 
 */

namespace Programa_AlmacenarNombres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int tam = 0;

            //bienvenido 
            Console.Write("\t\t\t" + "PROGRAMA PARA SOLICITAR NOMBRES " + "\n\n");

            // tamaño del vector 
            Console.Write("Ingrese el tamño del vector ...:");
            tam = int.Parse(Console.ReadLine());

            //declaracion de vector 
            string[] vector = new string[tam];

            //llenar el vector 

            for (int i =0;i<tam;i++) {

                Console.Write("Ingrese   el nombre....: ");
                vector[i] = Console.ReadLine();
            
            }//fin for
             //mostrar la informacion capturada 
            Console.Write("\t\t\t" + "Reporte de registrso insertados" + "\n\n");

            for (int i = 0; i < tam; i++)
            {

                Console.WriteLine("registro  # " + (i + 1) + " valor --> " + vector[i]);
            }//fin for


            Console.ReadLine();
        }//fin main
    }//fin class
}//fin namespaces
