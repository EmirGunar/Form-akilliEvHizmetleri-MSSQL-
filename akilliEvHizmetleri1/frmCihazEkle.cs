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
    public partial class frmCihazEkle : Form
    {
        AkilliEvHizmetleri akilliEvHizmetleri = new AkilliEvHizmetleri();

        public frmCihazEkle()
        {
            InitializeComponent();
        }

        private void frmCihazEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into Guvenlik_Cihazlari(cihaz_no,cihaz_tur,cihaz_durum, ev_numarasi) values(@cihaz_no,@cihaz_tur,@cihaz_durum, @ev_numarasi)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@cihaz_no", int.Parse(txtCihazNo.Text));
            komut2.Parameters.AddWithValue("@cihaz_tur", txtCihazTur.Text);
            komut2.Parameters.AddWithValue("@cihaz_durum", comboCihazDurum.Text);
            komut2.Parameters.AddWithValue("@ev_numarasi", int.Parse(txtEvNo.Text));

            akilliEvHizmetleri.ekle_sil_güncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
