namespace WindowsApp
{
    partial class Form1
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
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.btnCrearClienteInd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Location = new System.Drawing.Point(111, 74);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(144, 23);
            this.btnCrearProducto.TabIndex = 0;
            this.btnCrearProducto.Text = "Crear un Producto";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnCrearClienteInd
            // 
            this.btnCrearClienteInd.Location = new System.Drawing.Point(107, 156);
            this.btnCrearClienteInd.Name = "btnCrearClienteInd";
            this.btnCrearClienteInd.Size = new System.Drawing.Size(148, 23);
            this.btnCrearClienteInd.TabIndex = 1;
            this.btnCrearClienteInd.Text = "Crear un Cliente (Individuo)";
            this.btnCrearClienteInd.UseVisualStyleBackColor = true;
            this.btnCrearClienteInd.Click += new System.EventHandler(this.btnCrearClienteInd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 258);
            this.Controls.Add(this.btnCrearClienteInd);
            this.Controls.Add(this.btnCrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnCrearClienteInd;
    }
}

