using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            double celsius;
            if (double.TryParse(txtcelsius.Text, out celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                lblresultado.Text = "Resultado: " + fahrenheit + " °F";
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor numérico válido para Celsius.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
