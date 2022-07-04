using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TattooStudio.Model.SearchObjects;

namespace TattooStudio.WinUI.Termin
{
    public partial class frmPrikazTermina : Form
    {
        APIService _terminService = new APIService("Termin");
        public frmPrikazTermina()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void LoadCmbTerminFilter()
        {
            var list = new List<string>();
            list.Insert(0, "Svi termini");
            list.Insert(1, "Nadolazeći termini");
            list.Insert(2, "Zahtjevi (neodobreni termini)");
            cmbTerminFilter.DataSource = list;
        }
        private async void cmbTerminFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbTerminFilter.SelectedIndex;
            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadTermini(id);
            }
        }

        private async Task LoadTermini(int vrstaTermina = 0)
        {
            try
            {
                var request = new TerminSearchObject()
                {
                    UposlenikId = Global.prijavljeniUposlenik.UposlenikId
                };
                IList<Model.Termin> result = null;
                if (vrstaTermina == 1)
                {
                    request.NadolazeciTermini = true;
                }
                else if (vrstaTermina == 2)
                {
                    request.IsOdobren = false;
                }
                result = await _terminService.Get<IList<Model.Termin>>(request);
                dgvTermini.DataSource = null;
                dgvTermini.DataSource = result;
                dgvTermini.Columns[0].Visible = false;
                dgvTermini.Columns[1].Visible = false;
                dgvTermini.Columns[2].Visible = false;
                dgvTermini.Columns[5].Visible = false;
                dgvTermini.Columns[6].Visible = false;
                dgvTermini.Columns[8].Visible = false;
                dgvTermini.Columns[10].Visible = false;
                dgvTermini.Columns[13].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void frmPrikazTermina_Load(object sender, EventArgs e)
        {
            LoadCmbTerminFilter();
            await LoadTermini();
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                var request = new TerminSearchObject()
                {
                    Datum = dtpDatumPretraga.Value,
                    UposlenikId = Global.prijavljeniUposlenik.UposlenikId
                };
                var result = await _terminService.Get<IList<Model.Termin>>(request);
                dgvTermini.DataSource = null;
                dgvTermini.DataSource = result;
                dgvTermini.Columns[0].Visible = false;
                dgvTermini.Columns[1].Visible = false;
                dgvTermini.Columns[2].Visible = false;
                dgvTermini.Columns[5].Visible = false;
                dgvTermini.Columns[6].Visible = false;
                dgvTermini.Columns[8].Visible = false;
                dgvTermini.Columns[10].Visible = false;
                dgvTermini.Columns[13].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSviTermini_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new TerminSearchObject()
                {
                    UposlenikId = Global.prijavljeniUposlenik.UposlenikId
                };
                var result = await _terminService.Get<IList<Model.Termin>>(request);
                dgvTermini.DataSource = null;
                dgvTermini.DataSource = result;
                dgvTermini.Columns[0].Visible = false;
                dgvTermini.Columns[1].Visible = false;
                dgvTermini.Columns[2].Visible = false;
                dgvTermini.Columns[5].Visible = false;
                dgvTermini.Columns[6].Visible = false;
                dgvTermini.Columns[8].Visible = false;
                dgvTermini.Columns[10].Visible = false;
                dgvTermini.Columns[13].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTermini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvTermini.SelectedRows[0].DataBoundItem;
            frmTerminDetalji frm = new frmTerminDetalji(item as Model.Termin);
            frm.Show();
        }
    }
}
