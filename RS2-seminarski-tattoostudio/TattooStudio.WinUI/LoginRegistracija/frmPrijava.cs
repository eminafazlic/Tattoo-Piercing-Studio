using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TattooStudio.Model;
using TattooStudio.Model.Requests;
using TattooStudio.Model.Responses;
using TattooStudio.Model.SearchObjects;

namespace TattooStudio.WinUI.LoginRegistracija
{
    public partial class frmPrijava : Form
    {
        APIService _uposlenikService = new APIService("Uposlenik");
        APIService _portfolioService = new APIService("Portfolio");
        public frmPrijava()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private async void btnPrijava_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                try
                {
                    var userLoginModel = new UserLoginModel()
                    {
                        Username = txtKorisnickoIme.Text,
                        Password = txtLozinka.Text
                    };
                    var data = await _uposlenikService.Login<UserAuthenticationResult>(userLoginModel, "login");
                    if (data == null)
                    {
                        MessageBox.Show("Pogrešno korisničko ime ili lozinka", "Information", MessageBoxButtons.OK);
                        txtKorisnickoIme.Text = txtLozinka.Text = "";
                        return;
                    }
                    if (data != null)
                    {
                        APIService.Token = data.Token;
                        await _uposlenikService.Get<dynamic>(null);
                        var uposlenik = new UposlenikSearchObject()
                        {
                            KorisnickoIme = txtKorisnickoIme.Text
                        };
                        var pretragaUposlenika = await _uposlenikService.Get<IList<Uposlenik>>(uposlenik);
                        Global.prijavljeniUposlenik = pretragaUposlenika.FirstOrDefault();
                        var portfolio = new PortfolioSearchObject()
                        {
                            UposlenikId = Global.prijavljeniUposlenik.UposlenikId
                        };
                        var pretragaPortfolija = await _portfolioService.Get<IList<Model.Portfolio>>(portfolio);
                        Global.portfolioPrijavljenogUposlenika = pretragaPortfolija.FirstOrDefault();
                        var frm = new frmPocetna();
                        frm.Show();
                        Hide();
                    }
                }
                catch (Exception ex)
                {
                    txtKorisnickoIme.Text = txtLozinka.Text = "";
                    MessageBox.Show(ex.Message, "Autentikacija", MessageBoxButtons.OK);
                }
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(txtKorisnickoIme, err, Validator.poruka) &&
                Validator.ObaveznoPolje(txtLozinka, err, Validator.poruka);
        }
    }
}
