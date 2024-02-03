using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormYazarIstatistik : Form
    {
        public FormYazarIstatistik()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();

        private void FormYazarIstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select (Y.YazarAdi + ' ' + Y.YazarSoyadi), Count(KitapAdi) from Yazar Y inner join Kitap K on Y.YazarId = K.KYazarId where Y.YazarSilinme = 0 and K.KitapSilinme = 0 group by (Y.YazarAdi + ' ' + Y.YazarSoyadi)", bag.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) chart1.Series["Yazar"].Points.AddXY(dr[0], dr[1]);

            SqlCommand komut1 = new SqlCommand("Select count(YazarId) from Yazar where YazarSilinme = 0", bag.baglanti());
            dr = komut1.ExecuteReader();
            while (dr.Read()) labelSorgu1.Text = dr[0].ToString();

            SqlCommand komut2 = new SqlCommand("Select count(YazarCinsiyet) from Yazar where YazarCinsiyet = 'Erkek' and YazarSilinme = 0", bag.baglanti());
            dr = komut2.ExecuteReader();
            while (dr.Read()) labelSorgu2.Text = dr[0].ToString();

            SqlCommand komut3 = new SqlCommand("Select count(YazarCinsiyet) from Yazar where YazarCinsiyet = 'Kadın' and YazarSilinme = 0", bag.baglanti());
            dr = komut3.ExecuteReader();
            while (dr.Read()) labelSorgu3.Text = dr[0].ToString();

            dr.Close();
            bag.baglanti().Close();
        }

        private void FormYazarIstatistik_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormYazarKayit yazarKayit = new FormYazarKayit();
            yazarKayit.Show();
            this.Hide();
        }
    }
}
