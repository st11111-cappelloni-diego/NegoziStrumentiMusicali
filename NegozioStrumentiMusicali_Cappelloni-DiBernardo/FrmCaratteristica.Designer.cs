namespace NegozioStrumentiMusicali
{
    partial class FrmCaratteristica
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
            this.rtbCaratteristica = new System.Windows.Forms.RichTextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbCaratteristica
            // 
            this.rtbCaratteristica.Location = new System.Drawing.Point(16, 15);
            this.rtbCaratteristica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbCaratteristica.Name = "rtbCaratteristica";
            this.rtbCaratteristica.Size = new System.Drawing.Size(723, 408);
            this.rtbCaratteristica.TabIndex = 0;
            this.rtbCaratteristica.Text = "";
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(603, 503);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(140, 36);
            this.btnSalva.TabIndex = 21;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // FrmCaratteristica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 554);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.rtbCaratteristica);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCaratteristica";
            this.Text = "FrmCaratteristica";
            this.Load += new System.EventHandler(this.FrmCaratteristica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCaratteristica;
        private System.Windows.Forms.Button btnSalva;
    }
}