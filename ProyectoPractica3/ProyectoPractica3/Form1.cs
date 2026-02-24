using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPractica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btntabla_Click(object sender, EventArgs e)
        {
            tabla.Items.Clear();

            int numero = int.Parse(txtnumero.Text);

            if (int.TryParse(txtnumero.Text, out numero))
            { 
                for (int i = 1; i <= 12; i++)
                {
                int resultado = numero * i;
                tabla.Items.Add(numero + " x " + i + " = " + (numero * i));
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }

        }
    }
}
