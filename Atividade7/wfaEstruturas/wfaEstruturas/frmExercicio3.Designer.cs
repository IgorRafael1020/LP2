namespace wfaEstruturas
{
    partial class frmExercicio3
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
            this.btnPalindromo = new System.Windows.Forms.Button();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPalindromo
            // 
            this.btnPalindromo.Location = new System.Drawing.Point(304, 287);
            this.btnPalindromo.Name = "btnPalindromo";
            this.btnPalindromo.Size = new System.Drawing.Size(100, 39);
            this.btnPalindromo.TabIndex = 2;
            this.btnPalindromo.Text = "Verifica se é palíndromo";
            this.btnPalindromo.UseVisualStyleBackColor = true;
            this.btnPalindromo.Click += new System.EventHandler(this.btnPalindromo_Click);
            // 
            // txtPalavra
            // 
            this.txtPalavra.Location = new System.Drawing.Point(304, 156);
            this.txtPalavra.MaxLength = 50;
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(100, 20);
            this.txtPalavra.TabIndex = 1;
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.Location = new System.Drawing.Point(234, 159);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(43, 13);
            this.lblPalavra.TabIndex = 0;
            this.lblPalavra.Text = "Palavra";
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPalindromo);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.lblPalavra);
            this.Name = "frmExercicio3";
            this.Text = "Palíndromo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPalindromo;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Label lblPalavra;
    }
}