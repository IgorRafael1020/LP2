namespace wfaPesoIdeal
{
    partial class Form1
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.grp = new System.Windows.Forms.GroupBox();
            this.rdoFeminino = new System.Windows.Forms.RadioButton();
            this.rdoMasculino = new System.Windows.Forms.RadioButton();
            this.mskPeso = new System.Windows.Forms.MaskedTextBox();
            this.mskAltura = new System.Windows.Forms.MaskedTextBox();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(158, 111);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(158, 169);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Altura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(161, 297);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(312, 297);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(458, 297);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // grp
            // 
            this.grp.Controls.Add(this.rdoFeminino);
            this.grp.Controls.Add(this.rdoMasculino);
            this.grp.Location = new System.Drawing.Point(458, 99);
            this.grp.Name = "grp";
            this.grp.Size = new System.Drawing.Size(200, 100);
            this.grp.TabIndex = 7;
            this.grp.TabStop = false;
            this.grp.Text = "Sexo:";
            // 
            // rdoFeminino
            // 
            this.rdoFeminino.AutoSize = true;
            this.rdoFeminino.Location = new System.Drawing.Point(27, 58);
            this.rdoFeminino.Name = "rdoFeminino";
            this.rdoFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdoFeminino.TabIndex = 8;
            this.rdoFeminino.TabStop = true;
            this.rdoFeminino.Text = "Feminino";
            this.rdoFeminino.UseVisualStyleBackColor = true;
            // 
            // rdoMasculino
            // 
            this.rdoMasculino.AutoSize = true;
            this.rdoMasculino.Checked = true;
            this.rdoMasculino.Location = new System.Drawing.Point(27, 25);
            this.rdoMasculino.Name = "rdoMasculino";
            this.rdoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdoMasculino.TabIndex = 0;
            this.rdoMasculino.TabStop = true;
            this.rdoMasculino.Text = "Masculino";
            this.rdoMasculino.UseVisualStyleBackColor = true;
            // 
            // mskPeso
            // 
            this.mskPeso.Location = new System.Drawing.Point(265, 108);
            this.mskPeso.Mask = "99.99";
            this.mskPeso.Name = "mskPeso";
            this.mskPeso.Size = new System.Drawing.Size(100, 20);
            this.mskPeso.TabIndex = 2;
            this.mskPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskPesoAltura_KeyPress);
            // 
            // mskAltura
            // 
            this.mskAltura.Location = new System.Drawing.Point(265, 166);
            this.mskAltura.Mask = "9.99";
            this.mskAltura.Name = "mskAltura";
            this.mskAltura.Size = new System.Drawing.Size(100, 20);
            this.mskAltura.TabIndex = 3;
            this.mskAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskPesoAltura_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mskAltura);
            this.Controls.Add(this.mskPeso);
            this.Controls.Add(this.grp);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Name = "Form1";
            this.Text = "Peso Ideal";
            this.grp.ResumeLayout(false);
            this.grp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox grp;
        private System.Windows.Forms.RadioButton rdoFeminino;
        private System.Windows.Forms.RadioButton rdoMasculino;
        private System.Windows.Forms.MaskedTextBox mskPeso;
        private System.Windows.Forms.MaskedTextBox mskAltura;
    }
}

