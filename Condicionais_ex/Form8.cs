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
    public partial class frmpex2 : Form
    {
        public frmpex2()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double preco, total, desconto;
            Int32 cod;


            preco = Convert.ToDouble(txtpreco.Text);
            cod = Convert.ToInt32(txtcodigo.Text);


            switch (cod)
            {
                case 1:
                    desconto = preco * 0.05;
                    break;

                case 2:
                    desconto = preco * 0.15;
                    break;

                case 3:
                    desconto = preco * 0.07;
                    break;

                case 4:
                    desconto = preco * 0.12;
                    break;

                case 5:
                    desconto = preco * 0.20;
                    break;

                default:
                    desconto = 0;
                    MessageBox.Show("Produto importado, sem desconto disponível.");
                    break;

            }
            total = preco - desconto;
            txttotal.Text = total.ToString();
        }

        private void btnresetar_Click(object sender, EventArgs e)
        {
            txttotal.Clear();
            txtcodigo.Clear();
            txtpreco.Clear();
            txtpreco.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }
    }
}
