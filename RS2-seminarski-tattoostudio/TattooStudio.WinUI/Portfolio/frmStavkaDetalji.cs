using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using TattooStudio.Model.Requests;

namespace TattooStudio.WinUI.Portfolio
{
    public partial class frmStavkaDetalji : Form
    {
        APIService _stavkePortfoliumService = new APIService("StavkePortfolium");
        private Model.StavkePortfolium _stavkePortfolium;
        public frmStavkaDetalji(Model.StavkePortfolium stavkePortfolium = null)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            _stavkePortfolium = stavkePortfolium;
        }

        private void frmStavkaDetalji_Load(object sender, EventArgs e)
        {
            if (_stavkePortfolium != null)
            {
                dtpDatum.Value = (DateTime)_stavkePortfolium.Datum;
                txtOpis.Text = _stavkePortfolium.Opis;
                txtSlika.Text = LoginRegistracija.frmUposlenikDetalji.ConvertBytesToString((Byte[])_stavkePortfolium.Slika);
                pcbSlika.Image = Image.FromFile(txtSlika.Text);

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
                    txtSlika.Text = fileName;
                    var file = File.ReadAllBytes(fileName);
                    pcbSlika.Image = Image.FromFile(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (_stavkePortfolium != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Da li ste sigurni?", "Upozorenje", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        await _stavkePortfoliumService.Delete(_stavkePortfolium.StavkaPortfoliaId);
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                try
                {
                    var request = new StavkePortfoliumInsertRequest
                    {
                        Datum = dtpDatum.Value,
                        Opis = txtOpis.Text,
                        Slika = Encoding.ASCII.GetBytes(txtSlika.Text),
                        PortfolioId = Global.portfolioPrijavljenogUposlenika.PortfolioId
                    };
                    MemoryStream ms = new MemoryStream();
                    pcbSlika.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] buff = ms.GetBuffer();
                    request.Slika = buff;
                    byte[] slikaBytes = Encoding.ASCII.GetBytes(txtSlika.Text);
                    MemoryStream stream = new MemoryStream(slikaBytes);
                    request.Slika = stream.ToArray();
                    if (_stavkePortfolium == null)
                    {
                        await _stavkePortfoliumService.Insert<Model.StavkePortfolium>(request);
                    }
                    else
                    {
                        //request.PortfolioId = Global.portfolioPrijavljenogUposlenika.PortfolioId;
                        await _stavkePortfoliumService.Update<Model.StavkePortfolium>(_stavkePortfolium.StavkaPortfoliaId, request);
                    }
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
            return Validator.ObaveznoPolje(txtOpis, err, Validator.poruka) &&
                Validator.ObaveznoPolje(txtSlika, err, Validator.poruka);
        }
    }
}
