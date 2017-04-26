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
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet8.Seans' table. You can move, or remove it, as needed.
            this.seansTableAdapter1.Fill(this.sinemaOtomasyonDataSet8.Seans);
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet7.Salon' table. You can move, or remove it, as needed.
            this.salonTableAdapter.Fill(this.sinemaOtomasyonDataSet7.Salon);
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet6.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.sinemaOtomasyonDataSet6.Film);
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet5.Seans' table. You can move, or remove it, as needed.
            //this.seansTableAdapter.Fill(this.sinemaOtomasyonDataSet5.Seans);
            ekraniTemizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ESEANS itemSeans = new ESEANS();
            EFILM itemFilm = new EFILM();

            itemFilm = BLLADMIN.Film_Select(Convert.ToInt32(cmbFilmAd.SelectedValue));
            itemSeans.FilmAd = itemFilm.FilmAd;
            itemSeans.SalonAd = cmbSalon.SelectedItem.ToString();
            itemSeans.SeansNo = cmbSeans.SelectedItem.ToString();


            if (BLLADMIN.Seans_Insert(itemSeans) > 0)
            {
                MessageBox.Show("Seans eklendi");
            }

            else
            {
                MessageBox.Show("Seans eklenemedi");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int SeansID = 2;

            if (BLLADMIN.Seans_Delete(SeansID))
            {
                MessageBox.Show("sİLİNDİ" );
            }
            MessageBox.Show("sİLİNMEDİ");
        }
    }
}
