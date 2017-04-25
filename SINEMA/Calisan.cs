using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY_LAYER;
using FacadeLayer;
using BusinessLogicLayer;

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
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet3.Calisan' table. You can move, or remove it, as needed.
            this.calisanTableAdapter.Fill(this.sinemaOtomasyonDataSet3.Calisan);
            ekraniTemizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtAd.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtKullaniciAd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtParola.Text= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtTC.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            
            dateDogumTarih.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            dateIseGiris.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value.ToString())== 2)
            {
                cmbCalisanKategori.SelectedIndex = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value.ToString()) - 2;
            }

            else
            {
                cmbCalisanKategori.SelectedIndex = 1;
                cmbCalisanKategori.SelectedIndex = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ECALISAN item = new ECALISAN();

            item.Ad = txtAd.Text;
            item.DogumTarih = Convert.ToDateTime(dateDogumTarih.Text);
            item.IseGiris = Convert.ToDateTime(dateIseGiris.Text);
            item.KullaniciAd = txtKullaniciAd.Text;
            item.Parola = txtParola.Text;
            item.Soyad = txtSoyad.Text;
            item.TCNO = txtTC.Text;
            item.CalisanKategoriID = cmbCalisanKategori.SelectedIndex;
           

            if (BLLADMIN.Calisan_Insert(item) > 0)
            {

                MessageBox.Show("Çalışan eklendi.");
                
            }

            else
            {
                MessageBox.Show("Çalışan eklenemedi");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ECALISAN item = new ECALISAN();

            item.CalisanID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            item.Ad = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            item.KullaniciAd = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            item.Parola = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            item.Soyad = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            item.TCNO = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            item.IseGiris = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            item.DogumTarih = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());

            if (Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value.ToString()) == 2)
            {
                cmbCalisanKategori.SelectedIndex = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value.ToString()) - 2;
            }

            else
            {
                cmbCalisanKategori.SelectedIndex = 1;
                cmbCalisanKategori.SelectedIndex = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
            }
            item.CalisanKategoriID = cmbCalisanKategori.SelectedIndex;

            item.Ad = txtAd.Text;
            item.KullaniciAd = txtKullaniciAd.Text;
            item.Parola = txtParola.Text;
            item.Soyad = txtSoyad.Text;
            item.TCNO = txtTC.Text;
            item.IseGiris = Convert.ToDateTime(dateIseGiris.Text);
            item.DogumTarih = Convert.ToDateTime(dateDogumTarih.Text);
            if (cmbCalisanKategori.SelectedIndex == 1)
            {
                item.CalisanKategoriID = 1;
            }
            else
            {
                item.CalisanKategoriID = 2;
            }

            if (BLLADMIN.Calisan_Update(item))
            {
                MessageBox.Show("Güncelleme yapıldı");
            }
            else
            {
                MessageBox.Show("Güncelleme başarısız");
            }  
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int calisanID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            if (BLLADMIN.Calisan_Delete(calisanID))
            {
                MessageBox.Show("Silme başarılı");
            }
            else
            {
                MessageBox.Show("Silme başarısız");
            }
        }

       
    }
}
