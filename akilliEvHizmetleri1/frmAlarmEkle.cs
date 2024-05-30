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
    public partial class frmAlarmEkle : Form
    {
        AkilliEvHizmetleri akilliEvHizmetleri = new AkilliEvHizmetleri();
        public frmAlarmEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into Alarmlar(alarm_no, alarm_durum, alarm_tarih, olay_no) values(@alarm_no, @alarm_durum,@alarm_tarih, @olay_no)";

            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@alarm_no", int.Parse(txtAlarmNo.Text));
            komut2.Parameters.AddWithValue("@alarm_durum", comboAlarmDurum.Text);
            komut2.Parameters.AddWithValue("@alarm_tarih", DateTime.Parse(dateTimePicker1.Text));
            komut2.Parameters.AddWithValue("@olay_no", int.Parse(txtOlayNo.Text));

            akilliEvHizmetleri.ekle_sil_güncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmAlarmEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
