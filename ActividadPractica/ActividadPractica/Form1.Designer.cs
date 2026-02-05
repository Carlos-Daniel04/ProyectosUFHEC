namespace ActividadPractica
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
            this.NomYMatric = new System.Windows.Forms.Label();
            this.CambLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NomYMatric
            // 
            this.NomYMatric.AutoSize = true;
            this.NomYMatric.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NomYMatric.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomYMatric.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NomYMatric.Location = new System.Drawing.Point(12, 89);
            this.NomYMatric.Name = "NomYMatric";
            this.NomYMatric.Size = new System.Drawing.Size(838, 20);
            this.NomYMatric.TabIndex = 0;
            this.NomYMatric.Text = "Bienvenido a mi formulario WindowsForms mi nombre es Carlos Daniel y mi matricula" +
    " es LR-2025-03111";
            // 
            // CambLabel
            // 
            this.CambLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambLabel.Location = new System.Drawing.Point(345, 210);
            this.CambLabel.Name = "CambLabel";
            this.CambLabel.Size = new System.Drawing.Size(179, 57);
            this.CambLabel.TabIndex = 1;
            this.CambLabel.Text = "Cambiar";
            this.CambLabel.UseVisualStyleBackColor = true;
            this.CambLabel.Click += new System.EventHandler(this.CambLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(887, 422);
            this.Controls.Add(this.CambLabel);
            this.Controls.Add(this.NomYMatric);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomYMatric;
        private System.Windows.Forms.Button CambLabel;
    }
}

