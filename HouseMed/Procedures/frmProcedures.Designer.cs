namespace HouseMed.Procedures
{
    partial class frmProcedures
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
            this.labelPacijentIspis = new System.Windows.Forms.Label();
            this.labelPacijentText = new System.Windows.Forms.Label();
            this.btnOdaberi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDatum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnamneza = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDijagnoza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTerapija = new System.Windows.Forms.TextBox();
            this.tbPreporuka = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.ucNatrag1 = new HouseMed.ucNatrag();
            this.SuspendLayout();
            // 
            // labelPacijentIspis
            // 
            this.labelPacijentIspis.AutoSize = true;
            this.labelPacijentIspis.Location = new System.Drawing.Point(125, 26);
            this.labelPacijentIspis.Name = "labelPacijentIspis";
            this.labelPacijentIspis.Size = new System.Drawing.Size(35, 13);
            this.labelPacijentIspis.TabIndex = 0;
            this.labelPacijentIspis.Text = "label1";
            // 
            // labelPacijentText
            // 
            this.labelPacijentText.AutoSize = true;
            this.labelPacijentText.Location = new System.Drawing.Point(12, 26);
            this.labelPacijentText.Name = "labelPacijentText";
            this.labelPacijentText.Size = new System.Drawing.Size(104, 13);
            this.labelPacijentText.TabIndex = 1;
            this.labelPacijentText.Text = "Pacijent u postupku:";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Location = new System.Drawing.Point(249, 21);
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(75, 23);
            this.btnOdaberi.TabIndex = 2;
            this.btnOdaberi.Text = "Odaberi";
            this.btnOdaberi.UseVisualStyleBackColor = true;
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Današnji datum:";
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.Location = new System.Drawing.Point(125, 51);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(35, 13);
            this.labelDatum.TabIndex = 4;
            this.labelDatum.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anamneza:";
            // 
            // tbAnamneza
            // 
            this.tbAnamneza.Location = new System.Drawing.Point(128, 74);
            this.tbAnamneza.Multiline = true;
            this.tbAnamneza.Name = "tbAnamneza";
            this.tbAnamneza.Size = new System.Drawing.Size(205, 81);
            this.tbAnamneza.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status:";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(128, 161);
            this.tbStatus.Multiline = true;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(205, 33);
            this.tbStatus.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dijagnoza:";
            // 
            // tbDijagnoza
            // 
            this.tbDijagnoza.Location = new System.Drawing.Point(128, 200);
            this.tbDijagnoza.Multiline = true;
            this.tbDijagnoza.Name = "tbDijagnoza";
            this.tbDijagnoza.Size = new System.Drawing.Size(205, 48);
            this.tbDijagnoza.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Terapija:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Preporuka:";
            // 
            // tbTerapija
            // 
            this.tbTerapija.Location = new System.Drawing.Point(128, 254);
            this.tbTerapija.Multiline = true;
            this.tbTerapija.Name = "tbTerapija";
            this.tbTerapija.Size = new System.Drawing.Size(205, 33);
            this.tbTerapija.TabIndex = 13;
            // 
            // tbPreporuka
            // 
            this.tbPreporuka.Location = new System.Drawing.Point(128, 293);
            this.tbPreporuka.Multiline = true;
            this.tbPreporuka.Name = "tbPreporuka";
            this.tbPreporuka.Size = new System.Drawing.Size(205, 33);
            this.tbPreporuka.TabIndex = 14;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(101, 345);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(232, 23);
            this.btnSpremi.TabIndex = 15;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // ucNatrag1
            // 
            this.ucNatrag1.Location = new System.Drawing.Point(15, 345);
            this.ucNatrag1.Name = "ucNatrag1";
            this.ucNatrag1.Size = new System.Drawing.Size(80, 23);
            this.ucNatrag1.TabIndex = 16;
            // 
            // frmProcedures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 380);
            this.Controls.Add(this.ucNatrag1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.tbPreporuka);
            this.Controls.Add(this.tbTerapija);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbDijagnoza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAnamneza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdaberi);
            this.Controls.Add(this.labelPacijentText);
            this.Controls.Add(this.labelPacijentIspis);
            this.KeyPreview = true;
            this.Name = "frmProcedures";
            this.Text = "frmProcedures";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProcedures_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPacijentIspis;
        private System.Windows.Forms.Label labelPacijentText;
        private System.Windows.Forms.Button btnOdaberi;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAnamneza;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDijagnoza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTerapija;
        private System.Windows.Forms.TextBox tbPreporuka;
        private System.Windows.Forms.Button btnSpremi;
        private ucNatrag ucNatrag1;
    }
}