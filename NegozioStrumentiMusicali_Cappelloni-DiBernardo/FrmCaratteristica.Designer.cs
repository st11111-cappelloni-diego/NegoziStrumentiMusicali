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
            this.rtbCaratteristica.Location = new System.Drawing.Point(12, 12);
            this.rtbCaratteristica.Name = "rtbCaratteristica";
            this.rtbCaratteristica.Size = new System.Drawing.Size(543, 332);
            this.rtbCaratteristica.TabIndex = 0;
            this.rtbCaratteristica.Text = "";
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(452, 409);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(105, 29);
            this.btnSalva.TabIndex = 21;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // FrmCaratteristica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.rtbCaratteristica);
            this.Name = "FrmCaratteristica";
            this.Text = "FrmCaratteristica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCaratteristica;
        private System.Windows.Forms.Button btnSalva;
    }
}