using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AgenciaViaje.Web.Data
{
    public class DatUsuario
    {
         
       public DatUsuario()
        {
            con = new SqlConnection("Data Source = MATUS-PC\\MSSQLSERVER2012; Initial Catalog=Cinepolis; User Id=sa; Password=12345;");
        }
        public DataTable ObtenerUsuario(string Correo, string Password)
        {


            SqlCommand com = new SqlCommand("spObtenerUsuario", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Correo", Value = Correo });
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@Password", Value = Password });
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public SqlConnection con { get; set; }

    }
}
