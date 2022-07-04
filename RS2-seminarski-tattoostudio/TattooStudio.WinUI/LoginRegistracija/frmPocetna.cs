using System;
using System.Windows.Forms;
using TattooStudio.WinUI.Izvjestaj;
using TattooStudio.WinUI.Klijent;
using TattooStudio.WinUI.LoginRegistracija;
using TattooStudio.WinUI.Narudzba;
using TattooStudio.WinUI.Obavijest;
using TattooStudio.WinUI.Portfolio;
using TattooStudio.WinUI.Proizvod;
using TattooStudio.WinUI.Termin;

namespace TattooStudio.WinUI
{
    public partial class frmPocetna : Form
    {
        private int childFormNumber = 0;

        public frmPocetna()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }





        private void klijentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazKlijenata frm = new frmPrikazKlijenata();
            frm.MdiParent = this;
            frm.Show();
        }

        private void uposlenikProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUposlenikDetalji frm = new frmUposlenikDetalji(Global.prijavljeniUposlenik);
            frm.MdiParent = this;
            frm.Show();
        }

        private void izvještajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazIzvjestaja frm = new frmPrikazIzvjestaja();
            frm.MdiParent = this;
            frm.Show();
        }

        private void narudžbeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazNarudzbi frm = new frmPrikazNarudzbi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void obavijestiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazObavijesti frm = new frmPrikazObavijesti();
            frm.MdiParent = this;
            frm.Show();
        }

        private void portfolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazPortfolija frm = new frmPrikazPortfolija(Global.portfolioPrijavljenogUposlenika);
            frm.MdiParent = this;
            frm.Show();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazProizvoda frm = new frmPrikazProizvoda();
            frm.MdiParent = this;
            frm.Show();
        }

        private void terminiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrikazTermina frm = new frmPrikazTermina();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
