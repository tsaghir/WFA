namespace HouseMed.Raspored
{
    partial class frmAddNewPregled
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
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPacijent = new System.Windows.Forms.ComboBox();
            this.textBoxVrijeme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxUstanova = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(107, 87);
            this.dateTimePickerDatum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDatum.TabIndex = 0;
            // 
            // comboBoxPacijent
            // 
            this.comboBoxPacijent.FormattingEnabled = true;
            this.comboBoxPacijent.Location = new System.Drawing.Point(107, 32);
            this.comboBoxPacijent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPacijent.Name = "comboBoxPacijent";
            this.comboBoxPacijent.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPacijent.TabIndex = 1;
            this.comboBoxPacijent.SelectedValueChanged += new System.EventHandler(this.comboBoxPacijent_SelectedValueChanged);
            // 
            // textBoxVrijeme
            // 
            this.textBoxVrijeme.Location = new System.Drawing.Point(107, 140);
            this.textBoxVrijeme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxVrijeme.Name = "textBoxVrijeme";
            this.textBoxVrijeme.Size = new System.Drawing.Size(100, 22);
            this.textBoxVrijeme.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pacijent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrijeme";
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(107, 191);
            this.textBoxOpis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(100, 22);
            this.textBoxOpis.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ustanova";
            // 
            // comboBoxUstanova
            // 
            this.comboBoxUstanova.FormattingEnabled = true;
            this.comboBoxUstanova.Location = new System.Drawing.Point(107, 249);
            this.comboBoxUstanova.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxUstanova.Name = "comboBoxUstanova";
            this.comboBoxUstanova.Size = new System.Drawing.Size(121, 24);
            this.comboBoxUstanova.TabIndex = 9;
            this.comboBoxUstanova.SelectedValueChanged += new System.EventHandler(this.comboBoxUstanova_SelectedValueChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(235, 295);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 42);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "Dodaj Pregled";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // frmAddNewPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 358);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.comboBoxUstanova);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVrijeme);
            this.Controls.Add(this.comboBoxPacijent);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddNewPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi Pregled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
        private System.Windows.Forms.ComboBox comboBoxPacijent;
        private System.Windows.Forms.TextBox textBoxVrijeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxUstanova;
        private System.Windows.Forms.Button btnDodaj;
    }
}