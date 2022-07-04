
namespace TattooStudio.WinUI.Termin
{
    partial class frmTerminDetalji
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbOtkazan = new System.Windows.Forms.CheckBox();
            this.chbOdobren = new System.Windows.Forms.CheckBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtOpisZahtjeva = new System.Windows.Forms.RichTextBox();
            this.txtKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbOtkazan);
            this.groupBox1.Controls.Add(this.chbOdobren);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.txtOpisZahtjeva);
            this.groupBox1.Controls.Add(this.txtKorisnickoIme);
            this.groupBox1.Controls.Add(this.txtImePrezime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji termina";
            // 
            // chbOtkazan
            // 
            this.chbOtkazan.AutoCheck = false;
            this.chbOtkazan.AutoSize = true;
            this.chbOtkazan.Location = new System.Drawing.Point(9, 186);
            this.chbOtkazan.Name = "chbOtkazan";
            this.chbOtkazan.Size = new System.Drawing.Size(83, 21);
            this.chbOtkazan.TabIndex = 9;
            this.chbOtkazan.Text = "Otkazan";
            this.chbOtkazan.UseVisualStyleBackColor = true;
            // 
            // chbOdobren
            // 
            this.chbOdobren.AutoCheck = false;
            this.chbOdobren.AutoSize = true;
            this.chbOdobren.Location = new System.Drawing.Point(9, 159);
            this.chbOdobren.Name = "chbOdobren";
            this.chbOdobren.Size = new System.Drawing.Size(86, 21);
            this.chbOdobren.TabIndex = 8;
            this.chbOdobren.Text = "Odobren";
            this.chbOdobren.UseVisualStyleBackColor = true;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Enabled = false;
            this.dtpDatum.Location = new System.Drawing.Point(189, 83);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(349, 22);
            this.dtpDatum.TabIndex = 7;
            // 
            // txtOpisZahtjeva
            // 
            this.txtOpisZahtjeva.Location = new System.Drawing.Point(189, 111);
            this.txtOpisZahtjeva.Name = "txtOpisZahtjeva";
            this.txtOpisZahtjeva.ReadOnly = true;
            this.txtOpisZahtjeva.Size = new System.Drawing.Size(349, 96);
            this.txtOpisZahtjeva.TabIndex = 6;
            this.txtOpisZahtjeva.Text = "";
            // 
            // txtKorisnickoIme
            // 
            this.txtKorisnickoIme.Location = new System.Drawing.Point(189, 54);
            this.txtKorisnickoIme.Name = "txtKorisnickoIme";
            this.txtKorisnickoIme.ReadOnly = true;
            this.txtKorisnickoIme.Size = new System.Drawing.Size(349, 22);
            this.txtKorisnickoIme.TabIndex = 5;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(189, 24);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.ReadOnly = true;
            this.txtImePrezime.Size = new System.Drawing.Size(349, 22);
            this.txtImePrezime.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opis zahtjeva";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum termina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korisničko ime klijenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime i prezime klijenta";
            // 
            // btnOdobri
            // 
            this.btnOdobri.Location = new System.Drawing.Point(393, 224);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(154, 27);
            this.btnOdobri.TabIndex = 1;
            this.btnOdobri.Text = "Odobri";
            this.btnOdobri.UseVisualStyleBackColor = true;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(3, 224);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(154, 27);
            this.btnOtkazi.TabIndex = 2;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnOtkazi);
            this.panel1.Controls.Add(this.btnOdobri);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 268);
            this.panel1.TabIndex = 3;
            // 
            // frmTerminDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 294);
            this.Controls.Add(this.panel1);
            this.Name = "frmTerminDetalji";
            this.Text = "frmTerminDetalji";
            this.Load += new System.EventHandler(this.frmTerminDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.RichTextBox txtOpisZahtjeva;
        private System.Windows.Forms.TextBox txtKorisnickoIme;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.CheckBox chbOtkazan;
        private System.Windows.Forms.CheckBox chbOdobren;
        private System.Windows.Forms.Panel panel1;
    }
}