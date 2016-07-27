namespace HouseMed.Recipes
{
    partial class frmRecipe
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
            this.dgvRecipe = new System.Windows.Forms.DataGridView();
            this.menuStripRecipe = new System.Windows.Forms.MenuStrip();
            this.natragToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviReceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiOdabraniReceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).BeginInit();
            this.menuStripRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRecipe
            // 
            this.dgvRecipe.AllowUserToAddRows = false;
            this.dgvRecipe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecipe.Location = new System.Drawing.Point(0, 24);
            this.dgvRecipe.Name = "dgvRecipe";
            this.dgvRecipe.ReadOnly = true;
            this.dgvRecipe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipe.Size = new System.Drawing.Size(912, 461);
            this.dgvRecipe.TabIndex = 2;
            // 
            // menuStripRecipe
            // 
            this.menuStripRecipe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.natragToolStripMenuItem,
            this.noviReceptToolStripMenuItem,
            this.akcijeToolStripMenuItem,
            this.obrišiOdabraniReceptToolStripMenuItem});
            this.menuStripRecipe.Location = new System.Drawing.Point(0, 0);
            this.menuStripRecipe.Name = "menuStripRecipe";
            this.menuStripRecipe.Size = new System.Drawing.Size(912, 24);
            this.menuStripRecipe.TabIndex = 4;
            this.menuStripRecipe.Text = "File";
            // 
            // natragToolStripMenuItem
            // 
            this.natragToolStripMenuItem.Name = "natragToolStripMenuItem";
            this.natragToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.natragToolStripMenuItem.Text = "Natrag";
            this.natragToolStripMenuItem.Click += new System.EventHandler(this.natragToolStripMenuItem_Click);
            // 
            // noviReceptToolStripMenuItem
            // 
            this.noviReceptToolStripMenuItem.Name = "noviReceptToolStripMenuItem";
            this.noviReceptToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.noviReceptToolStripMenuItem.Text = "Novi recept";
            this.noviReceptToolStripMenuItem.Click += new System.EventHandler(this.noviReceptToolStripMenuItem_Click);
            // 
            // akcijeToolStripMenuItem
            // 
            this.akcijeToolStripMenuItem.Name = "akcijeToolStripMenuItem";
            this.akcijeToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.akcijeToolStripMenuItem.Text = "Uredi odabrani recept";
            this.akcijeToolStripMenuItem.Click += new System.EventHandler(this.akcijeToolStripMenuItem_Click);
            // 
            // obrišiOdabraniReceptToolStripMenuItem
            // 
            this.obrišiOdabraniReceptToolStripMenuItem.Name = "obrišiOdabraniReceptToolStripMenuItem";
            this.obrišiOdabraniReceptToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.obrišiOdabraniReceptToolStripMenuItem.Text = "Obriši odabrani recept";
            this.obrišiOdabraniReceptToolStripMenuItem.Click += new System.EventHandler(this.obrišiOdabraniReceptToolStripMenuItem_Click);
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 485);
            this.Controls.Add(this.dgvRecipe);
            this.Controls.Add(this.menuStripRecipe);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripRecipe;
            this.Name = "frmRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepti";
            this.Load += new System.EventHandler(this.frmRecipe_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRecipe_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipe)).EndInit();
            this.menuStripRecipe.ResumeLayout(false);
            this.menuStripRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRecipe;
        private System.Windows.Forms.MenuStrip menuStripRecipe;
        private System.Windows.Forms.ToolStripMenuItem noviReceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiOdabraniReceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem natragToolStripMenuItem;
    }
}