
namespace TattooStudio.WinUI.Portfolio
{
    partial class frmPrikazPortfolija
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStavkePortfolija = new System.Windows.Forms.DataGridView();
            this.btnDodajStavku = new System.Windows.Forms.Button();
            this.btnSacuvajOpis = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePortfolija)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 125);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vaš portfolio";
            // 
            // txtOpis
            // 
            this.txtOpis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOpis.Location = new System.Drawing.Point(3, 18);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(634, 104);
            this.txtOpis.TabIndex = 0;
            this.txtOpis.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStavkePortfolija);
            this.groupBox2.Location = new System.Drawing.Point(8, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(637, 259);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke portfolija";
            // 
            // dgvStavkePortfolija
            // 
            this.dgvStavkePortfolija.AllowUserToAddRows = false;
            this.dgvStavkePortfolija.AllowUserToDeleteRows = false;
            this.dgvStavkePortfolija.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkePortfolija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStavkePortfolija.Location = new System.Drawing.Point(3, 18);
            this.dgvStavkePortfolija.Name = "dgvStavkePortfolija";
            this.dgvStavkePortfolija.ReadOnly = true;
            this.dgvStavkePortfolija.RowHeadersWidth = 51;
            this.dgvStavkePortfolija.RowTemplate.Height = 24;
            this.dgvStavkePortfolija.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStavkePortfolija.Size = new System.Drawing.Size(631, 238);
            this.dgvStavkePortfolija.TabIndex = 0;
            this.dgvStavkePortfolija.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStavkePortfolija_CellContentClick);
            // 
            // btnDodajStavku
            // 
            this.btnDodajStavku.Location = new System.Drawing.Point(430, 163);
            this.btnDodajStavku.Name = "btnDodajStavku";
            this.btnDodajStavku.Size = new System.Drawing.Size(212, 23);
            this.btnDodajStavku.TabIndex = 3;
            this.btnDodajStavku.Text = "Dodaj novu stavku";
            this.btnDodajStavku.UseVisualStyleBackColor = true;
            this.btnDodajStavku.Click += new System.EventHandler(this.btnDodajStavku_Click);
            // 
            // btnSacuvajOpis
            // 
            this.btnSacuvajOpis.Location = new System.Drawing.Point(430, 134);
            this.btnSacuvajOpis.Name = "btnSacuvajOpis";
            this.btnSacuvajOpis.Size = new System.Drawing.Size(212, 23);
            this.btnSacuvajOpis.TabIndex = 4;
            this.btnSacuvajOpis.Text = "Sačuvaj promjene opisa";
            this.btnSacuvajOpis.UseVisualStyleBackColor = true;
            this.btnSacuvajOpis.Click += new System.EventHandler(this.btnSacuvajOpis_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSacuvajOpis);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnDodajStavku);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 460);
            this.panel1.TabIndex = 5;
            // 
            // frmPrikazPortfolija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 484);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrikazPortfolija";
            this.Text = "frmPrikazPortfolija";
            this.Load += new System.EventHandler(this.frmPrikazPortfolija_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkePortfolija)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDodajStavku;
        private System.Windows.Forms.Button btnSacuvajOpis;
        private System.Windows.Forms.DataGridView dgvStavkePortfolija;
        private System.Windows.Forms.Panel panel1;
    }
}