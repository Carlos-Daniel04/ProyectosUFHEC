namespace Practica_1._14
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
            this.Pestaña = new System.Windows.Forms.TabControl();
            this.tabpagina = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.Pestaña.SuspendLayout();
            this.tabpagina.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pestaña
            // 
            this.Pestaña.AccessibleName = "";
            this.Pestaña.Controls.Add(this.tabpagina);
            this.Pestaña.Controls.Add(this.tabPage2);
            this.Pestaña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pestaña.Location = new System.Drawing.Point(12, 12);
            this.Pestaña.Name = "Pestaña";
            this.Pestaña.SelectedIndex = 0;
            this.Pestaña.Size = new System.Drawing.Size(337, 256);
            this.Pestaña.TabIndex = 0;
            // 
            // tabpagina
            // 
            this.tabpagina.Controls.Add(this.lbl1);
            this.tabpagina.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabpagina.Location = new System.Drawing.Point(4, 28);
            this.tabpagina.Name = "tabpagina";
            this.tabpagina.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagina.Size = new System.Drawing.Size(329, 224);
            this.tabpagina.TabIndex = 0;
            this.tabpagina.Text = "Pestaña 1";
            this.tabpagina.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.lbl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(329, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pestaña 2";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(24, 98);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(247, 23);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Esta es la primera pestaña";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2.Location = new System.Drawing.Point(60, 103);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(218, 19);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Esta es la segunda pestaña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(349, 269);
            this.Controls.Add(this.Pestaña);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Pestaña.ResumeLayout(false);
            this.tabpagina.ResumeLayout(false);
            this.tabpagina.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Pestaña;
        private System.Windows.Forms.TabPage tabpagina;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

