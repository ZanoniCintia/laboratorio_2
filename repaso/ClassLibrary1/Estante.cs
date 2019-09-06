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
        
        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public static string MostrarEstante(Estante estante)
        {
           
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Estante. Ubicación: {0}\n", estante.ubicacionEstante);
            sb.AppendLine("Productos:");

            foreach (Producto producto in estante.GetProductos())
            {
                if (!(producto is null))
                {
                    sb.AppendLine(Producto.MostrarProducto(producto));

                }
            }

            return sb.ToString();
        }
        //Igualdad, retornará true, si es que el producto ya se encuentra en el estante,
        //false, caso contrario
        public static bool operator ==(Estante e,Producto p)
        {
            foreach (Producto producto in e.GetProductos())
            {
                if (!(producto is null) && producto == p)
                {
                    return true;
                }
            }

            return false;
        }

        //se fija si no se encuentra en el estante
        public static bool operator !=(Estante e,Producto p)
        {
            return !(e == p);

        }

        //Adición, retornará true y agregará el producto si el estante posee capacidad 
        //de almacenar al menos un producto más y dicho producto no se encuentra en él;
        // false, caso contrario.Reutilizar código
        public static bool operator +(Estante e,Producto p)
        {
            bool retorno = false;

            // Si no se encuentra en el estante
            if (e != p)
            {
                Producto[] productos = e.GetProductos();

                for (int i = 0; i < e.GetProductos().Length; i++)
                {
                    // Si es null queda espacio.
                    if (productos[i] is null)
                    {
                        productos[i] = p;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        //Sustracción (Estante, Producto), retornará un estante sin el producto, siempre y cuando
        //el producto se encuentre en el listado.Reutilizar código
        public static Estante operator -(Estante e, Producto p)
        {
            if(e==p)
            {
                Producto[] productos = e.GetProductos();

                for(int i=0;i<e.GetProductos().Length;i++)
                {
                    if(productos[i]==p)
                    {
                        productos[i] = null;
                    }
                }


            }
            return e;
        }
    }
}
