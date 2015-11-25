using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AgenciaViaje.Web.Data
{
    public class DatCatalogo
    {
        public DatCatalogo()
        {
            con = new SqlConnection("Data Source = MATUS-PC\\MSSQLSERVER2012; Initial Catalog=Cinepolis; User Id=sa; Password=12345;");
        }
        public SqlConnection con;
        public DatCatalogo()
        {
            con = new SqlConnection("Data Source = MATUS-PC\\MSSQLSERVER2012; Initial Catalog=Cinepolis; User Id=sa; Password=12345;");
        }

        public DataTable ObtenerCategoria()
        {
            try
            {

                SqlCommand com = new SqlCommand("spObtenerCategoria", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException(ex.Message);
            }

        }

        public DataTable ObtenerDestino()
        {
            try
            {
                SqlCommand com = new SqlCommand("spObtenerDestino", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException(ex.Message);
            }

        }
    }
}
