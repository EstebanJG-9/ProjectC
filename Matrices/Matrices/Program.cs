using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 
 programa que permita llenar una matriz y mostrar
  todo los datos ingresado y su respectiva posicion ,fila, columnas , en pantalla
 
 */
namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[5, 5];

            for (int filas = 0; filas < matrix.GetLength(0); filas++)
            {

                for (int columna = 0; columna < matrix.GetLength(1); columna++)
                {


                }
            }

            Console.ReadLine();
        }//fin main
    }//fin class
    //fin namespaces
}
