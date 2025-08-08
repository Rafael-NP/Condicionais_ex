using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicionais_ex
{
    public partial class frmex2 : Form
    {
        public frmex2()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btnresetar_Click(object sender, EventArgs e)
        {
            txtlivros.Clear();
            txtvalor.Clear();
            txtlivros.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double livros, valor;
            livros = Convert.ToDouble(txtlivros.Text);
            if (livros <= 10)
                valor = livros * 12;
            else
                valor = livros * 8;
            txtvalor.Text = Convert.ToString(valor);
        }
    }
}
