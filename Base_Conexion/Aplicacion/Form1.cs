using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//llmar libreria de conexion 
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplicacion
{


    public partial class Form1 : Form
    {
        //declarar variable  de conexion estatica
        static string conexionstring = "server=localhost; database=navidad; integrated security= true";//fin variable conexion

        //instancias la conexion 
        SqlConnection conexion = new SqlConnection(conexionstring);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {






        }//fin  form

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            //abrir la bd 

            conexion.Open();
            MessageBox.Show(" se a conectado ala base de datos " + conexion.Database);

        }//fin btn_conectar

        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            //cerrar bd

            conexion.Close();

            MessageBox.Show(" se  ha cerrado la base de datos" + conexion.Database);

        }//btn_apagar

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            //verificar consulta caja de texto vacio 
            if (tx_consultar.Text == "")
            {
                //generar consulta
                string sql = "select * from seleciones";

                //instancia para enviar consulta

                SqlCommand buscado = new SqlCommand(sql, conexion);

                //generar la conexion a la base de datos 

                SqlDataAdapter data = new SqlDataAdapter(buscado);
                
                //crear una tabla temporal virtual
                DataTable tabla = new DataTable();
                //instrucion para llenar la tabla 
                data.Fill(tabla);
                //mostrar la informacion 
                dataGridView1.DataSource = tabla;
            
            }//fin if
            else 
            {
                //generar consulta 
                string sql = "select * from seleciones where nom_sel= '"+ tx_consultar.Text+"'";

                //instancia para enviar consulta

                SqlCommand buscado = new SqlCommand(sql, conexion);

                //generar la conexion a la base de datos 

                SqlDataAdapter data = new SqlDataAdapter(buscado);

                //crear una tabla temporal virtual
                DataTable tabla = new DataTable();
                //instrucion para llenar la tabla 
                data.Fill(tabla);
                //mostrar la informacion 
                dataGridView1.DataSource = tabla;
                //limpiar caja de texto

                tx_consultar .Text= "";


            }//fin else

        }//btn_consulta

        //reporte general es la tabla virtual

        public void reporte_gral()
        {
            //generar consulta
            string sql = "select * from seleciones";

            //instancia para enviar consulta

            SqlCommand buscado = new SqlCommand(sql, conexion);

            //generar la conexion a la base de datos 

            SqlDataAdapter data = new SqlDataAdapter(buscado);

            //crear una tabla temporal virtual
            DataTable tabla = new DataTable();
            //instrucion para llenar la tabla 
            data.Fill(tabla);
            //mostrar la informacion 
            dataGridView1.DataSource = tabla;
         

        }//fin reporte general

        private void btn_insertar_Click(object sender, EventArgs e)
        {
            //variable de la consulta
            String sql = "insert into seleciones(nom_sel,lugar,nom_jugador)"+
                "values ('" + tx_nombre.Text+"','"+tx_continenete.Text+"','"+txt_njugador.Text+"')";

            //enviar consulta a la bd
            SqlCommand agregar = new SqlCommand(sql,conexion);
            //generar la conexion a la base de datos 
            SqlDataAdapter con = new SqlDataAdapter(agregar);
            conexion.Open();
            //ejecutar consulta
            agregar.ExecuteNonQuery();

            //mensaje de confirmacion
            MessageBox.Show("Insertado correctamente"+"el equipo "+tx_nombre.Text+"del continente"+tx_continenete.Text+"del jugador"+txt_njugador.Text);
            //carga la tabla virtual despues de la insercion
            reporte_gral();

            //limpiar las cajas de texto
            tx_nombre.Text = "";
            tx_continenete.Text = "";
            txt_njugador.Text = "";

            conexion.Close();
        }//btn_insertar

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            int confirmar;
            //variable de la consulta
            String sql = " delete from seleciones where nom_sel = '"+tx_nombre.Text+"'";

            //enviar consulta a la bd
            SqlCommand eliminar = new SqlCommand(sql, conexion);
            conexion.Open();
            //ejecuta la cosulta
            confirmar = eliminar.ExecuteNonQuery();

            //validacion de que haya informacion

            if (confirmar==1)
            {

                MessageBox.Show("se ha eliminado correctamente" + "el equipo " + tx_nombre.Text + "del continente" + tx_continenete.Text+"del jugador"+txt_njugador.Text);
                tx_nombre.Text = "";
                reporte_gral();
            }//fin if
            else
            {

                MessageBox.Show("EL REGISTRO NO SE PUDO ELIMINAR / NO EXISTE EL VALOR INGRESADO ");
                reporte_gral();
            }//fin else
            conexion.Close();
        }//btn_eliminar

        private void btn_actualizar_Click(object sender, EventArgs e)
        {

          

             int confirmar;
            //variable de la consulta
            String sql = "update seleciones set nom_sel = '"+tx_nombre.Text+"',lugar = '"+tx_continenete.Text+ "', nom_jugador ='"+txt_njugador.Text+"'  where nom_sel = '" + tx_consultar.Text+"'";

            //enviar consulta a la bd
            SqlCommand actualizar= new SqlCommand(sql, conexion);
            conexion.Open();
            //ejecuta la cosulta
            confirmar = actualizar.ExecuteNonQuery();

            //validacion de que haya informacion

            if (confirmar == 1)
            {

                MessageBox.Show("se ha Actualizado correctamente" + "el equipo " + tx_nombre.Text + "del continente" + tx_continenete.Text + "del jugador" + txt_njugador.Text  );
                tx_nombre.Text = "";
                reporte_gral();
            }//fin if
            else
            {

                MessageBox.Show("EL REGISTRO NO SE PUDO Actualizar / NO EXISTE EL VALOR INGRESADO ");
                reporte_gral();
            }//fin else
            conexion.Close();
        }//fin btn_actualizar

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }//fin forma class
}//fin namespaces
