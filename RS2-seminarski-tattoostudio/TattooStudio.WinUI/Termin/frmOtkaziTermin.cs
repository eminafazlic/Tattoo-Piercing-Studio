using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TattooStudio.Model.Requests;

namespace TattooStudio.WinUI.Termin
{
    public partial class frmOtkaziTermin : Form
    {
        APIService _terminService = new APIService("Termin");
        private Model.Termin _termin;
        public frmOtkaziTermin(Model.Termin termin = null)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _termin = termin;
        }

        private void frmOtkaziTermin_Load(object sender, EventArgs e)
        {
            if (_termin != null)
            {
                txtImePrezime.Text = _termin.Klijent.Ime + " " + _termin.Klijent.Prezime;
                txtKorisnickoIme.Text = _termin.Klijent.KorisnickoIme;
                dtpDatum.Value = _termin.Datum.Value;
                txtOpisZahtjeva.Text = _termin.Opis;
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if(ValidirajUnos())
            {
                try
                {
                    var request = new TerminUpdateRequest()
                    {
                        Komentar = txtKomentar.Text,
                        IsOtkazan = true,
                        IsOdobren = false,
                        IsPlacen = false
                    };
                    await _terminService.Update<Model.Termin>(_termin.TerminId, request);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(txtKomentar, err, Validator.poruka);
        }
    }
}
