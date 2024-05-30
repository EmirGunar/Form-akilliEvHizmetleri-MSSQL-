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
    public partial class frmOlaylar : Form
    {
        AkilliEvHizmetleri akilliEvHizmetleri = new AkilliEvHizmetleri();
        public frmOlaylar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cumle = "insert into Olaylar(olay_no, olay_tur, olay_tarih, EtkilesimTur, cihaz_no) values(@olay_no, @olay_tur, @olay_tarih, @EtkilesimTur, @cihaz_no)";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@olay_no", int.Parse(txtOlayNo.Text));
            komut2.Parameters.AddWithValue("@olay_tur", txtOlayTuru.Text);
            komut2.Parameters.AddWithValue("@olay_tarih", DateTime.Parse(dateTimePicker1.Text));
            komut2.Parameters.AddWithValue("@EtkilesimTur", txtEtkilesimTuru.Text);
            komut2.Parameters.AddWithValue("@cihaz_no", int.Parse(txtCihazNo.Text));

            akilliEvHizmetleri.ekle_sil_güncelle(komut2, cumle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
