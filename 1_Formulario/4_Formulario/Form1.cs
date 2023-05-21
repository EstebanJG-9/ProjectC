using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_nom_Click(object sender, EventArgs e)
        {
            label1.Text = " JUAN ESTEBAN GOMEZ ";



        }//btn_nom

        private void btn_estu_Click(object sender, EventArgs e)
        {

            label1.Text = "POLITECNICO INTERNACIONAL ";

        }//fin button_2

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "COLOMBIANA";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }//fin class
}//fin namespace
