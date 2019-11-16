using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Archivos;
using System.Threading;
using Patentes;


namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> auxList;
        
        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.auxList = new List<Thread>();
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.MostrarPatente(sender);
            vistaPatente2.MostrarPatente(sender);
            


        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {

        }

        private void btnTxt_Click(object sender, EventArgs e)
        {

        }

        private void btnSql_Click(object sender, EventArgs e)
        {

        }

        private void FinalizarSimulacion()
        {
            foreach(Thread L in auxList)
            {
                if(!(L is null) && L.IsAlive)
                {
                    L.Abort();
                }
            }
        }

        public void ProximaPatente()
        {
            foreach(Patente p in cola)
            {
                Thread hilo = new Thread(vistaPatente1.MostrarPatente);
                Thread hilo2 = new Thread(vistaPatente2.MostrarPatente);

                hilo.Start(p);
                hilo2.Start(p);

                auxList.Add(hilo);
                auxList.Add(hilo2);
            }
                
        }

        
    }
    public delegate Patentes.FinExposicionPatente ProximaPatente();
}
