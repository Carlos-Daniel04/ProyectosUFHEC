using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_WindowsForms
{
    public partial class Form1 : Form
    {
        int num = 0;
        string operador = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            txtpantalla.Text = txtpantalla.Text += bnt.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            txtpantalla.Text = txtpantalla.Text += bnt.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            txtpantalla.Text = txtpantalla.Text += bnt.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            txtpantalla.Text = txtpantalla.Text += bnt.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            txtpantalla.Text = txtpantalla.Text += bnt.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            txtpantalla.Text = txtpantalla.Text += bnt.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            txtpantalla.Text = txtpantalla.Text += bnt.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            txtpantalla.Text = txtpantalla.Text += bnt.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            txtpantalla.Text = txtpantalla.Text += bnt.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button bnt = (Button)sender;
            txtpantalla.Text = txtpantalla.Text += bnt.Text;
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtpantalla.Text);
            operador = "+";
            txtpantalla.Clear();
        }

        private void restar_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtpantalla.Text);
            operador = "-";
            txtpantalla.Clear();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtpantalla.Text);
            operador = "x";
            txtpantalla.Clear();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            num = int.Parse(txtpantalla.Text);
            operador = "/";
            txtpantalla.Clear();
        }

        private void igualresultado_Click(object sender, EventArgs e)
        {
            double num2 = double.Parse(txtpantalla.Text);
            double resultado = 0;
            switch (operador)
            {
                case "+":
                    resultado = num + num2;
                    break;
                case "-":
                    resultado = num - num2;
                    break;
                case "x":
                    resultado = num * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre cero");
                        return;
                    }
                    resultado = num / num2;
                    break;
            }
            txtpantalla.Text = resultado.ToString();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            txtpantalla.Clear();
            num = 0;
            operador = "";
        }
    }
}
