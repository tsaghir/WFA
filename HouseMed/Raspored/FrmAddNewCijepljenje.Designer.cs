namespace HouseMed.Raspored
{
    partial class FrmAddNewCijepljenje
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
            this.comboBoxPacijent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDjelatnik = new System.Windows.Forms.ComboBox();
            this.textBoxSlucaj = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.textBoxVrsta = new System.Windows.Forms.TextBox();
            this.textBoxPriprava = new System.Windows.Forms.TextBox();
            this.textBoxBroj = new System.Windows.Forms.TextBox();
            this.textBoxKolicina = new System.Windows.Forms.TextBox();
            this.btnDodajCijepljenje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPacijent
            // 
            this.comboBoxPacijent.FormattingEnabled = true;
            this.comboBoxPacijent.Location = new System.Drawing.Point(134, 48);
            this.comboBoxPacijent.Name = "comboBoxPacijent";
            this.comboBoxPacijent.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPacijent.TabIndex = 0;
            this.comboBoxPacijent.SelectedValueChanged += new System.EventHandler(this.comboBoxPacijent_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pacijent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Djelatnik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Slučaj";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vrsta cijepiva";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Priprava";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Broj doze";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Količina";
            // 
            // comboBoxDjelatnik
            // 
            this.comboBoxDjelatnik.FormattingEnabled = true;
            this.comboBoxDjelatnik.Location = new System.Drawing.Point(134, 89);
            this.comboBoxDjelatnik.Name = "comboBoxDjelatnik";
            this.comboBoxDjelatnik.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDjelatnik.TabIndex = 9;
            this.comboBoxDjelatnik.SelectedValueChanged += new System.EventHandler(this.comboBoxDjelatnik_SelectedValueChanged);
            // 
            // textBoxSlucaj
            // 
            this.textBoxSlucaj.Location = new System.Drawing.Point(134, 143);
            this.textBoxSlucaj.Name = "textBoxSlucaj";
            this.textBoxSlucaj.Size = new System.Drawing.Size(100, 22);
            this.textBoxSlucaj.TabIndex = 10;
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(134, 190);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDatum.TabIndex = 11;
            // 
            // textBoxVrsta
            // 
            this.textBoxVrsta.Location = new System.Drawing.Point(134, 238);
            this.textBoxVrsta.Name = "textBoxVrsta";
            this.textBoxVrsta.Size = new System.Drawing.Size(100, 22);
            this.textBoxVrsta.TabIndex = 12;
            // 
            // textBoxPriprava
            // 
            this.textBoxPriprava.Location = new System.Drawing.Point(134, 286);
            this.textBoxPriprava.Name = "textBoxPriprava";
            this.textBoxPriprava.Size = new System.Drawing.Size(100, 22);
            this.textBoxPriprava.TabIndex = 13;
            // 
            // textBoxBroj
            // 
            this.textBoxBroj.Location = new System.Drawing.Point(134, 339);
            this.textBoxBroj.Name = "textBoxBroj";
            this.textBoxBroj.Size = new System.Drawing.Size(100, 22);
            this.textBoxBroj.TabIndex = 14;
            // 
            // textBoxKolicina
            // 
            this.textBoxKolicina.Location = new System.Drawing.Point(134, 381);
            this.textBoxKolicina.Name = "textBoxKolicina";
            this.textBoxKolicina.Size = new System.Drawing.Size(100, 22);
            this.textBoxKolicina.TabIndex = 15;
            // 
            // btnDodajCijepljenje
            // 
            this.btnDodajCijepljenje.Location = new System.Drawing.Point(249, 418);
            this.btnDodajCijepljenje.Name = "btnDodajCijepljenje";
            this.btnDodajCijepljenje.Size = new System.Drawing.Size(123, 34);
            this.btnDodajCijepljenje.TabIndex = 16;
            this.btnDodajCijepljenje.Text = "Dodaj cijepljenje";
            this.btnDodajCijepljenje.UseVisualStyleBackColor = true;
            this.btnDodajCijepljenje.Click += new System.EventHandler(this.btnDodajCijepljenje_Click);
            // 
            // FrmAddNewCijepljenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 497);
            this.Controls.Add(this.btnDodajCijepljenje);
            this.Controls.Add(this.textBoxKolicina);
            this.Controls.Add(this.textBoxBroj);
            this.Controls.Add(this.textBoxPriprava);
            this.Controls.Add(this.textBoxVrsta);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.textBoxSlucaj);
            this.Controls.Add(this.comboBoxDjelatnik);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPacijent);
            this.Name = "FrmAddNewCijepljenje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodavanje cijepljenja";
            this.Load += new System.EventHandler(this.FrmAddNewCijepljenje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPacijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDjelatnik;
        private System.Windows.Forms.TextBox textBoxSlucaj;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.TextBox textBoxVrsta;
        private System.Windows.Forms.TextBox textBoxPriprava;
        private System.Windows.Forms.TextBox textBoxBroj;
        private System.Windows.Forms.TextBox textBoxKolicina;
        private System.Windows.Forms.Button btnDodajCijepljenje;
    }
}