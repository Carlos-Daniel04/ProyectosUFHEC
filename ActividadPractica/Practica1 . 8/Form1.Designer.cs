namespace Practica1._8
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
            this.btncontar = new System.Windows.Forms.Button();
            this.textcontado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncontar
            // 
            this.btncontar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontar.Location = new System.Drawing.Point(76, 199);
            this.btncontar.Name = "btncontar";
            this.btncontar.Size = new System.Drawing.Size(128, 42);
            this.btncontar.TabIndex = 0;
            this.btncontar.Text = "Contar";
            this.btncontar.UseVisualStyleBackColor = true;
            this.btncontar.Click += new System.EventHandler(this.btncontar_Click);
            // 
            // textcontado
            // 
            this.textcontado.AutoSize = true;
            this.textcontado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textcontado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcontado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textcontado.Location = new System.Drawing.Point(107, 157);
            this.textcontado.Name = "textcontado";
            this.textcontado.Size = new System.Drawing.Size(0, 22);
            this.textcontado.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(387, 371);
            this.Controls.Add(this.textcontado);
            this.Controls.Add(this.btncontar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncontar;
        private System.Windows.Forms.Label textcontado;
    }
}

