namespace NegozioStrumentiMusicali
{
    partial class FrmHome
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mioUtenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negoziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseProduttriciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mioUtenteToolStripMenuItem,
            this.utentiToolStripMenuItem,
            this.negoziToolStripMenuItem,
            this.ordiniToolStripMenuItem,
            this.strumentiToolStripMenuItem,
            this.caseProduttriciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mioUtenteToolStripMenuItem
            // 
            this.mioUtenteToolStripMenuItem.Name = "mioUtenteToolStripMenuItem";
            this.mioUtenteToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mioUtenteToolStripMenuItem.Text = "<nomeUtente>";
            // 
            // utentiToolStripMenuItem
            // 
            this.utentiToolStripMenuItem.Name = "utentiToolStripMenuItem";
            this.utentiToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.utentiToolStripMenuItem.Text = "Utenti";
            // 
            // negoziToolStripMenuItem
            // 
            this.negoziToolStripMenuItem.Name = "negoziToolStripMenuItem";
            this.negoziToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.negoziToolStripMenuItem.Text = "Negozi";
            // 
            // ordiniToolStripMenuItem
            // 
            this.ordiniToolStripMenuItem.Name = "ordiniToolStripMenuItem";
            this.ordiniToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ordiniToolStripMenuItem.Text = "Ordini";
            // 
            // strumentiToolStripMenuItem
            // 
            this.strumentiToolStripMenuItem.Name = "strumentiToolStripMenuItem";
            this.strumentiToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.strumentiToolStripMenuItem.Text = "Strumenti";
            // 
            // caseProduttriciToolStripMenuItem
            // 
            this.caseProduttriciToolStripMenuItem.Name = "caseProduttriciToolStripMenuItem";
            this.caseProduttriciToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.caseProduttriciToolStripMenuItem.Text = "Case produttrici";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmHome";
            this.Text = "Negozi di strumenti musicali";
            this.Load += new System.EventHandler(this.msHome_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mioUtenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negoziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strumentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseProduttriciToolStripMenuItem;
    }
}

