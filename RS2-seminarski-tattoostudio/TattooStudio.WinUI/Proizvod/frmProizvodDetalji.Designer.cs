
namespace TattooStudio.WinUI.Proizvod
{
    partial class frmProizvodDetalji
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUcitajSliku = new System.Windows.Forms.Button();
            this.txtPutanjaDoSlike = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.cmbTipProizvoda = new System.Windows.Forms.ComboBox();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.pcbSlika = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdSlika = new System.Windows.Forms.OpenFileDialog();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUcitajSliku);
            this.groupBox1.Controls.Add(this.txtPutanjaDoSlike);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnObrisi);
            this.groupBox1.Controls.Add(this.btnSpremi);
            this.groupBox1.Controls.Add(this.cmbTipProizvoda);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.txtCijena);
            this.groupBox1.Controls.Add(this.txtNaziv);
            this.groupBox1.Controls.Add(this.pcbSlika);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji proizvoda";
            // 
            // btnUcitajSliku
            // 
            this.btnUcitajSliku.Location = new System.Drawing.Point(532, 159);
            this.btnUcitajSliku.Name = "btnUcitajSliku";
            this.btnUcitajSliku.Size = new System.Drawing.Size(51, 23);
            this.btnUcitajSliku.TabIndex = 13;
            this.btnUcitajSliku.Text = "...";
            this.btnUcitajSliku.UseVisualStyleBackColor = true;
            this.btnUcitajSliku.Click += new System.EventHandler(this.btnUcitajSliku_Click);
            // 
            // txtPutanjaDoSlike
            // 
            this.txtPutanjaDoSlike.Location = new System.Drawing.Point(139, 159);
            this.txtPutanjaDoSlike.Name = "txtPutanjaDoSlike";
            this.txtPutanjaDoSlike.Size = new System.Drawing.Size(387, 22);
            this.txtPutanjaDoSlike.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Putanja do slike";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(18, 328);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(177, 31);
            this.btnObrisi.TabIndex = 10;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(406, 328);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(177, 31);
            this.btnSpremi.TabIndex = 9;
            this.btnSpremi.Text = "Sačuvaj";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // cmbTipProizvoda
            // 
            this.cmbTipProizvoda.DisplayMember = "Naziv";
            this.cmbTipProizvoda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipProizvoda.FormattingEnabled = true;
            this.cmbTipProizvoda.Location = new System.Drawing.Point(139, 72);
            this.cmbTipProizvoda.Name = "cmbTipProizvoda";
            this.cmbTipProizvoda.Size = new System.Drawing.Size(281, 24);
            this.cmbTipProizvoda.TabIndex = 8;
            this.cmbTipProizvoda.ValueMember = "TipProizvodumId";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(139, 199);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(444, 99);
            this.txtOpis.TabIndex = 7;
            this.txtOpis.Text = "";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(139, 112);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(281, 22);
            this.txtCijena.TabIndex = 6;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(139, 32);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(281, 22);
            this.txtNaziv.TabIndex = 5;
            // 
            // pcbSlika
            // 
            this.pcbSlika.Location = new System.Drawing.Point(426, 12);
            this.pcbSlika.Name = "pcbSlika";
            this.pcbSlika.Size = new System.Drawing.Size(157, 136);
            this.pcbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSlika.TabIndex = 4;
            this.pcbSlika.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Opis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cijena";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip proizvoda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            // 
            // ofdSlika
            // 
            this.ofdSlika.FileName = "openFileDialog1";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 394);
            this.panel1.TabIndex = 14;
            // 
            // frmProizvodDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 421);
            this.Controls.Add(this.panel1);
            this.Name = "frmProizvodDetalji";
            this.Text = "frmProizvodDetalji";
            this.Load += new System.EventHandler(this.frmProizvodDetalji_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSlika)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.ComboBox cmbTipProizvoda;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.PictureBox pcbSlika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPutanjaDoSlike;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUcitajSliku;
        private System.Windows.Forms.OpenFileDialog ofdSlika;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Panel panel1;
    }
}