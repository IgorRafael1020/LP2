namespace wfaMetodos
{
    partial class frmExercicio2
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
            this.txtPalavra1 = new System.Windows.Forms.TextBox();
            this.txtPalavra2 = new System.Windows.Forms.TextBox();
            this.BtnComparar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAsteriscos = new System.Windows.Forms.Button();
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPalavra1
            // 
            this.txtPalavra1.Location = new System.Drawing.Point(311, 102);
            this.txtPalavra1.Name = "txtPalavra1";
            this.txtPalavra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra1.TabIndex = 0;
            this.txtPalavra1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavra_KeyPress);
            // 
            // txtPalavra2
            // 
            this.txtPalavra2.Location = new System.Drawing.Point(311, 173);
            this.txtPalavra2.Name = "txtPalavra2";
            this.txtPalavra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra2.TabIndex = 1;
            this.txtPalavra2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavra_KeyPress);
            // 
            // BtnComparar
            // 
            this.BtnComparar.Location = new System.Drawing.Point(191, 296);
            this.BtnComparar.Name = "BtnComparar";
            this.BtnComparar.Size = new System.Drawing.Size(75, 55);
            this.BtnComparar.TabIndex = 2;
            this.BtnComparar.Text = "Comparar";
            this.BtnComparar.UseVisualStyleBackColor = true;
            this.BtnComparar.Click += new System.EventHandler(this.BtnComparar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(326, 296);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 55);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir Primeiro no Segundo";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAsteriscos
            // 
            this.btnAsteriscos.Location = new System.Drawing.Point(460, 296);
            this.btnAsteriscos.Name = "btnAsteriscos";
            this.btnAsteriscos.Size = new System.Drawing.Size(75, 55);
            this.btnAsteriscos.TabIndex = 4;
            this.btnAsteriscos.Text = "Inserir 2 Asteriscos";
            this.btnAsteriscos.UseVisualStyleBackColor = true;
            this.btnAsteriscos.Click += new System.EventHandler(this.btnAsteriscos_Click);
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(125, 105);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 5;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(125, 176);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 6;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Controls.Add(this.btnAsteriscos);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.BtnComparar);
            this.Controls.Add(this.txtPalavra2);
            this.Controls.Add(this.txtPalavra1);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPalavra1;
        private System.Windows.Forms.TextBox txtPalavra2;
        private System.Windows.Forms.Button BtnComparar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAsteriscos;
        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
    }
}