using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TattooStudio.Model.Requests;

namespace TattooStudio.WinUI.Obavijest
{
    public partial class frmPrikazObavijesti : Form
    {
        APIService _obavijestService = new APIService("Obavijest");
        int idPrijavljenogUposlenika = Global.prijavljeniUposlenik.UposlenikId;
        public frmPrikazObavijesti()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvObavijesti.SelectedRows[0].DataBoundItem;
            frmObavijestDetalji frm = new frmObavijestDetalji(item as Model.Obavijest);
            frm.ShowDialog();
            this.Close();
        }

        private void btnDodajObavijest_Click(object sender, EventArgs e)
        {
            frmObavijestDetalji frm = new frmObavijestDetalji();
            frm.ShowDialog();
            this.Close();
        }

        private async void frmSveObavijesti_Load(object sender, EventArgs e)
        {
            try
            {
                var request = new ObavijestInsertRequest()
                {
                    UposlenikId = idPrijavljenogUposlenika
                };
                dgvObavijesti.DataSource = null;
                dgvObavijesti.DataSource = await _obavijestService.Get<IList<Model.Obavijest>>(request);
                dgvObavijesti.Columns[0].Visible = false;
                dgvObavijesti.Columns[4].Visible = false;
                dgvObavijesti.Columns[5].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void chbSamoMojeObavijesti_CheckedChanged(object sender, EventArgs e)
        {
            if(chbSamoMojeObavijesti.Checked)
            {
                var request = new ObavijestInsertRequest()
                {
                    UposlenikId = idPrijavljenogUposlenika
                };
                dgvObavijesti.DataSource = null;
                dgvObavijesti.DataSource = await _obavijestService.Get<IList<Model.Obavijest>>(request);
                dgvObavijesti.Columns[0].Visible = false;
                dgvObavijesti.Columns[4].Visible = false;
                dgvObavijesti.Columns[5].Visible = false;
            }
            else
            {
                dgvObavijesti.DataSource = null;
                dgvObavijesti.DataSource = await _obavijestService.Get<IList<Model.Obavijest>>(null);
                dgvObavijesti.Columns[0].Visible = false;
                dgvObavijesti.Columns[4].Visible = false;
                dgvObavijesti.Columns[5].Visible = false;
            }
        }
    }
}
