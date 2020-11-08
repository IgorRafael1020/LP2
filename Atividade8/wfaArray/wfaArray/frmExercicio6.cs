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
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            double[] nota1 = new double[20];
            double[] nota2 = new double[20];
            double[] nota3 = new double[20];
            bool aux;
            String todasAsMedias = "";

            for (int i = 0; i < 20; i++)
            {
                do
                {
                    aux = double.TryParse(Interaction.InputBox("Digiti a nota do Aluno " + (i + 1), "Prova 1"), out nota1[i]);
                } while (aux == false);

                do
                {
                    aux = double.TryParse(Interaction.InputBox("Digiti a nota do Aluno " + (i + 1), "Prova 2"), out nota2[i]);
                } while (aux == false);

                do
                {
                    aux = double.TryParse(Interaction.InputBox("Digiti a nota do Aluno " + (i + 1), "Prova 3"), out nota3[i]);
                } while (aux == false);

                todasAsMedias += "Aluno " + (i + 1) + ": média: " + ((nota1[i] + nota2[i] + nota3[i])/3).ToString("N2") + "\n";
            }

            MessageBox.Show(todasAsMedias);
        }
    }
}
