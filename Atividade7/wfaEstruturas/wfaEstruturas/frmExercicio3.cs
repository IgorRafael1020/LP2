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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnPalindromo_Click(object sender, EventArgs e)
        {
            String palavra = txtPalavra.Text.ToUpper();
            palavra = palavra.Replace(" ","");

            char[] palindrome = palavra.ToCharArray();
            Array.Reverse(palindrome);

            if(palavra == new string(palindrome))
            {
                MessageBox.Show("Essa palavra é um palindrome");
            }
            else
            {
                MessageBox.Show("Essa palavra não é um palindrome");
            }
        }
    }
}
