namespace HouseMed.Procedures
{
    partial class frmProceduresControl
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
            this.dgvPostupciPacijenta = new System.Windows.Forms.DataGridView();
            this.btnPotvrda = new System.Windows.Forms.Button();
            this.btnUputnica = new System.Windows.Forms.Button();
            this.btnRecept = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnCijepljenje = new System.Windows.Forms.Button();
            this.ucNatrag1 = new HouseMed.ucNatrag();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostupciPacijenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPostupciPacijenta
            // 
            this.dgvPostupciPacijenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostupciPacijenta.Location = new System.Drawing.Point(12, 12);
            this.dgvPostupciPacijenta.Name = "dgvPostupciPacijenta";
            this.dgvPostupciPacijenta.Size = new System.Drawing.Size(527, 150);
            this.dgvPostupciPacijenta.TabIndex = 0;
            // 
            // btnPotvrda
            // 
            this.btnPotvrda.Location = new System.Drawing.Point(584, 12);
            this.btnPotvrda.Name = "btnPotvrda";
            this.btnPotvrda.Size = new System.Drawing.Size(125, 23);
            this.btnPotvrda.TabIndex = 1;
            this.btnPotvrda.Text = "Potvrda";
            this.btnPotvrda.UseVisualStyleBackColor = true;
            this.btnPotvrda.Click += new System.EventHandler(this.btnPotvrda_Click);
            // 
            // btnUputnica
            // 
            this.btnUputnica.Location = new System.Drawing.Point(584, 41);
            this.btnUputnica.Name = "btnUputnica";
            this.btnUputnica.Size = new System.Drawing.Size(125, 23);
            this.btnUputnica.TabIndex = 2;
            this.btnUputnica.Text = "Uputnica";
            this.btnUputnica.UseVisualStyleBackColor = true;
            this.btnUputnica.Click += new System.EventHandler(this.btnUputnica_Click);
            // 
            // btnRecept
            // 
            this.btnRecept.Location = new System.Drawing.Point(584, 70);
            this.btnRecept.Name = "btnRecept";
            this.btnRecept.Size = new System.Drawing.Size(125, 23);
            this.btnRecept.TabIndex = 3;
            this.btnRecept.Text = "Recept";
            this.btnRecept.UseVisualStyleBackColor = true;
            this.btnRecept.Click += new System.EventHandler(this.btnRecept_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Location = new System.Drawing.Point(584, 99);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(125, 23);
            this.btnPregled.TabIndex = 4;
            this.btnPregled.Text = "Naruči za pregled";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnCijepljenje
            // 
            this.btnCijepljenje.Location = new System.Drawing.Point(584, 128);
            this.btnCijepljenje.Name = "btnCijepljenje";
            this.btnCijepljenje.Size = new System.Drawing.Size(125, 23);
            this.btnCijepljenje.TabIndex = 5;
            this.btnCijepljenje.Text = "Naruči za cijepljenje";
            this.btnCijepljenje.UseVisualStyleBackColor = true;
            this.btnCijepljenje.Click += new System.EventHandler(this.btnCijepljenje_Click);
            // 
            // ucNatrag1
            // 
            this.ucNatrag1.Location = new System.Drawing.Point(606, 160);
            this.ucNatrag1.Name = "ucNatrag1";
            this.ucNatrag1.Size = new System.Drawing.Size(79, 23);
            this.ucNatrag1.TabIndex = 6;
            // 
            // frmProceduresControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 195);
            this.Controls.Add(this.ucNatrag1);
            this.Controls.Add(this.btnCijepljenje);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnRecept);
            this.Controls.Add(this.btnUputnica);
            this.Controls.Add(this.btnPotvrda);
            this.Controls.Add(this.dgvPostupciPacijenta);
            this.KeyPreview = true;
            this.Name = "frmProceduresControl";
            this.Text = "frmProceduresControl";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProceduresControl_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostupciPacijenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPostupciPacijenta;
        private System.Windows.Forms.Button btnPotvrda;
        private System.Windows.Forms.Button btnUputnica;
        private System.Windows.Forms.Button btnRecept;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnCijepljenje;
        private ucNatrag ucNatrag1;
    }
}