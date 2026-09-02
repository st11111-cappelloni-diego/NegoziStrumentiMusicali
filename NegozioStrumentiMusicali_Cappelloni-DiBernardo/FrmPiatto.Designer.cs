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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiametro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(351, 260);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(140, 36);
            this.btnSalva.TabIndex = 26;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 144);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(473, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "Materiale";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMateriale
            // 
            this.cbMateriale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateriale.FormattingEnabled = true;
            this.cbMateriale.Location = new System.Drawing.Point(17, 172);
            this.cbMateriale.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMateriale.Name = "cbMateriale";
            this.cbMateriale.Size = new System.Drawing.Size(472, 33);
            this.cbMateriale.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 77);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(473, 25);
            this.label15.TabIndex = 21;
            this.label15.Text = "Diametro [in]";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDiametro
            // 
            this.nudDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiametro.Location = new System.Drawing.Point(17, 108);
            this.nudDiametro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDiametro.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDiametro.Name = "nudDiametro";
            this.nudDiametro.Size = new System.Drawing.Size(473, 30);
            this.nudDiametro.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(18, 40);
            this.cbTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(472, 33);
            this.cbTipo.TabIndex = 28;
            // 
            // FrmPiatto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbMateriale);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nudDiametro);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipo;
    }
}