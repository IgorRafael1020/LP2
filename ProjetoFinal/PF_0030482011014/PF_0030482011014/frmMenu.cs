using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PF_0030482011014
{
    public partial class frmMenu : Form
    {
        public static SqlConnection conexao;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsmiCadastroCidade_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCidade>().Count()>0)
            {
                Application.OpenForms.OfType<frmCidade>().First().Focus();
            }
            else
            {
                frmCidade FrmCidade = new frmCidade();
                FrmCidade.MdiParent = this;
                FrmCidade.WindowState = FormWindowState.Maximized;
                FrmCidade.Show();
            }
        }

        private void tsmiSobre_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmSobre>().Count() > 0)
            {
                Application.OpenForms.OfType<frmSobre>().First().Focus();
            }
            else
            {
                frmSobre FrmSobre = new frmSobre();
                FrmSobre.MdiParent = this;
                FrmSobre.WindowState = FormWindowState.Maximized;
                FrmSobre.Show();
            }
        }

        private void tsmiSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=DESKTOP-AETP40F\\SQLEXPRESS;Initial Catalog=LP2;Persist Security Info=True;User ID=sa;Password=741963486");
                conexao.Open();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros =/" + ex.Message);
            }
        }
    }
}
