
namespace TattooStudio.WinUI.LoginRegistracija
{
    partial class frmRegistracija
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtPutanjaDoSlike = new System.Windows.Forms.TextBox();
            this.txtPotvrdaLozinke = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.cmbZanimanje = new System.Windows.Forms.ComboBox();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(151, 18);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(236, 22);
            this.txtIme.TabIndex = 0;
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(151, 106);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.Size = new System.Drawing.Size(236, 22);
            this.txtKorisnickoIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(151, 60);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(236, 22);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtPutanjaDoSlike
            // 
            this.txtPutanjaDoSlike.Location = new System.Drawing.Point(553, 196);
            this.txtPutanjaDoSlike.Name = "txtPutanjaDoSlike";
            this.txtPutanjaDoSlike.Size = new System.Drawing.Size(176, 22);
            this.txtPutanjaDoSlike.TabIndex = 3;
            // 
            // txtPotvrdaLozinke
            // 
            this.txtPotvrdaLozinke.Location = new System.Drawing.Point(151, 196);
            this.txtPotvrdaLozinke.Name = "txtPotvrdaLozinke";
            this.txtPotvrdaLozinke.PasswordChar = '*';
            this.txtPotvrdaLozinke.Size = new System.Drawing.Size(236, 22);
            this.txtPotvrdaLozinke.TabIndex = 4;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(151, 152);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(236, 22);
            this.txtLozinka.TabIndex = 5;
            // 
            // cmbSpol
            // 
            this.cmbSpol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(553, 101);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(236, 24);
            this.cmbSpol.TabIndex = 6;
            // 
            // cmbZanimanje
            // 
            this.cmbZanimanje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbZanimanje.FormattingEnabled = true;
            this.cmbZanimanje.Location = new System.Drawing.Point(553, 147);
            this.cmbZanimanje.Name = "cmbZanimanje";
            this.cmbZanimanje.Size = new System.Drawing.Size(236, 24);
            this.cmbZanimanje.TabIndex = 7;
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(216, 256);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(365, 34);
            this.btnRegistracija.TabIndex = 8;
            this.btnRegistracija.Text = "Registruj se";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Korisničko ime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lozinka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Potvrdite lozinku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fotografija";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Spol";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Zanimanje";
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Location = new System.Drawing.Point(735, 198);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(54, 23);
            this.btnUcitajSliku.TabIndex = 17;
            this.btnUcitajSliku.Text = "...";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Email";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(553, 60);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(236, 22);
            this.txtTelefon.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(553, 18);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(236, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtIme);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtKorisnickoIme);
            this.panel1.Controls.Add(this.txtTelefon);
            this.panel1.Controls.Add(this.txtPrezime);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtPutanjaDoSlike);
            this.panel1.Controls.Add(this.btnUcitajSliku);
            this.panel1.Controls.Add(this.txtPotvrdaLozinke);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtLozinka);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbSpol);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbZanimanje);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnRegistracija);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 299);
            this.panel1.TabIndex = 22;
            // 
            // frmRegistracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 327);
            this.Controls.Add(this.panel1);
            this.Name = "frmRegistracija";
            this.Text = "frmRegistracija";
            this.Load += new System.EventHandler(this.frmRegistracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtPutanjaDoSlike;
        private System.Windows.Forms.TextBox txtPotvrdaLozinke;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.ComboBox cmbZanimanje;
        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.Panel panel1;
    }
}