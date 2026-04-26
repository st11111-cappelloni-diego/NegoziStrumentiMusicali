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
            this.msHome = new System.Windows.Forms.MenuStrip();
            this.mioUtenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negoziToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordiniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseProduttriciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // msHome
            // 
            this.msHome.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mioUtenteToolStripMenuItem,
            this.utentiToolStripMenuItem,
            this.negoziToolStripMenuItem,
            this.ordiniToolStripMenuItem,
            this.strumentiToolStripMenuItem,
            this.caseProduttriciToolStripMenuItem});
            this.msHome.Location = new System.Drawing.Point(0, 0);
            this.msHome.Name = "msHome";
            this.msHome.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msHome.Size = new System.Drawing.Size(1579, 28);
            this.msHome.TabIndex = 0;
            this.msHome.Text = "menuStrip1";
            // 
            // mioUtenteToolStripMenuItem
            // 
            this.mioUtenteToolStripMenuItem.Name = "mioUtenteToolStripMenuItem";
            this.mioUtenteToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.mioUtenteToolStripMenuItem.Text = "<nomeUtente>";
            this.mioUtenteToolStripMenuItem.Click += new System.EventHandler(this.mioUtenteToolStripMenuItem_Click);
            // 
            // utentiToolStripMenuItem
            // 
            this.utentiToolStripMenuItem.Name = "utentiToolStripMenuItem";
            this.utentiToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.utentiToolStripMenuItem.Text = "Utenti";
            this.utentiToolStripMenuItem.Click += new System.EventHandler(this.utentiToolStripMenuItem_Click);
            // 
            // negoziToolStripMenuItem
            // 
            this.negoziToolStripMenuItem.Name = "negoziToolStripMenuItem";
            this.negoziToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.negoziToolStripMenuItem.Text = "Negozi";
            this.negoziToolStripMenuItem.Click += new System.EventHandler(this.negoziToolStripMenuItem_Click);
            // 
            // ordiniToolStripMenuItem
            // 
            this.ordiniToolStripMenuItem.Name = "ordiniToolStripMenuItem";
            this.ordiniToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ordiniToolStripMenuItem.Text = "Ordini";
            this.ordiniToolStripMenuItem.Click += new System.EventHandler(this.ordiniToolStripMenuItem_Click);
            // 
            // strumentiToolStripMenuItem
            // 
            this.strumentiToolStripMenuItem.Name = "strumentiToolStripMenuItem";
            this.strumentiToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.strumentiToolStripMenuItem.Text = "Strumenti";
            this.strumentiToolStripMenuItem.Click += new System.EventHandler(this.strumentiToolStripMenuItem_Click);
            // 
            // caseProduttriciToolStripMenuItem
            // 
            this.caseProduttriciToolStripMenuItem.Name = "caseProduttriciToolStripMenuItem";
            this.caseProduttriciToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.caseProduttriciToolStripMenuItem.Text = "Case produttrici";
            this.caseProduttriciToolStripMenuItem.Click += new System.EventHandler(this.caseProduttriciToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1579, 875);
            this.Controls.Add(this.msHome);
            this.MainMenuStrip = this.msHome;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHome";
            this.Text = "Negozi di strumenti musicali";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.msHome.ResumeLayout(false);
            this.msHome.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msHome;
        private System.Windows.Forms.ToolStripMenuItem mioUtenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negoziToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordiniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strumentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseProduttriciToolStripMenuItem;
    }
}

