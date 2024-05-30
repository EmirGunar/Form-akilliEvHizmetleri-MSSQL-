using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akilliEvHizmetleri1
{
    public partial class frmKullaniciKayit : Form
    {
        AkilliEvHizmetleri akilliev_hizmetleri = new AkilliEvHizmetleri();
        public frmKullaniciKayit()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }



      


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // First INSERT statement for Araclar table
            string araclarQuery = "INSERT INTO Kullanici(kullanici_no, adi, soyadi, eposta) VALUES(@kullanici_no, @adi, @soyadi, @eposta)";
            SqlCommand kullanicilarKomut = new SqlCommand();
            kullanicilarKomut.Parameters.AddWithValue("@kullanici_no", int.Parse(txtKullaniciNo.Text));
            kullanicilarKomut.Parameters.AddWithValue("@adi", txtAd.Text);
            kullanicilarKomut.Parameters.AddWithValue("@soyadi", txtSoyad.Text);
            kullanicilarKomut.Parameters.AddWithValue("@eposta", txtEposta.Text);
           


            // Second INSERT statement for Arac_Sinifi table
            //string aracSinifiQuery = "INSERT INTO Arac_Sinifi(arac_kodu, adi, kiralama_bedeli) VALUES(@arac_kodu, @adi, @kiralama_bedeli)";
            //SqlCommand aracSinifiKomut = new SqlCommand();
            //aracSinifiKomut.Parameters.AddWithValue("@arac_kodu", Convert.ToInt32(txtAd.Text));
            //aracSinifiKomut.Parameters.AddWithValue("@adi", txtSoyad.Text);
            //aracSinifiKomut.Parameters.AddWithValue("@kiralama_bedeli", txtEposta.Text);


            // Check if txtAracKodu is not empty
            if (!string.IsNullOrEmpty(txtAd.Text))
            {

                //akilliev_hizmetleri.ekle_sil_güncelle(aracSinifiKomut, aracSinifiQuery);

                akilliev_hizmetleri.ekle_sil_güncelle(kullanicilarKomut, araclarQuery);


            }

            // Clear text boxes
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void AracKodutxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtKira_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAracAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAracKodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void Markatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Modeltxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Renktxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Plakatxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
