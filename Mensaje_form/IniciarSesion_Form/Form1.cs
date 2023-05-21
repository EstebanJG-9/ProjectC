using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IniciarSesion_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int intentos = 0;
        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            string usuario = "abc";
            string contraseña = "123";
       


            //usuario = txt_usuario.Text;
           // contraseña = txt_contraseña.Text;


            do
            {
               // txt_contraseña.Text = "";
                //txt_usuario.Text = "";


                if (txt_contraseña.Text==contraseña && txt_usuario.Text==usuario)
                {

                    MessageBox.Show("BIENVENIDO ");
                    Application.Exit();



                }//fin if 
                else
                {
                    intentos++;

                    MessageBox.Show("usuairo /contraseña incorrecta" + intentos);
                    txt_contraseña.Text = "";
                    txt_usuario.Text = "";
             
                    //intentos--;


                }



               // MessageBox.Show("fin " + intentos + "intetnos ");


            } while (intentos==3);

            // MessageBox.Show("fin " + intentos + "intetnos ");



        }
    }
}
