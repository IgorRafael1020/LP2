using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaEstruturas
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int b = 0, c = 0, d = 0;
            double a, producao, salario, gratificacao;

            if(double.TryParse(txtProducao.Text, out producao) && double.TryParse(txtSalario.Text, out salario) && double.TryParse(txtGradificacao.Text, out gratificacao))
            {
                if (producao >= 100)
                {
                    b = 1;
                }
                if (producao >= 120)
                {
                    c = 1;
                }
                if (producao >= 150)
                {
                    d = 1;
                }

                a = salario + salario * (0.05 * b + 0.1 * c + 0.1 * d);

                if (producao < 150 && a >= 7000)
                {
                    a = 7000;
                }
                else
                {
                    a = salario + salario * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;
                }

                MessageBox.Show("Salário bruto = " + a);
            }
            else
            {
                MessageBox.Show("Preencha os dados corretamente");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCargo.Text = "";
            txtNumInscricao.Text = "";
            txtProducao.Text = "";
            txtSalario.Text = "";
            txtGradificacao.Text = "";
        }
    }
}
