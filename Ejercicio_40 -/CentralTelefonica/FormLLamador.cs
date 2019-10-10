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
        Centralita llamada;
        TextBox txtFoco = new TextBox();

        public Centralita Llamada
        {
            get
            {
                return llamada;
            }
        }
        public FormLLamador()
        {
            InitializeComponent();
        }

        public FormLLamador(Centralita centralita)
        {
        }

        private void ButtonAsterisco_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("*");
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            //Form aux = new (llamada);
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
    }
}
