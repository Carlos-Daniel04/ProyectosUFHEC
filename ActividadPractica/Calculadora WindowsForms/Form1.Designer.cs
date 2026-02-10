namespace Calculadora_WindowsForms
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
            this.txtpantalla = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.multiplicar = new System.Windows.Forms.Button();
            this.restar = new System.Windows.Forms.Button();
            this.igualresultado = new System.Windows.Forms.Button();
            this.sumar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpantalla
            // 
            this.txtpantalla.Location = new System.Drawing.Point(13, 67);
            this.txtpantalla.Margin = new System.Windows.Forms.Padding(4);
            this.txtpantalla.Name = "txtpantalla";
            this.txtpantalla.Size = new System.Drawing.Size(230, 22);
            this.txtpantalla.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(131, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 139);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 139);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(131, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 168);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(72, 168);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 23);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(131, 168);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(72, 197);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(53, 23);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // dividir
            // 
            this.dividir.Location = new System.Drawing.Point(190, 110);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(53, 23);
            this.dividir.TabIndex = 11;
            this.dividir.Text = "÷";
            this.dividir.UseVisualStyleBackColor = true;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // multiplicar
            // 
            this.multiplicar.Location = new System.Drawing.Point(190, 139);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(53, 23);
            this.multiplicar.TabIndex = 12;
            this.multiplicar.Text = "x";
            this.multiplicar.UseVisualStyleBackColor = true;
            this.multiplicar.Click += new System.EventHandler(this.multiplicar_Click);
            // 
            // restar
            // 
            this.restar.Location = new System.Drawing.Point(190, 168);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(53, 23);
            this.restar.TabIndex = 13;
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = true;
            this.restar.Click += new System.EventHandler(this.restar_Click);
            // 
            // igualresultado
            // 
            this.igualresultado.Location = new System.Drawing.Point(131, 197);
            this.igualresultado.Name = "igualresultado";
            this.igualresultado.Size = new System.Drawing.Size(53, 23);
            this.igualresultado.TabIndex = 14;
            this.igualresultado.Text = "=";
            this.igualresultado.UseVisualStyleBackColor = true;
            this.igualresultado.Click += new System.EventHandler(this.igualresultado_Click);
            // 
            // sumar
            // 
            this.sumar.Location = new System.Drawing.Point(190, 197);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(53, 23);
            this.sumar.TabIndex = 15;
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = true;
            this.sumar.Click += new System.EventHandler(this.sumar_Click);
            // 
            // borrar
            // 
            this.borrar.ForeColor = System.Drawing.Color.Red;
            this.borrar.Location = new System.Drawing.Point(12, 197);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(53, 23);
            this.borrar.TabIndex = 16;
            this.borrar.Text = "C";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(261, 267);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.igualresultado);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpantalla);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpantalla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button multiplicar;
        private System.Windows.Forms.Button restar;
        private System.Windows.Forms.Button igualresultado;
        private System.Windows.Forms.Button sumar;
        private System.Windows.Forms.Button borrar;
    }
}

