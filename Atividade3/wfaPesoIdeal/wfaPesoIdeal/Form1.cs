using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaPesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double pesoIdeal, altura, peso;
            if(double.TryParse(mskAltura.Text, out altura) && double.TryParse(mskPeso.Text, out peso))
            {
                if (rdoMasculino.Checked)
                {
                    pesoIdeal = Math.Round(72.7 * altura - 58, 2);
                    if (peso > pesoIdeal)
                    {
                        MessageBox.Show("Acima do peso \nPeso Ideal = " + pesoIdeal);
                    }
                    else if (peso < pesoIdeal)
                    {
                        MessageBox.Show("Abaixo do peso \nPeso Ideal = " + pesoIdeal);
                    }
                    else
                    {
                        MessageBox.Show("Parabéns Peso ideal!");
                    }
                }
                else
                {
                    pesoIdeal = 62.1 * altura - 44.7;
                    if (peso > pesoIdeal)
                    {
                        MessageBox.Show("Acima do peso \nPeso Ideal = " + pesoIdeal);
                    }
                    else if (peso < pesoIdeal)
                    {
                        MessageBox.Show("Abaixo do peso \nPeso Ideal = " + pesoIdeal);
                    }
                    else
                    {
                        MessageBox.Show("Parabéns Peso ideal!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Digite o Peso a Altura válidos");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            mskPeso.Text = "";
            mskAltura.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mskPesoAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
