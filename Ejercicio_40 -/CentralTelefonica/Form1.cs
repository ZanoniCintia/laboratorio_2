using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentralTelefonica
{
    public partial class FormMostrar : Form
    {
        public FormMostrar()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
