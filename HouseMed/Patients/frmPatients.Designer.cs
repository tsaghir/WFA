namespace HouseMed.Patients
{
    partial class frmPatients
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
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.pacijentiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mBODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oIBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drzavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobitelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijepljenjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifrazdrvustanoveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postupciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rasporedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uputnicaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnPostavi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNoviPacijent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUredi = new System.Windows.Forms.ToolStripMenuItem();
            this.btnObrisi = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxPretrazi = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AutoGenerateColumns = false;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pacijentiIDDataGridViewTextBoxColumn,
            this.mBODataGridViewTextBoxColumn,
            this.oIBDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.spolDataGridViewTextBoxColumn,
            this.mjestoDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.drzavaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mobitelDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn,
            this.cijepljenjeDataGridViewTextBoxColumn,
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn,
            this.sifrazdrvustanoveDataGridViewTextBoxColumn,
            this.postupciDataGridViewTextBoxColumn,
            this.rasporedDataGridViewTextBoxColumn,
            this.uputnicaDataGridViewTextBoxColumn,
            this.receptiDataGridViewTextBoxColumn,
            this.imePrezimeDataGridViewTextBoxColumn});
            this.dgvPatients.DataSource = this.pacijentiBindingSource;
            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatients.Location = new System.Drawing.Point(0, 31);
            this.dgvPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1012, 346);
            this.dgvPatients.TabIndex = 0;
            this.dgvPatients.SelectionChanged += new System.EventHandler(this.dgvPatients_SelectionChanged);
            // 
            // pacijentiIDDataGridViewTextBoxColumn
            // 
            this.pacijentiIDDataGridViewTextBoxColumn.DataPropertyName = "pacijentiID";
            this.pacijentiIDDataGridViewTextBoxColumn.HeaderText = "pacijentiID";
            this.pacijentiIDDataGridViewTextBoxColumn.Name = "pacijentiIDDataGridViewTextBoxColumn";
            this.pacijentiIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mBODataGridViewTextBoxColumn
            // 
            this.mBODataGridViewTextBoxColumn.DataPropertyName = "MBO";
            this.mBODataGridViewTextBoxColumn.HeaderText = "MBO";
            this.mBODataGridViewTextBoxColumn.Name = "mBODataGridViewTextBoxColumn";
            this.mBODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oIBDataGridViewTextBoxColumn
            // 
            this.oIBDataGridViewTextBoxColumn.DataPropertyName = "OIB";
            this.oIBDataGridViewTextBoxColumn.HeaderText = "OIB";
            this.oIBDataGridViewTextBoxColumn.Name = "oIBDataGridViewTextBoxColumn";
            this.oIBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjestoDataGridViewTextBoxColumn
            // 
            this.mjestoDataGridViewTextBoxColumn.DataPropertyName = "mjesto";
            this.mjestoDataGridViewTextBoxColumn.HeaderText = "mjesto";
            this.mjestoDataGridViewTextBoxColumn.Name = "mjestoDataGridViewTextBoxColumn";
            this.mjestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "drzava";
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            this.drzavaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobitelDataGridViewTextBoxColumn
            // 
            this.mobitelDataGridViewTextBoxColumn.DataPropertyName = "mobitel";
            this.mobitelDataGridViewTextBoxColumn.HeaderText = "mobitel";
            this.mobitelDataGridViewTextBoxColumn.Name = "mobitelDataGridViewTextBoxColumn";
            this.mobitelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifrazdrvustanoveIDDataGridViewTextBoxColumn
            // 
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.DataPropertyName = "sifra_zdrv_ustanoveID";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.HeaderText = "sifra_zdrv_ustanoveID";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.Name = "sifrazdrvustanoveIDDataGridViewTextBoxColumn";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijepljenjeDataGridViewTextBoxColumn
            // 
            this.cijepljenjeDataGridViewTextBoxColumn.DataPropertyName = "cijepljenje";
            this.cijepljenjeDataGridViewTextBoxColumn.HeaderText = "cijepljenje";
            this.cijepljenjeDataGridViewTextBoxColumn.Name = "cijepljenjeDataGridViewTextBoxColumn";
            this.cijepljenjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijepljenjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // evidencijahospitalizacijeDataGridViewTextBoxColumn
            // 
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.DataPropertyName = "evidencija_hospitalizacije";
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.HeaderText = "evidencija_hospitalizacije";
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.Name = "evidencijahospitalizacijeDataGridViewTextBoxColumn";
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.ReadOnly = true;
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sifrazdrvustanoveDataGridViewTextBoxColumn
            // 
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.DataPropertyName = "sifra_zdrv_ustanove";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.HeaderText = "sifra_zdrv_ustanove";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.Name = "sifrazdrvustanoveDataGridViewTextBoxColumn";
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.ReadOnly = true;
            this.sifrazdrvustanoveDataGridViewTextBoxColumn.Visible = false;
            // 
            // postupciDataGridViewTextBoxColumn
            // 
            this.postupciDataGridViewTextBoxColumn.DataPropertyName = "postupci";
            this.postupciDataGridViewTextBoxColumn.HeaderText = "postupci";
            this.postupciDataGridViewTextBoxColumn.Name = "postupciDataGridViewTextBoxColumn";
            this.postupciDataGridViewTextBoxColumn.ReadOnly = true;
            this.postupciDataGridViewTextBoxColumn.Visible = false;
            // 
            // rasporedDataGridViewTextBoxColumn
            // 
            this.rasporedDataGridViewTextBoxColumn.DataPropertyName = "raspored";
            this.rasporedDataGridViewTextBoxColumn.HeaderText = "raspored";
            this.rasporedDataGridViewTextBoxColumn.Name = "rasporedDataGridViewTextBoxColumn";
            this.rasporedDataGridViewTextBoxColumn.ReadOnly = true;
            this.rasporedDataGridViewTextBoxColumn.Visible = false;
            // 
            // uputnicaDataGridViewTextBoxColumn
            // 
            this.uputnicaDataGridViewTextBoxColumn.DataPropertyName = "uputnica";
            this.uputnicaDataGridViewTextBoxColumn.HeaderText = "uputnica";
            this.uputnicaDataGridViewTextBoxColumn.Name = "uputnicaDataGridViewTextBoxColumn";
            this.uputnicaDataGridViewTextBoxColumn.ReadOnly = true;
            this.uputnicaDataGridViewTextBoxColumn.Visible = false;
            // 
            // receptiDataGridViewTextBoxColumn
            // 
            this.receptiDataGridViewTextBoxColumn.DataPropertyName = "recepti";
            this.receptiDataGridViewTextBoxColumn.HeaderText = "recepti";
            this.receptiDataGridViewTextBoxColumn.Name = "receptiDataGridViewTextBoxColumn";
            this.receptiDataGridViewTextBoxColumn.ReadOnly = true;
            this.receptiDataGridViewTextBoxColumn.Visible = false;
            // 
            // imePrezimeDataGridViewTextBoxColumn
            // 
            this.imePrezimeDataGridViewTextBoxColumn.DataPropertyName = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.HeaderText = "ImePrezime";
            this.imePrezimeDataGridViewTextBoxColumn.Name = "imePrezimeDataGridViewTextBoxColumn";
            this.imePrezimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.imePrezimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataSource = typeof(HouseMed.DAL.pacijenti);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPostavi,
            this.btnNoviPacijent,
            this.btnUredi,
            this.btnObrisi,
            this.pretražiToolStripMenuItem,
            this.textBoxPretrazi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 31);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnPostavi
            // 
            this.btnPostavi.Name = "btnPostavi";
            this.btnPostavi.Size = new System.Drawing.Size(68, 27);
            this.btnPostavi.Text = "Postavi";
            this.btnPostavi.Click += new System.EventHandler(this.btnPostavi_Click);
            // 
            // btnNoviPacijent
            // 
            this.btnNoviPacijent.Name = "btnNoviPacijent";
            this.btnNoviPacijent.Size = new System.Drawing.Size(109, 27);
            this.btnNoviPacijent.Text = "Novi pacijent";
            this.btnNoviPacijent.Click += new System.EventHandler(this.btnNoviPacijent_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(57, 27);
            this.btnUredi.Text = "Uredi";
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(60, 27);
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // pretražiToolStripMenuItem
            // 
            this.pretražiToolStripMenuItem.Name = "pretražiToolStripMenuItem";
            this.pretražiToolStripMenuItem.Size = new System.Drawing.Size(71, 27);
            this.pretražiToolStripMenuItem.Text = "Pretraži";
            // 
            // textBoxPretrazi
            // 
            this.textBoxPretrazi.Name = "textBoxPretrazi";
            this.textBoxPretrazi.Size = new System.Drawing.Size(100, 27);
            this.textBoxPretrazi.TextChanged += new System.EventHandler(this.textBoxPretrazi_TextChanged);
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 377);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacijenti";
            this.Load += new System.EventHandler(this.frmPatients_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPatients_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacijentiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mBODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drzavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobitelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrazdrvustanoveIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijepljenjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evidencijahospitalizacijeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifrazdrvustanoveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postupciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rasporedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uputnicaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn receptiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnPostavi;
        private System.Windows.Forms.ToolStripMenuItem btnNoviPacijent;
        private System.Windows.Forms.ToolStripMenuItem btnUredi;
        private System.Windows.Forms.ToolStripMenuItem btnObrisi;
        private System.Windows.Forms.ToolStripMenuItem pretražiToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox textBoxPretrazi;
    }
}