using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgenciaViaje.Web.Business.Entity
{
    public class EntViaje
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaLlegada { get; set; }
        public int CateId { get; set; }
        public int DestId { get; set; }
        public DateTime FechaAlta { get; set; }
        public bool Estatus { get; set; }
        public string Descripcion { get; set; }
        public string Video { get; set; }
        public string FotoLugar { get; set; }
        public string FotoHotel { get; set; }
        public double Costo { get; set; }
        public string Lugar { get; set; }

        private EntDestino destino;
        public EntDestino Destino
        {
            get
            {
                if (destino == null)
                    destino = new EntDestino();
                return destino;
            }
            set
            {
                if (destino == null)
                    destino = new EntDestino();
                destino = value;
            }
        }
        private EntCategoria categoria;
        public EntCategoria Categoria
        {
            get
            {
                if (categoria == null)
                    categoria = new EntCategoria();
                return categoria;
            }
            set
            {
                if (categoria == null)
                    categoria = new EntCategoria();
                categoria = value;
            }
        }
    }
}
