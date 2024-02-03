using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormYazarKayit : Form
    {
        public FormYazarKayit()
        {
            InitializeComponent();
            Temizle();        
        }

        ClassBaglanti bag = new ClassBaglanti();
        int id = 0;

        public void Temizle()
        {
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            dateTimePickerDTarihi.Value = DateTime.Now;
            radioButtonErkek.Checked = false;
            radioButtonKadin.Checked = false;
            id = 0;
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Yazar where YazarSilinme = 0", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewYazarlar.DataSource = dt;
        }

        private void FormYazarKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void FormYazarKayit_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonGoruntule_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridViewYazarlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewYazarlar.Rows[e.RowIndex].Cells[0].Value);
            textBoxAd.Text = dataGridViewYazarlar.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridViewYazarlar.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridViewYazarlar.Rows[e.RowIndex].Cells[3].Value.ToString() == "Erkek") radioButtonErkek.Checked = true;
            else if (dataGridViewYazarlar.Rows[e.RowIndex].Cells[3].Value.ToString() == "Kadın") radioButtonKadin.Checked = true;
            else
            {
                radioButtonErkek.Checked = false;
                radioButtonKadin.Checked = false;
            }
            dateTimePickerDTarihi.Text = dataGridViewYazarlar.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                SqlCommand komut = new SqlCommand("update Yazar set YazarSilinme = 1 where YazarId = @p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
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

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Yazar(YazarAdi,YazarSoyadi,YazarCinsiyet,YazarDogumTarihi) values(@p1,@p2,@p3,@p4)", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            if (radioButtonErkek.Checked) komut.Parameters.AddWithValue("@p3", radioButtonErkek.Text);
            else if (radioButtonKadin.Checked) komut.Parameters.AddWithValue("@p3", radioButtonKadin.Text);
            else komut.Parameters.AddWithValue("@p3", "");
            komut.Parameters.AddWithValue("@p4", dateTimePickerDTarihi.Value);
            komut.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Yazar Başarıyla Kaydedildi", "Bilgi");
            Temizle();
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                SqlCommand komut = new SqlCommand("update Yazar set YazarAdi=@p2,YazarSoyadi=@p3,YazarCinsiyet=@p4,YazarDogumTarihi=@p5 where YazarId=@p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                komut.Parameters.AddWithValue("@p2", textBoxAd.Text);
                komut.Parameters.AddWithValue("@p3", textBoxSoyad.Text);
                if (radioButtonErkek.Checked) komut.Parameters.AddWithValue("@p4", radioButtonErkek.Text);
                else if (radioButtonKadin.Checked) komut.Parameters.AddWithValue("@p4", radioButtonKadin.Text);
                else komut.Parameters.AddWithValue("@p4", "");
                komut.Parameters.AddWithValue("@p5", dateTimePickerDTarihi.Value);
                komut.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Yazar Bigileri Güncellendi", "Bilgi");
                Temizle();
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçin");
            }
        }

        private void buttonIstatistikler_Click(object sender, EventArgs e)
        {
            FormYazarIstatistik yazarIstatistik = new FormYazarIstatistik();
            yazarIstatistik.Show();
            this.Hide();
        }
    }
}
