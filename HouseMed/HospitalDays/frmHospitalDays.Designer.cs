namespace HouseMed.HospitalDays
{
    partial class frmHospitalDays
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
            this.components = new System.ComponentModel.Container();
            this.dgvHospitalDays = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelPacijentIspis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOdaberi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNoviNalog = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUrediBoravak = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBrisiBoravak = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbPretrazi = new System.Windows.Forms.ToolStripTextBox();
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.djelatniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalDays)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatniciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHospitalDays
            // 
            this.dgvHospitalDays.AllowUserToAddRows = false;
            this.dgvHospitalDays.AllowUserToDeleteRows = false;
            this.dgvHospitalDays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitalDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHospitalDays.Location = new System.Drawing.Point(0, 27);
            this.dgvHospitalDays.Name = "dgvHospitalDays";
            this.dgvHospitalDays.ReadOnly = true;
            this.dgvHospitalDays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHospitalDays.Size = new System.Drawing.Size(637, 187);
            this.dgvHospitalDays.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelPacijentIspis,
            this.btnOdaberi,
            this.btnNoviNalog,
            this.btnUrediBoravak,
            this.btnBrisiBoravak,
            this.pretražiToolStripMenuItem,
            this.tbPretrazi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(637, 27);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelPacijentIspis
            // 
            this.labelPacijentIspis.Name = "labelPacijentIspis";
            this.labelPacijentIspis.Size = new System.Drawing.Size(64, 23);
            this.labelPacijentIspis.Text = "Pacijent:";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(112, 23);
            this.btnOdaberi.Text = "Odaberi pacijenta";
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // btnNoviNalog
            // 
            this.btnNoviNalog.Name = "btnNoviNalog";
            this.btnNoviNalog.Size = new System.Drawing.Size(77, 23);
            this.btnNoviNalog.Text = "Novi nalog";
            this.btnNoviNalog.Click += new System.EventHandler(this.btnNoviNalog_Click);
            // 
            // btnUrediBoravak
            // 
            this.btnUrediBoravak.Name = "btnUrediBoravak";
            this.btnUrediBoravak.Size = new System.Drawing.Size(80, 23);
            this.btnUrediBoravak.Text = "Uredi nalog";
            this.btnUrediBoravak.Click += new System.EventHandler(this.btnUrediBoravak_Click);
            // 
            // btnBrisiBoravak
            // 
            this.btnBrisiBoravak.Name = "btnBrisiBoravak";
            this.btnBrisiBoravak.Size = new System.Drawing.Size(74, 23);
            this.btnBrisiBoravak.Text = "Briši nalog";
            this.btnBrisiBoravak.Click += new System.EventHandler(this.btnBrisiBoravak_Click);
            // 
            // pretražiToolStripMenuItem
            // 
            this.pretražiToolStripMenuItem.Name = "pretražiToolStripMenuItem";
            this.pretražiToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.pretražiToolStripMenuItem.Text = "Pretraži: ";
            // 
            // tbPretrazi
            // 
            this.tbPretrazi.Name = "tbPretrazi";
            this.tbPretrazi.Size = new System.Drawing.Size(69, 23);
            this.tbPretrazi.TextChanged += new System.EventHandler(this.tbPretrazi_TextChanged);
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataSource = typeof(HouseMed.DAL.pacijenti);
            // 
            // djelatniciBindingSource
            // 
            this.djelatniciBindingSource.DataSource = typeof(HouseMed.DAL.djelatnici);
            // 
            // frmHospitalDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 214);
            this.Controls.Add(this.dgvHospitalDays);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHospitalDays";
            this.Text = "frmHospitalDays";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmHospitalDays_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalDays)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.djelatniciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHospitalDays;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private System.Windows.Forms.BindingSource djelatniciBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem labelPacijentIspis;
        private System.Windows.Forms.ToolStripMenuItem btnOdaberi;
        private System.Windows.Forms.ToolStripMenuItem btnNoviNalog;
        private System.Windows.Forms.ToolStripMenuItem btnUrediBoravak;
        private System.Windows.Forms.ToolStripMenuItem btnBrisiBoravak;
        private System.Windows.Forms.ToolStripMenuItem pretražiToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tbPretrazi;
    }
}