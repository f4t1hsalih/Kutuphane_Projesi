using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
            textBoxKullaniciAdi.Focus();
        }

        ClassBaglanti bag = new ClassBaglanti();

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Giris where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre", bag.baglanti());
            komut.Parameters.AddWithValue("KullaniciAdi", textBoxKullaniciAdi.Text);
            komut.Parameters.AddWithValue("Sifre", textBoxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FormAnaSayfa anaform = new FormAnaSayfa();
                anaform.Show();
                this.Hide();
            }
            else
            {
                labelBildirim.Text = "Kullanıcı Adı veya Şifre Hatalı!";
                labelBildirim.Visible = true;
                Temizle();
            }
            bag.baglanti().Close();
        }

        void Temizle()
        {
            textBoxKullaniciAdi.Text = "";
            textBoxSifre.Text = "";
        }
    }
}
