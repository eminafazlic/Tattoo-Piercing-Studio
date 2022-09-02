
namespace TattooStudio.WinUI.Izvjestaj
{
    partial class frmPrikazIzvjestaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajIzvjestaj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvIzvjestaj = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSviIzvjestaji = new System.Windows.Forms.Button();
            this.dtpDatumPretraga = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Pregled izvještaja";
            // 
            // btnDodajIzvjestaj
            // 
            this.btnDodajIzvjestaj.Location = new System.Drawing.Point(485, 20);
            this.btnDodajIzvjestaj.Name = "btnDodajIzvjestaj";
            this.btnDodajIzvjestaj.Size = new System.Drawing.Size(230, 36);
            this.btnDodajIzvjestaj.TabIndex = 8;
            this.btnDodajIzvjestaj.Text = "Generiši izvještaj";
            this.btnDodajIzvjestaj.UseVisualStyleBackColor = true;
            this.btnDodajIzvjestaj.Click += new System.EventHandler(this.btnDodajIzvjestaj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvIzvjestaj);
            this.groupBox1.Location = new System.Drawing.Point(16, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 279);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izvještaji";
            // 
            // dgvIzvjestaj
            // 
            this.dgvIzvjestaj.AllowUserToAddRows = false;
            this.dgvIzvjestaj.AllowUserToDeleteRows = false;
            this.dgvIzvjestaj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIzvjestaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIzvjestaj.Location = new System.Drawing.Point(3, 18);
            this.dgvIzvjestaj.Name = "dgvIzvjestaj";
            this.dgvIzvjestaj.ReadOnly = true;
            this.dgvIzvjestaj.RowHeadersWidth = 51;
            this.dgvIzvjestaj.RowTemplate.Height = 24;
            this.dgvIzvjestaj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIzvjestaj.Size = new System.Drawing.Size(693, 258);
            this.dgvIzvjestaj.TabIndex = 0;
            this.dgvIzvjestaj.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIzvjestaj_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDodajIzvjestaj);
            this.panel1.Location = new System.Drawing.Point(15, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 423);
            this.panel1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSviIzvjestaji);
            this.groupBox2.Controls.Add(this.dtpDatumPretraga);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(16, 347);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 68);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga izvještaja po datumu";
            // 
            // btnSviIzvjestaji
            // 
            this.btnSviIzvjestaji.Location = new System.Drawing.Point(575, 30);
            this.btnSviIzvjestaji.Name = "btnSviIzvjestaji";
            this.btnSviIzvjestaji.Size = new System.Drawing.Size(118, 23);
            this.btnSviIzvjestaji.TabIndex = 4;
            this.btnSviIzvjestaji.Text = "Poništi";
            this.btnSviIzvjestaji.UseVisualStyleBackColor = true;
            this.btnSviIzvjestaji.Click += new System.EventHandler(this.btnSviIzvjestaji_Click);
            // 
            // dtpDatumPretraga
            // 
            this.dtpDatumPretraga.Location = new System.Drawing.Point(377, 31);
            this.dtpDatumPretraga.Name = "dtpDatumPretraga";
            this.dtpDatumPretraga.Size = new System.Drawing.Size(189, 22);
            this.dtpDatumPretraga.TabIndex = 2;
            this.dtpDatumPretraga.ValueChanged += new System.EventHandler(this.dtpDatumPretraga_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odaberite datum da vidite izvještaje generisane tog dana";
            // 
            // frmPrikazIzvjestaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 451);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrikazIzvjestaja";
            this.Text = "frmPrikazIzvjestaja";
            this.Load += new System.EventHandler(this.frmPrikazIzvjestaja_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIzvjestaj)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajIzvjestaj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvIzvjestaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSviIzvjestaji;
        private System.Windows.Forms.DateTimePicker dtpDatumPretraga;
        private System.Windows.Forms.Label label2;
    }
}