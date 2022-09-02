
namespace TattooStudio.WinUI.Obavijest
{
    partial class frmPrikazObavijesti
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
            this.btnDodajObavijest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvObavijesti = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbSamoMojeObavijesti = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pregled obavijesti";
            // 
            // btnDodajObavijest
            // 
            this.btnDodajObavijest.Location = new System.Drawing.Point(472, 8);
            this.btnDodajObavijest.Name = "btnDodajObavijest";
            this.btnDodajObavijest.Size = new System.Drawing.Size(230, 36);
            this.btnDodajObavijest.TabIndex = 5;
            this.btnDodajObavijest.Text = "Dodaj novu obavijest";
            this.btnDodajObavijest.UseVisualStyleBackColor = true;
            this.btnDodajObavijest.Click += new System.EventHandler(this.btnDodajObavijest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvObavijesti);
            this.groupBox1.Location = new System.Drawing.Point(3, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 279);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obavijesti";
            // 
            // dgvObavijesti
            // 
            this.dgvObavijesti.AllowUserToAddRows = false;
            this.dgvObavijesti.AllowUserToDeleteRows = false;
            this.dgvObavijesti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijesti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObavijesti.Location = new System.Drawing.Point(3, 18);
            this.dgvObavijesti.Name = "dgvObavijesti";
            this.dgvObavijesti.ReadOnly = true;
            this.dgvObavijesti.RowHeadersWidth = 51;
            this.dgvObavijesti.RowTemplate.Height = 24;
            this.dgvObavijesti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObavijesti.Size = new System.Drawing.Size(693, 258);
            this.dgvObavijesti.TabIndex = 0;
            this.dgvObavijesti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.chbSamoMojeObavijesti);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnDodajObavijest);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 335);
            this.panel1.TabIndex = 1;
            // 
            // chbSamoMojeObavijesti
            // 
            this.chbSamoMojeObavijesti.AutoSize = true;
            this.chbSamoMojeObavijesti.Checked = true;
            this.chbSamoMojeObavijesti.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSamoMojeObavijesti.Location = new System.Drawing.Point(25, 23);
            this.chbSamoMojeObavijesti.Name = "chbSamoMojeObavijesti";
            this.chbSamoMojeObavijesti.Size = new System.Drawing.Size(207, 21);
            this.chbSamoMojeObavijesti.TabIndex = 7;
            this.chbSamoMojeObavijesti.Text = "Prikaži samo moje obavijesti";
            this.chbSamoMojeObavijesti.UseVisualStyleBackColor = true;
            this.chbSamoMojeObavijesti.CheckedChanged += new System.EventHandler(this.chbSamoMojeObavijesti_CheckedChanged);
            // 
            // frmPrikazObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 359);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrikazObavijesti";
            this.Text = "frmObavijesti";
            this.Load += new System.EventHandler(this.frmSveObavijesti_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijesti)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajObavijest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvObavijesti;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chbSamoMojeObavijesti;
    }
}