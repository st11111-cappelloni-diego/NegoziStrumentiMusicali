namespace NegozioStrumentiMusicali
{
    partial class FrmPiatto
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
            this.btnSalva = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMateriale = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nudDiametro = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiametro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(262, 174);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(105, 29);
            this.btnSalva.TabIndex = 26;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(355, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Materiale";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMateriale
            // 
            this.cbMateriale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateriale.FormattingEnabled = true;
            this.cbMateriale.Location = new System.Drawing.Point(12, 86);
            this.cbMateriale.Name = "cbMateriale";
            this.cbMateriale.Size = new System.Drawing.Size(355, 28);
            this.cbMateriale.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(355, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "Diametro [in]";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDiametro
            // 
            this.nudDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiametro.Location = new System.Drawing.Point(12, 34);
            this.nudDiametro.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDiametro.Name = "nudDiametro";
            this.nudDiametro.Size = new System.Drawing.Size(355, 26);
            this.nudDiametro.TabIndex = 23;
            // 
            // FrmPiatto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 212);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbMateriale);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nudDiametro);
            this.Name = "FrmPiatto";
            this.Text = "FrmPiatto";
            this.Load += new System.EventHandler(this.FrmPiatto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiametro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMateriale;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudDiametro;
    }
}