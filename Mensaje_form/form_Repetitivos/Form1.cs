using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_Repetitivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_for_Click(object sender, EventArgs e)
        {


            //ciclo for capacidad de repeticiones
            int n, f=1;

            n = int.Parse(textBox1.Text);

            for (int i =1; i<=n;i++)
            {

                f *= i;
            
            
            }//fin for 
            
            label1.Text=f.ToString();   // mostar en el label

            // n = 5 

          /*  for (int i = 1; i <= 5; i++)
            {

                5*4*3*2*1=120 //factorial

                f *= i;
                120 *= 5;

           */ //fin for 




        }

        private void btn_while_Click(object sender, EventArgs e)
        {

            //primero validamos y despues ejecutamos

            int n, f = 1,i=1;

            n=int.Parse(textBox1.Text);

            while (i<=n) 
            
            {
               f*=i;
                i++;


            
            }//fin while

            label1.Text=f.ToString();   

        }//btn while

        private void btn_do_Click(object sender, EventArgs e)
        {

            //primero una repeticion y despues valida 


            int n , f=1,i=1;    

            n=int.Parse (textBox1.Text);

            do
            {

                f *= i;
                i++;

            } while (i<=n); 
            //fin do while
            
            label1.Text = f.ToString(); 

   





        }//btn_do while
    }
}
