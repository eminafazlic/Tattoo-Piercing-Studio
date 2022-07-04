using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TattooStudio.WinUI.Narudzba
{
    public partial class frmPrikazNarudzbi : Form
    {
        APIService _narudzbaService = new APIService("Narudzba");
        public frmPrikazNarudzbi()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private async void frmPrikazNarudzbi_Load(object sender, EventArgs e)
        {
            try
            {
                dgvNarudzbe.DataSource = null;
                dgvNarudzbe.DataSource = await _narudzbaService.Get<IList<Model.Narudzba>>();
                dgvNarudzbe.Columns[1].Visible = false;
                dgvNarudzbe.Columns[6].Visible = false;
                dgvNarudzbe.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvNarudzbe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvNarudzbe.SelectedRows[0].DataBoundItem;
            frmNarudzbaDetalji frm = new frmNarudzbaDetalji(item as Model.Narudzba);
            frm.Show();
        }
    }
}
