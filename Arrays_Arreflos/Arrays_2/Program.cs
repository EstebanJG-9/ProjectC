using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            int[,] numeros = new int[2,5];//3 filas,5 columnas
                                          
            //asignar valores

            numeros[0,0] = 1;
            numeros[0,1] = 2;
            numeros[0,2] = 3;
            numeros[0,3] = 4; 
            numeros[0,4] = 5;
            numeros[1,0] = 10;
            numeros[1,2] = 20;
            numeros[1,3] = 30;   
            numeros[1,4] = 40;
           

            for (int f = 0; f <5; f++)
            {

                for (int c = 0; c < 5; c++)
                {
                    MessageBox.Show(numeros[f, c].ToString());// error

                }//fin for
            }//fin for

          








            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
