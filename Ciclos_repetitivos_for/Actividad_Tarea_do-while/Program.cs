using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_Tarea_do_while
{
    internal class Program
    {
        private static int j;
        private static int m;

        static void Main(string[] args)
        {

            /* 
             - actividad de tabla de multiplicar   con ciclo do y do-while 
             */

           //-tabla de multiplicar que el usuario quiera 
           //-imprimir del 1 al 10 

           Console.Write(" que tabla quiere ver ...  ");
           int tabla = int.Parse(Console.ReadLine());

           for (int i =1 ;i< 11 ;i++ )
           {
           //operacion 
           int rta = i * tabla;
           Console.WriteLine(tabla+ " * "+i+ " = "+ rta);

            }//fin for

            //proceso de informacion while 
            Console.Write(" CICLO  WHILE  ");
            Console.Write(" que tabla quiere ver ...  ");
            int tabla2 = int.Parse(Console.ReadLine());
          
            while (  j < 11 )
            {
                int rta2 = j * tabla2;
                Console.WriteLine(tabla2 + " * " + j + " = "+rta2 );
                j = j+1;
            }//fin while 

            //proceso de informacion while 
            Console.Write(" CICLO DO- WHILE  ");
            Console.Write(" que tabla quiere ver ...  ");
            int tabla3 = int.Parse(Console.ReadLine());
            


            do
            {
                int rta3 = m * tabla3;
                Console.WriteLine(tabla3 + " * " + m + " = " + rta3);
                m = m + 1;
            } while (m < 11);





            Console.ReadLine();


        }// fin main 
    }// fin class
}// fin namespace 
