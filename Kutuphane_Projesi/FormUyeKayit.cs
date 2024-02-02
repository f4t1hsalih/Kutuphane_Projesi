using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormUyeKayit : Form
    {
        public FormUyeKayit()
        {
            InitializeComponent();
        }

        ClassBaglanti bag = new ClassBaglanti();
        int id = 0;

        void Temizle()
        {
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            radioButtonErkek.Checked = false;
            radioButtonKadin.Checked = false;
            maskedTextBoxTel.Clear();
            textBoxMail.Clear();
            comboBoxAil.SelectedIndex = 0;
            comboBoxAilce.Text = "";
            richTextBoxATam.Clear();
            id = 0;
        }
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select U.UyeId,U.UyeAd,U.UyeSoyad, U.UyeCinsiyet,U.UyeTelefon,U.UyeEPosta,A.AdresilAdi,Al.AdresilceAdi,U.UyeAdresTam,U.UyeAdresilid,U.UyeAdresilceid from Uyeler U inner join Adresil A on U.UyeAdresilid=A.Adresilid inner join Adresilce Al on U.UyeAdresilceid=Al.Adresilceid ", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridViewUyeler.DataSource = dt;
        }

        private void FormUyeKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Uyeler(UyeAd,UyeSoyad,UyeCinsiyet,UyeTelefon,UyeEPosta,UyeAdresilid,UyeAdresilceid,UyeAdresTam) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", textBoxAd.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            if (radioButtonErkek.Checked) komut.Parameters.AddWithValue("@p3", radioButtonErkek.Text);
            else if (radioButtonKadin.Checked) komut.Parameters.AddWithValue("@p3", radioButtonKadin.Text);
            else komut.Parameters.AddWithValue("@p3", "");
            komut.Parameters.AddWithValue("@p4", maskedTextBoxTel.Text);
            komut.Parameters.AddWithValue("@p5", textBoxMail.Text);
            komut.Parameters.AddWithValue("@p6", comboBoxAil.SelectedValue);
            komut.Parameters.AddWithValue("@p7", comboBoxAilce.SelectedValue);
            komut.Parameters.AddWithValue("@p8", richTextBoxATam.Text);
            komut.ExecuteNonQuery();
            bag.baglanti().Close();
            MessageBox.Show("Üye Başarıyla Kaydedildi", "Bilgi");
            Temizle();
            Listele();
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void FormUyeKayit_Load(object sender, EventArgs e)
        {
            Listele();
            SqlDataAdapter da = new SqlDataAdapter("select * from Adresil", bag.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxAil.DataSource = dt;
            comboBoxAil.DisplayMember = "AdresilAdi";
            comboBoxAil.ValueMember = "Adresilid";
        }

        private void comboBoxAilce_MouseClick(object sender, MouseEventArgs e)
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

        private void buttonGoruntule_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {

            if (id != 0)
            {
                SqlCommand komut = new SqlCommand("update Uyeler set UyeAd = @p2, UyeSoyad = @p3, UyeCinsiyet = @p4, UyeTelefon = @p5, UyeEPosta = @p6, UyeAdresilid = @p7, UyeAdresilceid = @p8, UyeAdresTam = @p9 where UyeId = @p1", bag.baglanti());
                komut.Parameters.AddWithValue("@p1", id);
                komut.Parameters.AddWithValue("@p2", textBoxAd.Text);
                komut.Parameters.AddWithValue("@p3", textBoxSoyad.Text);
                if (radioButtonErkek.Checked) komut.Parameters.AddWithValue("@p4", radioButtonErkek.Text);
                else if (radioButtonKadin.Checked) komut.Parameters.AddWithValue("@p4", radioButtonKadin.Text);
                else komut.Parameters.AddWithValue("@p4", "");
                komut.Parameters.AddWithValue("@p5", maskedTextBoxTel.Text);
                komut.Parameters.AddWithValue("@p6", textBoxMail.Text);
                komut.Parameters.AddWithValue("@p7", comboBoxAil.SelectedValue);
                komut.Parameters.AddWithValue("@p8", comboBoxAilce.SelectedValue);
                komut.Parameters.AddWithValue("@p9", richTextBoxATam.Text);
                komut.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Üye Bigileri Güncellendi", "Bilgi");
                Temizle();
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Kayıt Seçin");
            }

        }

        private void dataGridViewUyeler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select Adresilceid,AdresilceAdi from Adresilce where Adresilid=" + dataGridViewUyeler.Rows[e.RowIndex].Cells[9].Value, bag.baglanti());
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBoxAilce.DisplayMember = "AdresilceAdi";
            comboBoxAilce.ValueMember = "Adresilceid";
            comboBoxAilce.DataSource = dt2;

            id = Convert.ToInt32(dataGridViewUyeler.Rows[e.RowIndex].Cells[0].Value);
            textBoxAd.Text = dataGridViewUyeler.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxSoyad.Text = dataGridViewUyeler.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridViewUyeler.Rows[e.RowIndex].Cells[3].Value.ToString() == "Erkek") radioButtonErkek.Checked = true;
            else if (dataGridViewUyeler.Rows[e.RowIndex].Cells[3].Value.ToString() == "Kadın") radioButtonKadin.Checked = true;
            else
            {
                radioButtonErkek.Checked = false;
                radioButtonKadin.Checked = false;
            }
            maskedTextBoxTel.Text = dataGridViewUyeler.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxMail.Text = dataGridViewUyeler.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBoxAil.SelectedValue = Convert.ToInt32(dataGridViewUyeler.Rows[e.RowIndex].Cells[9].Value);
            comboBoxAilce.SelectedValue = Convert.ToInt32(dataGridViewUyeler.Rows[e.RowIndex].Cells[10].Value);
            richTextBoxATam.Text = dataGridViewUyeler.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                SqlCommand komut = new SqlCommand("delete from Uyeler where UyeId=@p1", bag.baglanti());
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

        private void buttonIstatistik_Click(object sender, EventArgs e)
        {
            FormUyeIstatistik uyeIstatistik = new FormUyeIstatistik();
            uyeIstatistik.Show();
            this.Hide();
        }
    }
}
