using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormSec : Form
    {
        public FormSec()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();
        FormOduncVerme f = new FormOduncVerme();

        public int secimid;

        private void FormSec_Load(object sender, EventArgs e)
        {
            if (secimid == 1)
            {
                SqlDataAdapter da = new SqlDataAdapter("select U.UyeId AS 'Üye ID', U.UyeAd AS 'Adı', U.UyeSoyad AS 'Soyadı', U.UyeCinsiyet AS 'Cinsiyet', U.UyeTelefon AS 'Telefon', U.UyeEPosta AS 'Eposta', U.UyePuan AS 'Puan', U.UyeDurum AS 'Durum' from Uyeler U", bag.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSec.DataSource = dt;
            }
            else if (secimid == 2)
            {
                SqlDataAdapter da = new SqlDataAdapter("select K.KutuphaneId AS 'ID', K.KutuphaneAdi AS 'Adı', A.AdresilAdi AS 'İl', Ai.AdresilceAdi AS 'İlçe', K.KutuphaneAdresTam AS 'Adres' from Kutuphane K inner join Adresil A on K.KutuphaneAdresilid = A.Adresilid inner join Adresilce Ai on K.KutuphaneAdresilceid = Ai.Adresilceid", bag.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSec.DataSource = dt;
            }
            else if (secimid == 3)
            {
                foreach (Form x in Application.OpenForms)
                {
                    if (x.Name == "FormIslemler")
                        f = (FormOduncVerme)x;
                }

                SqlDataAdapter da = new SqlDataAdapter("select K.KitapISBN AS 'ISBN', K.KitapAdi AS 'Adı', K.KitapSayfa AS 'Sayfa', Y.YazarAdi+' '+Y.YazarSoyadi AS 'Yazar', Ya.YEAdi AS 'Yayınevi', Kk.Adet AS 'Adet' from Kutuphane_Kitap Kk inner join Kitap K on Kk.KitapISBN = K.KitapISBN inner join Yazar Y on K.KYazarId = Y.YazarId inner join Yayinevi Ya on K.KYEId = Ya.YEId where KutuphaneId =" + f.kutuphaneid, bag.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSec.DataSource = dt;
            }
        }

        private void dataGridViewSec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (secimid == 1)
            {
                foreach (Form x in Application.OpenForms)
                {
                    if (x.Name == "FormIslemler")
                        f = (FormOduncVerme)x;
                }
                f.uyeid = Convert.ToInt32(dataGridViewSec.Rows[e.RowIndex].Cells[0].Value);
                f.textBoxUyeAdi.Text = dataGridViewSec.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dataGridViewSec.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.uyepuan = Convert.ToInt32(dataGridViewSec.Rows[e.RowIndex].Cells[6].Value);
                f.uyedurum = Convert.ToInt32(dataGridViewSec.Rows[e.RowIndex].Cells[7].Value);
                this.Hide();
            }

            else if (secimid == 2)
            {
                foreach (Form _f in Application.OpenForms)
                {
                    if (_f.Name == "FormIslemler")
                        f = (FormOduncVerme)_f;
                }
                f.kutuphaneid = Convert.ToInt32(dataGridViewSec.Rows[e.RowIndex].Cells[0].Value);
                f.textBoxKutuphaneAdi.Text = dataGridViewSec.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Hide();
            }

            else if (secimid == 3)
            {

                if (Convert.ToInt32(dataGridViewSec.Rows[e.RowIndex].Cells[5].Value) == 0) MessageBox.Show("Seçtiğiniz kitap başka üyelere ödünç verildiği için elimizde hiç yok.\nLütfen başka bir kitap seçin.", "Bilgi");
                else
                {
                    foreach (Form _f in Application.OpenForms)
                    {
                        if (_f.Name == "FormIslemler")
                            f = (FormOduncVerme)_f;
                    }
                    f.kitapid = Convert.ToInt32(dataGridViewSec.Rows[e.RowIndex].Cells[0].Value);
                    f.textBoxKitapAdi.Text = dataGridViewSec.Rows[e.RowIndex].Cells[1].Value.ToString();
                    f.kitapAdet = Convert.ToInt32(dataGridViewSec.Rows[e.RowIndex].Cells[5].Value);
                    int gun = Convert.ToInt32(Convert.ToInt32(dataGridViewSec.Rows[e.RowIndex].Cells[2].Value) / 10);
                    f.dateTimePickerVerecegiTarih.Value = f.dateTimePickerVerecegiTarih.Value.AddDays(gun);
                    this.Hide();
                }

            }
        }

        private void textBoxIsim_TextChanged(object sender, EventArgs e)
        {
            if (secimid == 1)
            {
                SqlDataAdapter da = new SqlDataAdapter("select U.UyeId AS 'Üye ID', U.UyeAd AS 'Adı', U.UyeSoyad AS 'Soyadı', U.UyeCinsiyet AS 'Cinsiyet', U.UyeTelefon AS 'Telefon', U.UyeEPosta AS 'Eposta' from Uyeler U where U.UyeAd like '%' + '" + textBoxIsim.Text + "' + '%'", bag.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSec.DataSource = dt;
            }
            else if (secimid == 2)
            {
                SqlDataAdapter da = new SqlDataAdapter("select K.KutuphaneId AS 'ID', K.KutuphaneAdi AS 'Adı', A.AdresilAdi AS 'İl', Ai.AdresilceAdi AS 'İlçe', K.KutuphaneAdresTam AS 'Adres' from Kutuphane K inner join Adresil A on K.KutuphaneAdresilid = A.Adresilid inner join Adresilce Ai on K.KutuphaneAdresilceid = Ai.Adresilceid where K.KutuphaneAdi like '%' + '" + textBoxIsim.Text + "' + '%'", bag.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSec.DataSource = dt;
            }
            else if (secimid == 3)
            {
                foreach (Form x in Application.OpenForms)
                {
                    if (x.Name == "FormIslemler")
                        f = (FormOduncVerme)x;
                }

                SqlDataAdapter da = new SqlDataAdapter("select K.KitapISBN AS 'ISBN', K.KitapAdi AS 'Adı', K.KitapSayfa AS 'Sayfa', Y.YazarAdi+' '+Y.YazarSoyadi AS 'Yazar', Ya.YEAdi AS 'Yayınevi', Kk.Adet AS 'Adet' from Kutuphane_Kitap Kk inner join Kitap K on Kk.KitapISBN = K.KitapISBN inner join Yazar Y on K.KYazarId = Y.YazarId inner join Yayinevi Ya on K.KYEId = Ya.YEId where KutuphaneId =" + f.kutuphaneid + "and K.KitapAdi like '%' + '" + textBoxIsim.Text + "' + '%'", bag.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSec.DataSource = dt;
            }
        }
    }
}
