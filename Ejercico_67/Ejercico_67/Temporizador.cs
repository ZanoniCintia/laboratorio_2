using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades_67
{
    public sealed  class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get
            {
                bool retorno = false;
                if(!(hilo is null) && this.hilo.IsAlive)
                {
                    retorno = true;
                    
                }

                return retorno;
            }
            set
            {   
                if((Activo == false) && (value== true))
                {
                    Thread hilo = new Thread(Corriendo);
                    hilo.Start();
                }
                else if((Activo == true) && (value == false))
                {
                    hilo.Abort();
                }
                
            }
        }

        private void Corriendo()
        {
            while (true)
            {
                Thread.Sleep(250);
                if(this.EventoTiempo != null)
                {
                    EventoTiempo.Invoke();
                }
            }
        }

        public event EncargadoTiempo EventoTiempo;
        


        public int Intervalo
        {
            get { return this.intervalo; }
            set { intervalo = value; }
        }



        public delegate void EncargadoTiempo();
    }
}
