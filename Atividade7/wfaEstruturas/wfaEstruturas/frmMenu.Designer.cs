namespace wfaEstruturas
{
    partial class frmMenu
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
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiExercicio1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExercicio2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExercicio3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExercicio4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExercicio1,
            this.tsmiExercicio2,
            this.tsmiExercicio3,
            this.tsmiExercicio4,
            this.tsmiSair});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(800, 24);
            this.mnsMenu.TabIndex = 1;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tsmiExercicio1
            // 
            this.tsmiExercicio1.Name = "tsmiExercicio1";
            this.tsmiExercicio1.Size = new System.Drawing.Size(74, 20);
            this.tsmiExercicio1.Text = "Exercício &1";
            this.tsmiExercicio1.Click += new System.EventHandler(this.tsmiExercicio1_Click);
            // 
            // tsmiExercicio2
            // 
            this.tsmiExercicio2.Name = "tsmiExercicio2";
            this.tsmiExercicio2.Size = new System.Drawing.Size(74, 20);
            this.tsmiExercicio2.Text = "Exercício &2";
            this.tsmiExercicio2.Click += new System.EventHandler(this.tsmiExercicio2_Click);
            // 
            // tsmiExercicio3
            // 
            this.tsmiExercicio3.Name = "tsmiExercicio3";
            this.tsmiExercicio3.Size = new System.Drawing.Size(74, 20);
            this.tsmiExercicio3.Text = "Exercício &3";
            this.tsmiExercicio3.Click += new System.EventHandler(this.tsmiExercicio3_Click);
            // 
            // tsmiExercicio4
            // 
            this.tsmiExercicio4.Name = "tsmiExercicio4";
            this.tsmiExercicio4.Size = new System.Drawing.Size(74, 20);
            this.tsmiExercicio4.Text = "Exercício &4";
            this.tsmiExercicio4.Click += new System.EventHandler(this.tsmiExercicio4_Click);
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.Size = new System.Drawing.Size(38, 20);
            this.tsmiSair.Text = "&Sair";
            this.tsmiSair.Click += new System.EventHandler(this.tsmiSair_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnsMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiExercicio1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExercicio2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExercicio3;
        private System.Windows.Forms.ToolStripMenuItem tsmiExercicio4;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
    }
}

