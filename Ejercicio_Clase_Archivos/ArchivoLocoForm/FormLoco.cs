using System;
using System.IO;
using System.Windows.Forms;
using Entidades;

namespace ArchivoLocoForm
{
    public partial class FormLoco : Form
    {
        private const string EXTENSION_VALIDA = ".txt";

        public FormLoco()
        {
            InitializeComponent();
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
            
            
          Archivador.GuardarTexto(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), false, "ARCHIVO", richTextBoxTexto.Text);
            richTextBoxTexto.Clear();
        
        }

        private void ButtonLeer_Click(object sender, EventArgs e)
        {
            
            
            string fileName = openFileDialog2.FileName;
            if(openFileDialog2.ShowDialog()== DialogResult.OK)
            {
                richTextBoxTexto.Text = Archivador.LeeArchivo(fileName);
            }
            
                    
             
            
        }
    }
}
