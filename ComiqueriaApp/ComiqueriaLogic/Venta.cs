using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        #region Campos
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        #endregion

        #region Propiedades

        internal DateTime Fecha
        {
            get { return fecha; }
           //en vender va dateTime.now 
        }

        #endregion

        static Venta()
        {
           Venta.porcentajeIva = 21;
        }

        public static double CalcularPrecioFinal(double precioUnidad,int cantidad)
        {
            double precioFinal = ((precioUnidad*cantidad)*porcentajeIva)/100;

            return precioFinal;
        }
        public string ObtenerDescripcionBreve()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Fecha :{0}  – Descripción:{1} – PrecioFinal :{2}",this.fecha,producto.Descripcion,this.precioFinal);
            return sb.ToString();
        }

        private void Vender (int cantidad)
        {
            cantidad = producto.Stock - cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);

        }
        internal Venta(Producto producto,int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }
    }
}
