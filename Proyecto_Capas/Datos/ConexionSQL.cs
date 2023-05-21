using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //conexion
using System.Data.SqlClient;//conexion bd 

namespace Datos
{
    public class ConexionSQL
    {

        static string conexionstring = "server=localhost;database = punto_venta;"+
                                       "integrated security = true ";

        //crear objeto conexionstring 

        SqlConnection con = new  SqlConnection(conexionstring);//con es variable de bd conexion 

        public int consultalogin(string usuario ,string contraseña)
        {
            int count;
            con.Open();
            string sql = "select count(*)  from persona where usuario = '"+usuario+"' and contrasena ='"+contraseña+"' ";
            SqlCommand consul_login = new SqlCommand(sql, con);

            //convierte la consulta en valor numerico 
            count = Convert.ToInt32(consul_login.ExecuteScalar());


            con.Close();

            return count;
        
        }//fin funcion consultalogin

        public DataTable consultar_usuarios()
        {

            string sql = "select* from persona";

            SqlCommand consul = new SqlCommand(sql, con);//comando de sql
            SqlDataAdapter data = new SqlDataAdapter(consul);//adaptador de bd 
            DataTable tabla = new DataTable();//llamar a datba table
            data.Fill(tabla);

            return tabla;


        }//funcion consultrar ususario 
    }

}//fin class conexion

