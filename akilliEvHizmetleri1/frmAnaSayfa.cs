using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace akilliEvHizmetleri1
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEvEkle ekle = new frmEvEkle(); 
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmOlaylar olaylar = new frmOlaylar();
            olaylar.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCihazEkle ekle = new frmCihazEkle();
            ekle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCihazlariListele listele = new frmCihazlariListele();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKullaniciKayit kayıt = new frmKullaniciKayit();
            kayıt.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAkilliEvListele listele = new frmAkilliEvListele();
            listele.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmAlarmEkle alarm = new frmAlarmEkle();
            alarm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmAlarmListele listele = new frmAlarmListele();
            listele.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ViewListele viewlistele = new ViewListele();
            viewlistele.ShowDialog();
        }
    }
}
