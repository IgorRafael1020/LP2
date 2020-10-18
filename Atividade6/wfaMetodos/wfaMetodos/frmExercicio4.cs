using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnContaNumero_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for (var i=0; i<rtxTexto.Text.Length; i++)
            {
                if (char.IsNumber(rtxTexto.Text[i]))
                {
                    contador++;
                }
            }
            MessageBox.Show("O texto possui " + contador + " números");
        }

        private void btnContaEspaço_Click(object sender, EventArgs e)
        {
            int aux = 0, contador = 0;

            while (aux < rtxTexto.Text.Length)
            {
                if (char.IsWhiteSpace(rtxTexto.Text[aux]))
                {
                    contador = aux + 1;
                    break;
                }
                aux++;
            }
            if(contador == 0)
            {
                MessageBox.Show("O texto não possui espaço em branco");
            }
            else
            {
                MessageBox.Show("O texto possui um espaço em branco na posição " + contador);
            }
        }

        private void btnContaLetra_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (char c in rtxTexto.Text)
            {
                if (char.IsLetter(c))
                {
                    contador++;
                }
            }
            MessageBox.Show("O texto possui " + contador + " letras");
        }

        private void txtPalavra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
