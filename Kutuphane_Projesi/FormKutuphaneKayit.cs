using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormKutuphaneKayit : Form
    {
        public FormKutuphaneKayit()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();
        int id = 0;

        void Temizle()
        {
            textBoxKutuphaneAd.Clear();
            textBoxKurucu.Clear();
            comboBoxAil.SelectedIndex = 0;
            comboBoxAilce.Text = "";
            richTextBoxATam.Clear();
            id = 0;
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select K.KutuphaneId,K.KutuphaneAdi,K.KutuphaneKurucusu,A.AdresilAdi,AL.AdresilceAdi,K.KutuphaneAdresTam,A.Adresilid,AL.Adresilceid from Kutuphane K inner join Adresil A ON K.KutuphaneAdresilid=A.Adresilid inner join Adresilce AL ON K.KutuphaneAdresilceid=AL.Adresilceid", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewKutuphaneler.DataSource = dt;
        }

        private void FormKutuphaneKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void FormKutuphaneKayit_Load(object sender, EventArgs e)
        {
            Listele();
            SqlDataAdapter da = new SqlDataAdapter("select * from Adresil", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxAil.DataSource = dt;
            comboBoxAil.DisplayMember = "AdresilAdi";
            comboBoxAil.ValueMember = "Adresilid";
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void comboBoxAilce_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (comboBoxAil.SelectedValue != null)
            {
                SqlDataAdapter da2 = new SqlDataAdapter("select Adresilceid,AdresilceAdi from Adresilce where Adresilid=" + comboBoxAil.SelectedValue, bag.baglanti());
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                comboBoxAilce.DisplayMember = "AdresilceAdi";
                comboBoxAilce.ValueMember = "Adresilceid";
                comboBoxAilce.DataSource = dt2;
            }
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Kutuphane(KutuphaneAdi,KutuphaneKurucusu,KutuphaneAdresilid,KutuphaneAdresilceid,KutuphaneAdresTam) values(@p1,@p2,@p3,@p4,@p5)", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxKutuphaneAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxKurucu.Text);
            komut.Parameters.AddWithValue("@p3", comboBoxAil.SelectedValue);
            komut.Parameters.AddWithValue("@p4", comboBoxAilce.SelectedValue);
            komut.Parameters.AddWithValue("@p5", richTextBoxATam.Text);
            komut.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Kütüphane Başarıyla Eklendi", "Bilgi");
            Temizle();
            Listele();
        }

        private void buttonGoruntule_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                SqlCommand komut = new SqlCommand("delete from Kutuphane where KutuphaneId=@p1", bag.baglanti());
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

        private void dataGridViewKutuphaneler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select Adresilceid,AdresilceAdi from Adresilce where Adresilid=" + dataGridViewKutuphaneler.Rows[e.RowIndex].Cells[6].Value, bag.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxAilce.DisplayMember = "AdresilceAdi";
            comboBoxAilce.ValueMember = "Adresilceid";
            comboBoxAilce.DataSource = dt2;

            id = Convert.ToInt32(dataGridViewKutuphaneler.Rows[e.RowIndex].Cells[0].Value);
            textBoxKutuphaneAd.Text = dataGridViewKutuphaneler.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxKurucu.Text = dataGridViewKutuphaneler.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBoxAil.Text = dataGridViewKutuphaneler.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBoxAilce.SelectedValue = Convert.ToInt32(dataGridViewKutuphaneler.Rows[e.RowIndex].Cells[7].Value);
            richTextBoxATam.Text = dataGridViewKutuphaneler.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                SqlCommand komut = new SqlCommand("update Kutuphane set KutuphaneAdi=@p2,KutuphaneKurucusu=@p3,KutuphaneAdresilid=@p4,KutuphaneAdresilceid=@p5,KutuphaneAdresTam=@p6 where KutuphaneId=@p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                komut.Parameters.AddWithValue("@p2", textBoxKutuphaneAd.Text);
                komut.Parameters.AddWithValue("@p3", textBoxKurucu.Text);
                komut.Parameters.AddWithValue("@p4", comboBoxAil.SelectedValue);
                komut.Parameters.AddWithValue("@p5", comboBoxAilce.SelectedValue);
                komut.Parameters.AddWithValue("@p6", richTextBoxATam.Text);
                komut.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Kütüphane Bigileri Güncellendi", "Bilgi");
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
            FormKutuphaneIstatistik kutuphaneIstatistik = new FormKutuphaneIstatistik();
            kutuphaneIstatistik.Show();
            this.Hide();
        }
    }
}
