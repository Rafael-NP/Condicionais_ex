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
    public partial class frmex4 : Form
    {
        public frmex4()
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
            txtcod.Clear();
            txtlanche.Clear();
            txtcod.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Int32 cod;
            cod = Convert.ToInt32(txtcod.Text);
            switch (cod)
            {
                case 100:
                    txtlanche.Text = "Cachorro quente a 25 reais";
                break;
                case 101:
                    txtlanche.Text = "Bauru a 15 reais";
                break;
                case 102:
                    txtlanche.Text = "X-Burguer a 35 reais";
                   break;
                case 103:
                    txtlanche.Text = "Triplo X-Burguer a 47 reais";
                break;
                default:
                    MessageBox.Show("[ERRO] O código digitado é inválido.");
                    txtcod.Clear();
                    txtcod.Focus();
                break;
            }

        }
    }
}
