namespace ArchivoLocoForm
{
    partial class FormLoco
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxTexto = new System.Windows.Forms.RichTextBox();
            this.labelTexto = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonLeer = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // richTextBoxTexto
            // 
            this.richTextBoxTexto.Location = new System.Drawing.Point(26, 44);
            this.richTextBoxTexto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richTextBoxTexto.Name = "richTextBoxTexto";
            this.richTextBoxTexto.Size = new System.Drawing.Size(552, 271);
            this.richTextBoxTexto.TabIndex = 0;
            this.richTextBoxTexto.Text = "";
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(26, 8);
            this.labelTexto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(172, 25);
            this.labelTexto.TabIndex = 1;
            this.labelTexto.Text = "Ingrese un texto:";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(270, 331);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(150, 44);
            this.buttonGuardar.TabIndex = 2;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.ButtonGuardar_Click);
            // 
            // buttonLeer
            // 
            this.buttonLeer.Location = new System.Drawing.Point(432, 331);
            this.buttonLeer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonLeer.Name = "buttonLeer";
            this.buttonLeer.Size = new System.Drawing.Size(150, 44);
            this.buttonLeer.TabIndex = 4;
            this.buttonLeer.Text = "Leer";
            this.buttonLeer.UseVisualStyleBackColor = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // FormLoco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 404);
            this.Controls.Add(this.buttonLeer);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.richTextBoxTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormLoco";
            this.Text = "Clase Archivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxTexto;
        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonLeer;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

