﻿using Microsoft.VisualBasic;
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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            double[] num = new double[20];
            String numeroReverso = "";
            bool aux;

            for (int i = 0; i < 20; i++)
            {
                do
                {
                    aux = double.TryParse(Interaction.InputBox("Digite o Número " + (i+1), "Digite os números"), out num[i]);
                } while (aux == false);
            }
            for (int i = 19; i >= 0; i--)
            {
                numeroReverso += num[i] + " ";
            }
            MessageBox.Show(numeroReverso);
        }
    }
}
