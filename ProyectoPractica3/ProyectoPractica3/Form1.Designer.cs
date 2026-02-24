namespace ProyectoPractica3
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
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btntabla = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumero.Location = new System.Drawing.Point(12, 22);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(156, 26);
            this.txtnumero.TabIndex = 0;
            // 
            // btntabla
            // 
            this.btntabla.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntabla.Location = new System.Drawing.Point(185, 18);
            this.btntabla.Name = "btntabla";
            this.btntabla.Size = new System.Drawing.Size(75, 33);
            this.btntabla.TabIndex = 1;
            this.btntabla.Text = "Ver Tabla";
            this.btntabla.UseVisualStyleBackColor = true;
            this.btntabla.Click += new System.EventHandler(this.btntabla_Click);
            // 
            // tabla
            // 
            this.tabla.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabla.FormattingEnabled = true;
            this.tabla.ItemHeight = 20;
            this.tabla.Location = new System.Drawing.Point(12, 54);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(156, 244);
            this.tabla.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(369, 340);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.btntabla);
            this.Controls.Add(this.txtnumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btntabla;
        private System.Windows.Forms.ListBox tabla;
    }
}

