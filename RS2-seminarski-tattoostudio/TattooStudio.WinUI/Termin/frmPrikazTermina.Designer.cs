
namespace TattooStudio.WinUI.Termin
{
    partial class frmPrikazTermina
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
            this.dgvTermini = new System.Windows.Forms.DataGridView();
            this.cmbTerminFilter = new System.Windows.Forms.ComboBox();
            this.dtpDatumPretraga = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSviTermini = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTermini);
            this.groupBox1.Controls.Add(this.cmbTerminFilter);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vaši termini";
            // 
            // dgvTermini
            // 
            this.dgvTermini.AllowUserToAddRows = false;
            this.dgvTermini.AllowUserToDeleteRows = false;
            this.dgvTermini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermini.Location = new System.Drawing.Point(6, 51);
            this.dgvTermini.Name = "dgvTermini";
            this.dgvTermini.ReadOnly = true;
            this.dgvTermini.RowHeadersWidth = 51;
            this.dgvTermini.RowTemplate.Height = 24;
            this.dgvTermini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTermini.Size = new System.Drawing.Size(538, 369);
            this.dgvTermini.TabIndex = 1;
            this.dgvTermini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTermini_CellContentClick);
            // 
            // cmbTerminFilter
            // 
            this.cmbTerminFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerminFilter.FormattingEnabled = true;
            this.cmbTerminFilter.Location = new System.Drawing.Point(6, 21);
            this.cmbTerminFilter.Name = "cmbTerminFilter";
            this.cmbTerminFilter.Size = new System.Drawing.Size(532, 24);
            this.cmbTerminFilter.TabIndex = 0;
            this.cmbTerminFilter.SelectedIndexChanged += new System.EventHandler(this.cmbTerminFilter_SelectedIndexChanged);
            // 
            // dtpDatumPretraga
            // 
            this.dtpDatumPretraga.Location = new System.Drawing.Point(200, 31);
            this.dtpDatumPretraga.Name = "dtpDatumPretraga";
            this.dtpDatumPretraga.Size = new System.Drawing.Size(225, 22);
            this.dtpDatumPretraga.TabIndex = 2;
            this.dtpDatumPretraga.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberite datum za pretragu";
            // 
            // btnSviTermini
            // 
            this.btnSviTermini.Location = new System.Drawing.Point(431, 30);
            this.btnSviTermini.Name = "btnSviTermini";
            this.btnSviTermini.Size = new System.Drawing.Size(113, 23);
            this.btnSviTermini.TabIndex = 4;
            this.btnSviTermini.Text = "Poništi";
            this.btnSviTermini.UseVisualStyleBackColor = true;
            this.btnSviTermini.Click += new System.EventHandler(this.btnSviTermini_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSviTermini);
            this.groupBox2.Controls.Add(this.dtpDatumPretraga);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 68);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga termina po datumu";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 517);
            this.panel1.TabIndex = 6;
            // 
            // frmPrikazTermina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 541);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrikazTermina";
            this.Text = "frmPrikazTermina";
            this.Load += new System.EventHandler(this.frmPrikazTermina_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermini)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTermini;
        private System.Windows.Forms.ComboBox cmbTerminFilter;
        private System.Windows.Forms.DateTimePicker dtpDatumPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSviTermini;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
    }
}