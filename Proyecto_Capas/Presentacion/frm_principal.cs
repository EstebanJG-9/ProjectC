using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }//btn_salir

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instancias al formulario form usuarios
            fm_usuarios usu = new fm_usuarios();//objeto con el fromulario usuarios

            //ocultar ventana
            this.Hide();
            usu.ShowDialog();//muestra el fromulario 
            this.Show();//relaciona

        }
    }//class
}//fin namespace
