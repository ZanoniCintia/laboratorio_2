using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        
        public Estante(int capacidad, int ubicacion):this(cantidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public static string MostrarEstante(Estante estante)
        {
            string retorno = string.Empty;
            retorno += String.Format("Estante. Ubicación: {0}\n", estante.ubicacionEstante);
            retorno += "\nProductos: \n";

            foreach (Producto producto in estante.GetProductos())
            {
                if (!(producto is null))
                {
                    retorno += Producto.MostrarProducto(producto) + "\n";
                }
            }

            return retorno;
        }
        public static bool operator ==(Estante e,)
    }
}
