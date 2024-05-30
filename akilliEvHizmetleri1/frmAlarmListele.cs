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
    public partial class frmAlarmListele : Form
    {
        AkilliEvHizmetleri akilliEvHizmetleri = new AkilliEvHizmetleri();
        public frmAlarmListele()
        {
            InitializeComponent();
        }

        private void frmAlarmListele_Load(object sender, EventArgs e)
        {
            YenileAlarmListesi();
            YenileAlarmListesi2();
        }

        private void YenileAlarmListesi()
        {
            string cumle = "select * from Olaylar INNER JOIN Alarmlar ON Olaylar.olay_no=Alarmlar.olay_no";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = akilliEvHizmetleri.listele(adtr2, cumle);
        }

        private void YenileAlarmListesi2()
        {
            string cumle = "select * from Olaylar";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView2.DataSource = akilliEvHizmetleri.listele(adtr2, cumle);
            dataGridView2.Columns[0].HeaderText = "olay_no";
            dataGridView2.Columns[1].HeaderText = "olay_tur";
            dataGridView2.Columns[2].HeaderText = "olay_tarih";
            dataGridView2.Columns[3].HeaderText = "EtkilesimTur";
            dataGridView2.Columns[4].HeaderText = "cihaz_no";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtAlarmNo.Text = satır.Cells["alarm_no"].Value.ToString();
            txtAlarmDurum.Text = satır.Cells["alarm_durum"].Value.ToString();
            dateTimePicker1.Text = satır.Cells["alarm_tarih"].Value.ToString();
            txtOlayNo.Text = satır.Cells["olay_no"].Value.ToString();
            txtOlayTur.Text = satır.Cells["olay_tur"].Value.ToString();
            dateTimePicker2.Text = satır.Cells["olay_tarih"].Value.ToString();
            txtEtkilesimTur.Text = satır.Cells["EtkilesimTur"].Value.ToString();
            txtCihazNo.Text = satır.Cells["cihaz_no"].Value.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView2.CurrentRow;
            txtOlayNo.Text = satır.Cells["olay_no"].Value.ToString();
            txtOlayTur.Text = satır.Cells["olay_tur"].Value.ToString();
            dateTimePicker2.Text = satır.Cells["olay_tarih"].Value.ToString();
            txtEtkilesimTur.Text = satır.Cells["EtkilesimTur"].Value.ToString();
            txtCihazNo.Text = satır.Cells["cihaz_no"].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string cumle = "update Olaylar set olay_tur=@olay_tur, olay_tarih=@olay_tarih, EtkilesimTur=@EtkilesimTur where olay_no=@olay_no ";
            string cumle2 = "update Alarmlar set alarm_durum=@alarm_durum,alarm_tarih=@alarm_tarih where alarm_no=@alarm_no ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@alarm_no", int.Parse(txtAlarmNo.Text));
            komut2.Parameters.AddWithValue("@alarm_durum", txtAlarmDurum.Text);
            komut2.Parameters.AddWithValue("@alarm_tarih", DateTime.Parse(dateTimePicker1.Text));
            komut2.Parameters.AddWithValue("@olay_no", int.Parse(txtOlayNo.Text));
            komut2.Parameters.AddWithValue("@olay_tur", txtOlayTur.Text);
            komut2.Parameters.AddWithValue("@olay_tarih", DateTime.Parse(dateTimePicker2.Text));
            komut2.Parameters.AddWithValue("@EtkilesimTur", txtEtkilesimTur.Text);
            akilliEvHizmetleri.ekle_sil_güncelle(komut2, cumle);
            akilliEvHizmetleri.ekle_sil_güncelle(komut2, cumle2);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            YenileAlarmListesi();
            YenileAlarmListesi2();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cumle = "delete from Alarmlar where alarm_no='" + satir.Cells["alarm_no"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();

            akilliEvHizmetleri.ekle_sil_güncelle(komut2, cumle);
            YenileAlarmListesi();
            YenileAlarmListesi2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView2.CurrentRow;
            string cumle = "delete from Olaylar where olay_no='" + satir.Cells["olay_no"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();

            akilliEvHizmetleri.ekle_sil_güncelle(komut2, cumle);
            YenileAlarmListesi();
            YenileAlarmListesi2();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cumle = "select *from Alarmlar INNER JOIN Olaylar ON Alarmlar.olay_no=Olaylar.olay_no where alarm_no like '%" + textBox1.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();

            dataGridView1.DataSource = akilliEvHizmetleri.listele(adtr2, cumle);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
