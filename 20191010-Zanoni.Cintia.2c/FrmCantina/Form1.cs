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

namespace FrmCantina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            comboBox1.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            int capacidad = (int)numCapacidad.Value;
            int contenido = (int)numContenido.Value;
            Botella botella;
            string marca = txtMarca.Text;
            if (btnCerveza.Checked)
            {
                Botella.Tipo tipo;
                Enum.TryParse<Botella.Tipo>(comboBox1.SelectedValue.ToString(), out tipo);
                botella = new Cerveza(capacidad, marca, tipo, capacidad);
            }else
            {
                botella = new Agua(marca, capacidad, contenido);
            }
            if(botella is Agua)
            {
                barra1.AgregarBotella((Agua)botella);
            }else if (botella is Cerveza)
            {
                barra1.AgregarBotella((Cerveza)botella);
            }
            

        }
    }
}
