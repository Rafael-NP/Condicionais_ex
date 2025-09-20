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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void tsmisair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiex1_Click(object sender, EventArgs e)
        {
            Hide();
            frmex1 ex1 = new frmex1();
            ex1.Show();
        }

        private void tsmiex2_Click(object sender, EventArgs e)
        {
            Hide();
            frmex2 ex2 = new frmex2();
            ex2.Show();
        }

        private void tsmiex3_Click(object sender, EventArgs e)
        {
            Hide();
            frmex3 ex3 = new frmex3();
            ex3.Show();
        }

        private void tsmiex4_Click(object sender, EventArgs e)
        {
            Hide();
            frmex4 ex4 = new frmex4();
            ex4.Show();
        }

        private void tsmiex5_Click(object sender, EventArgs e)
        {
            Hide();
            frmex5 ex5 = new frmex5();
            ex5.Show();
        }

        private void tsmipex1_Click(object sender, EventArgs e)
        {
            Hide();
            frmpex1 pex1 = new frmpex1();
            pex1.Show();
        }

        private void tsmipex2_Click(object sender, EventArgs e)
        {
            Hide();
            frmpex2 pex2 = new frmpex2();
            pex2.Show();
        }
    }
}
