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
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSorteio_Click(object sender, EventArgs e)
        {
            int num1, num2, num;
            if(int.TryParse(txtNum1.Text, out num1) && int.TryParse(txtNum2.Text, out num2))
            {
                if (num1 >= num2)
                {
                    MessageBox.Show("O número 2 deve ser maior que o número 1");
                }
                else
                {
                    var rand = new Random();
                    num = rand.Next(num1,num2);
                    MessageBox.Show(num.ToString());
                }
            }
            else
            {
                MessageBox.Show("Digite apenas números inteiros");
            }
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }
    }
}
