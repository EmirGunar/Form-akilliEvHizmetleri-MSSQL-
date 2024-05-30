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
    public partial class frmAkilliEvListele : Form
    {
        AkilliEvHizmetleri akilliev_hizmetleri = new AkilliEvHizmetleri();
        public frmAkilliEvListele()
        {
            InitializeComponent();
        }

        private void frmMüsteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();
            YenileListele2();
        }

        private void YenileListele()
        {
            string cumle = "select *from Akilli_Ev INNER JOIN Kullanici ON Akilli_Ev.ev_sahibi_no=Kullanici.kullanici_no";
         
            
            
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = akilliev_hizmetleri.listele(adtr2, cumle);
            dataGridView1.Columns[0].HeaderText = "Ev_id";
            dataGridView1.Columns[1].HeaderText = "ADRES";
            dataGridView1.Columns[2].HeaderText = "Ev_Sahibi_No";
            dataGridView1.Columns[3].HeaderText = "Kullanici_No";
            dataGridView1.Columns[4].HeaderText = "Adi";
            dataGridView1.Columns[5].HeaderText = "Soyadi";
            dataGridView1.Columns[6].HeaderText = "Eposta";

        }
        private void YenileListele2()
        {
            string cumle = "select *from Kullanici";

            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView2.DataSource = akilliev_hizmetleri.listele(adtr2, cumle);
            dataGridView2.Columns[0].HeaderText = "Kullanici_No";
            dataGridView2.Columns[1].HeaderText = "Adi";
            dataGridView2.Columns[2].HeaderText = "Soyadi";
            dataGridView2.Columns[3].HeaderText = "Eposta";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select *from Akilli_Ev INNER JOIN Kullanici ON Akilli_Ev.ev_sahibi_no=Kullanici.kullanici_no where ev_id like '%" + textBox1.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
           
            dataGridView1.DataSource = akilliev_hizmetleri.listele(adtr2, cumle);
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update Akilli_Ev set adres=@adres,ev_sahibi_no=@ev_sahibi_no where ev_id = @ev_id";
            string cumle2 = "update Kullanici set adi=@adi,soyadi=@soyadi,eposta=@eposta where kullanici_no=@kullanici_no ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@kullanici_no", int.Parse(txtKullaniciNo.Text));
            komut2.Parameters.AddWithValue("@adi", txtAd.Text);
            komut2.Parameters.AddWithValue("@soyadi", txtSoyadi.Text);
            komut2.Parameters.AddWithValue("@eposta", txtEPosta.Text);
            komut2.Parameters.AddWithValue("@ev_id", int.Parse(txtEvId.Text));
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@ev_sahibi_no", int.Parse(txtEvSahibiNo.Text));

            akilliev_hizmetleri.ekle_sil_güncelle(komut2, cumle);
            akilliev_hizmetleri.ekle_sil_güncelle(komut2, cumle2);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
            YenileListele2();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtEvId.Text = satir.Cells[0].Value.ToString();
            txtAdres.Text = satir.Cells[1].Value.ToString();
            txtEvSahibiNo.Text = satir.Cells[2].Value.ToString();
            txtKullaniciNo.Text= satir.Cells[3].Value.ToString();
            txtAd.Text = satir.Cells[4].Value.ToString();
            txtSoyadi.Text = satir.Cells[5].Value.ToString();
            txtEPosta.Text = satir.Cells[6].Value.ToString();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "delete from Akilli_Ev where ev_id='" +satir.Cells["ev_id"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            akilliev_hizmetleri.ekle_sil_güncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void txtEvSahibiNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            string cumle = "delete from Kullanici where kullanici_no='" + satir.Cells["kullanici_no"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            akilliev_hizmetleri.ekle_sil_güncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileListele2();
            YenileListele();
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            txtKullaniciNo.Text = satir.Cells[0].Value.ToString();
            txtAd.Text = satir.Cells[1].Value.ToString();
            txtSoyadi.Text = satir.Cells[2].Value.ToString();
            txtEPosta.Text = satir.Cells[3].Value.ToString();
        }
    }
}
