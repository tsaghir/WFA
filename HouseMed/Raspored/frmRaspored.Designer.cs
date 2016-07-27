namespace HouseMed.Raspored
{
    partial class frmRaspored
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
            this.dateTimePickerRaspored = new System.Windows.Forms.DateTimePicker();
            this.dgvRaspored = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCijepljenje = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnNoviPregled = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUnosCijepljanja = new System.Windows.Forms.ToolStripMenuItem();
            this.datumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijepljenje)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePickerRaspored
            // 
            this.dateTimePickerRaspored.Location = new System.Drawing.Point(307, 6);
            this.dateTimePickerRaspored.Name = "dateTimePickerRaspored";
            this.dateTimePickerRaspored.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRaspored.TabIndex = 0;
            this.dateTimePickerRaspored.ValueChanged += new System.EventHandler(this.dateTimePickerRaspored_ValueChanged);
            // 
            // dgvRaspored
            // 
            this.dgvRaspored.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRaspored.Location = new System.Drawing.Point(59, 134);
            this.dgvRaspored.Name = "dgvRaspored";
            this.dgvRaspored.RowTemplate.Height = 24;
            this.dgvRaspored.Size = new System.Drawing.Size(741, 169);
            this.dgvRaspored.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pregled kalendara cijepljenja:";
            // 
            // dgvCijepljenje
            // 
            this.dgvCijepljenje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCijepljenje.Location = new System.Drawing.Point(59, 375);
            this.dgvCijepljenje.Name = "dgvCijepljenje";
            this.dgvCijepljenje.RowTemplate.Height = 24;
            this.dgvCijepljenje.Size = new System.Drawing.Size(741, 159);
            this.dgvCijepljenje.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNoviPregled,
            this.btnUnosCijepljanja,
            this.datumToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnNoviPregled
            // 
            this.btnNoviPregled.Name = "btnNoviPregled";
            this.btnNoviPregled.Size = new System.Drawing.Size(108, 24);
            this.btnNoviPregled.Text = "Novi pregled";
            this.btnNoviPregled.Click += new System.EventHandler(this.btnNoviPregled_Click);
            // 
            // btnUnosCijepljanja
            // 
            this.btnUnosCijepljanja.Name = "btnUnosCijepljanja";
            this.btnUnosCijepljanja.Size = new System.Drawing.Size(126, 24);
            this.btnUnosCijepljanja.Text = "Unos cijepljenja";
            this.btnUnosCijepljanja.Click += new System.EventHandler(this.btnUnosCijepljanja_Click);
            // 
            // datumToolStripMenuItem1
            // 
            this.datumToolStripMenuItem1.Name = "datumToolStripMenuItem1";
            this.datumToolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.datumToolStripMenuItem1.Text = "Datum: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kalendar pregleda:";
            // 
            // frmRaspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvCijepljenje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRaspored);
            this.Controls.Add(this.dateTimePickerRaspored);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frmRaspored";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raspored";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRaspored_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRaspored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCijepljenje)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerRaspored;
        private System.Windows.Forms.DataGridView dgvRaspored;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCijepljenje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnNoviPregled;
        private System.Windows.Forms.ToolStripMenuItem btnUnosCijepljanja;
        private System.Windows.Forms.ToolStripMenuItem datumToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
    }
}