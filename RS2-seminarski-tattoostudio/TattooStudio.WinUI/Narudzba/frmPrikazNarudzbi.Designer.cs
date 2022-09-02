
namespace TattooStudio.WinUI.Narudzba
{
    partial class frmPrikazNarudzbi
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
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbIsIsporucena = new System.Windows.Forms.CheckBox();
            this.chbIsPlacena = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNarudzbe);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sve narudžbe";
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.AllowUserToDeleteRows = false;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNarudzbe.Location = new System.Drawing.Point(3, 18);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.RowHeadersWidth = 51;
            this.dgvNarudzbe.RowTemplate.Height = 24;
            this.dgvNarudzbe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbe.Size = new System.Drawing.Size(770, 359);
            this.dgvNarudzbe.TabIndex = 0;
            this.dgvNarudzbe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNarudzbe_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.chbIsPlacena);
            this.panel1.Controls.Add(this.chbIsIsporucena);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 442);
            this.panel1.TabIndex = 1;
            // 
            // chbIsIsporucena
            // 
            this.chbIsIsporucena.AutoSize = true;
            this.chbIsIsporucena.Location = new System.Drawing.Point(22, 389);
            this.chbIsIsporucena.Name = "chbIsIsporucena";
            this.chbIsIsporucena.Size = new System.Drawing.Size(248, 21);
            this.chbIsIsporucena.TabIndex = 1;
            this.chbIsIsporucena.Text = "Prikaži samo isporučene narudžbe";
            this.chbIsIsporucena.UseVisualStyleBackColor = true;
            this.chbIsIsporucena.CheckedChanged += new System.EventHandler(this.chbIsIsporucena_CheckedChanged);
            // 
            // chbIsPlacena
            // 
            this.chbIsPlacena.AutoSize = true;
            this.chbIsPlacena.Location = new System.Drawing.Point(22, 416);
            this.chbIsPlacena.Name = "chbIsPlacena";
            this.chbIsPlacena.Size = new System.Drawing.Size(228, 21);
            this.chbIsPlacena.TabIndex = 2;
            this.chbIsPlacena.Text = "Prikaži samo plaćene narudžbe";
            this.chbIsPlacena.UseVisualStyleBackColor = true;
            this.chbIsPlacena.CheckedChanged += new System.EventHandler(this.chbIsPlacena_CheckedChanged);
            // 
            // frmPrikazNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 468);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrikazNarudzbi";
            this.Text = "frmPrikazNarudzbi";
            this.Load += new System.EventHandler(this.frmPrikazNarudzbi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbIsIsporucena;
        private System.Windows.Forms.CheckBox chbIsPlacena;
    }
}