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
            ekraniTemizle();
        }
    }
}
