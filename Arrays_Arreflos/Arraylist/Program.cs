using System;
using System.Collections;//referencia el ArrayList
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arraylist
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //estructura del Arraylist
            //  ArrayList nombre = new ArrayList();

            ArrayList lista = new ArrayList();
            //adicionar datos 
            lista.Add(45);
            lista.Add(70);
            lista.Add("hanna");
            lista.Add(80);
            lista.Add("evelin");
            lista.Add("jose");
            //lista.Add(2.6);


            //datos de tipo 

            //recorrido para mostrarlo

            //foreach (var i in lista) 
            //{
            //    MessageBox.Show(i.ToString());
            
            
            //}//fin foreach   

          // ArrayList lista = new ArrayList();

            List<int> lista2 = new List<int>();
            List<string> lista3 = new List<string>();

          
            lista2.Add(20);
            lista2.Add(30);
            lista2.Add(40);


      

            lista3.Add("dormir ");
            lista3.Add("hola");
            lista3.Add("tengo sueño");
            lista3.Remove("hola");



            foreach (var i in lista3)
            {

                MessageBox.Show(i);

            }//fin foreach
            lista3.Remove("hola");

            foreach (var i in lista3)
            {

                MessageBox.Show(i);

            }//fin foreach



            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
