using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormYayineviKayit : Form
    {
        public FormYayineviKayit()
        {
            InitializeComponent();
        }
        ClassBaglanti bag = new ClassBaglanti();
        int id = 0;

        void Temizle()
        {
            textBoxAd.Clear();
            textBoxKurucu.Clear();
            dateTimePickerKurulusTarih.Value = DateTime.Now;
            comboBoxAil.SelectedIndex = 0;
            comboBoxAilce.Text = "";
            richTextBoxATam.Clear();
            id = 0;
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Y.YEId, Y.YEAdi, Y.YEKurucusu, Y.YEKurulusTarihi, A.AdresilAdi, Al.AdresilceAdi, Y.YEAdresTam, Y.YEAdresilid, Y.YEAdresilceid from Yayinevi Y inner join Adresil A on Y.YEAdresilid = A.Adresilid inner join Adresilce Al on Y.YEAdresilceid = Al.Adresilceid where Y.YESilinme = 0", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewYayinevi.DataSource = dt;
        }

        private void FormYayinEviKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void FormYayinEviKayit_Load(object sender, EventArgs e)
        {
            Listele();
            SqlDataAdapter da = new SqlDataAdapter("select * from Adresil", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxAil.DataSource = dt;
            comboBoxAil.DisplayMember = "AdresilAdi";
            comboBoxAil.ValueMember = "Adresilid";
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Yayinevi(YEAdi,YEKurucusu,YEKurulusTarihi,YEAdresilid,YEAdresilceid,YEAdresTam) values(@p1,@p2,@p3,@p4,@p5,@p6)", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxKurucu.Text);
            komut.Parameters.AddWithValue("@p3", dateTimePickerKurulusTarih.Value);
            komut.Parameters.AddWithValue("@p4", comboBoxAil.SelectedValue);
            komut.Parameters.AddWithValue("@p5", comboBoxAilce.SelectedValue);
            komut.Parameters.AddWithValue("@p6", richTextBoxATam.Text);
            komut.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Yayınevi Başarıyla Kaydedildi", "Bilgi");
            Temizle();
            Listele();
        }

        private void buttonGoruntule_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                SqlCommand komut = new SqlCommand("update Yayinevi set YEAdi = @p2, YEKurucusu = @p3, YEKurulusTarihi = @p4, YEAdresilid = @p5, YEAdresilceid = @p6, YEAdresTam = @p7 where YEId = @p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                komut.Parameters.AddWithValue("@p2", textBoxAd.Text);
                komut.Parameters.AddWithValue("@p3", textBoxKurucu.Text);
                komut.Parameters.AddWithValue("@p4", dateTimePickerKurulusTarih.Value);
                komut.Parameters.AddWithValue("@p5", comboBoxAil.SelectedValue);
                komut.Parameters.AddWithValue("@p6", comboBoxAilce.SelectedValue);
                komut.Parameters.AddWithValue("@p7", richTextBoxATam.Text);
                komut.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Yayınevi Bigileri Güncellendi", "Bilgi");
                Temizle();
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçin");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                SqlCommand komut = new SqlCommand("update Yayinevi set YESilinme = 1 where YEId=@p1", bag.baglanti());
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

        private void dataGridViewYayinevi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select Adresilceid,AdresilceAdi from Adresilce where Adresilid=" + dataGridViewYayinevi.Rows[e.RowIndex].Cells[7].Value, bag.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxAilce.DisplayMember = "AdresilceAdi";
            comboBoxAilce.ValueMember = "Adresilceid";
            comboBoxAilce.DataSource = dt2;

            id = Convert.ToInt32(dataGridViewYayinevi.Rows[e.RowIndex].Cells[0].Value);
            textBoxAd.Text = dataGridViewYayinevi.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxKurucu.Text = dataGridViewYayinevi.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePickerKurulusTarih.Text = dataGridViewYayinevi.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxAil.SelectedValue = Convert.ToInt32(dataGridViewYayinevi.Rows[e.RowIndex].Cells[7].Value);
            comboBoxAilce.SelectedValue = Convert.ToInt32(dataGridViewYayinevi.Rows[e.RowIndex].Cells[8].Value);
            richTextBoxATam.Text = dataGridViewYayinevi.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void comboBoxAilce_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBoxAil.SelectedValue != null)
            {
                SqlDataAdapter da2 = new SqlDataAdapter("select Adresilceid, AdresilceAdi from Adresilce where Adresilid=" + comboBoxAil.SelectedValue, bag.baglanti());
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                comboBoxAilce.DisplayMember = "AdresilceAdi";
                comboBoxAilce.ValueMember = "Adresilceid";
                comboBoxAilce.DataSource = dt2;
            }
        }

        private void buttonIstatistik_Click(object sender, EventArgs e)
        {
            FormYayineviIstatistik yayineviIstatistik = new FormYayineviIstatistik();
            yayineviIstatistik.Show();
            this.Hide();
        }
    }
}
