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
    public partial class frmex5 : Form
    {
        public frmex5()
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
            txtpeso.Clear();
            txtaltura.Clear();
            txtimc.Clear();
            txtpeso.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            string classe;

            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);
            imc = peso / Math.Pow(altura, 2);

            if (imc < 17)
            {
                classe = "Magreza Severa";
            }

            else if (imc >= 17 && imc < 18.5)
            {
                classe = "Magreza leve";
            }

            else if (imc >= 18.5 && imc < 25)
            {
                classe = "Peso normal";
            }

            else if (imc >= 25 && imc < 30)
            {
                classe = "Sobrepeso";
            }

            else if (imc >= 30 && imc < 35)
            {
                classe = "Obesidade classe 1";
            }

            else if (imc >= 35 && imc < 40)
            {
                classe = "Obesidade classe 2";
            }

            else
            {
                classe = "Obesidade classe 3";
            }

            txtimc.Text = Convert.ToString(imc);
            txtclasse.Text = classe;
        }

        private void lblimc_Click(object sender, EventArgs e)
        {

        }

        private void lblpeso_Click(object sender, EventArgs e)
        {

        }

        private void lblaltura_Click(object sender, EventArgs e)
        {

        }
    }
}
