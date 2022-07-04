using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TattooStudio.Model.Requests;
using TattooStudio.Model.SearchObjects;

namespace TattooStudio.WinUI.Narudzba
{
    public partial class frmNarudzbaDetalji : Form
    {
        APIService _stavkeNarudzbeService = new APIService("StavkeNarudzbe");
        APIService _narudzbaService = new APIService("Narudzba");
        private Model.Narudzba _narudzba;
        public frmNarudzbaDetalji(Model.Narudzba narudzba = null)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _narudzba = narudzba;
        }

        private async void frmNarudzbaDetalji_Load(object sender, EventArgs e)
        {
            try
            {
                if (_narudzba != null)
                {
                    txtImePrezime.Text = _narudzba.Klijent.Ime + " " + _narudzba.Klijent.Prezime;
                    txtKorisnickoIme.Text = _narudzba.Klijent.KorisnickoIme;
                    txtDatum.Text = _narudzba.Datum.ToString();
                    txtUkupniIznos.Text = _narudzba.UkupniIznos.ToString();
                    chbIsIsporucena.Checked = _narudzba.IsIsporucena.Value;
                    var request = new StavkeNarudzbeSearchObject()
                    {
                        NarudzbaId = _narudzba.NarudzbaId
                    };
                    dgvStavkeNarudzbe.DataSource = null;
                    dgvStavkeNarudzbe.DataSource = await _stavkeNarudzbeService.Get<IList<Model.StavkeNarudzbe>>(request);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void chbIsIsporucena_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                var request = new NarudzbaInsertRequest()
                {
                    IsIsporucena = chbIsIsporucena.Checked,
                    Datum = _narudzba.Datum,
                    KlijentId = _narudzba.KlijentId,
                    StavkeNarudzbes = _narudzba.StavkeNarudzbes,
                    UkupniIznos = _narudzba.UkupniIznos
                };
                await _narudzbaService.Update<Model.Narudzba>(_narudzba.NarudzbaId, request);
                //Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
