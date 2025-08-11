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
    public partial class frmex1 : Form
    {
        public frmex1()
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
            txtpubli.Clear();
            txtrenda.Clear();
            txtpubli.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double publi, inPop, inGe, inArqui, inCad, renda;
            publi = Convert.ToDouble(txtpubli.Text);
            if (publi > 0)
            {
                inPop = (publi * 0.1) * 5;
                inGe = (publi * 0.5) * 10;
                inArqui = (publi * 0.3) * 20;
                inCad = (publi * 0.1) * 10;
                renda = inPop + inGe + inArqui + inCad;
                txtrenda.Text = renda.ToString();
            }
            else
                MessageBox.Show("[ERRO] O público deve ter ao menos uma pessoa");
        }
    }
}
