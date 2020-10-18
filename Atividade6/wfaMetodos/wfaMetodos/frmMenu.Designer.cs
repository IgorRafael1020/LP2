namespace wfaMetodos
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
            this.components = new System.ComponentModel.Container();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiExercicio2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiColar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExercicio3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExercicio4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExercicio5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu.SuspendLayout();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExercicio2,
            this.tsmiExercicio3,
            this.tsmiExercicio4,
            this.tsmiExercicio5,
            this.tsmiSair});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1035, 24);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tsmiExercicio2
            // 
            this.tsmiExercicio2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCopiar,
            this.tsmiColar});
            this.tsmiExercicio2.Name = "tsmiExercicio2";
            this.tsmiExercicio2.Size = new System.Drawing.Size(74, 20);
            this.tsmiExercicio2.Text = "Exercício &2";
            this.tsmiExercicio2.Click += new System.EventHandler(this.tsmiExercicio2_Click);
            // 
            // tsmiCopiar
            // 
            this.tsmiCopiar.Name = "tsmiCopiar";
            this.tsmiCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmiCopiar.Size = new System.Drawing.Size(151, 22);
            this.tsmiCopiar.Text = "Copiar";
            this.tsmiCopiar.Click += new System.EventHandler(this.tsmiCopiar_Click);
            // 
            // tsmiColar
            // 
            this.tsmiColar.Name = "tsmiColar";
            this.tsmiColar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmiColar.Size = new System.Drawing.Size(151, 22);
            this.tsmiColar.Text = "Colar";
            this.tsmiColar.Click += new System.EventHandler(this.tsmiColar_Click);
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
            // tsmiExercicio5
            // 
            this.tsmiExercicio5.Name = "tsmiExercicio5";
            this.tsmiExercicio5.Size = new System.Drawing.Size(74, 20);
            this.tsmiExercicio5.Text = "Exercício &5";
            this.tsmiExercicio5.Click += new System.EventHandler(this.tsmiExercicio5_Click);
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.Size = new System.Drawing.Size(38, 20);
            this.tsmiSair.Text = "&Sair";
            this.tsmiSair.Click += new System.EventHandler(this.tsmiSair_Click);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.editorDeTextoToolStripMenuItem});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(151, 48);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // editorDeTextoToolStripMenuItem
            // 
            this.editorDeTextoToolStripMenuItem.Name = "editorDeTextoToolStripMenuItem";
            this.editorDeTextoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editorDeTextoToolStripMenuItem.Text = "Editor de texto";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 565);
            this.ContextMenuStrip = this.cmsMenu;
            this.Controls.Add(this.mnsMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiExercicio2;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopiar;
        private System.Windows.Forms.ToolStripMenuItem tsmiColar;
        private System.Windows.Forms.ToolStripMenuItem tsmiExercicio3;
        private System.Windows.Forms.ToolStripMenuItem tsmiExercicio4;
        private System.Windows.Forms.ToolStripMenuItem tsmiExercicio5;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeTextoToolStripMenuItem;
    }
}

