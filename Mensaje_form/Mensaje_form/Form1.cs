using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensaje_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_mensaje1_Click(object sender, EventArgs e)
        {

            //mostrar menesaje por caja 
            MessageBox.Show("Informacion ", "TITULO");



        }//fin mensaje boton 

        private void button1_Click(object sender, EventArgs e)
        {


            //mensaje diferente de boton cancelar OK 


            //variable para definir el ok del boton 

            DialogResult respuesta;

            //capturar respuesta 
            respuesta = MessageBox.Show("INFROMACION ", "TITULO", MessageBoxButtons.OKCancel);

            //validar seleccion 

            if (respuesta==DialogResult.OK) 
            {

                MessageBox.Show("Oprmio el boton aceptar ");
            }//fin if
            else 
            {
                MessageBox.Show("Oprmio el boton cancelar  ");
                return;
            }//fin else

        }//fin boton 2

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            //capturar respuesta 
            respuesta = MessageBox.Show("INFROMACION ", "TITULO", MessageBoxButtons.YesNoCancel);

            //validar seleccion 

            if (respuesta == DialogResult.OK)
            {

                MessageBox.Show("Oprmio el boton no  ");
            }//fin if
            else if (respuesta==DialogResult.No) 
            {
                MessageBox.Show("Oprmio el boton cancelar  ");
                return;


            }//fin else if
            else
            {
                MessageBox.Show("Oprmio el boton cancelar  ");
                return;
            }//fin else

            // 


        }//fin boton 3

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INFROMACION ", "TITULO", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }//fin mensaje 4 

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INFROMACION ", "TITULO", MessageBoxButtons.OK, MessageBoxIcon.Question);


        }//fin botn 5

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INFROMACION ", "TITULO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }//boton 6
    }
}
