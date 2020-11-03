namespace wfaEstruturas
{
    partial class frmExercicio1
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.rtxTexto = new System.Windows.Forms.RichTextBox();
            this.btnEspacoEmBranco = new System.Windows.Forms.Button();
            this.btnContaR = new System.Windows.Forms.Button();
            this.btnParDeLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(135, 144);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(34, 13);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Texto";
            // 
            // rtxTexto
            // 
            this.rtxTexto.Location = new System.Drawing.Point(194, 141);
            this.rtxTexto.MaxLength = 100;
            this.rtxTexto.Name = "rtxTexto";
            this.rtxTexto.Size = new System.Drawing.Size(339, 96);
            this.rtxTexto.TabIndex = 1;
            this.rtxTexto.Text = "";
            // 
            // btnEspacoEmBranco
            // 
            this.btnEspacoEmBranco.Location = new System.Drawing.Point(217, 311);
            this.btnEspacoEmBranco.Name = "btnEspacoEmBranco";
            this.btnEspacoEmBranco.Size = new System.Drawing.Size(75, 44);
            this.btnEspacoEmBranco.TabIndex = 2;
            this.btnEspacoEmBranco.Text = "Espaço em Branco";
            this.btnEspacoEmBranco.UseVisualStyleBackColor = true;
            this.btnEspacoEmBranco.Click += new System.EventHandler(this.btnEspacoEmBranco_Click);
            // 
            // btnContaR
            // 
            this.btnContaR.Location = new System.Drawing.Point(329, 311);
            this.btnContaR.Name = "btnContaR";
            this.btnContaR.Size = new System.Drawing.Size(75, 44);
            this.btnContaR.TabIndex = 3;
            this.btnContaR.Text = "Conta R";
            this.btnContaR.UseVisualStyleBackColor = true;
            this.btnContaR.Click += new System.EventHandler(this.btnContaR_Click);
            // 
            // btnParDeLetras
            // 
            this.btnParDeLetras.Location = new System.Drawing.Point(432, 311);
            this.btnParDeLetras.Name = "btnParDeLetras";
            this.btnParDeLetras.Size = new System.Drawing.Size(75, 44);
            this.btnParDeLetras.TabIndex = 4;
            this.btnParDeLetras.Text = "Par de Letras";
            this.btnParDeLetras.UseVisualStyleBackColor = true;
            this.btnParDeLetras.Click += new System.EventHandler(this.btnParDeLetras_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParDeLetras);
            this.Controls.Add(this.btnContaR);
            this.Controls.Add(this.btnEspacoEmBranco);
            this.Controls.Add(this.rtxTexto);
            this.Controls.Add(this.lblTexto);
            this.Name = "frmExercicio1";
            this.Text = "LOOP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.RichTextBox rtxTexto;
        private System.Windows.Forms.Button btnEspacoEmBranco;
        private System.Windows.Forms.Button btnContaR;
        private System.Windows.Forms.Button btnParDeLetras;
    }
}