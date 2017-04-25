using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using ENTITY_LAYER;
using FacadeLayer;
using BusinessLogicLayer;

namespace SINEMA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            ekraniTemizle();
        }

        private void ekraniTemizle()
        {
            txtKullaniciAd.Clear();
            txtParola.Clear();
            cmbKullaniciTipi.SelectedIndex = -1;
        }
        
     

    }
}
