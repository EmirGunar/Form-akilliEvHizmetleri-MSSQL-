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
    public partial class frmCihazlariListele : Form
    {
        AkilliEvHizmetleri akillievhizmetleri = new AkilliEvHizmetleri();
        public frmCihazlariListele()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmAraçListele_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtCihazNo.Text = satır.Cells["cihaz_no"].Value.ToString();
            txtCihazTuru.Text = satır.Cells["cihaz_tur"].Value.ToString();
            comboCihazDurum.Text = satır.Cells["cihaz_durum"].Value.ToString();
            txtEvNo.Text = satır.Cells["ev_numarasi"].Value.ToString();
            txtOlayNo.Text = satır.Cells["olay_no"].Value.ToString();
            txtOlayTuru.Text = satır.Cells["olay_tur"].Value.ToString();
            dateTimePicker1.Text = satır.Cells["olay_tarih"].Value.ToString();
            txtEtkilesimTuru.Text = satır.Cells["EtkilesimTur"].Value.ToString();
        }

        private void frmCihazListele_Load(object sender, EventArgs e)
        {
            YenileCihazlarListesi();
            YenileCihazlarListesi2();
        }

        private void YenileCihazlarListesi()
        {
            string cumle = "select * from Guvenlik_Cihazlari INNER JOIN Olaylar ON Olaylar.cihaz_no=Guvenlik_Cihazlari.cihaz_no";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource= akillievhizmetleri.listele(adtr2, cumle);
        }

        private void YenileCihazlarListesi2()
        {
            string cumle = "select * from Guvenlik_Cihazlari";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView2.DataSource = akillievhizmetleri.listele(adtr2 , cumle);
            dataGridView2.Columns[0].HeaderText = "cihaz_no";
            dataGridView2.Columns[1].HeaderText = "cihaz_tur";
            dataGridView2.Columns[2].HeaderText = "cihaz_durum";
            dataGridView2.Columns[3].HeaderText = "ev_numarasi";
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update Guvenlik_Cihazlari set cihaz_tur=@cihaz_tur,cihaz_durum=@cihaz_durum where cihaz_no=@cihaz_no ";
            string cumle2 = "update Olaylar set olay_tur=@olay_tur,olay_tarih=@olay_tarih,EtkilesimTur=@EtkilesimTur where olay_no=@olay_no ";
            SqlCommand komut2= new SqlCommand();
            komut2.Parameters.AddWithValue("@cihaz_no", int.Parse(txtCihazNo.Text));
            komut2.Parameters.AddWithValue("@cihaz_tur", txtCihazTuru.Text);
            komut2.Parameters.AddWithValue("@cihaz_durum", comboCihazDurum.Text);
            komut2.Parameters.AddWithValue("@ev_numarasi", int.Parse(txtEvNo.Text));
            komut2.Parameters.AddWithValue("@olay_no", int.Parse(txtOlayNo.Text));
            komut2.Parameters.AddWithValue("@olay_tur", txtOlayTuru.Text);
            komut2.Parameters.AddWithValue("@olay_tarih", DateTime.Parse(dateTimePicker1.Text));
            komut2.Parameters.AddWithValue("@EtkilesimTur", txtEtkilesimTuru.Text);
            akillievhizmetleri.ekle_sil_güncelle(komut2, cumle);
            akillievhizmetleri.ekle_sil_güncelle(komut2, cumle2);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileCihazlarListesi();
            YenileCihazlarListesi2();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "delete from Olaylar where olay_no='" + satir.Cells["olay_no"].Value.ToString() + "'";
            SqlCommand komut2= new SqlCommand();

            akillievhizmetleri.ekle_sil_güncelle(komut2, cumle);
            YenileCihazlarListesi();
            YenileCihazlarListesi2();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch 
            {

                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOlayTuru_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCihazSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            string cumle = "delete from Guvenlik_Cihazlari where cihaz_no='" + satir.Cells["cihaz_no"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();

            akillievhizmetleri.ekle_sil_güncelle(komut2, cumle);
            YenileCihazlarListesi();
            YenileCihazlarListesi2();
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView2.CurrentRow;
            txtCihazNo.Text = satır.Cells["cihaz_no"].Value.ToString();
            txtCihazTuru.Text = satır.Cells["cihaz_tur"].Value.ToString();
            comboCihazDurum.Text = satır.Cells["cihaz_durum"].Value.ToString();
            txtEvNo.Text = satır.Cells["ev_numarasi"].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select *from Guvenlik_Cihazlari INNER JOIN Olaylar ON Guvenlik_Cihazlari.cihaz_no=Olaylar.cihaz_no where Olaylar.cihaz_no like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();

            dataGridView1.DataSource = akillievhizmetleri.listele(adtr2, cumle);
        }
    }
}
