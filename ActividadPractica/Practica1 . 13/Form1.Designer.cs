namespace Practica1._13
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
            this.components = new System.ComponentModel.Container();
            this.barra = new System.Windows.Forms.ProgressBar();
            this.iniciar = new System.Windows.Forms.Button();
            this.parar = new System.Windows.Forms.Button();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.Location = new System.Drawing.Point(12, 120);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(201, 23);
            this.barra.TabIndex = 0;
            // 
            // iniciar
            // 
            this.iniciar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.Location = new System.Drawing.Point(12, 68);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(91, 32);
            this.iniciar.TabIndex = 1;
            this.iniciar.Text = "Llenar ";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // parar
            // 
            this.parar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parar.Location = new System.Drawing.Point(122, 68);
            this.parar.Name = "parar";
            this.parar.Size = new System.Drawing.Size(91, 32);
            this.parar.TabIndex = 2;
            this.parar.Text = "Parar";
            this.parar.UseVisualStyleBackColor = true;
            this.parar.Click += new System.EventHandler(this.parar_Click);
            // 
            // tiempo
            // 
            this.tiempo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(291, 241);
            this.Controls.Add(this.parar);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.barra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar barra;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Button parar;
        private System.Windows.Forms.Timer tiempo;
    }
}

