using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   programa que permita solicitar 25 nombre y 25
   apellidos y los muestre en forma de un unico listado
 
 */
namespace Programa_Listados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //variables 
            int tam =0, tama=0;

            //bienvenida 

            Console.Write("\t\t\t" + "PROGRAMA PARA VER DOS LISTADOS " + "\n\n");

            Console.Write("Ingrese el tamaño de Nombres ");
            tam = int.Parse(Console.ReadLine());

   

            string[] vectornombre=new string[tam];
            int logitud = vectornombre.Length;

            for (int i=0; i<tam; i++) {

                Console.Write("Ingrese  un nombre ...:");
                 vectornombre[i] = Console.ReadLine();  

            }//fin for 

         
         //   Console.Write("Ingrese el tamaño de Apellidos ");
          //  tama = int.Parse(Console.ReadLine());

          

            string[] vectorapellido = new string[tam];

            for (int i =0; i < logitud;i++) {

                Console.Write("Ingrese  un Apellido ...:");
                vectorapellido[i] = Console.ReadLine();



            }//fin for


            //mostrar la informacion capturada 
            Console.Write("\t\t\t" + "Reporte de registrso Nombres" + "\n\n");


            for (int i = 0; i < tam; i++)
            {

                Console.WriteLine("registro  # " + (i + 1) + " valor --> " + vectornombre[i]  );
            }//fin for

            //mostrar la informacion capturada 
            Console.Write("\t\t\t" + "Reporte de registrso Apellidos" + "\n\n");

            for (int i = 0; i < logitud; i++)
            {

                Console.WriteLine("registro  # " + vectornombre[i] + "  --> " + vectorapellido[i]);
            }//fin for

            Console.ReadLine();
        }//fin main
    }//fin class
}//fin namespaces
