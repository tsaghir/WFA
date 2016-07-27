namespace HouseMed.Certificates
{
    partial class frmAddNewCertificate
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
            this.labelIspisPacijenta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSvrha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.ucNatrag1 = new HouseMed.ucNatrag();
            this.SuspendLayout();
            // 
            // labelIspisPacijenta
            // 
            this.labelIspisPacijenta.AutoSize = true;
            this.labelIspisPacijenta.Location = new System.Drawing.Point(12, 18);
            this.labelIspisPacijenta.Name = "labelIspisPacijenta";
            this.labelIspisPacijenta.Size = new System.Drawing.Size(72, 13);
            this.labelIspisPacijenta.TabIndex = 0;
            this.labelIspisPacijenta.Text = "Za pacijenta: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Svrha:";
            // 
            // tbSvrha
            // 
            this.tbSvrha.Location = new System.Drawing.Point(90, 48);
            this.tbSvrha.Multiline = true;
            this.tbSvrha.Name = "tbSvrha";
            this.tbSvrha.Size = new System.Drawing.Size(208, 52);
            this.tbSvrha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Opis:";
            // 
            // tbOpis
            // 
            this.tbOpis.Location = new System.Drawing.Point(90, 114);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.Size = new System.Drawing.Size(208, 105);
            this.tbOpis.TabIndex = 4;
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(131, 225);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(167, 23);
            this.btnSpremi.TabIndex = 5;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // ucNatrag1
            // 
            this.ucNatrag1.Location = new System.Drawing.Point(49, 225);
            this.ucNatrag1.Name = "ucNatrag1";
            this.ucNatrag1.Size = new System.Drawing.Size(76, 23);
            this.ucNatrag1.TabIndex = 6;
            // 
            // frmAddNewCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 258);
            this.Controls.Add(this.ucNatrag1);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSvrha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelIspisPacijenta);
            this.KeyPreview = true;
            this.Name = "frmAddNewCertificate";
            this.Text = "frmAddNewCertificate";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddNewCertificate_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIspisPacijenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSvrha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.Button btnSpremi;
        private ucNatrag ucNatrag1;
    }
}