using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormKutuphaneIstatistik : Form
    {
        public FormKutuphaneIstatistik()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();

        private void FormKutuphaneIstatistik_Load(object sender, EventArgs e)
        {
            label3.Text = "Tüm Kütüphanelerdeki\nToplam Kitap Sayısı";

            SqlCommand komut = new SqlCommand("select K.KutuphaneAdi, Sum(Adet) from Kutuphane_Kitap Kk inner join Kutuphane K on Kk.KutuphaneId = K.KutuphaneId where K.KutuphaneSilinme = 0 group by K.KutuphaneAdi\r\n", bag.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) chart1.Series["Kütüphane"].Points.AddXY(dr[0], dr[1]);

            SqlCommand komut1 = new SqlCommand("select count(KutuphaneAdi) from Kutuphane where KutuphaneSilinme = 0", bag.baglanti());
            dr = komut1.ExecuteReader();
            while (dr.Read()) labelSorgu1.Text = dr[0].ToString();

            SqlCommand komut2 = new SqlCommand("Select Count(distinct KutuphaneAdresilid) from Kutuphane where KutuphaneSilinme = 0", bag.baglanti());
            dr = komut2.ExecuteReader();
            while (dr.Read()) labelSorgu2.Text = dr[0].ToString();

            SqlCommand komut3 = new SqlCommand("Select sum(Adet) from Kutuphane_Kitap", bag.baglanti());
            dr = komut3.ExecuteReader();
            while (dr.Read()) labelSorgu3.Text = dr[0].ToString();

            dr.Close();
            bag.baglanti().Close();
        }

        private void FormKutuphaneIstatistik_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormKutuphaneKayit kutuphaneKayit = new FormKutuphaneKayit();
            kutuphaneKayit.Show();
            this.Hide();
        }
    }
}
