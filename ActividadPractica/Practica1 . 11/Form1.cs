using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1._11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnmostar_Click(object sender, EventArgs e)
        {
            lblver.Text = "Fecha: " + dtpfecha.Value.ToShortDateString();
        }
    }
}
