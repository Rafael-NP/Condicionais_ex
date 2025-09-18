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
    public partial class frmpex1 : Form
    {
        public frmpex1()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double ID, nota1, nota2, nota3, ME, MA;
            string msg, conc;

            nota1 = Convert.ToDouble(txtnota1.Text);
            nota2 = Convert.ToDouble(txtnota2.Text);
            nota3 = Convert.ToDouble(txtnota3.Text);
            ME = Convert.ToDouble(txtME.Text);
            ID = Convert.ToDouble(txtID.Text);

            MA = (nota1 + nota2 * 2 + nota3 * 3 + ME) / 7;

            if(MA >= 9.0)
            {
                msg = "aprovado";
                conc = "A";
            }
            else if(MA >= 7.5 && MA < 9.0)
            {
                msg = "aprovado";
                conc = "B";
            }
            else if(MA >= 6.0 && MA < 7.5)
            {
                msg = "aprovado";
                conc = "C";
            }
            else if(MA >= 4.0 && MA < 6.0)
            {
                msg = "reprovado";
                conc = "D";
            }
            else
            {
                msg = "reprovado";
                conc = "E";
            }

            MessageBox.Show("O aluno de ID " + ID + " obteve " + MA + " de média de aproveitamento, o conceito foi " + conc + " e foi " + msg + ".");
        }

        private void btnresetar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtME.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtID.Focus();
        }
    }
}
