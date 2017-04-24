using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SINEMA
{
    public partial class Film_İşlemleri : Form
    {
        public Film_İşlemleri()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            ekraniTemizle();
        }

        private void ekraniTemizle()
        {
            txtFilmAd.Clear();
            txtYapimci.Clear();
            txtSure.Clear();
            cmbFilmAktif.SelectedIndex = -1;
            cmbFilmKategori.SelectedIndex = -1;
            dateYayinTarih.Text = DateTime.Now.ToString();
        }

        private void Film_İşlemleri_Load(object sender, EventArgs e)
        {
            ekraniTemizle();
        }
    }
}
