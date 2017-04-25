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
    public partial class Salon : Form
    {
        public Salon()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            ekraniTemizle();
        }

        private void ekraniTemizle()
        {
            txtSalonAd.Clear();
            txtKapasite.Clear();
        }

        private void Salon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet4.Salon' table. You can move, or remove it, as needed.
            this.salonTableAdapter.Fill(this.sinemaOtomasyonDataSet4.Salon);
            ekraniTemizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtKapasite.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtSalonAd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ESALON item = new ESALON();

            item.SalonAd = txtSalonAd.Text;
            item.Kapasite = Convert.ToInt32(txtKapasite.Text);

            if (BLLADMIN.Salon_Insert(item) > 0)
            {

                MessageBox.Show("Salon eklendi.");
            }

            else
            {
                MessageBox.Show("Salon eklenemedi");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            ESALON item = new ESALON();
            item.SalonID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            item.Kapasite= Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            item.SalonAd = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            item.SalonAd = txtSalonAd.Text;
            item.Kapasite = Convert.ToInt32(txtKapasite.Text);

            if (BLLADMIN.Salon_Update(item))
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
            int SalonID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            if (BLLADMIN.Salon_Delete(SalonID))
            {
                MessageBox.Show("Silme yapıldı");
            }

            else
            {
                MessageBox.Show("Silme yapılamadı");
            }
        }
    }
}
