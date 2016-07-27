namespace HouseMed.Uputnice
{
    partial class frmUputnice
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
            this.dgvUputnice = new System.Windows.Forms.DataGridView();
            this.uputnicaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnNovaUputnica = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUredi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnObrisi = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUputnice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uputnicaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUputnice
            // 
            this.dgvUputnice.AllowUserToAddRows = false;
            this.dgvUputnice.AllowUserToDeleteRows = false;
            this.dgvUputnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUputnice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUputnice.Location = new System.Drawing.Point(0, 28);
            this.dgvUputnice.Name = "dgvUputnice";
            this.dgvUputnice.ReadOnly = true;
            this.dgvUputnice.RowTemplate.Height = 24;
            this.dgvUputnice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUputnice.Size = new System.Drawing.Size(967, 461);
            this.dgvUputnice.TabIndex = 0;
            this.dgvUputnice.SelectionChanged += new System.EventHandler(this.dgvUputnice_SelectionChanged);
            // 
            // uputnicaBindingSource
            // 
            this.uputnicaBindingSource.DataSource = typeof(HouseMed.DAL.uputnica);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovaUputnica,
            this.btnUredi,
            this.btnObrisi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnNovaUputnica
            // 
            this.btnNovaUputnica.Name = "btnNovaUputnica";
            this.btnNovaUputnica.Size = new System.Drawing.Size(117, 24);
            this.btnNovaUputnica.Text = "Nova uputnica";
            this.btnNovaUputnica.Click += new System.EventHandler(this.btnNovaUputnica_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(57, 24);
            this.btnUredi.Text = "Uredi";
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(60, 24);
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // frmUputnice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 489);
            this.Controls.Add(this.dgvUputnice);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUputnice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uputnice";
            this.Load += new System.EventHandler(this.frmUputnice_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUputnice_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUputnice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uputnicaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUputnice;
        private System.Windows.Forms.BindingSource uputnicaBindingSource;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnNovaUputnica;
        private System.Windows.Forms.ToolStripMenuItem btnUredi;
        private System.Windows.Forms.ToolStripMenuItem btnObrisi;
    }
}