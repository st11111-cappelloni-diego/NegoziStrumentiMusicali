namespace NegozioStrumentiMusicali
{
    partial class FrmOttone
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaterialeBocchino = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRivestimentoBocchino = new System.Windows.Forms.ComboBox();
            this.ckbLaccatura = new System.Windows.Forms.CheckBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Strumento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStrumento
            // 
            this.cbStrumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStrumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStrumento.FormattingEnabled = true;
            this.cbStrumento.Location = new System.Drawing.Point(98, 7);
            this.cbStrumento.Name = "cbStrumento";
            this.cbStrumento.Size = new System.Drawing.Size(436, 28);
            this.cbStrumento.TabIndex = 2;
            this.cbStrumento.SelectedIndexChanged += new System.EventHandler(this.cbStrumento_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Materiale corpo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaterialeCorpo
            // 
            this.cbMaterialeCorpo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterialeCorpo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterialeCorpo.FormattingEnabled = true;
            this.cbMaterialeCorpo.Location = new System.Drawing.Point(12, 82);
            this.cbMaterialeCorpo.Name = "cbMaterialeCorpo";
            this.cbMaterialeCorpo.Size = new System.Drawing.Size(258, 28);
            this.cbMaterialeCorpo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Placcatura";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 28);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Materiale bocchino";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaterialeBocchino
            // 
            this.cbMaterialeBocchino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterialeBocchino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaterialeBocchino.FormattingEnabled = true;
            this.cbMaterialeBocchino.Location = new System.Drawing.Point(276, 82);
            this.cbMaterialeBocchino.Name = "cbMaterialeBocchino";
            this.cbMaterialeBocchino.Size = new System.Drawing.Size(258, 28);
            this.cbMaterialeBocchino.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Rivestimento bocchino";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbRivestimentoBocchino
            // 
            this.cbRivestimentoBocchino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRivestimentoBocchino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRivestimentoBocchino.FormattingEnabled = true;
            this.cbRivestimentoBocchino.Location = new System.Drawing.Point(276, 136);
            this.cbRivestimentoBocchino.Name = "cbRivestimentoBocchino";
            this.cbRivestimentoBocchino.Size = new System.Drawing.Size(258, 28);
            this.cbRivestimentoBocchino.TabIndex = 11;
            // 
            // ckbLaccatura
            // 
            this.ckbLaccatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLaccatura.Location = new System.Drawing.Point(12, 179);
            this.ckbLaccatura.Name = "ckbLaccatura";
            this.ckbLaccatura.Size = new System.Drawing.Size(258, 24);
            this.ckbLaccatura.TabIndex = 12;
            this.ckbLaccatura.Text = "Laccatura";
            this.ckbLaccatura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbLaccatura.UseVisualStyleBackColor = true;
            // 
            // btnSalva
            // 
            this.btnSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalva.Location = new System.Drawing.Point(429, 191);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(105, 29);
            this.btnSalva.TabIndex = 19;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            // 
            // FrmOttone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 232);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.ckbLaccatura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbRivestimentoBocchino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMaterialeBocchino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMaterialeCorpo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStrumento);
            this.MaximizeBox = false;
            this.Name = "FrmOttone";
            this.Text = "FrmOttone";
            this.Load += new System.EventHandler(this.FrmOttone_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStrumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaterialeCorpo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaterialeBocchino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRivestimentoBocchino;
        private System.Windows.Forms.CheckBox ckbLaccatura;
        private System.Windows.Forms.Button btnSalva;
    }
}