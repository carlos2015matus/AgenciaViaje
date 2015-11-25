using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AgenciaViaje.Web.Data
{
    public class DatViaje
    {
        public SqlConnection con;
        public DatViaje()
        {
            con = new SqlConnection("Data Source = MATUS-PC\\MSSQLSERVER2012; Initial Catalog=Agencia; User Id=sa; Password=12345;");
        }

        public DataTable Obtener()
        {
            SqlCommand com = new SqlCommand("spObtenerViajes", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Obtener(int id)
        {
            SqlCommand com = new SqlCommand("spObtenerViaje", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@Id", Value = id });

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public int Insert(string nombre, string fechallegada, int cateId, int destId, string fechaAlta, bool estatus, string descr, string video, string fotoLugar, string fotoHotel, double costo, string lugar)
        {
            try
            {
                SqlCommand com = new SqlCommand("spInsertaViaje", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@nombre", Value = nombre });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime, ParameterName = "@fechallegada", Value = fechallegada });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@cateId", Value = cateId });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@destId", Value = destId });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime, ParameterName = "@fechaAlta", Value = fechaAlta });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Bit, ParameterName = "@estatus", Value = estatus });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@descr", Value = descr });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@video", Value = video });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@fotoLugar", Value = fotoLugar });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@fotoHotel", Value = fotoHotel });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Decimal, ParameterName = "@costo", Value = costo });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@lugar", Value = lugar });


                con.Open();
                int filas = Convert.ToInt32(com.ExecuteNonQuery());
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException(ex.Message);
            }
        }

        public int Eliminar(int Id)
        {
            try
            {
                SqlCommand com = new SqlCommand("spEliminarViajes", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@Id", Value = Id });
                int filas = Convert.ToInt32(com.ExecuteNonQuery());
                return filas;

            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException(ex.Message);
            }

        }

        public int Update(string nombre, string fechallegada, int cateId, int destId, string fechaAlta, bool estatus, string descr, string video, string fotoLugar, string fotoHotel, double costo, string lugar)
        {
            try
            {
                SqlCommand com = new SqlCommand("spActualizarViaje", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@nombre", Value = nombre });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime, ParameterName = "@fechallegada", Value = fechallegada });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@cateId", Value = cateId });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@destId", Value = destId });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.SmallDateTime, ParameterName = "@fechaAlta", Value = fechaAlta });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Bit, ParameterName = "@estatus", Value = estatus });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@descr", Value = descr });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@video", Value = video });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@fotoLugar", Value = fotoLugar });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@fotoHotel", Value = fotoHotel });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.Decimal, ParameterName = "@costo", Value = costo });
                com.Parameters.Add(new SqlParameter() { SqlDbType = SqlDbType.NVarChar, ParameterName = "@lugar", Value = lugar });


                con.Open();
                int filas = Convert.ToInt32(com.ExecuteNonQuery());
                con.Close();
                return filas;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new ApplicationException(ex.Message);
            }
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
