namespace wfaEstruturas
{
    partial class frmExercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNumIncricao = new System.Windows.Forms.Label();
            this.lblProducao = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblGratificacao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtNumInscricao = new System.Windows.Forms.TextBox();
            this.txtProducao = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtGradificacao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(149, 92);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(149, 131);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Cargo";
            // 
            // lblNumIncricao
            // 
            this.lblNumIncricao.AutoSize = true;
            this.lblNumIncricao.Location = new System.Drawing.Point(149, 170);
            this.lblNumIncricao.Name = "lblNumIncricao";
            this.lblNumIncricao.Size = new System.Drawing.Size(100, 13);
            this.lblNumIncricao.TabIndex = 2;
            this.lblNumIncricao.Text = "Numero de Incrição";
            // 
            // lblProducao
            // 
            this.lblProducao.AutoSize = true;
            this.lblProducao.Location = new System.Drawing.Point(149, 207);
            this.lblProducao.Name = "lblProducao";
            this.lblProducao.Size = new System.Drawing.Size(53, 13);
            this.lblProducao.TabIndex = 3;
            this.lblProducao.Text = "Produção";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(149, 249);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "Salário";
            // 
            // lblGratificacao
            // 
            this.lblGratificacao.AutoSize = true;
            this.lblGratificacao.Location = new System.Drawing.Point(149, 292);
            this.lblGratificacao.Name = "lblGratificacao";
            this.lblGratificacao.Size = new System.Drawing.Size(64, 13);
            this.lblGratificacao.TabIndex = 5;
            this.lblGratificacao.Text = "Gratificação";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(320, 89);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 6;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campo_KeyPress);
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(320, 128);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 7;
            this.txtCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campo_KeyPress);
            // 
            // txtNumInscricao
            // 
            this.txtNumInscricao.Location = new System.Drawing.Point(320, 167);
            this.txtNumInscricao.Name = "txtNumInscricao";
            this.txtNumInscricao.Size = new System.Drawing.Size(100, 20);
            this.txtNumInscricao.TabIndex = 8;
            this.txtNumInscricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campo_KeyPress);
            // 
            // txtProducao
            // 
            this.txtProducao.Location = new System.Drawing.Point(320, 204);
            this.txtProducao.Name = "txtProducao";
            this.txtProducao.Size = new System.Drawing.Size(100, 20);
            this.txtProducao.TabIndex = 9;
            this.txtProducao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campo_KeyPress);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(320, 246);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 10;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campo_KeyPress);
            // 
            // txtGradificacao
            // 
            this.txtGradificacao.Location = new System.Drawing.Point(320, 289);
            this.txtGradificacao.Name = "txtGradificacao";
            this.txtGradificacao.Size = new System.Drawing.Size(100, 20);
            this.txtGradificacao.TabIndex = 11;
            this.txtGradificacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.campo_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(235, 361);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(420, 361);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtGradificacao);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtProducao);
            this.Controls.Add(this.txtNumInscricao);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblGratificacao);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblProducao);
            this.Controls.Add(this.lblNumIncricao);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Name = "frmExercicio4";
            this.Text = "Calcular Salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNumIncricao;
        private System.Windows.Forms.Label lblProducao;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblGratificacao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtNumInscricao;
        private System.Windows.Forms.TextBox txtProducao;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtGradificacao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
    }
}