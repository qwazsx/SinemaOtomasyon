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
    public partial class Film_Kategori_İşlemleri : Form
    {
        public Film_Kategori_İşlemleri()
        {
            InitializeComponent();
        }

        private void btnYaniKayit_Click(object sender, EventArgs e)
        {
            ekraniTemizle();
        }

        private void ekraniTemizle()
        {
            txtKategoriAd.Clear();
            cmbGeneIIzleyici.SelectedIndex = -1;
        }

        private void Film_Kategori_İşlemleri_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet2.FilmKategori' table. You can move, or remove it, as needed.
            this.filmKategoriTableAdapter.Fill(this.sinemaOtomasyonDataSet2.FilmKategori);
            ekraniTemizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtKategoriAd.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "False")
            {
                cmbGeneIIzleyici.SelectedIndex = 1;
            }

            else
            {
                cmbGeneIIzleyici.SelectedIndex = 0;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EFILMKATEGORI item = new EFILMKATEGORI();

            item.KategoriAd = txtKategoriAd.Text;
           

            if (BLLADMIN.FilmKategori_Insert(item) > 0)
            {

                MessageBox.Show("Film kategori eklendi.");
                
            }

            else
            {
                MessageBox.Show("Film kategori eklenemedi");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EFILMKATEGORI item = new EFILMKATEGORI();

            item.KategoriID= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            item.KategoriAd = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            item.GenelIzleyici = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());

            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "False")
            {
                cmbGeneIIzleyici.SelectedIndex= 1;
            }

            else
            {
                cmbGeneIIzleyici.SelectedIndex = 0;
            }

            item.KategoriAd = txtKategoriAd.Text;
            item.GenelIzleyici = Convert.ToBoolean(cmbGeneIIzleyici.SelectedIndex);
           
            if (BLLADMIN.FilmKategori_Update(item))
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
            int filmKategoriID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

            if (BLLADMIN.FilmKategori_Delete(filmKategoriID))
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
