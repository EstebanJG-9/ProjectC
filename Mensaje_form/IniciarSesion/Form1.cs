using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IniciarSesion
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

        private void btn_ingresar_Click(object sender, EventArgs e)
        {

            string usuario = "poli";
            string contraseña = "123";

            //usuario = txt_usuario.Text;
            //contraseña = txt_contraseña.Text;




            if (txt_usuario.Text==usuario && txt_contraseña.Text==contraseña )
               {

                MessageBox.Show(" Ingreso correctamente ");

            }//fin if 
            else 
            {

                MessageBox.Show("clave/usuario INCORRECTO ");

            }//fin else



        }//fin boton ingresar 
    }
}
