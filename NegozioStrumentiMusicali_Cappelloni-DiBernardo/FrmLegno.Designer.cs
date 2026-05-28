namespace NegozioStrumentiMusicali
{
    partial class FrmLegno
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbStrumento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaterialeCorpo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaterialeChiavi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAltezza = new System.Windows.Forms.NumericUpDown();
            this.btnSalva = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudLunghezza = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudLarghezza = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltezza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLunghezza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLarghezza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Strumento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStrumento
            // 
            this.cbStrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStrumento.FormattingEnabled = true;
            this.cbStrumento.Location = new System.Drawing.Point(118, 7);
            this.cbStrumento.Name = "cbStrumento";
            this.cbStrumento.Size = new System.Drawing.Size(416, 28);
            this.cbStrumento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Materiale corpo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaterialeCorpo
            // 
            this.cbMaterialeCorpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterialeCorpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterialeCorpo.FormattingEnabled = true;
            this.cbMaterialeCorpo.Location = new System.Drawing.Point(12, 83);
            this.cbMaterialeCorpo.Name = "cbMaterialeCorpo";
            this.cbMaterialeCorpo.Size = new System.Drawing.Size(258, 28);
            this.cbMaterialeCorpo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(276, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Materiale chiavi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaterialeChiavi
            // 
            this.cbMaterialeChiavi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterialeChiavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterialeChiavi.FormattingEnabled = true;
            this.cbMaterialeChiavi.Location = new System.Drawing.Point(276, 83);
            this.cbMaterialeChiavi.Name = "cbMaterialeChiavi";
            this.cbMaterialeChiavi.Size = new System.Drawing.Size(258, 28);
            this.cbMaterialeChiavi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Altezza [cm]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAltezza
            // 
            this.nudAltezza.DecimalPlaces = 2;
            this.nudAltezza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAltezza.Location = new System.Drawing.Point(12, 137);
            this.nudAltezza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAltezza.Name = "nudAltezza";
            this.nudAltezza.Size = new System.Drawing.Size(258, 26);
            this.nudAltezza.TabIndex = 11;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(429, 259);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(105, 29);
            this.btnSalva.TabIndex = 20;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lunghezza [cm]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudLunghezza
            // 
            this.nudLunghezza.DecimalPlaces = 2;
            this.nudLunghezza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLunghezza.Location = new System.Drawing.Point(276, 137);
            this.nudLunghezza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLunghezza.Name = "nudLunghezza";
            this.nudLunghezza.Size = new System.Drawing.Size(258, 26);
            this.nudLunghezza.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Larghezza [cm]";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudLarghezza
            // 
            this.nudLarghezza.DecimalPlaces = 2;
            this.nudLarghezza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLarghezza.Location = new System.Drawing.Point(145, 189);
            this.nudLarghezza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLarghezza.Name = "nudLarghezza";
            this.nudLarghezza.Size = new System.Drawing.Size(258, 26);
            this.nudLarghezza.TabIndex = 24;
            // 
            // FrmLegno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudLarghezza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudLunghezza);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudAltezza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMaterialeChiavi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaterialeCorpo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStrumento);
            this.MaximizeBox = false;
            this.Name = "FrmLegno";
            this.Text = "Legno";
            this.Load += new System.EventHandler(this.FrmLegno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAltezza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLunghezza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLarghezza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStrumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaterialeCorpo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaterialeChiavi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAltezza;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudLunghezza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudLarghezza;
    }
}