using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using file = System.IO.File;

namespace Practica1._15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            AbrirArchivo.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (AbrirArchivo.ShowDialog() == DialogResult.OK)
            {
                txtarchivo.Text = file.ReadAllText(AbrirArchivo.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarArchivo.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (GuardarArchivo.ShowDialog() == DialogResult.OK)
            {
                file.WriteAllText(GuardarArchivo.FileName, txtarchivo.Text);
            }
        }
    }
}
