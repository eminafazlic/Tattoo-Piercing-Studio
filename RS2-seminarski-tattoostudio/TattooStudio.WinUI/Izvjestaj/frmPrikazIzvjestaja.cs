using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace TattooStudio.WinUI.Izvjestaj
{
    public partial class frmPrikazIzvjestaja : Form
    {
        APIService _izvjestajService = new APIService("Izvjestaj");
        int prijavljeniUposlenikId = Global.prijavljeniUposlenik.UposlenikId;
        public frmPrikazIzvjestaja()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private async Task LoadIzvjestaji()
        {
            try
            {
                var request = new IzvjestajSearchObject()
                {
                    UposlenikId = Global.prijavljeniUposlenik.UposlenikId
                };
                dgvIzvjestaj.DataSource = null;
                dgvIzvjestaj.DataSource = await _izvjestajService.Get<IList<Model.Izvjestaj>>(request);
                dgvIzvjestaj.Columns[0].Visible = false;
                dgvIzvjestaj.Columns[1].Visible = false;
                dgvIzvjestaj.Columns[3].Width = 500;
                dgvIzvjestaj.Columns[4].Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void frmPrikazIzvjestaja_Load(object sender, EventArgs e)
        {
            await LoadIzvjestaji();
        }

        private void dgvIzvjestaj_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvIzvjestaj.SelectedRows[0].DataBoundItem;
            frmIzvjestajDetalji frm = new frmIzvjestajDetalji(item as Model.Izvjestaj);
            frm.Show();
        }

        private void btnDodajIzvjestaj_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new frmTipIzvjestaja();
                frm.Show();
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void dtpDatumPretraga_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var request = new IzvjestajSearchObject()
                {
                    Datum = dtpDatumPretraga.Value,
                    UposlenikId = Global.prijavljeniUposlenik.UposlenikId,
                };
                var result = await _izvjestajService.Get<IList<Model.Izvjestaj>>(request);
                dgvIzvjestaj.DataSource = null;
                dgvIzvjestaj.DataSource = result;
                dgvIzvjestaj.Columns[0].Visible = false;
                dgvIzvjestaj.Columns[1].Visible = false;
                dgvIzvjestaj.Columns[3].Width = 500;
                dgvIzvjestaj.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSviIzvjestaji_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new IzvjestajSearchObject()
                {
                    UposlenikId = Global.prijavljeniUposlenik.UposlenikId
                };
                var result = await _izvjestajService.Get<IList<Model.Izvjestaj>>(null);
                dgvIzvjestaj.Columns[0].Visible = false;
                dgvIzvjestaj.Columns[1].Visible = false;
                dgvIzvjestaj.Columns[3].Width = 500;
                dgvIzvjestaj.Columns[4].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
