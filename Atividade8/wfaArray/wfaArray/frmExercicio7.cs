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
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            String nome, caracter;
            int finalRa = 4;

            for (int i = 0; i < finalRa ; i++)
            {
                nome = Interaction.InputBox("Digite o nome " + (i+1), "Lista de Nomes");
                caracter = nome.Replace(" ","");
                lstNome.Items.Add("Nome " + (i+1) + ": " + nome + " " + caracter.Length + " Caracteres");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstNome.Items.Clear();
        }
    }
}
