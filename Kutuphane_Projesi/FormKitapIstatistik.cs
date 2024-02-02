using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormKitapIstatistik : Form
    {
        public FormKitapIstatistik()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();

        private void FormKitapIstatistik_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormKitapKayit kitapKayit = new FormKitapKayit();
            kitapKayit.Show();
            this.Hide();
        }

        private void FormKitapIstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select K.KitapAdi, Sum(Kk.Adet) as 'Toplam' from Kitap K inner join Kutuphane_Kitap Kk on K.KitapISBN = Kk.KitapISBN group by K.KitapAdi", bag.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) chart1.Series["Kitap"].Points.AddXY(dr[0], dr[1]);

            SqlCommand komut1 = new SqlCommand("select Count(KitapAdi) from Kitap", bag.baglanti());
            dr = komut1.ExecuteReader();
            while (dr.Read()) labelSorgu1.Text = dr[0].ToString();

            SqlCommand komut2 = new SqlCommand("select count(DISTINCT KTurId) from Kitap ", bag.baglanti());
            dr = komut2.ExecuteReader();
            while (dr.Read()) labelSorgu2.Text = dr[0].ToString();

            SqlCommand komut3 = new SqlCommand("select avg(KitapSayfa) from Kitap", bag.baglanti());
            dr = komut3.ExecuteReader();
            while (dr.Read()) labelSorgu3.Text = dr[0].ToString();

            dr.Close();
            bag.baglanti().Close();
        }
    }
}
