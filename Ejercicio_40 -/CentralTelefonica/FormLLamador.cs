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


namespace CentralTelefonica
{
    public partial class FormLLamador : Form
    {
        Centralita miniCentral;
        TextBox txtFoco = new TextBox();

        public Centralita MiniCentral
        {
            get
            {
                return miniCentral;
            }
        }
        public FormLLamador(Centralita centralita)
        {
            InitializeComponent();
            miniCentral = centralita;
        }

 

        private void ButtonAsterisco_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("*");
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void TxtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (txtNroDestino.Text.StartsWith("#"))
            {
                cmbFranja.Enabled = true;
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }

        private void ButtonNumeral_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("#");
        }

        private void LimpiarOConcatenar(string valor)
        {
            if (txtFoco.Text == "Nro Destino" || txtFoco.Text == "Nro Origen")
            {
                txtFoco.Text = valor;
            }
            else
            {
                txtFoco.Text += valor;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("7");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("8");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("9");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("4");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("5");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("6");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("1");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("2");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("3");
        }

        private void FormLLamador_Load(object sender, EventArgs e)
        {

        }

        private void TxtNroDestino_Click(object sender, EventArgs e)
        {
            txtFoco = txtNroDestino;
        }

        private void TxtNroOrigen_Click(object sender, EventArgs e)
        {
            txtFoco = txtNroOrigen;
        }

        private void ButtonLlamar_Click(object sender, EventArgs e)
        {
            Random aux = new Random();
            float duracion = (float)aux.Next(1, 50);
            Llamada llamada;
            if (txtNroDestino.Text.StartsWith("#"))
            {
                Provincial.Franja franja;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franja);
                llamada = new Provincial(franja, txtNroOrigen.Text, duracion, txtNroDestino.Text);
            }
            else
            {
                float costo = (aux.Next(50, 60) / 100) * duracion;
                llamada = new Local(txtNroOrigen.Text, duracion, txtNroDestino.Text, costo);
            }
            miniCentral.Llamadas.Add(llamada);
        }
    }
}
