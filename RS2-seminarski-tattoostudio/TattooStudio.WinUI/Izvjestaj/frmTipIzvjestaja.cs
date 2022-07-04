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

namespace TattooStudio.WinUI.Izvjestaj
{
    public partial class frmTipIzvjestaja : Form
    {
        APIService _izvjestajService = new APIService("Izvjestaj");
        int prijavljeniUposlenikId = Global.prijavljeniUposlenik.UposlenikId;

        public frmTipIzvjestaja()
        {
            InitializeComponent();
        }

        private async void btnGenerisi_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new IzvjestajInsertRequest()
                {
                    UposlenikId = prijavljeniUposlenikId,
                    Mjesecni = rbMjesec.Checked,
                    Godisnji = rbGodina.Checked,
                    OdPocetka = rbSve.Checked,
                    zaJednogUposlenog = rbUposlenik.Checked,
                    zaSveUposlene = rbSviUposlenici.Checked
                };
                var izvjestaj = await _izvjestajService.Insert<Model.Izvjestaj>(request);
                frmIzvjestajDetalji frm = new frmIzvjestajDetalji(izvjestaj);
                frm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
