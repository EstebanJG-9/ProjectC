using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Login_ASP
{
    public partial class Formulario_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }
        //crear evento boton ingresar 
        string incap = "1233";
        protected void BtnIngresar(object sender, EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection con = new SqlConnection(conectar);
            SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", con)
            {
                CommandType = CommandType.StoredProcedure


            };//.CreateCommand();   
            cmd.Connection.Open();
            cmd.Parameters.Add("@usu", SqlDbType.VarChar, 50).Value = tx_usuario.Text;
            cmd.Parameters.Add("@contra", SqlDbType.VarChar, 50).Value = tx_contraseña.Text;
            cmd.Parameters.Add("@incap", SqlDbType.VarChar, 50).Value = incap;

            SqlDataReader lectura = cmd.ExecuteReader();

            if (lectura.Read())
            {

                //sesion usuario 
                Response.Redirect("Index.aspx");


            } //fin fin 
            else
            {
                Response.Write("ACCESO DENEGADO");
                cmd.Connection.Close();
              


            }
        }
   } }