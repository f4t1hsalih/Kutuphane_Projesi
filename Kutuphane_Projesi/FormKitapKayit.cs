using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormKitapKayit : Form
    {
        public FormKitapKayit()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();
        int isbn = 0;

        void Temizle()
        {
            maskedTextBoxKitapISBN.Clear();
            textBoxKitapAd.Clear();
            maskedTextBoxSayfaSayisi.Clear();
            comboBoxTur.SelectedIndex = 0;
            comboBoxKitapYazar.SelectedIndex = 0;
            comboBoxYayinevi.SelectedIndex = 0;
            isbn = 0;
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select K.KitapISBN,K.KitapAdi,K.KitapSayfa,T.TurAdi,(Y.YazarAdi+' '+Y.YazarSoyadi)as YazarAdi,YE.YEAdi from Kitap K inner join Tur T on K.KTurId=T.TurId inner join Yazar Y on K.KYazarId=Y.YazarId inner join Yayinevi YE on K.KYEId=YE.YEId where KitapSilinme = 0", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewKitaplar.DataSource = dt;
        }

        private void FormKitapKayit_Load(object sender, EventArgs e)
        {
            Listele();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tur", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxTur.DataSource = dt;
            comboBoxTur.DisplayMember = "TurAdi";
            comboBoxTur.ValueMember = "TurId";

            SqlDataAdapter da2 = new SqlDataAdapter("select YazarId,(YazarAdi+' '+YazarSoyadi)as YazarAd from Yazar where YazarSilinme = 0", bag.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxKitapYazar.DataSource = dt2;
            comboBoxKitapYazar.DisplayMember = "YazarAd";
            comboBoxKitapYazar.ValueMember = "YazarId";

            SqlDataAdapter da3 = new SqlDataAdapter("select YEId,YEAdi from Yayinevi", bag.baglanti());
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            comboBoxYayinevi.DataSource = dt3;
            comboBoxYayinevi.DisplayMember = "YEAdi";
            comboBoxYayinevi.ValueMember = "YEId";
        }

        private void FormKitapKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAnaSayfa anasayfa = new FormAnaSayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Kitap(KitapISBN,KitapAdi,KitapSayfa,KTurId,KYazarId,KYEId) values(@p1,@p2,@p3,@p4,@p5,@p6)", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", maskedTextBoxKitapISBN.Text);
                komut.Parameters.AddWithValue("@p2", textBoxKitapAd.Text);
                komut.Parameters.AddWithValue("@p3", maskedTextBoxSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@p4", comboBoxTur.SelectedValue);
                komut.Parameters.AddWithValue("@p5", comboBoxKitapYazar.SelectedValue);
                komut.Parameters.AddWithValue("@p6", comboBoxYayinevi.SelectedValue);
                komut.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Kitap Başarıyla Eklendi", "Bilgi");
                Temizle();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Yazdığınız ISBN no başka bir kitapta kayıtlı olduğu için işleminiz gerçekleştirilemiyor.\nLütfen başka bir ISBN no giriniz.", "Bilgi");
            }


        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (isbn != 0)
            {
                SqlCommand komut = new SqlCommand("update Kitap set KitapSilinme = 1 where KitapISBN=@p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", isbn);
                komut.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Kayıt Başarıyla Silindi", "Bilgi");
                Temizle();
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçin");
            }
        }

        private void dataGridViewKitaplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            isbn = Convert.ToInt32(dataGridViewKitaplar.Rows[e.RowIndex].Cells[0].Value);
            maskedTextBoxKitapISBN.Text = isbn.ToString(); ;
            textBoxKitapAd.Text = dataGridViewKitaplar.Rows[e.RowIndex].Cells[1].Value.ToString();
            maskedTextBoxSayfaSayisi.Text = dataGridViewKitaplar.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxTur.Text = dataGridViewKitaplar.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxKitapYazar.Text = dataGridViewKitaplar.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBoxYayinevi.Text = dataGridViewKitaplar.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void buttonGoruntule_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (isbn != 0)
            {
                SqlCommand komut = new SqlCommand("update Kitap set KitapAdi=@p2,KitapSayfa=@p3,KTurId=@p4,KYazarId=@p5,KYEId=@p6 where KitapISBN=@p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", isbn);
                komut.Parameters.AddWithValue("@p2", textBoxKitapAd.Text);
                komut.Parameters.AddWithValue("@p3", maskedTextBoxSayfaSayisi.Text);
                komut.Parameters.AddWithValue("@p4", comboBoxTur.SelectedValue);
                komut.Parameters.AddWithValue("@p5", comboBoxKitapYazar.SelectedValue);
                komut.Parameters.AddWithValue("@p6", comboBoxYayinevi.SelectedValue);
                komut.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Kitap Bigileri Güncellendi", "Bilgi");
                Temizle();
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçin");
            }
        }

        private void buttonIstatistik_Click(object sender, EventArgs e)
        {
            FormKitapIstatistik kitapIstatistik = new FormKitapIstatistik();
            kitapIstatistik.Show();
            this.Hide();
        }
    }
}
