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
        APIService _klijentService = new APIService("Klijent");

        private Model.Narudzba _narudzba;
        private Model.Klijent _klijent;
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
                    _klijent = await _klijentService.GetById<Model.Klijent>(_narudzba.KlijentId);
                    txtImePrezime.Text = _klijent.Ime + " " + _klijent.Prezime;
                    txtKorisnickoIme.Text = _klijent.KorisnickoIme;
                    txtDatum.Text = _narudzba.Datum.ToString();
                    txtUkupniIznos.Text = _narudzba.UkupniIznos.ToString();
                    chbPlacena.Checked = _narudzba.IsPlacena.Value;
                    chbIsIsporucena.Checked = _narudzba.IsIsporucena.Value;
                    var request = new StavkeNarudzbeSearchObject()
                    {
                        NarudzbaId = _narudzba.NarudzbaId
                    };
                    dgvStavkeNarudzbe.DataSource = null;
                    dgvStavkeNarudzbe.DataSource = await _stavkeNarudzbeService.Get<IList<Model.StavkeNarudzbe>>(request);
                    dgvStavkeNarudzbe.Columns[0].Visible = false;
                    dgvStavkeNarudzbe.Columns[1].Visible = false;
                    dgvStavkeNarudzbe.Columns["Narudzba"].Visible = false;
                    dgvStavkeNarudzbe.Columns[4].Visible = false;
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
                if (_narudzba.IsPlacena == true)
                {
                    var request = new NarudzbaInsertRequest()
                    {
                        IsIsporucena = chbIsIsporucena.Checked,
                        Datum = _narudzba.Datum,
                        KlijentId = _narudzba.KlijentId,
                        //StavkeNarudzbes = _narudzba.StavkeNarudzbes,
                        UkupniIznos = _narudzba.UkupniIznos,
                        IsPlacena = _narudzba.IsPlacena
                    };
                    await _narudzbaService.Update<Model.Narudzba>(_narudzba.NarudzbaId, request);
                    //Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
