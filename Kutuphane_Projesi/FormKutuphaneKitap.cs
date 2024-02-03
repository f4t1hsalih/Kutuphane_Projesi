using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormKutuphaneKitap : Form
    {
        public FormKutuphaneKitap()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();
        int id = 0;

        void Temizle()
        {
            id = 0;
            comboBoxKutuphaneAdi.SelectedIndex = 0;
            comboBoxKitapAdi.SelectedIndex = 0;
            maskedTextBoxAdet.Clear();
            comboBoxKutuphaneAdi.Enabled = true;
            comboBoxKitapAdi.Enabled = true;
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Kk.Id, Ku.KutuphaneAdi, K.KitapAdi, Kk.Adet from Kutuphane_Kitap Kk inner join Kutuphane Ku on Kk.KutuphaneId = Ku.KutuphaneId inner join Kitap K on Kk.KitapISBN = K.KitapISBN", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewKutuphaneKitap.DataSource = dt;
        }

        private void FormKutuphaneKitap_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void FormKutuphaneKitap_Load(object sender, EventArgs e)
        {
            Listele();

            SqlDataAdapter da = new SqlDataAdapter("select * from Kutuphane", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxKutuphaneAdi.DataSource = dt;
            comboBoxKutuphaneAdi.DisplayMember = "KutuphaneAdi";
            comboBoxKutuphaneAdi.ValueMember = "KutuphaneId";

            SqlDataAdapter da2 = new SqlDataAdapter("select * from Kitap", bag.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxKitapAdi.DataSource = dt2;
            comboBoxKitapAdi.DisplayMember = "KitapAdi";
            comboBoxKitapAdi.ValueMember = "KitapISBN";
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void buttonGoruntule_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select * from Kutuphane_Kitap where KutuphaneId=@p1 and KitapISBN=@p2", bag.baglanti());
            komut1.Parameters.AddWithValue("@p1", comboBoxKutuphaneAdi.SelectedValue);
            komut1.Parameters.AddWithValue("@p2", comboBoxKitapAdi.SelectedValue);
            SqlDataReader dr = komut1.ExecuteReader();
            if (!dr.Read())
            {
                if (maskedTextBoxAdet.Text != "" && maskedTextBoxAdet.Text != "0")
                {
                    SqlCommand komut = new SqlCommand("insert into Kutuphane_Kitap(KutuphaneId,KitapISBN,Adet) values(@p1,@p2,@p3)", bag.baglanti());
                    komut.Parameters.AddWithValue("@p1", comboBoxKutuphaneAdi.SelectedValue);
                    komut.Parameters.AddWithValue("@p2", comboBoxKitapAdi.SelectedValue);
                    komut.Parameters.AddWithValue("@p3", maskedTextBoxAdet.Text);
                    komut.ExecuteNonQuery();
                    bag.baglanti().Close();

                    MessageBox.Show("Kütüphaneye Kitap Başarıyla Eklendi", "Bilgi");
                    Temizle();
                    Listele();
                }
                else MessageBox.Show("Lütfen Adet Giriniz", "Bilgi");
            }
            else MessageBox.Show("Girdiğiniz Kayıt Daha Önce Yapılmıştır.\nEğer Adet'i Değiştirmek İstiyorsanız Önceden Yapılan Kaydı Güncelleyiniz.", "Bilgi");

        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (id != 0 && maskedTextBoxAdet.Text != "" && maskedTextBoxAdet.Text != "0")
            {
                SqlCommand komut = new SqlCommand("update Kutuphane_Kitap set Adet=@p2 where Id=@p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                komut.Parameters.AddWithValue("@p2", maskedTextBoxAdet.Text);
                komut.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Adet Güncellendi", "Bilgi");
                Temizle();
                Listele();
            }
            else if (maskedTextBoxAdet.Text == "") MessageBox.Show("Lütfen Bir Adet Giriniz", "Bilgi");
            else if (maskedTextBoxAdet.Text == "0") MessageBox.Show("Girilen Adet 0 Olamaz", "Bilgi");
            else MessageBox.Show("Lütfen Bir Kayıt Seçin");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                SqlCommand komut = new SqlCommand("delete from Kutuphane_Kitap where Id=@p1", bag.baglanti());
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

        private void dataGridViewKutuphaneKitap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewKutuphaneKitap.Rows[e.RowIndex].Cells[0].Value);
            comboBoxKutuphaneAdi.Text = dataGridViewKutuphaneKitap.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBoxKitapAdi.Text = dataGridViewKutuphaneKitap.Rows[e.RowIndex].Cells[2].Value.ToString();
            maskedTextBoxAdet.Text = dataGridViewKutuphaneKitap.Rows[e.RowIndex].Cells[3].Value.ToString();

            comboBoxKutuphaneAdi.Enabled = false;
            comboBoxKitapAdi.Enabled = false;
        }
    }
}
