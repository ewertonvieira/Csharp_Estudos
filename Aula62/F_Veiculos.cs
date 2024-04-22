using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula62
{
    public partial class F_Veiculos : Form
    {
        Form1 Fp;
        public F_Veiculos(string v, Form1 f) // Parametro de entrada;
        {
            InitializeComponent();
            tb_listaVeiculos.Text = v;

            Fp = f;
            f.num = 10;
        }

        private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Fp.tb_listaVeiculos.Text = tb_listaVeiculos.Text; // tb_listaVeiculos da interface principal receve o valor de tb_listaVeiculos da interface secundaria.
        }
    }
}
