using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormUyeIstatistik : Form
    {
        public FormUyeIstatistik()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();

        private void FormUyeIstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select A.AdresilAdi,Count(Distinct U.UyeAd) from uyeler U inner join Adresil A on U.UyeAdresilid=A.Adresilid group by A.AdresilAdi", bag.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) chart1.Series["Üye"].Points.AddXY(dr[0], dr[1]);

            SqlCommand komut1 = new SqlCommand("select Count(UyeId) from Uyeler", bag.baglanti());
            dr = komut1.ExecuteReader();
            while (dr.Read()) labelSorgu1.Text = dr[0].ToString();

            SqlCommand komut2 = new SqlCommand("select Count(*) from Uyeler where UyeDurum=1", bag.baglanti());
            dr = komut2.ExecuteReader();
            while (dr.Read()) labelSorgu2.Text = dr[0].ToString();

            SqlCommand komut3 = new SqlCommand("select top 1 A.AdresilAdi from Uyeler U inner join Adresil A on U.UyeAdresilid=A.Adresilid group by A.AdresilAdi order by Count(U.UyeAdresilid) Desc", bag.baglanti());
            dr = komut3.ExecuteReader();
            while (dr.Read()) labelSorgu3.Text = dr[0].ToString();

            dr.Close();
            bag.baglanti().Close();
        }

        private void FormUyeIstatistik_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormUyeKayit uyeKayit = new FormUyeKayit();
            uyeKayit.Show();
            this.Hide();
        }
    }
}
