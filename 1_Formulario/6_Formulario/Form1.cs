using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton calcular 

            //variables
            double hora_trabajada, horas_extras, valor_hora, valor_extra, total, total_Extras, sub_total, descuento,neto;
     
            //parseo  de double  a string 
            hora_trabajada = Convert.ToDouble(txt_horasTrabajadas.Text);
            horas_extras = Convert.ToDouble(txt_horasExtras.Text);
            valor_hora = Convert.ToDouble(txt_vhoraTrabajo.Text);
            valor_extra = Convert.ToDouble(txt_vhoraExtra.Text);

            //operaciones 
            total = hora_trabajada * valor_hora;
            total_Extras = horas_extras * valor_extra;
            sub_total = total + total_Extras;
            descuento = sub_total * 0.05;
            neto = sub_total - descuento;

            //mostrar en pantalla la solucion 
            txt_nombreP.Text = txt_nombre.Text;
            txt_neto.Text = neto.ToString();    
            txt_thorasTrabajadas.Text = total.ToString();
            txt_thorasExtras.Text = total_Extras.ToString();
            txt_subtotal.Text = sub_total.ToString();
            txt_descuento.Text = descuento.ToString();

            



        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            //boton limpiar 

            txt_nombre.Text = "";
            txt_horasTrabajadas.Text = "";
            txt_horasExtras.Text = "";
            txt_vhoraTrabajo.Text = "";
            txt_vhoraExtra.Text = "";
            txt_thorasTrabajadas.Text = "";
            txt_thorasExtras.Text = "";
            txt_subtotal.Text = "";
            txt_descuento.Text = "";
            txt_nombre.Focus();


        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //boton salir 

            Close();


        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
