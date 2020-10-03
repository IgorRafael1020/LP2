namespace wfaSalario
{
    partial class frmSalario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeFun = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.lblAliquotaInss = new System.Windows.Forms.Label();
            this.lblAliquotaIrpf = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.lblDescontoInss = new System.Windows.Forms.Label();
            this.lblDescontoIrpf = new System.Windows.Forms.Label();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdnFeminino = new System.Windows.Forms.RadioButton();
            this.rdnMasculino = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.mskSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnVerificarDesconto = new System.Windows.Forms.Button();
            this.mskAliquotaInss = new System.Windows.Forms.MaskedTextBox();
            this.mskAliquotaIrpf = new System.Windows.Forms.MaskedTextBox();
            this.mskSalarioFamilia = new System.Windows.Forms.MaskedTextBox();
            this.mskSalarioLiquido = new System.Windows.Forms.MaskedTextBox();
            this.mskDescontoInss = new System.Windows.Forms.MaskedTextBox();
            this.mskDescontoIrpf = new System.Windows.Forms.MaskedTextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.btnLimparDados = new System.Windows.Forms.Button();
            this.lblDadosFun = new System.Windows.Forms.Label();
            this.grpSexo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFun
            // 
            this.lblNomeFun.AutoSize = true;
            this.lblNomeFun.Location = new System.Drawing.Point(121, 43);
            this.lblNomeFun.Name = "lblNomeFun";
            this.lblNomeFun.Size = new System.Drawing.Size(93, 13);
            this.lblNomeFun.TabIndex = 0;
            this.lblNomeFun.Text = "Nome Funcionário";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(121, 75);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(67, 13);
            this.lblSalarioBruto.TabIndex = 1;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(121, 109);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(89, 13);
            this.lblNumFilhos.TabIndex = 2;
            this.lblNumFilhos.Text = "Número de Filhos";
            // 
            // lblAliquotaInss
            // 
            this.lblAliquotaInss.AutoSize = true;
            this.lblAliquotaInss.Location = new System.Drawing.Point(121, 287);
            this.lblAliquotaInss.Name = "lblAliquotaInss";
            this.lblAliquotaInss.Size = new System.Drawing.Size(73, 13);
            this.lblAliquotaInss.TabIndex = 3;
            this.lblAliquotaInss.Text = "Aliquota INSS";
            // 
            // lblAliquotaIrpf
            // 
            this.lblAliquotaIrpf.AutoSize = true;
            this.lblAliquotaIrpf.Location = new System.Drawing.Point(122, 324);
            this.lblAliquotaIrpf.Name = "lblAliquotaIrpf";
            this.lblAliquotaIrpf.Size = new System.Drawing.Size(72, 13);
            this.lblAliquotaIrpf.TabIndex = 4;
            this.lblAliquotaIrpf.Text = "Aliquota IRPF";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Location = new System.Drawing.Point(122, 360);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(76, 13);
            this.lblSalarioFamilia.TabIndex = 5;
            this.lblSalarioFamilia.Text = "Salário Família";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Location = new System.Drawing.Point(121, 395);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(78, 13);
            this.lblSalarioLiquido.TabIndex = 6;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // lblDescontoInss
            // 
            this.lblDescontoInss.AutoSize = true;
            this.lblDescontoInss.Location = new System.Drawing.Point(449, 287);
            this.lblDescontoInss.Name = "lblDescontoInss";
            this.lblDescontoInss.Size = new System.Drawing.Size(81, 13);
            this.lblDescontoInss.TabIndex = 7;
            this.lblDescontoInss.Text = "Desconto INSS";
            // 
            // lblDescontoIrpf
            // 
            this.lblDescontoIrpf.AutoSize = true;
            this.lblDescontoIrpf.Location = new System.Drawing.Point(450, 324);
            this.lblDescontoIrpf.Name = "lblDescontoIrpf";
            this.lblDescontoIrpf.Size = new System.Drawing.Size(80, 13);
            this.lblDescontoIrpf.TabIndex = 8;
            this.lblDescontoIrpf.Text = "Desconto IRPF";
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdnFeminino);
            this.grpSexo.Controls.Add(this.rdnMasculino);
            this.grpSexo.Location = new System.Drawing.Point(495, 22);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(171, 91);
            this.grpSexo.TabIndex = 12;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdnFeminino
            // 
            this.rdnFeminino.AutoSize = true;
            this.rdnFeminino.Location = new System.Drawing.Point(45, 66);
            this.rdnFeminino.Name = "rdnFeminino";
            this.rdnFeminino.Size = new System.Drawing.Size(31, 17);
            this.rdnFeminino.TabIndex = 1;
            this.rdnFeminino.Text = "F";
            this.rdnFeminino.UseVisualStyleBackColor = true;
            this.rdnFeminino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // rdnMasculino
            // 
            this.rdnMasculino.AutoSize = true;
            this.rdnMasculino.Checked = true;
            this.rdnMasculino.Location = new System.Drawing.Point(45, 32);
            this.rdnMasculino.Name = "rdnMasculino";
            this.rdnMasculino.Size = new System.Drawing.Size(34, 17);
            this.rdnMasculino.TabIndex = 0;
            this.rdnMasculino.TabStop = true;
            this.rdnMasculino.Text = "M";
            this.rdnMasculino.UseVisualStyleBackColor = true;
            this.rdnMasculino.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkCasado);
            this.panel1.Location = new System.Drawing.Point(495, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 52);
            this.panel1.TabIndex = 13;
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Location = new System.Drawing.Point(45, 18);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(62, 17);
            this.chkCasado.TabIndex = 0;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            this.chkCasado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // mskSalarioBruto
            // 
            this.mskSalarioBruto.Location = new System.Drawing.Point(266, 72);
            this.mskSalarioBruto.Mask = "$ 00000.00";
            this.mskSalarioBruto.Name = "mskSalarioBruto";
            this.mskSalarioBruto.Size = new System.Drawing.Size(100, 20);
            this.mskSalarioBruto.TabIndex = 10;
            this.mskSalarioBruto.ValidatingType = typeof(int);
            this.mskSalarioBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // mskNumFilhos
            // 
            this.mskNumFilhos.Location = new System.Drawing.Point(266, 106);
            this.mskNumFilhos.Mask = "00";
            this.mskNumFilhos.Name = "mskNumFilhos";
            this.mskNumFilhos.Size = new System.Drawing.Size(100, 20);
            this.mskNumFilhos.TabIndex = 11;
            this.mskNumFilhos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(266, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 9;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter_KeyPress);
            // 
            // btnVerificarDesconto
            // 
            this.btnVerificarDesconto.Location = new System.Drawing.Point(251, 161);
            this.btnVerificarDesconto.Name = "btnVerificarDesconto";
            this.btnVerificarDesconto.Size = new System.Drawing.Size(124, 34);
            this.btnVerificarDesconto.TabIndex = 14;
            this.btnVerificarDesconto.Text = "Verificar Desconto";
            this.btnVerificarDesconto.UseVisualStyleBackColor = true;
            this.btnVerificarDesconto.Click += new System.EventHandler(this.btnVerificarDesconto_Click);
            // 
            // mskAliquotaInss
            // 
            this.mskAliquotaInss.Enabled = false;
            this.mskAliquotaInss.Location = new System.Drawing.Point(266, 284);
            this.mskAliquotaInss.Name = "mskAliquotaInss";
            this.mskAliquotaInss.Size = new System.Drawing.Size(100, 20);
            this.mskAliquotaInss.TabIndex = 15;
            // 
            // mskAliquotaIrpf
            // 
            this.mskAliquotaIrpf.Enabled = false;
            this.mskAliquotaIrpf.Location = new System.Drawing.Point(266, 321);
            this.mskAliquotaIrpf.Name = "mskAliquotaIrpf";
            this.mskAliquotaIrpf.Size = new System.Drawing.Size(100, 20);
            this.mskAliquotaIrpf.TabIndex = 16;
            // 
            // mskSalarioFamilia
            // 
            this.mskSalarioFamilia.Enabled = false;
            this.mskSalarioFamilia.Location = new System.Drawing.Point(266, 357);
            this.mskSalarioFamilia.Name = "mskSalarioFamilia";
            this.mskSalarioFamilia.Size = new System.Drawing.Size(100, 20);
            this.mskSalarioFamilia.TabIndex = 17;
            // 
            // mskSalarioLiquido
            // 
            this.mskSalarioLiquido.Enabled = false;
            this.mskSalarioLiquido.Location = new System.Drawing.Point(266, 392);
            this.mskSalarioLiquido.Name = "mskSalarioLiquido";
            this.mskSalarioLiquido.Size = new System.Drawing.Size(100, 20);
            this.mskSalarioLiquido.TabIndex = 18;
            // 
            // mskDescontoInss
            // 
            this.mskDescontoInss.Enabled = false;
            this.mskDescontoInss.Location = new System.Drawing.Point(558, 284);
            this.mskDescontoInss.Name = "mskDescontoInss";
            this.mskDescontoInss.Size = new System.Drawing.Size(100, 20);
            this.mskDescontoInss.TabIndex = 19;
            // 
            // mskDescontoIrpf
            // 
            this.mskDescontoIrpf.Enabled = false;
            this.mskDescontoIrpf.Location = new System.Drawing.Point(558, 321);
            this.mskDescontoIrpf.Name = "mskDescontoIrpf";
            this.mskDescontoIrpf.Size = new System.Drawing.Size(100, 20);
            this.mskDescontoIrpf.TabIndex = 20;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Location = new System.Drawing.Point(122, 228);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(117, 13);
            this.lblDados.TabIndex = 21;
            this.lblDados.Text = "Dados do Funcionário :";
            // 
            // btnLimparDados
            // 
            this.btnLimparDados.Location = new System.Drawing.Point(534, 384);
            this.btnLimparDados.Name = "btnLimparDados";
            this.btnLimparDados.Size = new System.Drawing.Size(124, 34);
            this.btnLimparDados.TabIndex = 23;
            this.btnLimparDados.Text = "Limpar Dados";
            this.btnLimparDados.UseVisualStyleBackColor = true;
            this.btnLimparDados.Click += new System.EventHandler(this.btnLimparDados_Click);
            // 
            // lblDadosFun
            // 
            this.lblDadosFun.AutoSize = true;
            this.lblDadosFun.Location = new System.Drawing.Point(263, 228);
            this.lblDadosFun.Name = "lblDadosFun";
            this.lblDadosFun.Size = new System.Drawing.Size(0, 13);
            this.lblDadosFun.TabIndex = 24;
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDadosFun);
            this.Controls.Add(this.btnLimparDados);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.mskDescontoIrpf);
            this.Controls.Add(this.mskDescontoInss);
            this.Controls.Add(this.mskSalarioLiquido);
            this.Controls.Add(this.mskSalarioFamilia);
            this.Controls.Add(this.mskAliquotaIrpf);
            this.Controls.Add(this.mskAliquotaInss);
            this.Controls.Add(this.btnVerificarDesconto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mskNumFilhos);
            this.Controls.Add(this.mskSalarioBruto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.lblDescontoIrpf);
            this.Controls.Add(this.lblDescontoInss);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAliquotaIrpf);
            this.Controls.Add(this.lblAliquotaInss);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNomeFun);
            this.Name = "frmSalario";
            this.Text = "Salário";
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFun;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Label lblAliquotaInss;
        private System.Windows.Forms.Label lblAliquotaIrpf;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.Label lblDescontoInss;
        private System.Windows.Forms.Label lblDescontoIrpf;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdnFeminino;
        private System.Windows.Forms.RadioButton rdnMasculino;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.MaskedTextBox mskSalarioBruto;
        private System.Windows.Forms.MaskedTextBox mskNumFilhos;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnVerificarDesconto;
        private System.Windows.Forms.MaskedTextBox mskAliquotaInss;
        private System.Windows.Forms.MaskedTextBox mskAliquotaIrpf;
        private System.Windows.Forms.MaskedTextBox mskSalarioFamilia;
        private System.Windows.Forms.MaskedTextBox mskSalarioLiquido;
        private System.Windows.Forms.MaskedTextBox mskDescontoInss;
        private System.Windows.Forms.MaskedTextBox mskDescontoIrpf;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Button btnLimparDados;
        private System.Windows.Forms.Label lblDadosFun;
    }
}

