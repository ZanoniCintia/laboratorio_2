using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;
        #region Atributo
        private string codigoDeBarra;
        private string marca;
        private float precio;
        #endregion 

        public Producto(string marca,string codigoDeBarra,float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigoDeBarra;
            this.precio = precio;

        }
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            string mostrar = string.Empty;

            mostrar += string.Format("Marca: {0}\n", p.marca);
            mostrar += string.Format("Codigo de Barras : {0}\n", p.codigoDeBarra);
            mostrar += string.Format("precio :{0}\n", p.precio);

            return mostrar;


        }
        //retorna el codigo de barras
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        //compara si son iguales los productos por codigo de barras y marca
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca);
        }
        //compara si la marca ingresada por parametro es la misma del producto
        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }
        //compara si producto 1 es igual al 2 , si no son iguales retorna true .
        public static bool operator !=(Producto p1,Producto p2)
        {
            return !(p1 == p2);
        }
        //compara si el producto y la marca son iguales , retorna true si no son iguales
        public static bool operator !=(Producto p,string marca)
        {
            return !(p == marca);
        }
      
    }
}
