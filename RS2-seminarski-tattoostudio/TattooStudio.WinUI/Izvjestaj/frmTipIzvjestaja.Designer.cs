
namespace TattooStudio.WinUI.Izvjestaj
{
    partial class frmTipIzvjestaja
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMjesec = new System.Windows.Forms.RadioButton();
            this.rbGodina = new System.Windows.Forms.RadioButton();
            this.rbSve = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSviUposlenici = new System.Windows.Forms.RadioButton();
            this.rbUposlenik = new System.Windows.Forms.RadioButton();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnGenerisi);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 149);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSve);
            this.groupBox1.Controls.Add(this.rbGodina);
            this.groupBox1.Controls.Add(this.rbMjesec);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izvještaj...";
            // 
            // rbMjesec
            // 
            this.rbMjesec.AutoSize = true;
            this.rbMjesec.Location = new System.Drawing.Point(6, 21);
            this.rbMjesec.Name = "rbMjesec";
            this.rbMjesec.Size = new System.Drawing.Size(122, 21);
            this.rbMjesec.TabIndex = 0;
            this.rbMjesec.TabStop = true;
            this.rbMjesec.Text = "za ovaj mjesec";
            this.rbMjesec.UseVisualStyleBackColor = true;
            // 
            // rbGodina
            // 
            this.rbGodina.AutoSize = true;
            this.rbGodina.Location = new System.Drawing.Point(6, 46);
            this.rbGodina.Name = "rbGodina";
            this.rbGodina.Size = new System.Drawing.Size(118, 21);
            this.rbGodina.TabIndex = 1;
            this.rbGodina.TabStop = true;
            this.rbGodina.Text = "za ovu godinu";
            this.rbGodina.UseVisualStyleBackColor = true;
            // 
            // rbSve
            // 
            this.rbSve.AutoSize = true;
            this.rbSve.Location = new System.Drawing.Point(6, 73);
            this.rbSve.Name = "rbSve";
            this.rbSve.Size = new System.Drawing.Size(132, 21);
            this.rbSve.TabIndex = 2;
            this.rbSve.TabStop = true;
            this.rbSve.Text = "od početka rada";
            this.rbSve.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSviUposlenici);
            this.groupBox2.Controls.Add(this.rbUposlenik);
            this.groupBox2.Location = new System.Drawing.Point(165, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 111);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Izvještaj...";
            // 
            // rbSviUposlenici
            // 
            this.rbSviUposlenici.AutoSize = true;
            this.rbSviUposlenici.Location = new System.Drawing.Point(6, 46);
            this.rbSviUposlenici.Name = "rbSviUposlenici";
            this.rbSviUposlenici.Size = new System.Drawing.Size(142, 21);
            this.rbSviUposlenici.TabIndex = 1;
            this.rbSviUposlenici.TabStop = true;
            this.rbSviUposlenici.Text = "za sve uposlenike";
            this.rbSviUposlenici.UseVisualStyleBackColor = true;
            // 
            // rbUposlenik
            // 
            this.rbUposlenik.AutoSize = true;
            this.rbUposlenik.Location = new System.Drawing.Point(6, 21);
            this.rbUposlenik.Name = "rbUposlenik";
            this.rbUposlenik.Size = new System.Drawing.Size(110, 21);
            this.rbUposlenik.TabIndex = 0;
            this.rbUposlenik.TabStop = true;
            this.rbUposlenik.Text = "samo za Vas";
            this.rbUposlenik.UseVisualStyleBackColor = true;
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(3, 118);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(318, 28);
            this.btnGenerisi.TabIndex = 4;
            this.btnGenerisi.Text = "Generiši izvještaj";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // frmTipIzvjestaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 178);
            this.Controls.Add(this.panel1);
            this.Name = "frmTipIzvjestaja";
            this.Text = "frmTipIzvjestaja";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSviUposlenici;
        private System.Windows.Forms.RadioButton rbUposlenik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSve;
        private System.Windows.Forms.RadioButton rbGodina;
        private System.Windows.Forms.RadioButton rbMjesec;
    }
}