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
    public partial class FilmSeansSalon : Form
    {
        public FilmSeansSalon()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            ekraniTemizle();
        }

        private void ekraniTemizle()
        {
            cmbFilmAd.SelectedIndex = -1;
            cmbSalon.SelectedIndex = -1;
            cmbSeans.SelectedIndex = -1;
        }

        private void FilmSeansSalon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet7.Salon' table. You can move, or remove it, as needed.
            this.salonTableAdapter.Fill(this.sinemaOtomasyonDataSet7.Salon);
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet6.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.sinemaOtomasyonDataSet6.Film);
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet5.Seans' table. You can move, or remove it, as needed.
            this.seansTableAdapter.Fill(this.sinemaOtomasyonDataSet5.Seans);
            ekraniTemizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ESEANS itemSeans = new ESEANS();
            EFILM itemFilm = new EFILM();

            itemSeans.FilmID = Convert.ToInt32(cmbFilmAd.SelectedIndex);
            itemSeans.SalonID = Convert.ToInt32(cmbSalon.SelectedIndex);
            itemSeans.SeansNo = cmbSeans.SelectedIndex.ToString();

            //itemFilm = BLLADMIN.Film_Select(Convert.ToInt32(cmbFilmAd.SelectedIndex));
            //DateTime tarih = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            //tarih = itemFilm.YayinTarih;
            //bool active = Convert.ToBoolean(dataGridView1.SelectedRows[0].Cells[5].Value);
            //active = itemFilm.Active;

            if (BLLADMIN.Seans_Insert(itemSeans) > 0)
            {
                MessageBox.Show("Seans eklendi");
            }

            else
            {
                MessageBox.Show("Seans eklenemedi");
            }

        }
    }
}
