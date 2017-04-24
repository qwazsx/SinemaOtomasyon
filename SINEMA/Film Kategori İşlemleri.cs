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
            ekraniTemizle();
        }

    }
}
