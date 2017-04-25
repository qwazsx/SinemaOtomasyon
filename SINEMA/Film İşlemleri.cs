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

        private void filmListele()
        {
            List<EFILM> filmList = BLLADMIN.Film_SelectList();
            dataGridView1.DataSource = filmList;
            
        }

        private void Film_İşlemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet1.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.sinemaOtomasyonDataSet1.Film);
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet.FilmKategori' table. You can move, or remove it, as needed.
            this.filmKategoriTableAdapter.Fill(this.sinemaOtomasyonDataSet.FilmKategori);
            ekraniTemizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtFilmAd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtYapimci.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtSure.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            cmbFilmKategori.SelectedIndex = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            dateYayinTarih.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            if (dataGridView1.SelectedRows[0].Cells[6].Value.ToString() == "False")
            {
                cmbFilmAktif.SelectedIndex = 1;
            }

            else
            {
                cmbFilmAktif.SelectedIndex = 0;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EFILM item = new EFILM();

            item.FilmAd = txtFilmAd.Text;
            item.Yapimci = txtYapimci.Text;
            item.Sure = Convert.ToInt32(txtSure.Text);
            item.KategoriID = cmbFilmKategori.SelectedIndex + 1;
            item.Active = Convert.ToBoolean(cmbFilmAktif.SelectedValue);
            item.YayinTarih = Convert.ToDateTime(dateYayinTarih.Text);

            if (BLLADMIN.Film_Insert(item) > 0)
            {
                
                MessageBox.Show("Film eklendi.");
                filmListele();
            }

            else
            {
                MessageBox.Show("Film eklenemedi");
            }


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EFILM item = new EFILM();

            item.FilmID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            item.FilmAd = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            item.Yapimci = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            item.Sure = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[5].Value);
            item.KategoriID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value);
            item.YayinTarih = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());

            if (dataGridView1.SelectedRows[0].Cells[6].Value.ToString() == "False")
            {
                cmbFilmAktif.SelectedIndex = 1;
            }

            else
            {
                cmbFilmAktif.SelectedIndex = 0;
            }

            item.FilmAd = txtFilmAd.Text;
            item.Yapimci = txtYapimci.Text;
            item.Sure = Convert.ToInt32(txtSure.Text);
            item.KategoriID = cmbFilmKategori.SelectedIndex + 1;
            item.YayinTarih = Convert.ToDateTime(dateYayinTarih.Text);
            item.Active = Convert.ToBoolean(cmbFilmAktif.SelectedIndex);

            if (BLLADMIN.Film_Update(item))
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
            int filmID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            if (BLLADMIN.Film_Delete(filmID))
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
