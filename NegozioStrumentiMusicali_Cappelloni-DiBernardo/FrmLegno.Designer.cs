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
            ((System.ComponentModel.ISupportInitialize)(this.nudAltezza)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Strumento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStrumento
            // 
            this.cbStrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStrumento.FormattingEnabled = true;
            this.cbStrumento.Location = new System.Drawing.Point(157, 9);
            this.cbStrumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbStrumento.Name = "cbStrumento";
            this.cbStrumento.Size = new System.Drawing.Size(553, 33);
            this.cbStrumento.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Materiale corpo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaterialeCorpo
            // 
            this.cbMaterialeCorpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterialeCorpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterialeCorpo.FormattingEnabled = true;
            this.cbMaterialeCorpo.Location = new System.Drawing.Point(16, 102);
            this.cbMaterialeCorpo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaterialeCorpo.Name = "cbMaterialeCorpo";
            this.cbMaterialeCorpo.Size = new System.Drawing.Size(343, 33);
            this.cbMaterialeCorpo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Materiale chiavi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaterialeChiavi
            // 
            this.cbMaterialeChiavi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterialeChiavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterialeChiavi.FormattingEnabled = true;
            this.cbMaterialeChiavi.Location = new System.Drawing.Point(368, 102);
            this.cbMaterialeChiavi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaterialeChiavi.Name = "cbMaterialeChiavi";
            this.cbMaterialeChiavi.Size = new System.Drawing.Size(343, 33);
            this.cbMaterialeChiavi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Altezza [cm]";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudAltezza
            // 
            this.nudAltezza.DecimalPlaces = 2;
            this.nudAltezza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAltezza.Location = new System.Drawing.Point(16, 169);
            this.nudAltezza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudAltezza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAltezza.Name = "nudAltezza";
            this.nudAltezza.Size = new System.Drawing.Size(344, 30);
            this.nudAltezza.TabIndex = 11;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(572, 165);
            this.btnSalva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(140, 36);
            this.btnSalva.TabIndex = 20;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // FrmLegno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 220);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudAltezza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMaterialeChiavi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaterialeCorpo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStrumento);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmLegno";
            this.Text = "FrmLegno";
            this.Load += new System.EventHandler(this.FrmLegno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAltezza)).EndInit();
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
    }
}