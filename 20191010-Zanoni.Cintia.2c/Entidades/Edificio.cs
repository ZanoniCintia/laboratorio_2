using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Edificio
    {
        private Cantina[] cantinas;
        private const short limiteCantinas = 2;
        private static Edificio singleton;

        private Edificio()
        {
            this.cantinas = new  Cantina[limiteCantinas];
        }

        static Edificio()
        {
            singleton = null;
        }

        public Edificio GetBar()
        {
            return singleton;
        }

        private static bool operator +(Edificio e, Cantina c)
        {
            bool retorno = false;
            for(int i=0; i< e.cantinas.Length; i++)
            {
                if()
            }

            return retorno;
        }

    }
}
