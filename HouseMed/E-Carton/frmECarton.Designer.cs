using System.Drawing;

namespace HouseMed.E_Carton
{
    partial class frmECarton
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
            this.pacijentiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvHostpitalizacija = new System.Windows.Forms.DataGridView();
            this.dgvPostupci = new System.Windows.Forms.DataGridView();
            this.lblPreview = new System.Windows.Forms.Label();
            this.btnEditCijepljenje = new System.Windows.Forms.Button();
            this.lblHospitalizacija = new System.Windows.Forms.Label();
            this.btnEditHospitalizacija = new System.Windows.Forms.Button();
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.lblPostupci = new System.Windows.Forms.Label();
            this.btnEditPostupci = new System.Windows.Forms.Button();
            this.lblRaspored = new System.Windows.Forms.Label();
            this.btnEditRaspored = new System.Windows.Forms.Button();
            this.menuStripECarton = new System.Windows.Forms.MenuStrip();
            this.natragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaberiPacijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaberiPrikazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboPrikaz = new System.Windows.Forms.ToolStripComboBox();
            this.pretražiPacijenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.ToolStripTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dgvPreview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostpitalizacija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostupci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            this.menuStripECarton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
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
            this.receptiDataGridViewTextBoxColumn});
            this.dgvPatients.DataSource = this.pacijentiBindingSource;
            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatients.Location = new System.Drawing.Point(0, 0);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(1026, 319);
            this.dgvPatients.TabIndex = 0;
            this.dgvPatients.SelectionChanged += new System.EventHandler(this.dgvPatients_SelectionChanged);
            // 
            // pacijentiIDDataGridViewTextBoxColumn
            // 
            this.pacijentiIDDataGridViewTextBoxColumn.DataPropertyName = "pacijentiID";
            this.pacijentiIDDataGridViewTextBoxColumn.HeaderText = "Br. Pacijenta";
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
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spolDataGridViewTextBoxColumn
            // 
            this.spolDataGridViewTextBoxColumn.DataPropertyName = "spol";
            this.spolDataGridViewTextBoxColumn.HeaderText = "Spol";
            this.spolDataGridViewTextBoxColumn.Name = "spolDataGridViewTextBoxColumn";
            this.spolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjestoDataGridViewTextBoxColumn
            // 
            this.mjestoDataGridViewTextBoxColumn.DataPropertyName = "mjesto";
            this.mjestoDataGridViewTextBoxColumn.HeaderText = "Mjesto";
            this.mjestoDataGridViewTextBoxColumn.Name = "mjestoDataGridViewTextBoxColumn";
            this.mjestoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drzavaDataGridViewTextBoxColumn
            // 
            this.drzavaDataGridViewTextBoxColumn.DataPropertyName = "drzava";
            this.drzavaDataGridViewTextBoxColumn.HeaderText = "Država";
            this.drzavaDataGridViewTextBoxColumn.Name = "drzavaDataGridViewTextBoxColumn";
            this.drzavaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobitelDataGridViewTextBoxColumn
            // 
            this.mobitelDataGridViewTextBoxColumn.DataPropertyName = "mobitel";
            this.mobitelDataGridViewTextBoxColumn.HeaderText = "Mobitel";
            this.mobitelDataGridViewTextBoxColumn.Name = "mobitelDataGridViewTextBoxColumn";
            this.mobitelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifrazdrvustanoveIDDataGridViewTextBoxColumn
            // 
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.DataPropertyName = "sifra_zdrv_ustanoveID";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.HeaderText = "Br. Ustanove";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.Name = "sifrazdrvustanoveIDDataGridViewTextBoxColumn";
            this.sifrazdrvustanoveIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijepljenjeDataGridViewTextBoxColumn
            // 
            this.cijepljenjeDataGridViewTextBoxColumn.DataPropertyName = "cijepljenje";
            this.cijepljenjeDataGridViewTextBoxColumn.HeaderText = "Cijepljenje";
            this.cijepljenjeDataGridViewTextBoxColumn.Name = "cijepljenjeDataGridViewTextBoxColumn";
            this.cijepljenjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijepljenjeDataGridViewTextBoxColumn.Visible = false;
            // 
            // evidencijahospitalizacijeDataGridViewTextBoxColumn
            // 
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.DataPropertyName = "evidencija_hospitalizacije";
            this.evidencijahospitalizacijeDataGridViewTextBoxColumn.HeaderText = "Hospitalizacija";
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
            // pacijentiBindingSource
            // 
            this.pacijentiBindingSource.DataSource = typeof(HouseMed.DAL.pacijenti);
            // 
            // dgvHostpitalizacija
            // 
            this.dgvHostpitalizacija.AllowUserToAddRows = false;
            this.dgvHostpitalizacija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHostpitalizacija.Location = new System.Drawing.Point(3, 1124);
            this.dgvHostpitalizacija.Name = "dgvHostpitalizacija";
            this.dgvHostpitalizacija.ReadOnly = true;
            this.dgvHostpitalizacija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHostpitalizacija.Size = new System.Drawing.Size(1021, 204);
            this.dgvHostpitalizacija.TabIndex = 11;
            // 
            // dgvPostupci
            // 
            this.dgvPostupci.AllowUserToAddRows = false;
            this.dgvPostupci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostupci.Location = new System.Drawing.Point(3, 1404);
            this.dgvPostupci.Name = "dgvPostupci";
            this.dgvPostupci.ReadOnly = true;
            this.dgvPostupci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPostupci.Size = new System.Drawing.Size(1021, 240);
            this.dgvPostupci.TabIndex = 12;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblPreview.Location = new System.Drawing.Point(3, 0);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(94, 24);
            this.lblPreview.TabIndex = 14;
            this.lblPreview.Text = "Uputnice";
            // 
            // btnEditCijepljenje
            // 
            this.btnEditCijepljenje.Location = new System.Drawing.Point(937, 1059);
            this.btnEditCijepljenje.Name = "btnEditCijepljenje";
            this.btnEditCijepljenje.Size = new System.Drawing.Size(75, 23);
            this.btnEditCijepljenje.TabIndex = 16;
            this.btnEditCijepljenje.Text = "Uredi";
            this.btnEditCijepljenje.UseVisualStyleBackColor = true;
            // 
            // lblHospitalizacija
            // 
            this.lblHospitalizacija.AutoSize = true;
            this.lblHospitalizacija.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblHospitalizacija.Location = new System.Drawing.Point(9, 1090);
            this.lblHospitalizacija.Name = "lblHospitalizacija";
            this.lblHospitalizacija.Size = new System.Drawing.Size(145, 24);
            this.lblHospitalizacija.TabIndex = 17;
            this.lblHospitalizacija.Text = "Hospitalizacija";
            // 
            // btnEditHospitalizacija
            // 
            this.btnEditHospitalizacija.Location = new System.Drawing.Point(937, 1334);
            this.btnEditHospitalizacija.Name = "btnEditHospitalizacija";
            this.btnEditHospitalizacija.Size = new System.Drawing.Size(75, 23);
            this.btnEditHospitalizacija.TabIndex = 18;
            this.btnEditHospitalizacija.Text = "Uredi";
            this.btnEditHospitalizacija.UseVisualStyleBackColor = true;
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.AllowUserToAddRows = false;
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Location = new System.Drawing.Point(3, 1730);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.ReadOnly = true;
            this.dgvRaspored.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRaspored.Size = new System.Drawing.Size(1021, 229);
            this.dgvRaspored.TabIndex = 19;
            // 
            // lblPostupci
            // 
            this.lblPostupci.AutoSize = true;
            this.lblPostupci.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblPostupci.Location = new System.Drawing.Point(9, 1372);
            this.lblPostupci.Name = "lblPostupci";
            this.lblPostupci.Size = new System.Drawing.Size(93, 24);
            this.lblPostupci.TabIndex = 20;
            this.lblPostupci.Text = "Postupci";
            // 
            // btnEditPostupci
            // 
            this.btnEditPostupci.Location = new System.Drawing.Point(937, 1651);
            this.btnEditPostupci.Name = "btnEditPostupci";
            this.btnEditPostupci.Size = new System.Drawing.Size(75, 23);
            this.btnEditPostupci.TabIndex = 21;
            this.btnEditPostupci.Text = "Uredi";
            this.btnEditPostupci.UseVisualStyleBackColor = true;
            // 
            // lblRaspored
            // 
            this.lblRaspored.AutoSize = true;
            this.lblRaspored.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.lblRaspored.Location = new System.Drawing.Point(1, 1703);
            this.lblRaspored.Name = "lblRaspored";
            this.lblRaspored.Size = new System.Drawing.Size(101, 24);
            this.lblRaspored.TabIndex = 22;
            this.lblRaspored.Text = "Raspored";
            // 
            // btnEditRaspored
            // 
            this.btnEditRaspored.Location = new System.Drawing.Point(937, 1965);
            this.btnEditRaspored.Name = "btnEditRaspored";
            this.btnEditRaspored.Size = new System.Drawing.Size(75, 23);
            this.btnEditRaspored.TabIndex = 23;
            this.btnEditRaspored.Text = "Uredi";
            this.btnEditRaspored.UseVisualStyleBackColor = true;
            // 
            // menuStripECarton
            // 
            this.menuStripECarton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.natragToolStripMenuItem,
            this.odaberiPacijentaToolStripMenuItem,
            this.odaberiPrikazToolStripMenuItem,
            this.comboPrikaz,
            this.pretražiPacijenteToolStripMenuItem,
            this.txtSearch});
            this.menuStripECarton.Location = new System.Drawing.Point(0, 0);
            this.menuStripECarton.Name = "menuStripECarton";
            this.menuStripECarton.Size = new System.Drawing.Size(1026, 27);
            this.menuStripECarton.TabIndex = 24;
            this.menuStripECarton.Text = "menuStrip1";
            // 
            // natragToolStripMenuItem
            // 
            this.natragToolStripMenuItem.Name = "natragToolStripMenuItem";
            this.natragToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.natragToolStripMenuItem.Text = "Natrag";
            this.natragToolStripMenuItem.Click += new System.EventHandler(this.natragToolStripMenuItem_Click);
            // 
            // odaberiPacijentaToolStripMenuItem
            // 
            this.odaberiPacijentaToolStripMenuItem.Name = "odaberiPacijentaToolStripMenuItem";
            this.odaberiPacijentaToolStripMenuItem.Size = new System.Drawing.Size(112, 23);
            this.odaberiPacijentaToolStripMenuItem.Text = "Odaberi pacijenta";
            this.odaberiPacijentaToolStripMenuItem.Click += new System.EventHandler(this.odaberiPacijentaToolStripMenuItem_Click);
            // 
            // odaberiPrikazToolStripMenuItem
            // 
            this.odaberiPrikazToolStripMenuItem.Name = "odaberiPrikazToolStripMenuItem";
            this.odaberiPrikazToolStripMenuItem.Size = new System.Drawing.Size(98, 23);
            this.odaberiPrikazToolStripMenuItem.Text = "Odaberi prikaz:";
            // 
            // comboPrikaz
            // 
            this.comboPrikaz.Name = "comboPrikaz";
            this.comboPrikaz.Size = new System.Drawing.Size(121, 23);
            this.comboPrikaz.SelectedIndexChanged += new System.EventHandler(this.comboPrikaz_SelectedIndexChanged);
            // 
            // pretražiPacijenteToolStripMenuItem
            // 
            this.pretražiPacijenteToolStripMenuItem.Name = "pretražiPacijenteToolStripMenuItem";
            this.pretražiPacijenteToolStripMenuItem.Size = new System.Drawing.Size(112, 23);
            this.pretražiPacijenteToolStripMenuItem.Text = "Pretraži pacijente:";
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 23);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPatients);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvPreview);
            this.splitContainer1.Panel2.Controls.Add(this.lblPreview);
            this.splitContainer1.Size = new System.Drawing.Size(1026, 651);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 26;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 328);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // dgvPreview
            // 
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPreview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreview.Location = new System.Drawing.Point(0, 27);
            this.dgvPreview.Name = "dgvPreview";
            this.dgvPreview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPreview.Size = new System.Drawing.Size(1026, 301);
            this.dgvPreview.TabIndex = 0;
            // 
            // frmECarton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 678);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnEditRaspored);
            this.Controls.Add(this.lblRaspored);
            this.Controls.Add(this.btnEditPostupci);
            this.Controls.Add(this.lblPostupci);
            this.Controls.Add(this.dgvRaspored);
            this.Controls.Add(this.btnEditHospitalizacija);
            this.Controls.Add(this.lblHospitalizacija);
            this.Controls.Add(this.btnEditCijepljenje);
            this.Controls.Add(this.dgvPostupci);
            this.Controls.Add(this.dgvHostpitalizacija);
            this.Controls.Add(this.menuStripECarton);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripECarton;
            this.Name = "frmECarton";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-Karton";
            this.Load += new System.EventHandler(this.frmECarton_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmECarton_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacijentiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostpitalizacija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostupci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            this.menuStripECarton.ResumeLayout(false);
            this.menuStripECarton.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.BindingSource pacijentiBindingSource;
        private System.Windows.Forms.DataGridView dgvHostpitalizacija;
        private System.Windows.Forms.DataGridView dgvPostupci;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Button btnEditCijepljenje;
        private System.Windows.Forms.Label lblHospitalizacija;
        private System.Windows.Forms.Button btnEditHospitalizacija;
        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Label lblPostupci;
        private System.Windows.Forms.Button btnEditPostupci;
        private System.Windows.Forms.Label lblRaspored;
        private System.Windows.Forms.Button btnEditRaspored;
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
        private System.Windows.Forms.MenuStrip menuStripECarton;
        private System.Windows.Forms.ToolStripMenuItem natragToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaberiPacijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaberiPrikazToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox comboPrikaz;
        private System.Windows.Forms.ToolStripMenuItem pretražiPacijenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox txtSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPreview;
        private System.Windows.Forms.Splitter splitter1;
    }
}