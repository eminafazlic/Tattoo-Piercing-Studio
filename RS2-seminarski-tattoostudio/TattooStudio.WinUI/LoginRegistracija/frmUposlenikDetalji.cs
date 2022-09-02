using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TattooStudio.Model;
using TattooStudio.Model.Requests;

namespace TattooStudio.WinUI.LoginRegistracija
{
    public partial class frmUposlenikDetalji : Form
    {
        APIService _uposlenikService = new APIService("Uposlenik");
        APIService _spolService = new APIService("Spol");
        APIService _zanimanjeService = new APIService("Zanimanje");
        private Model.Uposlenik _uposlenik;
        public frmUposlenikDetalji(Model.Uposlenik uposlenik)
        {
            InitializeComponent();
            _uposlenik = uposlenik;
            WindowState = FormWindowState.Maximized;
        }

        private async Task LoadSpol()
        {
            try
            {
                var spolovi = await _spolService.Get<List<Spol>>();
                cmbSpol.DataSource = spolovi;
                cmbSpol.DisplayMember = "Naziv";
                cmbSpol.ValueMember = "SpolId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task LoadZanimanje()
        {
            try
            {
                var zanimanja = await _zanimanjeService.Get<List<Zanimanje>>();
                cmbZanimanje.DataSource = zanimanja;
                cmbZanimanje.DisplayMember = "Naziv";
                cmbZanimanje.ValueMember = "ZanimanjeId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void frmUposlenikDetalji_Load(object sender, EventArgs e)
        {
            await LoadSpol();
            await LoadZanimanje();
            if (_uposlenik != null)
            {
                txtIme.Text = _uposlenik.Ime;
                txtPrezime.Text = _uposlenik.Prezime;
                txtKorisnickoIme.Text = _uposlenik.KorisnickoIme;
                txtEmail.Text = _uposlenik.Email;
                txtTelefon.Text = _uposlenik.Telefon;
                txtPutanjaDoSlike.Text = ConvertBytesToString((Byte[])_uposlenik.Slika);
                cmbSpol.SelectedValue = _uposlenik.SpolId;
                cmbZanimanje.SelectedValue = _uposlenik.ZanimanjeId;
                if (File.Exists(txtPutanjaDoSlike.Text))
                {
                    pcbSlika.Image = Image.FromFile(txtPutanjaDoSlike.Text);
                }
            }
        }

        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                try
                {
                    var request = new UposlenikInsertRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        KorisnickoIme = txtKorisnickoIme.Text,
                        Lozinka = txtLozinka.Text,
                        PotvrdiLozinku = txtPotvrdaLozinke.Text,
                        Email = txtEmail.Text,
                        Telefon = txtTelefon.Text,
                        SpolId = (int)cmbSpol.SelectedValue,
                        ZanimanjeId = (int)cmbZanimanje.SelectedValue
                    };
                    MemoryStream ms = new MemoryStream();
                    pcbSlika.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] buff = ms.GetBuffer();
                    request.Slika = buff;
                    byte[] slikaBytes = Encoding.ASCII.GetBytes(txtPutanjaDoSlike.Text);
                    MemoryStream stream = new MemoryStream(slikaBytes);
                    request.Slika = stream.ToArray();
                    Global.prijavljeniUposlenik = await _uposlenikService.Update<Model.Uposlenik>(_uposlenik.UposlenikId, request);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            if (_uposlenik != null)
            {
                DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?", "Upozorenje", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        await _uposlenikService.Delete(_uposlenik.UposlenikId);
                        Application.Exit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            try
            {
                var result = ofdSlika.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var fileName = ofdSlika.FileName;
                    txtPutanjaDoSlike.Text = fileName;
                    var file = File.ReadAllBytes(fileName);
                    //request.Slika = File.ReadAllBytes(filename);
                    pcbSlika.Image = Image.FromFile(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string ConvertBytesToString(byte[] bytes)
        {
            string output = String.Empty;
            MemoryStream stream = new MemoryStream(bytes);
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);
            output = reader.ReadToEnd();
            return output;
        }

        private bool ValidirajUnos()
        {
            return Validator.ObaveznoPolje(txtIme, err, Validator.poruka) &&
                Validator.MinDuzina(txtIme, err, 3, Validator.minDuzina) &&
                Validator.MaxDuzina(txtIme, err, 20, Validator.minDuzina) &&
                //Validator.SamoSlova(txtIme, err, Validator.samoSlova) &&
                Validator.ObaveznoPolje(txtPrezime, err, Validator.poruka) &&
                Validator.MinDuzina(txtPrezime, err, 3, Validator.minDuzina) &&
                Validator.MaxDuzina(txtPrezime, err, 30, Validator.minDuzina) &&
                //Validator.SamoSlova(txtPrezime, err, Validator.samoSlova) &&
                Validator.ObaveznoPolje(txtKorisnickoIme, err, Validator.poruka) &&
                Validator.ObaveznoPolje(txtLozinka, err, Validator.poruka) &&
                Validator.ObaveznoPolje(txtPotvrdaLozinke, err, Validator.poruka) &&
                Validator.LozinkePolje(txtLozinka, txtPotvrdaLozinke, err, Validator.lozinke) &&
                Validator.EmailPolje(txtEmail, err, Validator.email) &&
                Validator.TelefonPolje(txtTelefon, err, Validator.telefon) &&
                Validator.ObaveznoPolje(txtPutanjaDoSlike, err, Validator.poruka);
        }
    }
}
