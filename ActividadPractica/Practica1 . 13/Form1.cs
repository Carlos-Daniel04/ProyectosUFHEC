using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (barra.Value < 100)
            {
                barra.Value++;
                
            }
            else
            {
                tiempo.Stop();
                MessageBox.Show("Carga completa");
            }
        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            tiempo.Start();
        }

        private void parar_Click(object sender, EventArgs e)
        {
            tiempo.Stop();
        }
    }
}
