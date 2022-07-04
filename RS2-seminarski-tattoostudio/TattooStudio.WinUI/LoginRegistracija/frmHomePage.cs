using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TattooStudio.WinUI.LoginRegistracija
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistracija frm = new frmRegistracija();
            Hide();
            frm.ShowDialog();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            frmPrijava frm = new frmPrijava();
            Hide();
            frm.ShowDialog();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
