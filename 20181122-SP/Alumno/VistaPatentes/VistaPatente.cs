using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Entidades;

namespace Patentes
{
    public partial class VistaPatente : UserControl
    {        
        public VistaPatente()
        {
            InitializeComponent();

            picPatente.Image = fondosPatente.Images[(int)Patente.Tipo.Mercosur];
        }

        public void MostrarPatente(object patente)
        {
            if (lblPatenteNro.InvokeRequired)
            {
                try
                {
                    Random r = new Random();
                    MostrarPatente m = new MostrarPatente(this.MostrarPatente);
                    object[] obj = new object[] { patente };
                    this.lblPatenteNro.Invoke(m, patente);
                    Thread.Sleep(r.Next(2000, 5000));

                    
                    FinExposicion.Invoke(this);
                    
                }
                catch (Exception) { }
            }
            else
            {
                picPatente.Image = fondosPatente.Images[(int)((Patente)patente).TipoCodigo];
                lblPatenteNro.Text = patente.ToString();
            }
        }

        private void lblPatenteNro_Click(object sender, EventArgs e)
        {

        }

    public event FinExposicionPatente FinExposicion;
    }

    public delegate void FinExposicionPatente(VistaPatente vp);
    public delegate void MostrarPatente(object patente);
    
}
