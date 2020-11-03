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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnEspacoEmBranco_Click(object sender, EventArgs e)
        {
            int espacoBranco = 0;
            for (int i = 0; i < rtxTexto.Text.Length; i++)
            {
                if (rtxTexto.Text.Substring(i,1) == " ")
                {
                    espacoBranco++;
                }
            }
            MessageBox.Show("Há " + espacoBranco + " espaços em brancos nesse texto");
        }

        private void btnContaR_Click(object sender, EventArgs e)
        {
            int x = 0, qtdR = 0;
            do
            {
                if (rtxTexto.Text.Substring(x, 1) == "r" || rtxTexto.Text.Substring(x, 1) == "R")
                {
                    qtdR++;
                }
                x++;
            }
            while (x < rtxTexto.Text.Length);
            MessageBox.Show("Há " + qtdR + " R nesse texto");
        }

        private void btnParDeLetras_Click(object sender, EventArgs e)
        {
            int dupla = 0;
            for (int i = 0; i < rtxTexto.Text.Length-1; i++)
            {
                if (rtxTexto.Text.Substring(i, 1) == rtxTexto.Text.Substring(i+1, 1))
                {
                    dupla++;
                }
            }
            MessageBox.Show("Há " + dupla + " letras que aparesem em dupla nesse texto");
        }
    }
}
