using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormOduncVerme : Form
    {
        public FormOduncVerme()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();
        public int uyeid, uyepuan, uyedurum, kutuphaneid, kitapid, kitapAdet;
        void Temizle()
        {
            uyeid = 0;
            kutuphaneid = 0;
            kitapid = 0;
            kitapAdet = 0;
            textBoxUyeAdi.Clear();
            textBoxKutuphaneAdi.Clear();
            textBoxKitapAdi.Clear();
            dateTimePickerVerecegiTarih.Value = DateTime.Now;
        }

        private void FormIslemler_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (uyeid != 0 || kutuphaneid != 0 || kitapid != 0)
            {
                if (uyepuan != 0)
                {
                    if (uyedurum == 0)
                    {
                        SqlCommand komut = new SqlCommand("insert into Islemler(UyeId,KutuphaneId,KitapISBN,OduncAlmaTarihi,GeriVermeTarihi) values(@p1,@p2,@p3,@p4,@p5)", bag.baglanti());
                        komut.Parameters.AddWithValue("@p1", uyeid);
                        komut.Parameters.AddWithValue("@p2", kutuphaneid);
                        komut.Parameters.AddWithValue("@p3", kitapid);
                        komut.Parameters.AddWithValue("@p4", dateTimePickerAldigiTarih.Value);
                        komut.Parameters.AddWithValue("@p5", dateTimePickerVerecegiTarih.Value);
                        komut.ExecuteNonQuery();

                        SqlCommand komut2 = new SqlCommand("update Uyeler set UyePuan = @p2, UyeDurum = @p3 where UyeId = @p1", bag.baglanti());
                        komut2.Parameters.AddWithValue("@p1", uyeid);
                        komut2.Parameters.AddWithValue("@p2", uyepuan - 10);
                        komut2.Parameters.AddWithValue("@p3", 1);
                        komut2.ExecuteNonQuery();

                        SqlCommand komut3 = new SqlCommand("update Kutuphane_Kitap set Adet = @p3 where KutuphaneId = @p1 and KitapISBN = @p2", bag.baglanti());
                        komut3.Parameters.AddWithValue("@p1", kutuphaneid);
                        komut3.Parameters.AddWithValue("@p2", kitapid);
                        komut3.Parameters.AddWithValue("@p3", kitapAdet - 1);
                        komut3.ExecuteNonQuery();

                        bag.baglanti().Close();
                        MessageBox.Show("İşlem Kaydedildi", "Bilgi");
                        Temizle();
                    }
                    else MessageBox.Show(textBoxUyeAdi.Text + " daha önce aldığı kitabı getirmediği için\ntekrar kitap ödünç alamaz.", "Bilgi");

                }
                else MessageBox.Show(textBoxUyeAdi.Text + " çok kez kitap getirmemiş!\nArtık bu üyeye kitap ödünç verilemez!", "Bilgi");

            }
            else MessageBox.Show("Lütfen Alanları Boş Bırakmayınız!", "Bilgi");

        }

        private void buttonUyeSec_Click(object sender, EventArgs e)
        {
            FormSec sec = new FormSec();
            sec.secimid = 1;
            sec.ShowDialog();
        }

        private void buttonKutuphaneSec_Click(object sender, EventArgs e)
        {
            FormSec sec = new FormSec();
            sec.secimid = 2;

            kitapid = 0;
            kitapAdet = 0;
            textBoxKitapAdi.Clear();

            sec.ShowDialog();
        }

        private void buttonKitapSec_Click(object sender, EventArgs e)
        {
            FormSec sec = new FormSec();
            sec.secimid = 3;
            sec.ShowDialog();
        }

    }
}
