using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaSalario
{
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        private void btnVerificarDesconto_Click(object sender, EventArgs e)
        {
            double salario, salFamilia, inss, irpf;
            int qtdFilhos;

            if (double.TryParse(mskSalarioBruto.Text.Remove(0,3), out salario) && int.TryParse(mskNumFilhos.Text, out qtdFilhos) && txtNome.Text != string.Empty)
            {
                if (rdnMasculino.Checked == true)
                {
                    lblDados.Text = "Dados do Funcionário :";
                    if(chkCasado.Checked == true)
                    {
                        lblDadosFun.Text = txtNome.Text + "\nCasado\nTem " + mskNumFilhos.Text + " Filho(s)";
                    }
                    else
                    {
                        lblDadosFun.Text = txtNome.Text + "\nSolteiro\nTem " + mskNumFilhos.Text + " Filho(s)";
                    }
                }
                else
                {
                    lblDados.Text = "Dados da Funcionária :";
                    if (chkCasado.Checked == true)
                    {
                        lblDadosFun.Text = txtNome.Text + "\nCasada\nTem " + mskNumFilhos.Text + " Filho(s)";
                    }
                    else
                    {
                        lblDadosFun.Text = txtNome.Text + "\nSolteira\nTem " + mskNumFilhos.Text + " Filho(s)";
                    }
                }

                if (salario <= 800.87)
                {
                    inss = salario * 7.65 / 100;
                    mskAliquotaInss.Text = "7,65%";
                    mskDescontoInss.Text = "R$ " + inss.ToString("N2");
                }
                else if (salario <= 1050)
                {
                    inss = salario * 8.65 / 100;
                    mskAliquotaInss.Text = "8,65%";
                    mskDescontoInss.Text = "R$ " + inss.ToString("N2");
                }
                else if (salario <= 1400.77)
                {
                    inss = salario * 9 / 100;
                    mskAliquotaInss.Text = "9,00%";
                    mskDescontoInss.Text = "R$ " + inss.ToString("N2");
                }
                else if (salario <= 2801.56)
                {
                    inss = salario * 11 / 100;
                    mskAliquotaInss.Text = "11,00%";
                    mskDescontoInss.Text = "R$ " + inss.ToString("N2");
                }
                else
                {
                    inss = 308.17;
                    mskAliquotaInss.Text = "Teto";
                    mskDescontoInss.Text = "R$ " + inss.ToString("N2");
                }

                if (salario <= 1257.12)
                {
                    irpf = 0;
                    mskAliquotaIrpf.Text = "Isento";
                    mskDescontoIrpf.Text = "R$ 0,00";
                }
                else if (salario <= 2512.08)
                {
                    irpf = salario * 15 / 100;
                    mskAliquotaIrpf.Text = "15,00%";
                    mskDescontoIrpf.Text = "R$ " + irpf.ToString("N2");
                }
                else
                {
                    irpf = salario * 27.5 / 100;
                    mskAliquotaIrpf.Text = "27,50%";
                    mskDescontoIrpf.Text = "R$ " + irpf.ToString("N2");
                }

                if (salario <= 435.52)
                {
                    salFamilia = qtdFilhos * 22.33;
                    mskSalarioFamilia.Text = "R$ " + salFamilia.ToString("N2");
                }
                else if (salario <= 654.61)
                {
                    salFamilia = qtdFilhos * 15.74;
                    mskSalarioFamilia.Text = "R$ " + salFamilia.ToString("N2");
                }
                else
                {
                    salFamilia = 0;
                    mskSalarioFamilia.Text = "R$ 0,00";
                }

                mskSalarioLiquido.Text = "R$ " + (salario - inss - irpf + salFamilia).ToString("N2");
            }
            else if (double.TryParse(mskSalarioBruto.Text.Remove(0, 3), out salario) && int.TryParse(mskNumFilhos.Text, out qtdFilhos))
            {
                MessageBox.Show("Insira o Nome do Funcionário");
            }
            else
            {
                MessageBox.Show("Salário Bruto ou Números de Filhos inválidos");
            }
        }

        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            mskSalarioBruto.Text = "";
            mskNumFilhos.Text = "";
            rdnMasculino.Checked = true;
            chkCasado.Checked = false;

            lblDados.Text = "Dados do Funcionário :";
            lblDadosFun.Text = "";
            mskAliquotaInss.Text = "";
            mskAliquotaIrpf.Text = "";
            mskDescontoInss.Text = "";
            mskDescontoIrpf.Text = "";
            mskSalarioFamilia.Text = "";
            mskSalarioLiquido.Text = "";
        }

        private void enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
