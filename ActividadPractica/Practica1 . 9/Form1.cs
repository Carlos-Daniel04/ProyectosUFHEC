using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero;
            if (int.TryParse(txtnumero.Text, out numero))
            {
                MessageBox.Show("El número es: " + numero);
            }
            else
            {
                MessageBox.Show("ERROR Por favor, ingrese un número.");
            }
        }
    }
}
