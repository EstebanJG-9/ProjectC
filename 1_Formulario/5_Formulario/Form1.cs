using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn__Click(object sender, EventArgs e)
        {
            //declarar variables 
            int A;
            int B;

            //inicializar variables 
            // A = 0;
            // B = 10;


            //capturar datos
            A = int.Parse(tx_A.Text);  // de la caja 
            B = int.Parse(tx_B.Text);  // de la caja 

            //operar varuables
            A = A + 1;  //se incrementa la variable a 
            B = B + 1;

            //mostrar informacion

            tx_A.Text = A.ToString();

            tx_B.Text = B.ToString();




        }//fin button1

        private void button1_Click(object sender, EventArgs e)
        {

            tx_A.Text = "";
            tx_B.Text = "";
            tx_A.Focus();   

        }//btn_limpiar
    }//fin class
}//fin namespace
