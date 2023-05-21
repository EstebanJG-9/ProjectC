using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Negocio;//se hereda la clase negocio

namespace Presentacion
{
    public partial class Form1 : Form//se cambio el internal por el public 
    {
        //instanciar a la clase negocio 
        ConexionSQLN cn = new ConexionSQLN();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //cerrar la aplicacion 
            Application.Exit();


        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {


            if (cn.conSQL(txt_usuario.Text,txt_contrasena.Text)==1) 
            {
                MessageBox.Show("SI EXISTE EL USUARIO ");
                //quitar la ventana del login
                 this.Hide();

                //ir a formulario frm_principal

                frm_principal ppal = new frm_principal();
                ppal.Show();
            
            
            }//fin if 
            else 
            {

                MessageBox.Show("usuario no existe ");
            
            
            }//fin else

        }//fin btn ingresar
    }
}
