using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Par_Impar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num =0;


            num = Convert.ToInt32(txt_numero.Text);

            


            if (num % 2 ==0 )
            {
                MessageBox.Show("el numero es par  ");
                txt_calcular.Text = " el numero es par " + num;


            }//fin if 

            else
            {

                MessageBox.Show("el numero es impar  ");
                txt_calcular.Text = " el numero es impar" + num;
            }




        

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
