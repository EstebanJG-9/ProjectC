using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays_Arreflos
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //declaracion de aarray 

            int[] numeros = new int[5];

            //asignara valores
            numeros[0] = 10;
            numeros[1] = 20;    
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50; // se declara n catidad del array 

           // MessageBox.Show(numeros[2].ToString());

            for (int i = 0;i<numeros.Length;i++) 
            {
            
            MessageBox.Show(numeros[i].ToString()); 
            
            
            }//fin for


            string[] usuarios = new string[5];

            //llenar el vector 


            for (int i = 0; i < usuarios.Length; i++)
            {

               usuarios[i] ="la posicion es : "+ i.ToString();


            }//fin for
            //salida de la informacion 
            for (int j = 0; j < usuarios.Length; j++)
            {

                MessageBox.Show(usuarios[j].ToString());


            }//fin for


            //string nombre = "esteban";
            //MessageBox.Show(nombre);

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
