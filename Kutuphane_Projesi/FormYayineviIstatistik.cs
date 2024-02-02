using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormYayineviIstatistik : Form
    {
        public FormYayineviIstatistik()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();

        private void FormYayineviIstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select Y.YEAdi,Count(K.KitapAdi) from Yayinevi Y inner join Kitap K on Y.YEId=K.KYEId group by Y.YEAdi", bag.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) chart1.Series["Yayınevi"].Points.AddXY(dr[0], dr[1]);

            SqlCommand komut1 = new SqlCommand("select count(YEId) from Yayinevi", bag.baglanti());
            dr = komut1.ExecuteReader();
            while (dr.Read()) labelSorgu1.Text = dr[0].ToString();

            SqlCommand komut2 = new SqlCommand("select top 1 Y.YEAdi from Yayinevi Y inner join Kitap K on Y.YEId=K.KYEId group by Y.YEAdi order by Count(K.KYEId) Desc", bag.baglanti());
            dr = komut2.ExecuteReader();
            while (dr.Read()) labelSorgu2.Text = dr[0].ToString();

            SqlCommand komut3 = new SqlCommand("select top 1 A.AdresilAdi from Yayinevi Y inner join Adresil A on Y.YEAdresilid=A.Adresilid group by A.AdresilAdi order by COUNT(Y.YEAdi) Desc", bag.baglanti());
            dr = komut3.ExecuteReader();
            while (dr.Read()) labelSorgu3.Text = dr[0].ToString();

            dr.Close();
            bag.baglanti().Close();
        }

        private void FormYayineviIstatistik_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormYayineviKayit yayineviKayit = new FormYayineviKayit();
            yayineviKayit.Show();
            this.Hide();
        }
    }
}
