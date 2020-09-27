using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1, num2, resultado;

        public int valiNum()
        {
            int aux = 0;
            if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
            {
                aux = 1;
            }

            return aux;
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (valiNum() == 1)
            {
                resultado = num1 + num2;
                txtResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores inválidos!");
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (valiNum() == 1)
            {
                resultado = num1 - num2;
                txtResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores inválidos!");
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (valiNum() == 1)
            {
                resultado = num1 * num2;
                txtResultado.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Valores inválidos!");
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (valiNum() == 1)
            {
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    txtResultado.Text = resultado.ToString("N2");
                }
                else
                {
                    MessageBox.Show("O denominador não pode ser 0!");
                }
            }
            else
            {
                MessageBox.Show("Valores inválidos!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)44 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
