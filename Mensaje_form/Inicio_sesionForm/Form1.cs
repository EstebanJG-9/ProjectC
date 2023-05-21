using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_sesionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int intentos = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            string usu = "abc";
            string con = "123";



            do
            {

                Form1.Show();

                if (txt_contrasena.Text == con && txt_usuario.Text == usu)
                {


                    label3.Text = ("bienvenido Entraste ");


                    txt_contrasena.Text = "";
                    txt_usuario.Text = "";

                }//fin if
                else
                {
                    intentos++;

                    MessageBox.Show("usuairo /contraseña incorrecta" + intentos);
                    txt_contrasena.Text = "";
                    txt_usuario.Text = "";
                    //intentos--;

                    if (intentos == 3)
                    {

                        MessageBox.Show("fin " + intentos + "intetnos ");
                        //  label3.Text = (" lleva  intentos");

                        // intentos = intentos++;

                        Application.Exit();

                    }


                }//fin if


            } while ();














            //  MessageBox.Show("ha exedido los intentos permitidos ");





        }//fin btn

       
    }
}
