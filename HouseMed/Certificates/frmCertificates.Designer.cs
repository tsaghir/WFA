namespace HouseMed.Utilities
{
    partial class frmCertificates
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelPacijentIspis = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOdaberi = new System.Windows.Forms.ToolStripMenuItem();
            this.novaPotvrdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UrediPotvrduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCertificates = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificates)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelPacijentIspis,
            this.btnOdaberi,
            this.novaPotvrdaToolStripMenuItem,
            this.UrediPotvrduToolStripMenuItem,
            this.izbrišiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(586, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelPacijentIspis
            // 
            this.labelPacijentIspis.Name = "labelPacijentIspis";
            this.labelPacijentIspis.Size = new System.Drawing.Size(64, 20);
            this.labelPacijentIspis.Text = "Pacijent:";
            // 
            // btnOdaberi
            // 
            this.btnOdaberi.Name = "btnOdaberi";
            this.btnOdaberi.Size = new System.Drawing.Size(112, 20);
            this.btnOdaberi.Text = "Odaberi pacijenta";
            this.btnOdaberi.Click += new System.EventHandler(this.btnOdaberi_Click);
            // 
            // novaPotvrdaToolStripMenuItem
            // 
            this.novaPotvrdaToolStripMenuItem.Name = "novaPotvrdaToolStripMenuItem";
            this.novaPotvrdaToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.novaPotvrdaToolStripMenuItem.Text = "Nova potvrda";
            this.novaPotvrdaToolStripMenuItem.Click += new System.EventHandler(this.novaPotvrdaToolStripMenuItem_Click);
            // 
            // UrediPotvrduToolStripMenuItem
            // 
            this.UrediPotvrduToolStripMenuItem.Name = "UrediPotvrduToolStripMenuItem";
            this.UrediPotvrduToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.UrediPotvrduToolStripMenuItem.Text = "Uredi potvrdu";
            this.UrediPotvrduToolStripMenuItem.Click += new System.EventHandler(this.UrediPotvrduToolStripMenuItem_Click);
            // 
            // izbrišiToolStripMenuItem
            // 
            this.izbrišiToolStripMenuItem.Name = "izbrišiToolStripMenuItem";
            this.izbrišiToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.izbrišiToolStripMenuItem.Text = "Izbriši";
            this.izbrišiToolStripMenuItem.Click += new System.EventHandler(this.izbrišiToolStripMenuItem_Click);
            // 
            // dgvCertificates
            // 
            this.dgvCertificates.AllowUserToAddRows = false;
            this.dgvCertificates.AllowUserToDeleteRows = false;
            this.dgvCertificates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCertificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCertificates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCertificates.Location = new System.Drawing.Point(0, 24);
            this.dgvCertificates.Name = "dgvCertificates";
            this.dgvCertificates.ReadOnly = true;
            this.dgvCertificates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCertificates.Size = new System.Drawing.Size(586, 188);
            this.dgvCertificates.TabIndex = 2;
            // 
            // frmCertificates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 212);
            this.Controls.Add(this.dgvCertificates);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCertificates";
            this.Text = "frmCertificates";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCertificates_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem labelPacijentIspis;
        private System.Windows.Forms.ToolStripMenuItem btnOdaberi;
        private System.Windows.Forms.DataGridView dgvCertificates;
        private System.Windows.Forms.ToolStripMenuItem novaPotvrdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UrediPotvrduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbrišiToolStripMenuItem;
    }
}