namespace HouseMed.Recipes
{
    partial class frmMedicationSelect
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
            this.dgvMedication = new System.Windows.Forms.DataGridView();
            this.lijekoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStripMedication = new System.Windows.Forms.MenuStrip();
            this.natragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaberiLijekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoviLijekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urediOdabraniLijekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiOdabraniLijekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.lijekoviIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumvrijemekontroleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roktrajanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifrazdrvustanoveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedication)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).BeginInit();
            this.menuStripMedication.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedication
            // 
            this.dgvMedication.AllowUserToAddRows = false;
            this.dgvMedication.AutoGenerateColumns = false;
            this.dgvMedication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lijekoviIDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.datumvrijemekontroleDataGridViewTextBoxColumn,
            this.roktrajanjaDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.cijenaDataGridViewTextBoxColumn,
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn,
            this.sifrazdrvustanoveDataGridViewTextBoxColumn,
            this.receptiDataGridViewTextBoxColumn});
            this.dgvMedication.DataSource = this.lijekoviBindingSource;
            this.dgvMedication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedication.Location = new System.Drawing.Point(0, 27);
            this.dgvMedication.Name = "dgvMedication";
            this.dgvMedication.ReadOnly = true;
            this.dgvMedication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedication.Size = new System.Drawing.Size(684, 230);
            this.dgvMedication.TabIndex = 0;
            // 
            // lijekoviBindingSource
            // 
            this.lijekoviBindingSource.DataSource = typeof(HouseMed.DAL.lijekovi);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStripMedication
            // 
            this.menuStripMedication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.natragToolStripMenuItem,
            this.odaberiLijekToolStripMenuItem,
            this.dodajNoviLijekToolStripMenuItem,
            this.urediOdabraniLijekToolStripMenuItem,
            this.obrišiOdabraniLijekToolStripMenuItem,
            this.pretražiToolStripMenuItem,
            this.txtSearch});
            this.menuStripMedication.Location = new System.Drawing.Point(0, 0);
            this.menuStripMedication.Name = "menuStripMedication";
            this.menuStripMedication.Size = new System.Drawing.Size(684, 27);
            this.menuStripMedication.TabIndex = 8;
            this.menuStripMedication.Text = "menuStrip1";
            // 
            // natragToolStripMenuItem
            // 
            this.natragToolStripMenuItem.Name = "natragToolStripMenuItem";
            this.natragToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.natragToolStripMenuItem.Text = "Natrag";
            this.natragToolStripMenuItem.Click += new System.EventHandler(this.natragToolStripMenuItem_Click);
            // 
            // odaberiLijekToolStripMenuItem
            // 
            this.odaberiLijekToolStripMenuItem.Name = "odaberiLijekToolStripMenuItem";
            this.odaberiLijekToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.odaberiLijekToolStripMenuItem.Text = "Odaberi lijek";
            this.odaberiLijekToolStripMenuItem.Click += new System.EventHandler(this.odaberiLijekToolStripMenuItem_Click);
            // 
            // dodajNoviLijekToolStripMenuItem
            // 
            this.dodajNoviLijekToolStripMenuItem.Name = "dodajNoviLijekToolStripMenuItem";
            this.dodajNoviLijekToolStripMenuItem.Size = new System.Drawing.Size(100, 23);
            this.dodajNoviLijekToolStripMenuItem.Text = "Dodaj novi lijek";
            this.dodajNoviLijekToolStripMenuItem.Click += new System.EventHandler(this.dodajNoviLijekToolStripMenuItem_Click);
            // 
            // urediOdabraniLijekToolStripMenuItem
            // 
            this.urediOdabraniLijekToolStripMenuItem.Name = "urediOdabraniLijekToolStripMenuItem";
            this.urediOdabraniLijekToolStripMenuItem.Size = new System.Drawing.Size(121, 23);
            this.urediOdabraniLijekToolStripMenuItem.Text = "Uredi odabrani lijek";
            this.urediOdabraniLijekToolStripMenuItem.Click += new System.EventHandler(this.urediOdabraniLijekToolStripMenuItem_Click);
            // 
            // obrišiOdabraniLijekToolStripMenuItem
            // 
            this.obrišiOdabraniLijekToolStripMenuItem.Name = "obrišiOdabraniLijekToolStripMenuItem";
            this.obrišiOdabraniLijekToolStripMenuItem.Size = new System.Drawing.Size(124, 23);
            this.obrišiOdabraniLijekToolStripMenuItem.Text = "Obriši odabrani lijek";
            this.obrišiOdabraniLijekToolStripMenuItem.Click += new System.EventHandler(this.obrišiOdabraniLijekToolStripMenuItem_Click);
            // 
            // pretražiToolStripMenuItem
            // 
            this.pretražiToolStripMenuItem.Name = "pretražiToolStripMenuItem";
            this.pretražiToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.pretražiToolStripMenuItem.Text = "Pretraži:";
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 23);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lijekoviIDDataGridViewTextBoxColumn
            // 
            this.lijekoviIDDataGridViewTextBoxColumn.DataPropertyName = "lijekoviID";
            this.lijekoviIDDataGridViewTextBoxColumn.HeaderText = "ID Lijeka";
            this.lijekoviIDDataGridViewTextBoxColumn.Name = "lijekoviIDDataGridViewTextBoxColumn";
            this.lijekoviIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumvrijemekontroleDataGridViewTextBoxColumn
            // 
            this.datumvrijemekontroleDataGridViewTextBoxColumn.DataPropertyName = "datum_vrijeme_kontrole";
            this.datumvrijemekontroleDataGridViewTextBoxColumn.HeaderText = "Datum kontrole";
            this.datumvrijemekontroleDataGridViewTextBoxColumn.Name = "datumvrijemekontroleDataGridViewTextBoxColumn";
            this.datumvrijemekontroleDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumvrijemekontroleDataGridViewTextBoxColumn.Width = 140;
            // 
            // roktrajanjaDataGridViewTextBoxColumn
            // 
            this.roktrajanjaDataGridViewTextBoxColumn.DataPropertyName = "rok_trajanja";
            this.roktrajanjaDataGridViewTextBoxColumn.HeaderText = "Rok trajanja";
            this.roktrajanjaDataGridViewTextBoxColumn.Name = "roktrajanjaDataGridViewTextBoxColumn";
            this.roktrajanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifrazdrvustanoveIDDataGridViewTextBoxColumn
            // 
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.DataPropertyName = "sifra_zdrv_ustanoveID";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.HeaderText = "sifra_zdrv_ustanoveID";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.Name = "sifrazdrvustanoveIDDataGridViewTextBoxColumn";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sifrazdrvustanoveDataGridViewTextBoxColumn
            // 
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.DataPropertyName = "sifra_zdrv_ustanove";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.HeaderText = "sifra_zdrv_ustanove";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.Name = "sifrazdrvustanoveDataGridViewTextBoxColumn";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.Visible = false;
            // 
            // receptiDataGridViewTextBoxColumn
            // 
            this.receptiDataGridViewTextBoxColumn.DataPropertyName = "recepti";
            this.receptiDataGridViewTextBoxColumn.HeaderText = "recepti";
            this.receptiDataGridViewTextBoxColumn.Name = "receptiDataGridViewTextBoxColumn";
            this.receptiDataGridViewTextBoxColumn.ReadOnly = true;
            this.receptiDataGridViewTextBoxColumn.Visible = false;
            // 
            // frmMedicationSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 257);
            this.Controls.Add(this.dgvMedication);
            this.Controls.Add(this.menuStripMedication);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripMedication;
            this.Name = "frmMedicationSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lijekovi";
            this.Load += new System.EventHandler(this.frmMedicationSelect_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMedicationSelect_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedication)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lijekoviBindingSource)).EndInit();
            this.menuStripMedication.ResumeLayout(false);
            this.menuStripMedication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMedication;
        private System.Windows.Forms.BindingSource lijekoviBindingSource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStripMedication;
        private System.Windows.Forms.ToolStripMenuItem natragToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoviLijekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urediOdabraniLijekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem odaberiLijekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiOdabraniLijekToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn lijekoviIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumvrijemekontroleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roktrajanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrazdrvustanoveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrazdrvustanoveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptiDataGridViewTextBoxColumn;
    }
}