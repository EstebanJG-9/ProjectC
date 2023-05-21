using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace from_switch
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

        private void Form1_Load(object sender, EventArgs e)
        {

            //cargar datos al combobox
            comboBox1.Items.Add("selecionar");
            comboBox1.Items.Add("Azul");
            comboBox1.Items.Add("Rojo");



        }//fin form load

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.Text)  
            {
                case "Azul": label2.Text = ("Seleciono el color azul ");
                    label4.BackColor = System.Drawing.Color.Blue;
                    break;

                case "Rojo":
                    label2.Text = ("Seleciono el color rojo ");
                    label4.BackColor=System.Drawing.Color.Red;
                    break;

                default:

                    MessageBox.Show("Selecione un color ");

                    break;




            }//fin switch

        }
    }//fin formulario
}//fin class
