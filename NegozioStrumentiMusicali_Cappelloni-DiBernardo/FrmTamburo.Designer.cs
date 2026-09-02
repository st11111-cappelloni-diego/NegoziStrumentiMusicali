namespace NegozioStrumentiMusicali
{
    partial class FrmTamburo
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
            this.label12 = new System.Windows.Forms.Label();
            this.cbMateriale = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nudStrati = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nudDiametro = new System.Windows.Forms.NumericUpDown();
            this.btnSalva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudStrati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiametro)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(355, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Materiale";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMateriale
            // 
            this.cbMateriale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateriale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMateriale.FormattingEnabled = true;
            this.cbMateriale.Location = new System.Drawing.Point(14, 197);
            this.cbMateriale.Name = "cbMateriale";
            this.cbMateriale.Size = new System.Drawing.Size(355, 28);
            this.cbMateriale.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(14, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(356, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Strati";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudStrati
            // 
            this.nudStrati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStrati.Location = new System.Drawing.Point(14, 143);
            this.nudStrati.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudStrati.Name = "nudStrati";
            this.nudStrati.Size = new System.Drawing.Size(355, 26);
            this.nudStrati.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(355, 20);
            this.label15.TabIndex = 12;
            this.label15.Text = "Diametro [in]";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudDiametro
            // 
            this.nudDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDiametro.Location = new System.Drawing.Point(14, 88);
            this.nudDiametro.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDiametro.Name = "nudDiametro";
            this.nudDiametro.Size = new System.Drawing.Size(355, 26);
            this.nudDiametro.TabIndex = 14;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(265, 271);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(105, 29);
            this.btnSalva.TabIndex = 19;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(14, 34);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(355, 28);
            this.cbTipo.TabIndex = 21;
            // 
            // FrmTamburo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbMateriale);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nudStrati);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nudDiametro);
            this.MaximizeBox = false;
            this.Name = "FrmTamburo";
            this.Text = "FrmTamburo";
            this.Load += new System.EventHandler(this.FrmTamburo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudStrati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiametro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbMateriale;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudStrati;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudDiametro;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipo;
    }
}