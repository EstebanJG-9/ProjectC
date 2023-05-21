using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
          -permita llenar un vector segun el tamaño dado por un usuario 
          -mostrar la informacion de dicho vector
          -buscar un valor especifico
           */


namespace Arreglos_dimensiones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //declarar variables 
            int tam = 0, post = 0,not=0;//determina el tamaño del vector 
            double sum = 0,prom =0,result=0;
            bool bandera = true;
           
            

            //captura del tamaño por parte del usuario 
            Console.Write("ingrese el tamaño del vector...");
            tam = int.Parse(Console.ReadLine());

            //declarar vector //debemos declarar tamaño 
            int[] vector = new int[tam];


            //llenar el vector 
            for (int i = 0;i<tam;i++ )
            {
                //captura de datos para el arreglo 
                Console.Write("Dato # "+ (i+1)+"ingrese un numero....:");
                vector[i]= int.Parse(Console.ReadLine());
            
            
            }//fin for

            //mostrar la informacion capturada 
            Console.Write("\t\t\t Reporte de registros inretados \n:");
            for (int i =0;i<tam;i++)
            {

                //imprimir por pantalla 
                Console.WriteLine("Registro# "+ (i+1)+" valor -------> "+vector[i] + " ");
            
            }//fin for

            Console.Write("\t\t\t Buscar un registro\n:");
            Console.Write("¿que datos esta buscando ?......::");
            int busc = int.Parse(Console.ReadLine());
            for (int i = 0; i < tam; i++)
            {
                if (busc == vector[i]) 
                {
                    //Console.WriteLine("***el valor buscado si existe****")
                    bandera = true;
                    post = i;
                    i = tam;

                }//fin if 
                else
                {
                    // Console.WriteLine("***el valor buscado no existe****");
                    bandera = false;
                }//fin else 
                //imprimir por pantalla 
              //  Console.WriteLine("Registro# " + (i + 1) + " valor -------> " + vector[i] + " ");

            }//fin for
            if (bandera==true) 
            {
                 Console.WriteLine("***el valor buscado si existe****");
                Console.WriteLine("Registro# " + (post+ 1) + " valor -------> " + vector[post] + " ");
            }//fin if 
            else
            {
                Console.WriteLine("***el valor buscado no  existe****");
            }//fin else


            /*
             -calcular 5 notas  y con el promedio 

             */
            //captura del tamaño por parte del usuario 
            Console.Write("INGRESE CUANTAS CALIFICACIONES DESEA  ...");
            not = int.Parse(Console.ReadLine());

            //declarar vector //debemos declarar tamaño 
           
            int[] notas = new int[not];
            result = notas.Length;
         
            //llenar el vector 
            for (int j = 0; j < not; j++)  // j < not 
            {
                //captura de datos para el arreglo 
                Console.Write("nota # " + (j + 1) + "ingrese su calificacion ....:");
                notas[j] = int.Parse(Console.ReadLine());
      
                sum = sum + notas[j] ;  // tener en cuenta se suma +sum +vector por notaw
                prom = sum /result;  // se declaro la vr prom se convoca sum y result el cual es un .lenght 
             


            }//fin for

            Console.WriteLine("suma   de ......: " +sum);
            Console.WriteLine("su promedio es  de ......: " + prom);









            Console.ReadLine();
        }//fin main
    }// fin class
}// fin namespace
