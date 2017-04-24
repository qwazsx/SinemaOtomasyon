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
            cmbSalonAd.SelectedIndex = -1;
            txtKapasite.Clear();
        }

        private void Salon_Load(object sender, EventArgs e)
        {
            ekraniTemizle();
        }
    }
}
