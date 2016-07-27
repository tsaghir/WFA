namespace HouseMed.HospitalDays
{
    partial class frmAddNewHospitalDay
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
            this.labelBoravioOd = new System.Windows.Forms.Label();
            this.dtpBoravioOd = new System.Windows.Forms.DateTimePicker();
            this.labelBoravioDo = new System.Windows.Forms.Label();
            this.dtpBoravioDo = new System.Windows.Forms.DateTimePicker();
            this.labelBolnica = new System.Windows.Forms.Label();
            this.tbRazlogBoravka = new System.Windows.Forms.TextBox();
            this.labelRazlogBoravka = new System.Windows.Forms.Label();
            this.tbBolnica = new System.Windows.Forms.TextBox();
            this.btnDodajBoravak = new System.Windows.Forms.Button();
            this.ucNatrag1 = new HouseMed.ucNatrag();
            this.SuspendLayout();
            // 
            // labelBoravioOd
            // 
            this.labelBoravioOd.AutoSize = true;
            this.labelBoravioOd.Location = new System.Drawing.Point(30, 27);
            this.labelBoravioOd.Name = "labelBoravioOd";
            this.labelBoravioOd.Size = new System.Drawing.Size(61, 13);
            this.labelBoravioOd.TabIndex = 2;
            this.labelBoravioOd.Text = "Boravio od:";
            // 
            // dtpBoravioOd
            // 
            this.dtpBoravioOd.Location = new System.Drawing.Point(108, 24);
            this.dtpBoravioOd.Name = "dtpBoravioOd";
            this.dtpBoravioOd.Size = new System.Drawing.Size(166, 20);
            this.dtpBoravioOd.TabIndex = 3;
            // 
            // labelBoravioDo
            // 
            this.labelBoravioDo.AutoSize = true;
            this.labelBoravioDo.Location = new System.Drawing.Point(30, 58);
            this.labelBoravioDo.Name = "labelBoravioDo";
            this.labelBoravioDo.Size = new System.Drawing.Size(64, 13);
            this.labelBoravioDo.TabIndex = 4;
            this.labelBoravioDo.Text = "Boravio do: ";
            // 
            // dtpBoravioDo
            // 
            this.dtpBoravioDo.Location = new System.Drawing.Point(108, 56);
            this.dtpBoravioDo.Name = "dtpBoravioDo";
            this.dtpBoravioDo.Size = new System.Drawing.Size(166, 20);
            this.dtpBoravioDo.TabIndex = 5;
            // 
            // labelBolnica
            // 
            this.labelBolnica.AutoSize = true;
            this.labelBolnica.Location = new System.Drawing.Point(43, 94);
            this.labelBolnica.Name = "labelBolnica";
            this.labelBolnica.Size = new System.Drawing.Size(48, 13);
            this.labelBolnica.TabIndex = 6;
            this.labelBolnica.Text = "Bolnica: ";
            // 
            // tbRazlogBoravka
            // 
            this.tbRazlogBoravka.Location = new System.Drawing.Point(108, 127);
            this.tbRazlogBoravka.Multiline = true;
            this.tbRazlogBoravka.Name = "tbRazlogBoravka";
            this.tbRazlogBoravka.Size = new System.Drawing.Size(166, 106);
            this.tbRazlogBoravka.TabIndex = 8;
            // 
            // labelRazlogBoravka
            // 
            this.labelRazlogBoravka.AutoSize = true;
            this.labelRazlogBoravka.Location = new System.Drawing.Point(9, 130);
            this.labelRazlogBoravka.Name = "labelRazlogBoravka";
            this.labelRazlogBoravka.Size = new System.Drawing.Size(85, 13);
            this.labelRazlogBoravka.TabIndex = 9;
            this.labelRazlogBoravka.Text = "Razlog boravka:";
            // 
            // tbBolnica
            // 
            this.tbBolnica.Location = new System.Drawing.Point(108, 91);
            this.tbBolnica.Name = "tbBolnica";
            this.tbBolnica.Size = new System.Drawing.Size(166, 20);
            this.tbBolnica.TabIndex = 12;
            // 
            // btnDodajBoravak
            // 
            this.btnDodajBoravak.Location = new System.Drawing.Point(115, 257);
            this.btnDodajBoravak.Name = "btnDodajBoravak";
            this.btnDodajBoravak.Size = new System.Drawing.Size(159, 23);
            this.btnDodajBoravak.TabIndex = 13;
            this.btnDodajBoravak.Text = "Dodaj";
            this.btnDodajBoravak.UseVisualStyleBackColor = true;
            this.btnDodajBoravak.Click += new System.EventHandler(this.btnDodajBoravak_Click);
            // 
            // ucNatrag1
            // 
            this.ucNatrag1.Location = new System.Drawing.Point(33, 257);
            this.ucNatrag1.Name = "ucNatrag1";
            this.ucNatrag1.Size = new System.Drawing.Size(76, 23);
            this.ucNatrag1.TabIndex = 14;
            // 
            // frmAddNewHospitalDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 291);
            this.Controls.Add(this.ucNatrag1);
            this.Controls.Add(this.btnDodajBoravak);
            this.Controls.Add(this.tbBolnica);
            this.Controls.Add(this.labelRazlogBoravka);
            this.Controls.Add(this.tbRazlogBoravka);
            this.Controls.Add(this.labelBolnica);
            this.Controls.Add(this.dtpBoravioDo);
            this.Controls.Add(this.labelBoravioDo);
            this.Controls.Add(this.dtpBoravioOd);
            this.Controls.Add(this.labelBoravioOd);
            this.KeyPreview = true;
            this.Name = "frmAddNewHospitalDay";
            this.Text = "frmAddNewHospitalDay";
            this.Load += new System.EventHandler(this.frmAddNewHospitalDay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddNewHospitalDay_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelBoravioOd;
        private System.Windows.Forms.DateTimePicker dtpBoravioOd;
        private System.Windows.Forms.Label labelBoravioDo;
        private System.Windows.Forms.DateTimePicker dtpBoravioDo;
        private System.Windows.Forms.Label labelBolnica;
        private System.Windows.Forms.TextBox tbRazlogBoravka;
        private System.Windows.Forms.Label labelRazlogBoravka;
        private System.Windows.Forms.TextBox tbBolnica;
        private System.Windows.Forms.Button btnDodajBoravak;
        private ucNatrag ucNatrag1;
    }
}