using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace TattooStudio.WinUI.Portfolio
{
    public partial class frmPrikazPortfolija : Form
    {
        APIService _portfolioService = new APIService("Portfolio");
        APIService _stavkePortfolijaService = new APIService("StavkePortfolium");
        private Model.Portfolio _portfolio;
        public frmPrikazPortfolija(Model.Portfolio portfolio = null)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _portfolio = portfolio;
        }

        private async void frmPrikazPortfolija_Load(object sender, EventArgs e)
        {
            try
            {
                if (_portfolio != null)
                {
                    txtOpis.Text = _portfolio.Opis;
                    var request = new StavkePortfoliumSearchObject()
                    {
                        PortfolioId = _portfolio.PortfolioId
                    };
                    dgvStavkePortfolija.DataSource = null;
                    dgvStavkePortfolija.DataSource = await _stavkePortfolijaService.Get<IList<Model.StavkePortfolium>>(request);
                    dgvStavkePortfolija.Columns[0].Visible = false;
                    dgvStavkePortfolija.Columns[1].Visible = false;
                    dgvStavkePortfolija.Columns[2].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSacuvajOpis_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new PortfolioInsertRequest()
                {
                    Opis = txtOpis.Text,
                    Uposlenikid = Global.prijavljeniUposlenik.UposlenikId
                };
                if (_portfolio != null)
                {
                    Global.portfolioPrijavljenogUposlenika = await _portfolioService.Update<Model.Portfolio>(_portfolio.PortfolioId, request);
                }
                else
                {
                    //request.Uposlenikid = Global.prijavljeniUposlenik.UposlenikId;
                    await _portfolioService.Insert<Model.Portfolio>(request);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDodajStavku_Click(object sender, EventArgs e)
        {
            frmStavkaDetalji frm = new frmStavkaDetalji();
            frm.Show();
            this.Close();
        }

        private void dgvStavkePortfolija_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvStavkePortfolija.SelectedRows[0].DataBoundItem;
            frmStavkaDetalji frm = new frmStavkaDetalji(item as Model.StavkePortfolium);
            frm.Show();
            this.Close();
        }
    }
}
