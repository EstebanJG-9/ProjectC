using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_3
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            int[,] numeros = new int[5,5];

            int[] numeros1 = {2,4,6,8,10,12,14,20,25,30,45};
            //recorrido
           // foreach (var item in coleccion )
                foreach (var i in numeros1)
                {

                   MessageBox.Show(i.ToString());
                   

                 }//fin foreach






            //for (int f =0;f<numeros.GetLength(0);f++) //   0 filas  1 columnas .GetLength
            //{
            //    for (int c=0;c<numeros.GetLength(1);c++) 
            //    {

            //        numeros[f, c] = 2 * (f + 3)*(c + 4);


            //    }//fin for


            //}//fin for 

            //for (int f = 0; f <numeros .GetLength(0); f++) //   0 filas  1 columnas .GetLength
            //{
            //    for (int c = 0; c < numeros.GetLength(1); c++)
            //    {

            //        MessageBox.Show("en la fila --> "+ f + " columna " + c + " es el valor  " + numeros[f,c]);

            //    }//fin for


            //}//fin for 



            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
