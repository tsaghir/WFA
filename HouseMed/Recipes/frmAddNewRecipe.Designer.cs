namespace HouseMed.Recipes
{
    partial class frmAddNewRecipe
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
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtDoziranje = new System.Windows.Forms.TextBox();
            this.lblDoziranje = new System.Windows.Forms.Label();
            this.lblPacijent = new System.Windows.Forms.Label();
            this.txtPacijent = new System.Windows.Forms.TextBox();
            this.btnChoosePatient = new System.Windows.Forms.Button();
            this.chckNadoplata = new System.Windows.Forms.CheckBox();
            this.lblDjelatnici = new System.Windows.Forms.Label();
            this.comboDjelatnici = new System.Windows.Forms.ComboBox();
            this.gbUstanova = new System.Windows.Forms.GroupBox();
            this.comboUstanova = new System.Windows.Forms.ComboBox();
            this.lblUstanova = new System.Windows.Forms.Label();
            this.lblLijekovi = new System.Windows.Forms.Label();
            this.gbPacijent = new System.Windows.Forms.GroupBox();
            this.txtSlucaj = new System.Windows.Forms.TextBox();
            this.lblSlucaj = new System.Windows.Forms.Label();
            this.btnChooseMedicine = new System.Windows.Forms.Button();
            this.txtLijekovi = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbUstanova.SuspendLayout();
            this.gbPacijent.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(12, 74);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(50, 13);
            this.lblKolicina.TabIndex = 0;
            this.lblKolicina.Text = "Količina: ";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(64, 71);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(100, 20);
            this.txtKolicina.TabIndex = 1;
            // 
            // txtDoziranje
            // 
            this.txtDoziranje.Location = new System.Drawing.Point(64, 97);
            this.txtDoziranje.Multiline = true;
            this.txtDoziranje.Name = "txtDoziranje";
            this.txtDoziranje.Size = new System.Drawing.Size(181, 49);
            this.txtDoziranje.TabIndex = 2;
            // 
            // lblDoziranje
            // 
            this.lblDoziranje.AutoSize = true;
            this.lblDoziranje.Location = new System.Drawing.Point(5, 100);
            this.lblDoziranje.Name = "lblDoziranje";
            this.lblDoziranje.Size = new System.Drawing.Size(57, 13);
            this.lblDoziranje.TabIndex = 3;
            this.lblDoziranje.Text = "Doziranje: ";
            // 
            // lblPacijent
            // 
            this.lblPacijent.AutoSize = true;
            this.lblPacijent.Location = new System.Drawing.Point(11, 21);
            this.lblPacijent.Name = "lblPacijent";
            this.lblPacijent.Size = new System.Drawing.Size(51, 13);
            this.lblPacijent.TabIndex = 4;
            this.lblPacijent.Text = "Pacijent: ";
            // 
            // txtPacijent
            // 
            this.txtPacijent.Location = new System.Drawing.Point(64, 21);
            this.txtPacijent.Name = "txtPacijent";
            this.txtPacijent.ReadOnly = true;
            this.txtPacijent.Size = new System.Drawing.Size(100, 20);
            this.txtPacijent.TabIndex = 5;
            // 
            // btnChoosePatient
            // 
            this.btnChoosePatient.Location = new System.Drawing.Point(170, 19);
            this.btnChoosePatient.Name = "btnChoosePatient";
            this.btnChoosePatient.Size = new System.Drawing.Size(75, 23);
            this.btnChoosePatient.TabIndex = 6;
            this.btnChoosePatient.Text = "Odaberi";
            this.btnChoosePatient.UseVisualStyleBackColor = true;
            this.btnChoosePatient.Click += new System.EventHandler(this.btnChoosePatient_Click);
            // 
            // chckNadoplata
            // 
            this.chckNadoplata.AutoSize = true;
            this.chckNadoplata.Location = new System.Drawing.Point(170, 74);
            this.chckNadoplata.Name = "chckNadoplata";
            this.chckNadoplata.Size = new System.Drawing.Size(75, 17);
            this.chckNadoplata.TabIndex = 7;
            this.chckNadoplata.Text = "Nadoplata";
            this.chckNadoplata.UseVisualStyleBackColor = true;
            // 
            // lblDjelatnici
            // 
            this.lblDjelatnici.AutoSize = true;
            this.lblDjelatnici.Location = new System.Drawing.Point(6, 22);
            this.lblDjelatnici.Name = "lblDjelatnici";
            this.lblDjelatnici.Size = new System.Drawing.Size(56, 13);
            this.lblDjelatnici.TabIndex = 8;
            this.lblDjelatnici.Text = "Djelatnici: ";
            // 
            // comboDjelatnici
            // 
            this.comboDjelatnici.FormattingEnabled = true;
            this.comboDjelatnici.Location = new System.Drawing.Point(68, 19);
            this.comboDjelatnici.Name = "comboDjelatnici";
            this.comboDjelatnici.Size = new System.Drawing.Size(177, 21);
            this.comboDjelatnici.TabIndex = 9;
            this.comboDjelatnici.SelectedValueChanged += new System.EventHandler(this.comboDjelatnici_SelectedValueChanged);
            // 
            // gbUstanova
            // 
            this.gbUstanova.Controls.Add(this.comboUstanova);
            this.gbUstanova.Controls.Add(this.lblUstanova);
            this.gbUstanova.Controls.Add(this.comboDjelatnici);
            this.gbUstanova.Controls.Add(this.lblDjelatnici);
            this.gbUstanova.Location = new System.Drawing.Point(19, 12);
            this.gbUstanova.Name = "gbUstanova";
            this.gbUstanova.Size = new System.Drawing.Size(251, 81);
            this.gbUstanova.TabIndex = 10;
            this.gbUstanova.TabStop = false;
            this.gbUstanova.Text = "Interno";
            // 
            // comboUstanova
            // 
            this.comboUstanova.FormattingEnabled = true;
            this.comboUstanova.Location = new System.Drawing.Point(68, 47);
            this.comboUstanova.Name = "comboUstanova";
            this.comboUstanova.Size = new System.Drawing.Size(177, 21);
            this.comboUstanova.TabIndex = 11;
            this.comboUstanova.SelectedValueChanged += new System.EventHandler(this.comboUstanova_SelectedValueChanged);
            // 
            // lblUstanova
            // 
            this.lblUstanova.AutoSize = true;
            this.lblUstanova.Location = new System.Drawing.Point(6, 47);
            this.lblUstanova.Name = "lblUstanova";
            this.lblUstanova.Size = new System.Drawing.Size(59, 13);
            this.lblUstanova.TabIndex = 10;
            this.lblUstanova.Text = "Ustanova: ";
            // 
            // lblLijekovi
            // 
            this.lblLijekovi.AutoSize = true;
            this.lblLijekovi.Location = new System.Drawing.Point(12, 45);
            this.lblLijekovi.Name = "lblLijekovi";
            this.lblLijekovi.Size = new System.Drawing.Size(46, 13);
            this.lblLijekovi.TabIndex = 10;
            this.lblLijekovi.Text = "Lijekovi:";
            // 
            // gbPacijent
            // 
            this.gbPacijent.Controls.Add(this.txtSlucaj);
            this.gbPacijent.Controls.Add(this.lblSlucaj);
            this.gbPacijent.Controls.Add(this.chckNadoplata);
            this.gbPacijent.Controls.Add(this.btnChooseMedicine);
            this.gbPacijent.Controls.Add(this.txtLijekovi);
            this.gbPacijent.Controls.Add(this.lblPacijent);
            this.gbPacijent.Controls.Add(this.lblDoziranje);
            this.gbPacijent.Controls.Add(this.lblLijekovi);
            this.gbPacijent.Controls.Add(this.txtDoziranje);
            this.gbPacijent.Controls.Add(this.txtPacijent);
            this.gbPacijent.Controls.Add(this.txtKolicina);
            this.gbPacijent.Controls.Add(this.btnChoosePatient);
            this.gbPacijent.Controls.Add(this.lblKolicina);
            this.gbPacijent.Location = new System.Drawing.Point(19, 108);
            this.gbPacijent.Name = "gbPacijent";
            this.gbPacijent.Size = new System.Drawing.Size(251, 243);
            this.gbPacijent.TabIndex = 11;
            this.gbPacijent.TabStop = false;
            this.gbPacijent.Text = "Podaci pacijenta";
            // 
            // txtSlucaj
            // 
            this.txtSlucaj.Location = new System.Drawing.Point(64, 152);
            this.txtSlucaj.Multiline = true;
            this.txtSlucaj.Name = "txtSlucaj";
            this.txtSlucaj.Size = new System.Drawing.Size(181, 74);
            this.txtSlucaj.TabIndex = 14;
            // 
            // lblSlucaj
            // 
            this.lblSlucaj.AutoSize = true;
            this.lblSlucaj.Location = new System.Drawing.Point(20, 152);
            this.lblSlucaj.Name = "lblSlucaj";
            this.lblSlucaj.Size = new System.Drawing.Size(42, 13);
            this.lblSlucaj.TabIndex = 13;
            this.lblSlucaj.Text = "Slučaj: ";
            // 
            // btnChooseMedicine
            // 
            this.btnChooseMedicine.Location = new System.Drawing.Point(170, 44);
            this.btnChooseMedicine.Name = "btnChooseMedicine";
            this.btnChooseMedicine.Size = new System.Drawing.Size(75, 23);
            this.btnChooseMedicine.TabIndex = 12;
            this.btnChooseMedicine.Text = "Odaberi";
            this.btnChooseMedicine.UseVisualStyleBackColor = true;
            this.btnChooseMedicine.Click += new System.EventHandler(this.btnChooseMedicine_Click);
            // 
            // txtLijekovi
            // 
            this.txtLijekovi.Location = new System.Drawing.Point(64, 45);
            this.txtLijekovi.Name = "txtLijekovi";
            this.txtLijekovi.ReadOnly = true;
            this.txtLijekovi.Size = new System.Drawing.Size(100, 20);
            this.txtLijekovi.TabIndex = 11;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(114, 357);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(195, 357);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Odustani";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddNewRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 387);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbPacijent);
            this.Controls.Add(this.gbUstanova);
            this.KeyPreview = true;
            this.Name = "frmAddNewRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izradi novi recept";
            this.Load += new System.EventHandler(this.frmAddNewRecipe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddNewRecipe_KeyDown);
            this.gbUstanova.ResumeLayout(false);
            this.gbUstanova.PerformLayout();
            this.gbPacijent.ResumeLayout(false);
            this.gbPacijent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtDoziranje;
        private System.Windows.Forms.Label lblDoziranje;
        private System.Windows.Forms.Label lblPacijent;
        private System.Windows.Forms.TextBox txtPacijent;
        private System.Windows.Forms.Button btnChoosePatient;
        private System.Windows.Forms.CheckBox chckNadoplata;
        private System.Windows.Forms.Label lblDjelatnici;
        private System.Windows.Forms.ComboBox comboDjelatnici;
        private System.Windows.Forms.GroupBox gbUstanova;
        private System.Windows.Forms.Label lblUstanova;
        private System.Windows.Forms.Label lblLijekovi;
        private System.Windows.Forms.ComboBox comboUstanova;
        private System.Windows.Forms.GroupBox gbPacijent;
        private System.Windows.Forms.TextBox txtSlucaj;
        private System.Windows.Forms.Label lblSlucaj;
        private System.Windows.Forms.Button btnChooseMedicine;
        private System.Windows.Forms.TextBox txtLijekovi;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
    }
}