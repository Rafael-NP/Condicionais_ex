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
    public partial class frmex3 : Form
    {
        public frmex3()
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
            txtnome.Clear();
            txtidade.Clear();
            txtsexo.Clear();
            txtsalFixo.Clear();
            txtnome.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string nome, sexo;
            double idade, salFixo, salFinal;
            nome = txtnome.Text;
            sexo = txtsexo.Text;
            idade = Convert.ToDouble(txtidade.Text);
            salFixo = Convert.ToDouble(txtsalFixo.Text);
            if (sexo == "M" || sexo == "F")
            {
                if(sexo == "M")
                {
                    if (idade >= 30)
                        salFinal = salFixo + 100.00;
                    else
                        salFinal = salFixo + 50.00;
                }
                else
                {
                    if (idade >= 30)
                        salFinal = salFixo + 250.00;
                    else
                        salFinal = salFixo + 150.00;
                }
                MessageBox.Show("O(a) " + nome + " irá receber " + salFinal + " reais.");
            }
            else
                MessageBox.Show("[ERRO] A maneira com a qual você expressou o sexo é inválida.");
        }
    }
}
