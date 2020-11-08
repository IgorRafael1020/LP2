namespace wfaArray
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
            this.btnArmazem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArmazem
            // 
            this.btnArmazem.Location = new System.Drawing.Point(348, 284);
            this.btnArmazem.Name = "btnArmazem";
            this.btnArmazem.Size = new System.Drawing.Size(80, 40);
            this.btnArmazem.TabIndex = 0;
            this.btnArmazem.Text = "Quantidade e Preço";
            this.btnArmazem.UseVisualStyleBackColor = true;
            this.btnArmazem.Click += new System.EventHandler(this.btnArmazem_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArmazem);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArmazem;
    }
}