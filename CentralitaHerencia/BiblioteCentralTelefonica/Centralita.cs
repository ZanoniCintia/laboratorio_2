﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioteCentralTelefonica
{
    public class Centralita
    {
        #region Fields
        private List<Llamada> listaLLamada;
        private string razonSocial;
        #endregion

        #region Properties
        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaLLamada;
            }
        }
        #endregion

        #region Methods

        public Centralita()
        {
            this.listaLLamada = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float auxGanancias = 0;

            foreach (Llamada llamada in listaLLamada)
            {
                if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas && llamada is Local)
                {
                    auxGanancias = auxGanancias + ((Local)llamada).CostoLLamada;
                }
                else if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas && llamada is Provincial)
                {
                    auxGanancias= auxGanancias + ((Provincial)llamada).CostoLlamada;
                }
            }
            return auxGanancias;
        }
        
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            string aux = "";
            sb.AppendLine("Razon social: " + this.razonSocial);
            sb.AppendLine("Ganancia total: " + GananciasPorTotal);
            foreach (Llamada llamada in listaLLamada)
            {
                if (llamada is Local)
                {
                    aux = ((Local)llamada).Mostrar();
                }
                else if (llamada is Provincial)
                {
                    aux = ((Provincial)llamada).Mostrar();
                }
                sb.AppendLine(aux);
            }
            return sb.ToString();
        }
         public void OrdenarLlamadas()
        {
            this.listaLLamada.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion
    }
}
