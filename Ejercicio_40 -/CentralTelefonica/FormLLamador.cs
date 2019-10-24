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
      

   
        private void DiscadorOnClick(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button boton = (Button)sender;
               
                this.txtFoco.Text += boton.Text;
                //this.txtNroOrigen.Text += boton.Text;
              
                
            }
        }
       
        private void TxtNroDestino_Click(object sender, EventArgs e)
        {
             txtFoco = txtNroDestino;
             txtNroDestino.Text = ""; 
            
        
        }

        private void TxtNroOrigen_Click(object sender, EventArgs e)
        {
            txtFoco = txtNroOrigen;
            txtNroOrigen.Text = "";
        }

        private void ButtonLlamar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            float duracion = random.Next(1, 50);
            string mensaje = string.Empty;
            Llamada llamada;
            if (txtNroDestino.Text != "Nro Destino" && txtNroOrigen.Text != "Nro Origen")
            {
                if (txtNroDestino.Text.StartsWith("#"))
                {
                    cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                    Provincial.Franja franja;
                    Enum.TryParse(cmbFranja.SelectedValue.ToString(), out franja);
                    llamada = new Provincial(franja,txtNroOrigen.Text, duracion, txtNroDestino.Text);

                }
                else
                {
                    cmbFranja.Enabled = false;
                    float costo = (float)((random.Next(50, 56)) / 100);
                    llamada = new Local(txtNroOrigen.Text, duracion, txtNroDestino.Text, costo);
                }
                miniCentral.Llamadas.Add(llamada);
                mensaje = "Llamada creada exitosamente!";
                ButtonLimpiar_Click(sender, e);
            }
            else
            {
                mensaje = "Debe cargar numero origen y destino";
            }
            MessageBox.Show(mensaje);

        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "Nro Destino";
            txtNroOrigen.Text = "Nro Origen";
        }

      



        /*private void ButtonAsterisco_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("*");
        }*/

        /* private void ButtonNumeral_Click(object sender, EventArgs e)
    {
        LimpiarOConcatenar("#");
    }*/

        /* private void LimpiarOConcatenar(string valor)
         {
             if (txtFoco.Text == "Nro Destino" || txtFoco.Text == "Nro Origen")
             {
                 txtFoco.Text = valor;
             }
             else
             {
                 txtFoco.Text += valor;
             }
         }*/
        /* private void Button7_Click(object sender, EventArgs e)
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
         */
        /*private void Button0_Click(object sender, EventArgs e)
        {
            LimpiarOConcatenar("0");

        }*/
    }
}
