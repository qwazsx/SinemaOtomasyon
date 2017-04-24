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
    public partial class Calisan : Form
    {
        public Calisan()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            ekraniTemizle();
        }

        private void ekraniTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtKullaniciAd.Clear();
            txtParola.Clear();
            txtTC.Clear();
            cmbCalisanKategori.SelectedIndex = -1;
            dateDogumTarih.Text = DateTime.Now.ToString();
            dateIseGiris.Text = DateTime.Now.ToString();
        }

        private void Calisan_Load(object sender, EventArgs e)
        {
            ekraniTemizle();
        }
    }
}
