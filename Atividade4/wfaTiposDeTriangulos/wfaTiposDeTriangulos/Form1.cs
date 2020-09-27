using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaTiposDeTriangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double ladoA, ladoB, ladoC;
            if(double.TryParse(txtLadoA.Text, out ladoA) && double.TryParse(txtLadoB.Text, out ladoB) && double.TryParse(txtLadoC.Text, out ladoC))
            {
                if (Math.Abs(ladoB - ladoC) < ladoA && ladoA < (ladoB + ladoC) &&
                Math.Abs(ladoA - ladoC) < ladoB && ladoB < (ladoA + ladoC) &&
                Math.Abs(ladoA - ladoB) < ladoC && ladoC < (ladoA + ladoB))
                {
                    if (ladoA == ladoB && ladoB == ladoC)
                    {
                        MessageBox.Show("Triângulo Equilátero");
                    }
                    else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
                    {
                        MessageBox.Show("Triângulo Isósceles");
                    }
                    else
                    {
                        MessageBox.Show("Triângulo Escaleno");
                    }
                }
                else
                {
                    MessageBox.Show("Esses lados não formam um triângulo");
                }
            }
            else
            {
                MessageBox.Show("Valores inválidos!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Text = "";
            txtLadoB.Text = "";
            txtLadoC.Text = "";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLados_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
            if(e.KeyChar == (char)13)
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
