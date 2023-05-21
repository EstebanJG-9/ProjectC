using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Negocio
{
    public class ConexionSQLN
    {
        ConexionSQL ccn = new  ConexionSQL();

        public int conSQL(string user,string clave) 
        {


            return ccn.consultalogin(user,clave);
        
        }//fin consql


       
    }




}//fin clase conexionsqln

