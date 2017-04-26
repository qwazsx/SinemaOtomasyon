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
    public partial class Biletci : Form
    {
        public Biletci()
        {
            InitializeComponent();
        }

        private void Biletci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet11.Seans' table. You can move, or remove it, as needed.
            this.seansTableAdapter.Fill(this.sinemaOtomasyonDataSet11.Seans);
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet10.Salon' table. You can move, or remove it, as needed.
            this.salonTableAdapter.Fill(this.sinemaOtomasyonDataSet10.Salon);
            // TODO: This line of code loads data into the 'sinemaOtomasyonDataSet9.Film' table. You can move, or remove it, as needed.
            this.filmTableAdapter.Fill(this.sinemaOtomasyonDataSet9.Film);

            cmbFilmAd.SelectedIndex = -1;
            cmbSalonAd.SelectedIndex = -1;
            cmbSeans.SelectedIndex = -1;
            lblToplam.Visible = false;
            //lblFiyat.Visible = false;

        }

        private void btnBiletKes_Click(object sender, EventArgs e)
        {
            lblToplam.Visible = true;
           
            lblFiyat.Visible = true;
        }

        private void btn60_MouseClick(object sender, MouseEventArgs e)
        {
            btn60.BackColor = Color.Turquoise;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.Blue;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Blue;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn3.BackColor = Color.Blue;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn4.BackColor = Color.Blue;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn5.BackColor = Color.Blue;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn6.BackColor = Color.Blue;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn7.BackColor = Color.Blue;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btn8.BackColor = Color.Blue;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn9.BackColor = Color.Blue;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            btn10.BackColor = Color.Blue;
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            btn11.BackColor = Color.Blue;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            btn12.BackColor = Color.Blue;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            btn13.BackColor = Color.Blue;
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            btn14.BackColor = Color.Blue;
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            btn15.BackColor = Color.Blue;
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            btn16.BackColor = Color.Blue;
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            btn17.BackColor = Color.Blue;
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            btn18.BackColor = Color.Blue;
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            btn19.BackColor = Color.Blue;
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            btn20.BackColor = Color.Blue;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            btn21.BackColor = Color.Blue;
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            btn22.BackColor = Color.Blue;
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            btn23.BackColor = Color.Blue;
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            btn24.BackColor = Color.Blue;
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            btn25.BackColor = Color.Blue;
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            btn26.BackColor = Color.Blue;
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            btn27.BackColor = Color.Blue;
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            btn28.BackColor = Color.Blue;
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            btn29.BackColor = Color.Blue;
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            btn30.BackColor = Color.Blue;
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            btn31.BackColor = Color.Blue;
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            btn32.BackColor = Color.Blue;
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            btn33.BackColor = Color.Blue;
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            btn34.BackColor = Color.Blue;
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            btn35.BackColor = Color.Blue;
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            btn36.BackColor = Color.Blue;
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            btn37.BackColor = Color.Blue;
        }

        private void btn38_Click(object sender, EventArgs e)
        {
            btn38.BackColor = Color.Blue;
        }

        private void btn39_Click(object sender, EventArgs e)
        {
            btn39.BackColor = Color.Blue;
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            btn40.BackColor = Color.Blue;
        }

        private void btn41_Click(object sender, EventArgs e)
        {
            btn41.BackColor = Color.Blue;
        }

        private void btn42_Click(object sender, EventArgs e)
        {
            btn42.BackColor = Color.Blue;
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            btn43.BackColor = Color.Blue;
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            btn44.BackColor = Color.Blue;
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            btn45.BackColor = Color.Blue;
        }

        private void btn46_Click(object sender, EventArgs e)
        {
            btn46.BackColor = Color.Blue;
        }

        private void btn47_Click(object sender, EventArgs e)
        {
            btn47.BackColor = Color.Blue;
        }

        private void btn48_Click(object sender, EventArgs e)
        {
            btn48.BackColor = Color.Blue;
        }

        private void btn49_Click(object sender, EventArgs e)
        {
            btn49.BackColor = Color.Blue;
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            btn50.BackColor = Color.Blue;
        }

        private void btn51_Click(object sender, EventArgs e)
        {
            btn51.BackColor = Color.Blue;
        }

        private void btn52_Click(object sender, EventArgs e)
        {
            btn52.BackColor = Color.Blue;
        }

        private void btn53_Click(object sender, EventArgs e)
        {
            btn53.BackColor = Color.Blue;
        }

        private void btn54_Click(object sender, EventArgs e)
        {
            btn54.BackColor = Color.Blue;
        }

        private void btn55_Click(object sender, EventArgs e)
        {
            btn55.BackColor = Color.Blue;
        }

        private void btn56_Click(object sender, EventArgs e)
        {
            btn56.BackColor = Color.Blue;
        }

        private void btn57_Click(object sender, EventArgs e)
        {
            btn57.BackColor = Color.Blue;
        }

        private void btn58_Click(object sender, EventArgs e)
        {
            btn58.BackColor = Color.Blue;
        }

        private void btn59_Click(object sender, EventArgs e)
        {
            btn59.BackColor = Color.Blue;
        }

        private void btn60_Click(object sender, EventArgs e)
        {
            
            btn60.BackColor = Color.Blue;
        }


        

        

       

       

        
    }
}
