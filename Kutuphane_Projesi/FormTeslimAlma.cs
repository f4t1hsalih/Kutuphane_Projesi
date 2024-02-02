using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormTeslimAlma : Form
    {
        public FormTeslimAlma()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();
        int id = 0, uyeid = 0, kutuphaneid = 0, kitapid = 0;

        void Temizle()
        {
            id = 0;
            uyeid = 0;
            kutuphaneid = 0;
            kitapid = 0;
            textBoxUyeAdi.Clear();
            textBoxKutuphaneAdi.Clear();
            textBoxKitapAdi.Clear();
            dateTimePickerAldigiTarih.Value = DateTime.Now;
            labelGecenGunSayisi.ForeColor = Color.Black;
            labelGecenGunSayisi.Text = "***";
        }

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select I.IslemId, U.UyeAd, Ku.KutuphaneAdi, K.KitapAdi, I.OduncAlmaTarihi, I.GeriVermeTarihi, Ku.KutuphaneId AS 'Kutuphaneno', K.KitapISBN, U.UyeId As 'Uyeno' from Islemler I inner join Uyeler U on I.UyeId=U.UyeId inner join Kutuphane Ku on I.KutuphaneId=Ku.KutuphaneId inner join Kitap K on I.KitapISBN=K.KitapISBN where I.GeriVerdigiTarih='1900-01-01'", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewTeslimAlma.DataSource = dt;
        }

        private void FormTeslimAlma_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void FormTeslimAlma_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridViewTeslimAlma_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridViewTeslimAlma.Rows[e.RowIndex].Cells[0].Value);
            textBoxUyeAdi.Text = dataGridViewTeslimAlma.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxKutuphaneAdi.Text = dataGridViewTeslimAlma.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewTeslimAlma.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePickerAldigiTarih.Text = dataGridViewTeslimAlma.Rows[e.RowIndex].Cells[4].Value.ToString();
            DateTime odunctarihi = Convert.ToDateTime(dataGridViewTeslimAlma.Rows[e.RowIndex].Cells[4].Value);
            DateTime almatarihi = Convert.ToDateTime(dataGridViewTeslimAlma.Rows[e.RowIndex].Cells[5].Value);
            kutuphaneid = Convert.ToInt32(dataGridViewTeslimAlma.Rows[e.RowIndex].Cells[6].Value);
            kitapid = Convert.ToInt32(dataGridViewTeslimAlma.Rows[e.RowIndex].Cells[7].Value);
            uyeid = Convert.ToInt32(dataGridViewTeslimAlma.Rows[e.RowIndex].Cells[8].Value);

            TimeSpan fark = almatarihi.Subtract(odunctarihi);
            TimeSpan gunsayisi = odunctarihi.Subtract(DateTime.Now);
            labelGecenGunSayisi.Text = (gunsayisi.Days * -1).ToString() + " Gün";
            if ((gunsayisi.Days * -1) < fark.Days) labelGecenGunSayisi.ForeColor = Color.Green;
            else labelGecenGunSayisi.ForeColor = Color.Red;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (id != 0 && uyeid != 0 && kutuphaneid != 0 && kitapid != 0)
            {
                //Kitabın Adetini çek
                SqlDataAdapter da = new SqlDataAdapter("select * from Kutuphane_Kitap where KutuphaneId=" + kutuphaneid + " and KitapISBN=" + kitapid, bag.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                int adet = Convert.ToInt32(dt.Rows[0][3]);

                //Üyenin Puanını çek
                SqlDataAdapter da2 = new SqlDataAdapter("select * from Uyeler where UyeId=" + uyeid, bag.baglanti());
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                int puan = Convert.ToInt32(dt2.Rows[0][9]);

                //Geri Verdiği tarihi kaydet
                SqlCommand komut = new SqlCommand("update Islemler set GeriVerdigiTarih=@p2 where IslemId=@p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                komut.Parameters.AddWithValue("@p2", DateTime.Now.ToString("MM/dd/yyyy"));
                komut.ExecuteNonQuery();

                //Kütüphanedeki Kitabın sayısını artır
                SqlCommand komut2 = new SqlCommand("update Kutuphane_Kitap set Adet=@p3 where KutuphaneId=@p1 and KitapISBN=@p2", bag.baglanti());
                komut2.Parameters.AddWithValue("@p1", kutuphaneid);
                komut2.Parameters.AddWithValue("@p2", kitapid);
                komut2.Parameters.AddWithValue("@p3", adet + 1);
                komut2.ExecuteNonQuery();

                //Üye zamanında teslim etmişse puanını artır yoksa artırma
                SqlCommand komut3 = new SqlCommand("update Uyeler set UyePuan=@p2, UyeDurum=@p3 where UyeId=@p1 ", bag.baglanti());
                komut3.Parameters.AddWithValue("@p1", uyeid);
                if (labelGecenGunSayisi.ForeColor == Color.Green) komut3.Parameters.AddWithValue("@p2", puan + 10);
                else komut3.Parameters.AddWithValue("@p2", puan);
                komut3.Parameters.AddWithValue("@p3", 0);
                komut3.ExecuteNonQuery();

                bag.baglanti().Close();
                MessageBox.Show("İşlem Başarıyla Kaydedildi", "Bilgi");
                Temizle();
                Listele();
            }
            else MessageBox.Show("Lütfen Bir Kayıt Seçin");
        }
    }
}
