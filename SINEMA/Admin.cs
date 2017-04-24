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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Film_İşlemleri frmFilm = new Film_İşlemleri();
            frmFilm.ShowDialog();
            
        }

        private void çalışanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calisan frmCalisan = new Calisan();
            frmCalisan.ShowDialog();
        }

        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salon frmSalon = new Salon();
            frmSalon.ShowDialog();
        }

        private void filmSeansSalonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilmSeansSalon frmSeans = new FilmSeansSalon();
            frmSeans.ShowDialog();
        }

        private void filmKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Film_Kategori_İşlemleri frmFilmKategori = new Film_Kategori_İşlemleri();
            frmFilmKategori.ShowDialog();
        }
    }
}
