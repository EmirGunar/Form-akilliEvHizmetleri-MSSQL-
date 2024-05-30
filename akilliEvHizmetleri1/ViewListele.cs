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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace akilliEvHizmetleri1
{
    public partial class ViewListele : Form
    {
        AkilliEvHizmetleri akilliEvHizmetleri = new AkilliEvHizmetleri();
        public ViewListele()
        {
            InitializeComponent();
        }
        private void YenileListele()
        {
            string cumle = "select *from OlayEvDurum";



            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = akilliEvHizmetleri.listele(adtr2, cumle);
            dataGridView1.Columns[0].HeaderText = "olay_no";
            dataGridView1.Columns[1].HeaderText = "olay_tur";
            dataGridView1.Columns[2].HeaderText = "olay_tarih";
            dataGridView1.Columns[3].HeaderText = "EtkilesimTur";
            dataGridView1.Columns[4].HeaderText = "ev_id";
            dataGridView1.Columns[5].HeaderText = "adres";
            dataGridView1.Columns[6].HeaderText = "Ev_sahibi_no";
            dataGridView1.Columns[7].HeaderText = "Ev_sahibi_adi";
            dataGridView1.Columns[8].HeaderText = "Ev_sahibi_Soyadi";
            dataGridView1.Columns[9].HeaderText = "Cihaz_no";
            dataGridView1.Columns[10].HeaderText = "Cihaz_tur";
            dataGridView1.Columns[11].HeaderText = "Cihaz_Durum";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cumle = "select *from OlayEvDurum ";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = akilliEvHizmetleri.listele(adtr2, cumle);
        }

        private void ViewListele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }
    }
}
