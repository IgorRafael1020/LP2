using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PF_0030482011014
{
    public partial class frmCidade : Form
    {
        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();

        public frmCidade()
        {
            InitializeComponent();
        }

        private void frmCidade_Load(object sender, EventArgs e)
        {
            try
            {
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                bnCidade.DataSource = dsCidade.Tables["TBCIDADE"];
                dgvCidade.DataSource = bnCidade;
                
                bdnCidade.BindingSource = bnCidade;
                txtCodigo.DataBindings.Add("TEXT", bnCidade, "id_cidade");
                txtNome.DataBindings.Add("TEXT", bnCidade, "nome_cidade");
                cmbEstado.DataBindings.Add("SelectedItem", bnCidade, "uf_cidade");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tsbInserir_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            bnCidade.AddNew();
            txtNome.Enabled = true;
            cmbEstado.Enabled = true;
            cmbEstado.SelectedIndex = 0;
            txtNome.Focus();

            tsbSalvar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbInserir.Enabled = false;
            tsbEditar.Enabled = false;
            tsbExcluir.Enabled = false;

            bInclusao = true;
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            txtNome.Enabled = true;
            cmbEstado.Enabled = true;
            cmbEstado.SelectedIndex = 0;
            txtNome.Focus();

            tsbSalvar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbInserir.Enabled = false;
            tsbEditar.Enabled = false;
            tsbExcluir.Enabled = false;

            bInclusao = false;
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            if (tbCidade.SelectedIndex == 0)
            {
                tbCidade.SelectTab(1);
            }
            if (MessageBox.Show("Deseja excluir esse item?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Cidade RegCid = new Cidade();
                RegCid.Idcidade = Convert.ToInt16(txtCodigo.Text);
                RegCid.Nomecidade = txtNome.Text;
                RegCid.Ufcidade = cmbEstado.SelectedItem.ToString();

                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Cidade excluida com sucesso");
                    Cidade R = new Cidade();
                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(R.Listar());
                    bnCidade.DataSource = dsCidade.Tables["TBCIDADE"];

                }
                else
                {
                    MessageBox.Show("Erro ao excluir cidade");
                }
            }
        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                MessageBox.Show("Cidade Inválida");
            }
            else
            {
                Cidade RegCid = new Cidade();
                RegCid.Idcidade = Convert.ToInt16(txtCodigo.Text);
                RegCid.Nomecidade = txtNome.Text;
                RegCid.Ufcidade = cmbEstado.SelectedItem.ToString();

                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Cidade Inserida com sucesso");
                        tsbInserir.Enabled = true;
                        tsbEditar.Enabled = true;
                        tsbExcluir.Enabled = true;
                        tsbSalvar.Enabled = false;
                        tsbCancelar.Enabled = false;

                        txtCodigo.Enabled = false;
                        txtNome.Enabled = false;
                        cmbEstado.Enabled = false;

                        bInclusao = false;

                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["TBCIDADE"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade");
                    }
                }
                else
                {
                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Cidade Editado com sucesso");
                        tsbInserir.Enabled = true;
                        tsbEditar.Enabled = true;
                        tsbExcluir.Enabled = true;
                        tsbSalvar.Enabled = false;
                        tsbCancelar.Enabled = false;

                        txtCodigo.Enabled = false;
                        txtNome.Enabled = false;
                        cmbEstado.Enabled = false;

                        bInclusao = false;

                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["TBCIDADE"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao editar cidade");
                    }
                }
            }
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            bnCidade.CancelEdit();

            tsbInserir.Enabled = true;
            tsbEditar.Enabled = true;
            tsbExcluir.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;

            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            cmbEstado.Enabled = false;

            bInclusao = false;
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
