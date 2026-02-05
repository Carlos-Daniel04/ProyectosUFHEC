namespace ActividadPractictica
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
            this.NomYMatri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomYMatri
            // 
            this.NomYMatri.AutoSize = true;
            this.NomYMatri.BackColor = System.Drawing.SystemColors.ControlText;
            this.NomYMatri.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomYMatri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NomYMatri.Location = new System.Drawing.Point(266, 169);
            this.NomYMatri.Name = "NomYMatri";
            this.NomYMatri.Size = new System.Drawing.Size(294, 23);
            this.NomYMatri.TabIndex = 0;
            this.NomYMatri.Text = "Bienvenido al formulario de Carlos Daniel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NomYMatri);
            this.Name = "Form1";
            this.Text = "SS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomYMatri;
    }
}

