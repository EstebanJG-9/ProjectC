using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_09_Marzo_V1.Recursos.Paginas
{
    public partial class FrmRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Cancelar(object sender, EventArgs e)
        {
            Response.Redirect("/Recursos/Paginas/FrmLogin.aspx");
        }

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        protected void Registrar(object sender, EventArgs e)
        {
            int tam_image = int.Parse(FUImage.FileContent.Length.ToString());
            string contra_vali = tx_contra.Text;
            Regex letras = new Regex(@"[a-zA-Z]");
            Regex numeros = new Regex(@"[0-9]");
            Regex especiales = new Regex("[!\"#\\$&'()*+,-./:;=@\\[\\]{|}~]");

            //RegexMatchTimeoutException letras = new RegexMatchTimeoutException(@"[a-zA-Z]");
            //RegexStringValidator letras = new RegexStringValidator(@"[a-zA-Z]");
            //RegexStringValidator numeros = new RegexStringValidator(@"[0-9]");
            //RegexStringValidator especiales = new RegexStringValidator("[!\"#\\$&'()*+,-./:;=@\\[\\]{|}~]");

            SqlCommand usuarios = new SqlCommand("con_usuario", con);
            usuarios.CommandType = CommandType.StoredProcedure;
            usuarios.Parameters.Add("@usuario", SqlDbType.VarChar).Value = tx_usuario;
            int user = Convert.ToInt32(usuarios.ExecuteScalar());
            if (tx_nombre.Text == "" || tx_apellido.Text == "" || tx_fecha.Text == "" || tx_usuario.Text == "")
            {
                lb_error.Text = "los campos no puden estar vacios";
            }//fin if
            else if(user>=1)
            {
                lb_error.Text = "ese usuario ...."+tx_usuario.Text+"ya existe ";
            }//fin else
            else if (tx_contra.Text!=tx_contra2.Text)
            {
                lb_error.Text = "los datos de la clave no coinciden con la confrimacion";
            }//fin else if
            else if (!letras.IsMatch(contra_vali))
            {
                lb_error.Text = "la contraseña debe tener letras";
            }//fin else if
            else if (!numeros.IsMatch(contra_vali))
            {
                lb_error.Text = "la contraseña debe tener numeros";
            }//fin else if
            else if (!especiales.IsMatch(contra_vali))
            {
                lb_error.Text = "la contraseña debe tener  caracteres especiales";
            }//fin else if
            else if (!FUImage.HasFile)
            {
                lb_error.Text = "no se cargo la imagen correctamente";
            }//fin else if

            else
            {
                byte[] imagen = FUImage.FileBytes;
                string patron = "1233";//clave del encriptamiento
                using (con)
                {
                    using (SqlCommand cmd=  new SqlCommand ("registrar",con)) 
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@nombre",SqlDbType.VarChar).Value = tx_nombre.Text;
                        cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = tx_apellido.Text;
                        cmd.Parameters.Add("@fecha", SqlDbType.Date).Value = tx_fecha.Text;
                        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = tx_usuario.Text;
                        cmd.Parameters.Add("@contra", SqlDbType.VarChar).Value = tx_contra.Text;
                        cmd.Parameters.Add("@patron", SqlDbType.VarChar).Value = patron;
                        cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = imagen;
                        cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = 0;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Response.Redirect("/Recursos/Paginas/frmLogin.aspx");


                    }//fin using


                }//fin using
            }//fin else
        }
    }
}