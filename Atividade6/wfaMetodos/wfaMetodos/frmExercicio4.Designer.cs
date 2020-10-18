namespace wfaMetodos
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.rtxTexto = new System.Windows.Forms.RichTextBox();
            this.btnContaNumero = new System.Windows.Forms.Button();
            this.btnContaEspaço = new System.Windows.Forms.Button();
            this.btnContaLetra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(44, 83);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(34, 13);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Texto";
            // 
            // rtxTexto
            // 
            this.rtxTexto.Location = new System.Drawing.Point(115, 83);
            this.rtxTexto.Name = "rtxTexto";
            this.rtxTexto.Size = new System.Drawing.Size(469, 148);
            this.rtxTexto.TabIndex = 1;
            this.rtxTexto.Text = "";
            this.rtxTexto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPalavra_KeyPress);
            // 
            // btnContaNumero
            // 
            this.btnContaNumero.Location = new System.Drawing.Point(115, 296);
            this.btnContaNumero.Name = "btnContaNumero";
            this.btnContaNumero.Size = new System.Drawing.Size(75, 38);
            this.btnContaNumero.TabIndex = 2;
            this.btnContaNumero.Text = "Conta Números";
            this.btnContaNumero.UseVisualStyleBackColor = true;
            this.btnContaNumero.Click += new System.EventHandler(this.btnContaNumero_Click);
            // 
            // btnContaEspaço
            // 
            this.btnContaEspaço.Location = new System.Drawing.Point(313, 295);
            this.btnContaEspaço.Name = "btnContaEspaço";
            this.btnContaEspaço.Size = new System.Drawing.Size(75, 39);
            this.btnContaEspaço.TabIndex = 3;
            this.btnContaEspaço.Text = "Conta Espaços";
            this.btnContaEspaço.UseVisualStyleBackColor = true;
            this.btnContaEspaço.Click += new System.EventHandler(this.btnContaEspaço_Click);
            // 
            // btnContaLetra
            // 
            this.btnContaLetra.Location = new System.Drawing.Point(509, 295);
            this.btnContaLetra.Name = "btnContaLetra";
            this.btnContaLetra.Size = new System.Drawing.Size(75, 39);
            this.btnContaLetra.TabIndex = 4;
            this.btnContaLetra.Text = "Conta Letras";
            this.btnContaLetra.UseVisualStyleBackColor = true;
            this.btnContaLetra.Click += new System.EventHandler(this.btnContaLetra_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContaLetra);
            this.Controls.Add(this.btnContaEspaço);
            this.Controls.Add(this.btnContaNumero);
            this.Controls.Add(this.rtxTexto);
            this.Controls.Add(this.lblTexto);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.RichTextBox rtxTexto;
        private System.Windows.Forms.Button btnContaNumero;
        private System.Windows.Forms.Button btnContaEspaço;
        private System.Windows.Forms.Button btnContaLetra;
    }
}