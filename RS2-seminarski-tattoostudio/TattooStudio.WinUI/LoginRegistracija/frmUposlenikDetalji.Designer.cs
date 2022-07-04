
namespace TattooStudio.WinUI.LoginRegistracija
{
    partial class frmUposlenikDetalji
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbZanimanje = new System.Windows.Forms.ComboBox();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.txtPotvrdaLozinke = new System.Windows.Forms.TextBox();
            this.txtPutanjaDoSlike = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.pcbSlika = new System.Windows.Forms.PictureBox();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Email";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(543, 56);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(236, 22);
            this.txtTelefon.TabIndex = 40;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(543, 14);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 22);
            this.txtEmail.TabIndex = 39;
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Location = new System.Drawing.Point(725, 194);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(54, 23);
            this.btnUcitajSliku.TabIndex = 38;
            this.btnUcitajSliku.Text = "...";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Zanimanje";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Spol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Fotografija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Potvrdite lozinku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Korisničko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ime";
            // 
            // cmbZanimanje
            // 
            this.cmbZanimanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZanimanje.FormattingEnabled = true;
            this.cmbZanimanje.Location = new System.Drawing.Point(543, 143);
            this.cmbZanimanje.Name = "cmbZanimanje";
            this.cmbZanimanje.Size = new System.Drawing.Size(236, 24);
            this.cmbZanimanje.TabIndex = 29;
            // 
            // cmbSpol
            // 
            this.cmbSpol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(543, 97);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(236, 24);
            this.cmbSpol.TabIndex = 28;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(141, 148);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(236, 22);
            this.txtLozinka.TabIndex = 27;
            // 
            // txtPotvrdaLozinke
            // 
            this.txtPotvrdaLozinke.Location = new System.Drawing.Point(141, 192);
            this.txtPotvrdaLozinke.Name = "txtPotvrdaLozinke";
            this.txtPotvrdaLozinke.Size = new System.Drawing.Size(236, 22);
            this.txtPotvrdaLozinke.TabIndex = 26;
            // 
            // txtPutanjaDoSlike
            // 
            this.txtPutanjaDoSlike.Location = new System.Drawing.Point(543, 192);
            this.txtPutanjaDoSlike.Name = "txtPutanjaDoSlike";
            this.txtPutanjaDoSlike.Size = new System.Drawing.Size(176, 22);
            this.txtPutanjaDoSlike.TabIndex = 25;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(141, 56);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(236, 22);
            this.txtPrezime.TabIndex = 24;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(141, 102);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(236, 22);
            this.txtKorisnickoIme.TabIndex = 23;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(141, 14);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(236, 22);
            this.txtIme.TabIndex = 22;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(15, 290);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(233, 29);
            this.btnObrisi.TabIndex = 43;
            this.btnObrisi.Text = "Obriši račun";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(823, 290);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(233, 29);
            this.btnSpremi.TabIndex = 44;
            this.btnSpremi.Text = "Sačuvaj promjene";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // pcbSlika
            // 
            this.pcbSlika.Location = new System.Drawing.Point(823, 14);
            this.pcbSlika.Name = "pcbSlika";
            this.pcbSlika.Size = new System.Drawing.Size(233, 200);
            this.pcbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSlika.TabIndex = 45;
            this.pcbSlika.TabStop = false;
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnSpremi);
            this.panel1.Controls.Add(this.pcbSlika);
            this.panel1.Controls.Add(this.txtIme);
            this.panel1.Controls.Add(this.txtKorisnickoIme);
            this.panel1.Controls.Add(this.btnObrisi);
            this.panel1.Controls.Add(this.txtPrezime);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPutanjaDoSlike);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtPotvrdaLozinke);
            this.panel1.Controls.Add(this.txtTelefon);
            this.panel1.Controls.Add(this.txtLozinka);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.cmbSpol);
            this.panel1.Controls.Add(this.btnUcitajSliku);
            this.panel1.Controls.Add(this.cmbZanimanje);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 342);
            this.panel1.TabIndex = 46;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmUposlenikDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 366);
            this.Controls.Add(this.panel1);
            this.Name = "frmUposlenikDetalji";
            this.Text = "frmUposlenikDetalji";
            this.Load += new System.EventHandler(this.frmUposlenikDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbZanimanje;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.TextBox txtPotvrdaLozinke;
        private System.Windows.Forms.TextBox txtPutanjaDoSlike;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.PictureBox pcbSlika;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider err;
    }
}