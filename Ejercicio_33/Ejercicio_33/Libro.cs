using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_33
{
    class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }
        public string this[int i]
        {
            get
            {
                ;
                if (i >= 0 && i < this.paginas.Count)
                {
                    return this.paginas[i];
                }
                else
                {
                    return string.Empty;
                }

            }
            set
            {
                if (paginas.Count == i && i > this.paginas.Count)
                {
                    this.paginas[i] = value;
                }
                else
                {
                    this.paginas.Add(value);
                }
            }

        }
    }
}
