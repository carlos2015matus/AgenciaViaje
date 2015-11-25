using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AgenciaViaje.Web.Data;
using AgenciaViaje.Web.Business.Entity;

namespace AgenciaViaje.Web.Business
{
    public class BusCatalogo
    {

        public BusCatalogo() { }
        public List<EntCategoria> ObtenerClas()
        {
            DataTable dt = new DatCatalogo().ObtenerCategoria();
            List<EntCategoria> lst = new List<EntCategoria>();
            foreach (DataRow dr in dt.Rows)
            {
                EntCategoria ent = new EntCategoria();
                ent.Id = Convert.ToInt32(dr["CLAS_ID"]);
                ent.Nomb = dr["CLAS_NOMB"].ToString();
                ent.Desc = dr["CLAS_DESC"].ToString();
                lst.Add(ent);
            }
            return lst;
        }

        public List<EntDestino> ObtenerDestino()
        {
            DataTable dt = new DatCatalogo().ObtenerDestino();
            List<EntDestino> lst = new List<EntDestino>();
            foreach (DataRow dr in dt.Rows)
            {
                EntDestino ent = new EntDestino();
                ent.Id = Convert.ToInt32(dr["GENE_ID"]);
                ent.Nomb = dr["GENE_NOMB"].ToString();
                ent.Desc = dr["GENE_DESC"].ToString();
                lst.Add(ent);
            }
            return lst;
        }
    }
}
