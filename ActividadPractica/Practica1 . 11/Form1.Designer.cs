namespace Practica1._11
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
            this.btnmostar = new System.Windows.Forms.Button();
            this.lblver = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmostar
            // 
            this.btnmostar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostar.Location = new System.Drawing.Point(12, 136);
            this.btnmostar.Name = "btnmostar";
            this.btnmostar.Size = new System.Drawing.Size(97, 43);
            this.btnmostar.TabIndex = 0;
            this.btnmostar.Text = "Ver";
            this.btnmostar.UseVisualStyleBackColor = true;
            this.btnmostar.Click += new System.EventHandler(this.btnmostar_Click);
            // 
            // lblver
            // 
            this.lblver.AutoSize = true;
            this.lblver.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblver.Location = new System.Drawing.Point(115, 151);
            this.lblver.Name = "lblver";
            this.lblver.Size = new System.Drawing.Size(0, 16);
            this.lblver.TabIndex = 1;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfecha.Location = new System.Drawing.Point(12, 110);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(255, 21);
            this.dtpfecha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(83, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Calendario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(402, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.lblver);
            this.Controls.Add(this.btnmostar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmostar;
        private System.Windows.Forms.Label lblver;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.Label label2;
    }
}

