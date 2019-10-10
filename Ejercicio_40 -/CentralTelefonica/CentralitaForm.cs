using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioteCentralTelefonica;
using CentralTelefonica;

namespace CentralitaForm
{
    public partial class Central : Form
    {
        Centralita centralita = new Centralita("Cin Center");
        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }

        }
        public Central (Centralita center) : this()
        {
            this.centralita = center;
        }
        private static Centralita SimularCentral()
        {
            // Mi central 
            Centralita c = new Centralita("Cin Center");
            // Mis 4 llamadas 
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial(Provincial.Franja.Franja_1, "Morón", 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);
            c += l1;
            c += l2;
            c += l3;
            c += l4;

            return c;
        }

        private void Central_Load(object sender, EventArgs e)
        {
            centralita = SimularCentral();
        }

        public Central()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form llamador = new FormLLamador(centralita);
            llamador.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            string aux = "No se han hecho llamadas";
            if (centralita.Llamadas.Count > 0)
            {
                aux = centralita.Mostrar();
            }
            MessageBox.Show(aux);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string aux = string.Empty;
            foreach (Llamada call in Centralita.Llamadas)
            {
                if (call is Local)
                {
                    aux += call.ToString() + "\n";
                }
            }
            if (string.IsNullOrEmpty(aux))
            {
                aux = "Aun no se han hecho llamadas locales";

            }
            MessageBox.Show(aux);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string aux = "";
            foreach (Llamada call in Centralita.Llamadas)
            {
                if (call is Provincial)
                {
                    aux += call.ToString() + "\n";
                }
            }
            if (aux == "")
            {
                aux = "Aun no se han hecho llamadas provinciales";

            }
            MessageBox.Show(aux);
        }
    }
}
