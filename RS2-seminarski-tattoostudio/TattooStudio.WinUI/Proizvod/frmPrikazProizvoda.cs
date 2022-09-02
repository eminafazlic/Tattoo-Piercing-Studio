using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TattooStudio.Model;
using TattooStudio.Model.SearchObjects;

namespace TattooStudio.WinUI.Proizvod
{
    public partial class frmPrikazProizvoda : Form
    {
        APIService _proizvodService = new APIService("Proizvod");
        APIService _tipProizvodaService = new APIService("TipProizvodum");
        public frmPrikazProizvoda()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            try
            {
                var search = new ProizvodSearchObject()
                {
                    Naziv = txtNaziv.Text,
                    Cijena = (string.IsNullOrEmpty(txtCijena.Text)) ? int.MaxValue : Decimal.Parse(txtCijena.Text),
                    TipProizvodaId = (int)cmbTipProizvoda.SelectedValue
                };
                var list = await _proizvodService.Get<IList<Model.Proizvod>>(search);
                dgvProizvodi.DataSource = null;
                dgvProizvodi.DataSource = list;
                dgvProizvodi.Columns[0].Visible = false;
                dgvProizvodi.Columns[3].Visible = false;
                dgvProizvodi.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProizvodi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvProizvodi.SelectedRows[0].DataBoundItem;
            frmProizvodDetalji frm = new frmProizvodDetalji(item as Model.Proizvod);
            frm.Show();
            this.Close();
        }

        private async Task LoadTipProizvoda()
        {
            try
            {
                var tipProizvoda = await _tipProizvodaService.Get<List<TipProizvodum>>();
                cmbTipProizvoda.DataSource = tipProizvoda;
                cmbTipProizvoda.ValueMember = "TipProizvodaId";
                cmbTipProizvoda.DisplayMember = "Naziv";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void frmPrikazProizvoda_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadTipProizvoda();
                dgvProizvodi.DataSource = null;
                dgvProizvodi.DataSource = await _proizvodService.Get<IList<Model.Proizvod>>(null);
                dgvProizvodi.Columns[0].Visible = false;
                dgvProizvodi.Columns[3].Visible = false;
                dgvProizvodi.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            frmProizvodDetalji frm = new frmProizvodDetalji();
            frm.Show();
            this.Close();
        }
    }
}
