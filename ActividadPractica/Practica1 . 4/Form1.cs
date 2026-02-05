using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int num1 = int.Parse(TexNumero1.Text);
            int num2 = int.Parse(TexNumero2.Text);
            int suma = num1 + num2;
            Resultado.Text = "El resultado es:  " + suma;


        }
    }
}
