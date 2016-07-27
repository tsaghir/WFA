namespace HouseMed
{
    partial class frmMenu
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
            this.btnEkarton = new System.Windows.Forms.Button();
            this.btnLijekovi = new System.Windows.Forms.Button();
            this.btnRecept = new System.Windows.Forms.Button();
            this.btnBolnica = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.btnUputnice = new System.Windows.Forms.Button();
            this.btnKalendar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPotvrde = new System.Windows.Forms.Button();
            this.labelOdabraniPacijent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZaprimi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEkarton
            // 
            this.btnEkarton.Location = new System.Drawing.Point(343, 62);
            this.btnEkarton.Name = "btnEkarton";
            this.btnEkarton.Size = new System.Drawing.Size(83, 37);
            this.btnEkarton.TabIndex = 0;
            this.btnEkarton.Text = "E - karton";
            this.btnEkarton.UseVisualStyleBackColor = true;
            this.btnEkarton.Click += new System.EventHandler(this.btnEkarton_Click);
            // 
            // btnLijekovi
            // 
            this.btnLijekovi.Location = new System.Drawing.Point(131, 30);
            this.btnLijekovi.Name = "btnLijekovi";
            this.btnLijekovi.Size = new System.Drawing.Size(83, 37);
            this.btnLijekovi.TabIndex = 1;
            this.btnLijekovi.Text = "Lijekovi";
            this.btnLijekovi.UseVisualStyleBackColor = true;
            this.btnLijekovi.Click += new System.EventHandler(this.btnLijekovi_Click);
            // 
            // btnRecept
            // 
            this.btnRecept.Location = new System.Drawing.Point(30, 30);
            this.btnRecept.Name = "btnRecept";
            this.btnRecept.Size = new System.Drawing.Size(83, 37);
            this.btnRecept.TabIndex = 2;
            this.btnRecept.Text = "Recepti";
            this.btnRecept.UseVisualStyleBackColor = true;
            this.btnRecept.Click += new System.EventHandler(this.btnRecept_Click);
            // 
            // btnBolnica
            // 
            this.btnBolnica.Location = new System.Drawing.Point(158, 30);
            this.btnBolnica.Name = "btnBolnica";
            this.btnBolnica.Size = new System.Drawing.Size(83, 37);
            this.btnBolnica.TabIndex = 3;
            this.btnBolnica.Text = "Boravak u bolnici";
            this.btnBolnica.UseVisualStyleBackColor = true;
            this.btnBolnica.Click += new System.EventHandler(this.btnBolnica_Click);
            // 
            // btnPatients
            // 
            this.btnPatients.Location = new System.Drawing.Point(22, 30);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(83, 37);
            this.btnPatients.TabIndex = 4;
            this.btnPatients.Text = "Pacijenti";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // btnUputnice
            // 
            this.btnUputnice.Location = new System.Drawing.Point(30, 94);
            this.btnUputnice.Name = "btnUputnice";
            this.btnUputnice.Size = new System.Drawing.Size(83, 37);
            this.btnUputnice.TabIndex = 5;
            this.btnUputnice.Text = "Uputnice";
            this.btnUputnice.UseVisualStyleBackColor = true;
            this.btnUputnice.Click += new System.EventHandler(this.btnUputnice_Click);
            // 
            // btnKalendar
            // 
            this.btnKalendar.Location = new System.Drawing.Point(158, 94);
            this.btnKalendar.Name = "btnKalendar";
            this.btnKalendar.Size = new System.Drawing.Size(83, 37);
            this.btnKalendar.TabIndex = 6;
            this.btnKalendar.Text = "Kalendar";
            this.btnKalendar.UseVisualStyleBackColor = true;
            this.btnKalendar.Click += new System.EventHandler(this.btnKalendar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPatients);
            this.groupBox1.Controls.Add(this.btnLijekovi);
            this.groupBox1.Location = new System.Drawing.Point(23, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 92);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Baza";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPotvrde);
            this.groupBox2.Controls.Add(this.labelOdabraniPacijent);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnBolnica);
            this.groupBox2.Controls.Add(this.btnRecept);
            this.groupBox2.Controls.Add(this.btnKalendar);
            this.groupBox2.Controls.Add(this.btnUputnice);
            this.groupBox2.Location = new System.Drawing.Point(464, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 170);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pacijent";
            // 
            // btnPotvrde
            // 
            this.btnPotvrde.Location = new System.Drawing.Point(273, 30);
            this.btnPotvrde.Name = "btnPotvrde";
            this.btnPotvrde.Size = new System.Drawing.Size(83, 37);
            this.btnPotvrde.TabIndex = 9;
            this.btnPotvrde.Text = "Potvrde";
            this.btnPotvrde.UseVisualStyleBackColor = true;
            this.btnPotvrde.Click += new System.EventHandler(this.btnPotvrde_Click);
            // 
            // labelOdabraniPacijent
            // 
            this.labelOdabraniPacijent.AutoSize = true;
            this.labelOdabraniPacijent.Location = new System.Drawing.Point(98, 154);
            this.labelOdabraniPacijent.Name = "labelOdabraniPacijent";
            this.labelOdabraniPacijent.Size = new System.Drawing.Size(174, 13);
            this.labelOdabraniPacijent.TabIndex = 8;
            this.labelOdabraniPacijent.Text = "...odabir pomoću gumba \"Pacijenti\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Odabrani pacijent:";
            // 
            // btnZaprimi
            // 
            this.btnZaprimi.Location = new System.Drawing.Point(343, 126);
            this.btnZaprimi.Name = "btnZaprimi";
            this.btnZaprimi.Size = new System.Drawing.Size(83, 37);
            this.btnZaprimi.TabIndex = 9;
            this.btnZaprimi.Text = "Zaprimi pacijenta";
            this.btnZaprimi.UseVisualStyleBackColor = true;
            this.btnZaprimi.Click += new System.EventHandler(this.btnZaprimi_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 235);
            this.Controls.Add(this.btnZaprimi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEkarton);
            this.KeyPreview = true;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funkcionalnosti";
            this.Activated += new System.EventHandler(this.frmMenu_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMenu_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkarton;
        private System.Windows.Forms.Button btnLijekovi;
        private System.Windows.Forms.Button btnRecept;
        private System.Windows.Forms.Button btnBolnica;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button btnUputnice;
        private System.Windows.Forms.Button btnKalendar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnZaprimi;
        private System.Windows.Forms.Label labelOdabraniPacijent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPotvrde;
    }
}