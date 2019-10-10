using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    class Comiqueria
    {
        private List<Producto> productos;
        private List<Venta> ventas;

        public Producto this[Guid codigo]
        {
            get
            {
                foreach (Producto aux in productos)
                {
                    if ((Guid)aux == codigo)
                    {
                        return aux;
                    }
                }
                return null;
            }
        }

        public Comiqueria()
        {
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();

        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> retorno = new Dictionary<Guid, string>();
            foreach (Producto p in productos)
            {
                retorno.Add((Guid)p, p.Descripcion);
            }
            return retorno;
        }

        public string ListarVentas()
        {
            StringBuilder retorno = new StringBuilder();
            ventas.Sort(OrdenarPorFecha);
            foreach (Venta v in this.ventas)
            {
                retorno.AppendLine(v.ObtenerDescripcionBreve());
            }
            return retorno.ToString();


        }



    }
}
