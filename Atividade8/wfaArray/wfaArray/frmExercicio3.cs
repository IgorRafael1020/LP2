using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaArray
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnArmazem_Click(object sender, EventArgs e)
        {
            double[] qtd = new double[10];
            double[] preco = new double[10];
            double precoTotal = 0;
            bool aux;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    aux = double.TryParse(Interaction.InputBox("Digite a quantidade vendida do item " + (i + 1), "Digite a quantidade"), out qtd[i]);
                } while (aux == false);

                do
                {
                    aux = double.TryParse(Interaction.InputBox("Digite o preço do item " + (i + 1), "Digite o preço"), out preco[i]);
                } while (aux == false);

                precoTotal += qtd[i]*preco[i];
            }
            MessageBox.Show("Faturamento mensal: R$ " + precoTotal.ToString("N2"));
        }
    }
}
