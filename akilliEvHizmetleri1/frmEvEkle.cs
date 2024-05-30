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
    public partial class frmEvEkle : Form
    {
        AkilliEvHizmetleri akilliev_hizmetleri = new AkilliEvHizmetleri();
        public frmEvEkle()
        {
            InitializeComponent();
        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into Akilli_Ev(ev_id,adres,ev_sahibi_no) values(@ev_id,@adres,@ev_sahibi_no)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ev_id", int.Parse(txtEvId.Text));
            komut2.Parameters.AddWithValue("@adres",txtAdres.Text );
            komut2.Parameters.AddWithValue("@ev_sahibi_no", int.Parse(txtEvSahibiNo.Text));

            akilliev_hizmetleri.ekle_sil_güncelle(komut2,cumle);
            foreach(Control item in Controls) if(item is TextBox) item.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
