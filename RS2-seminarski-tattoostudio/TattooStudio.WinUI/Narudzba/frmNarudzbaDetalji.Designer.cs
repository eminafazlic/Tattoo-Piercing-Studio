
namespace TattooStudio.WinUI.Narudzba
{
    partial class frmNarudzbaDetalji
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
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtUkupniIznos = new System.Windows.Forms.TextBox();
            this.dgvStavkeNarudzbe = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbIsIsporucena = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(140, 68);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.ReadOnly = true;
            this.txtImePrezime.Size = new System.Drawing.Size(262, 22);
            this.txtImePrezime.TabIndex = 0;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(140, 105);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.ReadOnly = true;
            this.txtKorisnickoIme.Size = new System.Drawing.Size(262, 22);
            this.txtKorisnickoIme.TabIndex = 1;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(140, 145);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(262, 22);
            this.txtDatum.TabIndex = 2;
            // 
            // txtUkupniIznos
            // 
            this.txtUkupniIznos.Location = new System.Drawing.Point(140, 185);
            this.txtUkupniIznos.Name = "txtUkupniIznos";
            this.txtUkupniIznos.ReadOnly = true;
            this.txtUkupniIznos.Size = new System.Drawing.Size(262, 22);
            this.txtUkupniIznos.TabIndex = 3;
            // 
            // dgvStavkeNarudzbe
            // 
            this.dgvStavkeNarudzbe.AllowUserToAddRows = false;
            this.dgvStavkeNarudzbe.AllowUserToDeleteRows = false;
            this.dgvStavkeNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNarudzbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStavkeNarudzbe.Location = new System.Drawing.Point(3, 18);
            this.dgvStavkeNarudzbe.Name = "dgvStavkeNarudzbe";
            this.dgvStavkeNarudzbe.ReadOnly = true;
            this.dgvStavkeNarudzbe.RowHeadersWidth = 51;
            this.dgvStavkeNarudzbe.RowTemplate.Height = 24;
            this.dgvStavkeNarudzbe.Size = new System.Drawing.Size(401, 241);
            this.dgvStavkeNarudzbe.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDatum);
            this.groupBox1.Controls.Add(this.txtUkupniIznos);
            this.groupBox1.Controls.Add(this.txtImePrezime);
            this.groupBox1.Controls.Add(this.txtKorisnickoIme);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji narudžbe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ukupni iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum narudžbe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Korisničko ime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime i prezime";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStavkeNarudzbe);
            this.groupBox2.Location = new System.Drawing.Point(420, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 262);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke narudžbe";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.chbIsIsporucena);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(9, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 299);
            this.panel1.TabIndex = 7;
            // 
            // chbIsIsporucena
            // 
            this.chbIsIsporucena.AutoSize = true;
            this.chbIsIsporucena.Location = new System.Drawing.Point(6, 275);
            this.chbIsIsporucena.Name = "chbIsIsporucena";
            this.chbIsIsporucena.Size = new System.Drawing.Size(213, 21);
            this.chbIsIsporucena.TabIndex = 7;
            this.chbIsIsporucena.Text = "Ova narudžba je isporučena.";
            this.chbIsIsporucena.UseVisualStyleBackColor = true;
            this.chbIsIsporucena.CheckedChanged += new System.EventHandler(this.chbIsIsporucena_CheckedChanged);
            // 
            // frmNarudzbaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 311);
            this.Controls.Add(this.panel1);
            this.Name = "frmNarudzbaDetalji";
            this.Text = "frmNarudzbaDetalji";
            this.Load += new System.EventHandler(this.frmNarudzbaDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNarudzbe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtUkupniIznos;
        private System.Windows.Forms.DataGridView dgvStavkeNarudzbe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbIsIsporucena;
    }
}