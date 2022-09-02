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
    public partial class frmTerminDetalji : Form
    {
        APIService _terminService = new APIService("Termin");
        private Model.Termin _termin;
        public frmTerminDetalji(Model.Termin termin = null)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _termin = termin;
        }

        private void frmTerminDetalji_Load(object sender, EventArgs e)
        {
            if (_termin != null)
            {
                txtImePrezime.Text = _termin.Klijent.Ime + " " + _termin.Klijent.Prezime;
                txtKorisnickoIme.Text = _termin.Klijent.KorisnickoIme;
                txtOpisZahtjeva.Text = _termin.Opis;
                chbOdobren.Checked = (bool)_termin.IsOdobren;
                chbOtkazan.Checked = (bool)_termin.IsOtkazan;
                dtpDatum.Value = _termin.Datum.Value;
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            frmOtkaziTermin frm = new frmOtkaziTermin(_termin);
            frm.Show();
            this.Close();
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            frmOdobriTermin frm = new frmOdobriTermin(_termin);
            frm.Show();
            this.Close();
        }
    }
}
