using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgenciaViaje.Web.Business.Entity;
using System.Data;
using AgenciaViaje.Web.Data;

namespace AgenciaViaje.Web.Business
{
    public class BusViaje
    {

        public List<EntViaje> Obtener()
        {
            DataTable dt = new DatViaje().Obtener();
            List<EntViaje> lst = new List<EntViaje>();
            foreach (DataRow dr in dt.Rows)
            {
                EntViaje ent = new EntViaje();
                ent.Id = Convert.ToInt32(dr["VIAJ_ID"]);
                ent.Nombre = dr["VIAJ_NOMB"].ToString();
                ent.FechaLlegada = Convert.ToDateTime(dr["VIAJ_FECH_LLEG"]);
                ent.CateId = Convert.ToInt32(dr["VIAJ_CATE_ID"]);
                ent.DestId = Convert.ToInt32(dr["VIAJ_DEST_ID"]);
                ent.FechaAlta = Convert.ToDateTime(dr["VIAJ_FECH_ALTA"]);
                ent.Estatus = Convert.ToBoolean(dr["VIAJ_ESTA"]);
                ent.Descripcion = dr["VIAJ_DESC"].ToString();
                ent.Video = dr["VIAJ_VIDE"].ToString();
                ent.FotoLugar = dr["VIAJ_FOTO_LUGA"].ToString();
                ent.FotoHotel = dr["VIAJ_HOTE"].ToString();
                ent.Costo = Convert.ToDouble(dr["VIAJ_COST"]);
                ent.Lugar = dr["VIAJ_LUGA"].ToString();
                lst.Add(ent);
            }
            return lst;
        }

        public void Insertar(EntViaje ent)
        {
            int fila = new DatViaje().Insert(ent.Nombre, ent.FechaLlegada.ToString("MM/dd/yyyy"), ent.CateId, ent.DestId, ent.FechaAlta.ToString("MM/dd/yyyy"), ent.Estatus, ent.Descripcion, ent.Video, ent.FotoLugar, ent.FotoHotel, ent.Costo, ent.Lugar);
            if (fila != 1)
            {
                throw new ApplicationException("Error al Insertar pelicula" + ent.Nombre + "");
            }
        }

        public void Update(EntViaje ent)
        {
            int fila = new DatViaje().Update(ent.Nombre, ent.FechaLlegada.ToString("MM/dd/yyyy"), ent.CateId, ent.DestId, ent.FechaAlta.ToString("MM/dd/yyyy"), ent.Estatus, ent.Descripcion, ent.Video, ent.FotoLugar, ent.FotoHotel, ent.Costo, ent.Lugar);
            if (fila != 1)
            {
                throw new ApplicationException("Error al actualizar pelicula" + ent.Nombre + "");
            }
        }

        public void Eliminar(EntViaje ent)
        {
            int fila = new DatViaje().Eliminar(ent.Id);
            if (fila != 1)
            {
                throw new ApplicationException("Error al Borrar pelicula" + ent.Nombre + "");
            }

        }

        public List<EntViaje> ObtenerCategoria(int categoria)
        {
            try
            {
                DataTable dt = new DatViaje().ObtenerCategoria();
                List<EntViaje> lst = new List<EntViaje>();
                foreach (DataRow dr in dt.Rows)
                {
                    EntViaje ent = new EntViaje();
                    ent.Id = Convert.ToInt32(dr["VIAJ_ID"]);
                    ent.Nombre = dr["VIAJ_NOMB"].ToString();
                    ent.FechaLlegada = Convert.ToDateTime(dr["VIAJ_FECH_LLEG"]);
                    ent.CateId = Convert.ToInt32(dr["VIAJ_CATE_ID"]);
                    ent.DestId = Convert.ToInt32(dr["VIAJ_DEST_ID"]);
                    ent.FechaAlta = Convert.ToDateTime(dr["VIAJ_ESTA"]);
                    ent.Estatus = Convert.ToBoolean(dr["VIAJ_ESTA"]);
                    ent.Descripcion = dr["VIAJ_DESC"].ToString();
                    ent.Video = dr["VIAJ_VIDE"].ToString();
                    ent.FotoLugar = dr["VIAJ_FOTO_LUGA"].ToString();
                    ent.FotoHotel = dr["VIAJ_FOTO_HOTE"].ToString();
                    ent.Costo = Convert.ToDouble(dr["VIAJ_COSTO"]);
                    ent.Lugar = dr["VIAJ_LUGA"].ToString();
                    ent.Categoria.Nomb = dr["CATE_NOMB"].ToString();
                    ent.Destino.Nomb = dr["DEST_NOMB"].ToString();
                    lst.Add(ent);
                }
                return lst;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EntViaje> ObtenerGenero(int genero)
        {
            try
            {
                DataTable dt = new DatViaje().ObtenerCategoria();
                List<EntViaje> lst = new List<EntViaje>();
                foreach (DataRow dr in dt.Rows)
                {
                    EntViaje ent = new EntViaje();
                    ent.Id = Convert.ToInt32(dr["VIAJ_ID"]);
                    ent.Nombre = dr["VIAJ_NOMB"].ToString();
                    ent.FechaLlegada = Convert.ToDateTime(dr["VIAJ_FECH_LLEG"]);
                    ent.CateId = Convert.ToInt32(dr["VIAJ_CATE_ID"]);
                    ent.DestId = Convert.ToInt32(dr["VIAJ_DEST_ID"]);
                    ent.FechaAlta = Convert.ToDateTime(dr["VIAJ_ESTA"]);
                    ent.Estatus = Convert.ToBoolean(dr["VIAJ_ESTA"]);
                    ent.Descripcion = dr["VIAJ_DESC"].ToString();
                    ent.Video = dr["VIAJ_VIDE"].ToString();
                    ent.FotoLugar = dr["VIAJ_FOTO_LUGA"].ToString();
                    ent.FotoHotel = dr["VIAJ_FOTO_HOTE"].ToString();
                    ent.Costo = Convert.ToDouble(dr["VIAJ_COSTO"]);
                    ent.Lugar = dr["VIAJ_LUGA"].ToString();
                    ent.Categoria.Nomb = dr["CATE_NOMB"].ToString();
                    ent.Destino.Nomb = dr["DEST_NOMB"].ToString();
                    lst.Add(ent);

                }
                return lst;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
