namespace Practica1._05
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
            this.rabtnHombre = new System.Windows.Forms.RadioButton();
            this.rabtnMujer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.respuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rabtnHombre
            // 
            this.rabtnHombre.AutoSize = true;
            this.rabtnHombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtnHombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rabtnHombre.Location = new System.Drawing.Point(286, 174);
            this.rabtnHombre.Name = "rabtnHombre";
            this.rabtnHombre.Size = new System.Drawing.Size(82, 22);
            this.rabtnHombre.TabIndex = 0;
            this.rabtnHombre.TabStop = true;
            this.rabtnHombre.Text = "Hombre";
            this.rabtnHombre.UseVisualStyleBackColor = true;
            // 
            // rabtnMujer
            // 
            this.rabtnMujer.AutoSize = true;
            this.rabtnMujer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabtnMujer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rabtnMujer.Location = new System.Drawing.Point(286, 202);
            this.rabtnMujer.Name = "rabtnMujer";
            this.rabtnMujer.Size = new System.Drawing.Size(67, 22);
            this.rabtnMujer.TabIndex = 1;
            this.rabtnMujer.TabStop = true;
            this.rabtnMujer.Text = "Mujer";
            this.rabtnMujer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(282, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Que sexo eres?";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(264, 275);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(124, 37);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Acaeptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.respuesta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.respuesta.Location = new System.Drawing.Point(260, 250);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(0, 22);
            this.respuesta.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.respuesta);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rabtnMujer);
            this.Controls.Add(this.rabtnHombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rabtnHombre;
        private System.Windows.Forms.RadioButton rabtnMujer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label respuesta;
    }
}

