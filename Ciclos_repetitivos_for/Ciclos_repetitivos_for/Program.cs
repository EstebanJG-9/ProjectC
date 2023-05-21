using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos_repetitivos_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJEMPLO CICLO FOR ");
            /*
             imprimir los numeros del 0 al 9  
            */
            for (int vi = 0; vi <= 9; vi++)
            {
                //mostrar informacion 
                //Console.Write(vi+" ");  nos muestra los datos en  horizontal 
                Console.WriteLine(vi + " ");     //vertical 



            }//fin for 

            

          
            Console.WriteLine("\nEJEMPLO 2 CICLO for  ");
            /*
             - imprimir secuencia desde el 0 hasta el 1 usuario indique 
             - imprimir secuencia valor inicial que el usuario quiera y 
               hasta donde el usuario quiera ver
            - indicar el intervalo entre cada numero 
             */
            Console.WriteLine("indique el ultimo numero a ver ....: ");
            int vf = int.Parse(Console.ReadLine());

            Console.WriteLine("indique  el primer  numero a ver ....: ");
            int ini = int.Parse(Console.ReadLine());


            Console.WriteLine("indique  el intervalo   numero a ver ....: ");
            int salto = int.Parse(Console.ReadLine());

         
            // proceso de informacion 



            for (int i = ini; i <= vf; i=i+salto) // i ++ incremento  i -- decremento i=i+salto es el intervalo
            {
                Console.Write(i+ " ");
            }// fin for 
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\nEJEMPLO 2 CICLO do  ");
            /*
             - imprimir secuencia desde el 0 hasta el 1 usuario indique 
             - imprimir secuencia valor inicial que el usuario quiera y 
               hasta donde el usuario quiera ver
            - indicar el intervalo entre cada numero 
             */
            Console.WriteLine("indique el ultimo numero a ver ....: ");
            int vfw = int.Parse(Console.ReadLine());

            Console.WriteLine("indique  el primer  numero a ver ....: ");
            int iniw = int.Parse(Console.ReadLine());


            Console.WriteLine("indique  el intervalo   numero a ver ....: ");
            int saltow = int.Parse(Console.ReadLine());

            //proceso de informacion while 
            int j = iniw;
            while (j <= vfw)
            {
                Console.Write(j + " ");
                j = j + saltow;
            }//fin while 

 

            Console.Clear();
            Console.WriteLine("\nEJEMPLO 3 CICLO DO-WHILE ");
            /*
             - imprimir secuencia desde el 0 hasta el 1 usuario indique 
             - imprimir secuencia valor inicial que el usuario quiera y 
               hasta donde el usuario quiera ver
            - indicar el intervalo entre cada numero 
             */
            Console.WriteLine("indique el ultimo numero a ver ....: ");
            int vfd = int.Parse(Console.ReadLine());

            Console.WriteLine("indique  el primer  numero a ver ....: ");
            int inid = int.Parse(Console.ReadLine());


            Console.WriteLine("indique  el intervalo   numero a ver ....: ");
            int saltod = int.Parse(Console.ReadLine());

            int m = inid;


            do
            {
                Console.Write(m + "  ");
                m = m + saltod;
            } while (m <= vfd);





            Console.ReadLine();
        }//fin main
    }//fin class
}// fin namespace
