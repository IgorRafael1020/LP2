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

                a = salario + salario * (0.05 * b + 0.1 * c + 0.1 * d) + gratificacao;

                if (producao >= 150 && gratificacao > 0)
                {
                    MessageBox.Show("Salário bruto = R$ " + a.ToString("N2"));
                }
                else if (a >= 7000)
                {
                    MessageBox.Show("Salário bruto = R$ 7000,00");
                }
                else
                {
                    MessageBox.Show("Salário bruto = R$ " + a.ToString("N2"));
                }
                
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

        private void campo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
