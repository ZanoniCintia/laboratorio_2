using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Producto
    {
        #region Atributo
        private string codigoDeBarra;
        private string marca;
        private float precio;
        #endregion 

        private Producto(string marca,string codigoDeBarra,float precio)
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

    }
}
