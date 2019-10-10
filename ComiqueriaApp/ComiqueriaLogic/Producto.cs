﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private string descripcion;
        private double precio;
        private int stock;

        #region Propiedades

        public string Descripcion
        {
            get { return descripcion; }
            
        }

        public static explicit operator Guid(Producto v)
        {
            throw new NotImplementedException();
        }

        public double Precio
        {
            get { return Precio; }
            
        }


        public int Stock
        {
            get { return stock; }

            set
            {
                if (stock >= 0)
                {
                    stock = value;
                }
            }

        }


        #endregion

            #region Metodos

        protected Producto(string descripcion,int stock,double precio)
        {
            this.codigo = Guid.NewGuid();
            this.stock = stock;
            this.precio = precio;
            this.descripcion = descripcion;


        }
        public string toString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendFormat("Descripcion : {0} \n",descripcion);
            sb.AppendFormat("Codigo : {0} \n", codigo);
            sb.AppendFormat("Precio :{0} \n", precio);
            sb.AppendFormat("Stock : {0} \n", stock);


            return sb.ToString();
        }
        #endregion



    }
}
