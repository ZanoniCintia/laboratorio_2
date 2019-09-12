using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Billetes
{
    public class Dolar
    {
        private static double cotizarRespectoDolar;
        public double cantidad;

        static Dolar()
        {
            Dolar.cotizarRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;

        }
        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizarRespectoDolar = cotizacion;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizarRespectoDolar;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region Conversiones
        public static implicit operator Dolar(double d)
        {
            Dolar aux = new Dolar(d);
            return aux;
        }
        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());

        }
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }
        #endregion

        #region Operaciones
        public static  Dolar operator +(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.cantidad + ((Dolar)p).cantidad);
            return aux;
        }
        public static Dolar operator +(Dolar d,Euro e)
        {
            Dolar aux = new Dolar(d.cantidad + ((Dolar)e).cantidad);
            return aux;
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar aux = new Dolar(d.cantidad - ((Dolar)p).cantidad);
            return aux;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar aux = new Dolar(d.cantidad - ((Dolar)e).cantidad);
            return aux;
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Dolar d1,Dolar d2)
        {
            return d1.cantidad == d2.cantidad;

        }
        public static bool operator !=(Dolar d1,Dolar d2)
        {
            return !(d1 == d2);
        }
        public static bool operator ==(Dolar d,Pesos p)
        {
            return d.cantidad == p.cantidad;
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == e.cantidad;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        #endregion
    }


}
