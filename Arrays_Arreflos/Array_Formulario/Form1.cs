using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array_Formulario
{
    public partial class Form1 : Form
    {

        List<string> listaNombres = new List<string>();
        


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombre;
            nombre = textBox1.Text;
            listaNombres.Add(nombre);
            listBox1.DataSource = null;
            //mostrar los datos 

            listBox1.DataSource = listaNombres; 


            



        }//btn OK 

        private void button3_Click(object sender, EventArgs e)
        {

            listaNombres.Remove(textBox1.Text);
            listBox1.DataSource = null;
            //mostrar los datos 
            listBox1.DataSource = listaNombres;



        }//btn_ eliminar

        private void button4_Click(object sender, EventArgs e)
        {
            var dato = listaNombres.IndexOf(textBox2.Text); 
            listaNombres.RemoveAt(dato);
            listaNombres.Insert(dato,textBox1.Text);




           // listaNombres.Remove(textBox1.Text);
            listBox1.DataSource = null;
            //mostrar los datos 
            listBox1.DataSource = listaNombres;

        }
    }
}
