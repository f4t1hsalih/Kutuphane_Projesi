using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kutuphane_Projesi
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }

        private void FormAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonKitapIslemleri_Click(object sender, EventArgs e)
        {
            FormKitapKayit kitap = new FormKitapKayit();
            kitap.Show();
            this.Hide();
        }

        private void buttonKutuphaneIslemleri_Click(object sender, EventArgs e)
        {
            FormKutuphaneKayit kutuphane = new FormKutuphaneKayit();
            kutuphane.Show();
            this.Hide();
        }

        private void buttonUyeIslemleri_Click(object sender, EventArgs e)
        {
            FormUyeKayit uye = new FormUyeKayit();
            uye.Show();
            this.Hide();
        }

        private void buttonYayineviIslemleri_Click(object sender, EventArgs e)
        {
            FormYayineviKayit yayinevi = new FormYayineviKayit();
            yayinevi.Show();
            this.Hide();
        }

        private void buttonOduncIslemleri_Click(object sender, EventArgs e)
        {
            FormOduncVerme oduncverme = new FormOduncVerme();
            oduncverme.Show();
            this.Hide();
        }

        private void buttonYazar_Click(object sender, EventArgs e)
        {
            FormYazarKayit yazar = new FormYazarKayit();
            yazar.Show();
            this.Hide();
        }

        private void buttonTeslimAlma_Click(object sender, EventArgs e)
        {
            FormTeslimAlma teslimAlma = new FormTeslimAlma();
            teslimAlma.Show();
            this.Hide();
        }

        private void buttonKutuphaneKitap_Click(object sender, EventArgs e)
        {
            FormKutuphaneKitap kutuphaneKitap = new FormKutuphaneKitap();
            kutuphaneKitap.Show();
            this.Hide();
        }

        private void buttonKitapIslemleri_MouseLeave(object sender, EventArgs e)
        {
            buttonKitapIslemleri.Font = new Font(buttonKitapIslemleri.Font.Name, buttonKitapIslemleri.Font.Size, buttonKitapIslemleri.Font.Style ^ FontStyle.Bold);
        }

        private void buttonKitapIslemleri_MouseEnter(object sender, EventArgs e)
        {
            buttonKitapIslemleri.Font = new Font(buttonKitapIslemleri.Font.Name, buttonKitapIslemleri.Font.Size, buttonKitapIslemleri.Font.Style ^ FontStyle.Bold);
        }

        private void buttonKutuphaneIslemleri_MouseEnter(object sender, EventArgs e)
        {
            buttonKutuphaneIslemleri.Font = new Font(buttonKutuphaneIslemleri.Font.Name, buttonKutuphaneIslemleri.Font.Size, buttonKutuphaneIslemleri.Font.Style ^ FontStyle.Bold);
        }

        private void buttonKutuphaneIslemleri_MouseLeave(object sender, EventArgs e)
        {
            buttonKutuphaneIslemleri.Font = new Font(buttonKutuphaneIslemleri.Font.Name, buttonKutuphaneIslemleri.Font.Size, buttonKutuphaneIslemleri.Font.Style ^ FontStyle.Bold);
        }

        private void buttonYazar_MouseEnter(object sender, EventArgs e)
        {
            buttonYazar.Font = new Font(buttonYazar.Font.Name, buttonYazar.Font.Size, buttonYazar.Font.Style ^ FontStyle.Bold);
        }

        private void buttonYazar_MouseLeave(object sender, EventArgs e)
        {
            buttonYazar.Font = new Font(buttonYazar.Font.Name, buttonYazar.Font.Size, buttonYazar.Font.Style ^ FontStyle.Bold);
        }

        private void buttonUyeIslemleri_MouseEnter(object sender, EventArgs e)
        {
            buttonUyeIslemleri.Font = new Font(buttonUyeIslemleri.Font.Name, buttonUyeIslemleri.Font.Size, buttonUyeIslemleri.Font.Style ^ FontStyle.Bold);
        }

        private void buttonUyeIslemleri_MouseLeave(object sender, EventArgs e)
        {
            buttonUyeIslemleri.Font = new Font(buttonUyeIslemleri.Font.Name, buttonUyeIslemleri.Font.Size, buttonUyeIslemleri.Font.Style ^ FontStyle.Bold);
        }

        private void buttonYayineviIslemleri_MouseEnter(object sender, EventArgs e)
        {
            buttonYayineviIslemleri.Font = new Font(buttonYayineviIslemleri.Font.Name, buttonYayineviIslemleri.Font.Size, buttonYayineviIslemleri.Font.Style ^ FontStyle.Bold);
        }

        private void buttonYayineviIslemleri_MouseLeave(object sender, EventArgs e)
        {
            buttonYayineviIslemleri.Font = new Font(buttonYayineviIslemleri.Font.Name, buttonYayineviIslemleri.Font.Size, buttonYayineviIslemleri.Font.Style ^ FontStyle.Bold);
        }

        private void buttonOduncIslemleri_MouseEnter(object sender, EventArgs e)
        {
            buttonOduncIslemleri.Font = new Font(buttonOduncIslemleri.Font.Name, buttonOduncIslemleri.Font.Size, buttonOduncIslemleri.Font.Style ^ FontStyle.Bold);
        }

        private void buttonOduncIslemleri_MouseLeave(object sender, EventArgs e)
        {
            buttonOduncIslemleri.Font = new Font(buttonOduncIslemleri.Font.Name, buttonOduncIslemleri.Font.Size, buttonOduncIslemleri.Font.Style ^ FontStyle.Bold);
        }

        private void buttonKutuphaneKitap_MouseEnter(object sender, EventArgs e)
        {
            buttonKutuphaneKitap.Font= new Font(buttonKutuphaneKitap.Font.Name, buttonKutuphaneKitap.Font.Size, buttonKutuphaneKitap.Font.Style ^ FontStyle.Bold);
        }

        private void buttonKutuphaneKitap_MouseLeave(object sender, EventArgs e)
        {
            buttonKutuphaneKitap.Font = new Font(buttonKutuphaneKitap.Font.Name, buttonKutuphaneKitap.Font.Size, buttonKutuphaneKitap.Font.Style ^ FontStyle.Bold);
        }

        private void buttonTeslimAlma_MouseEnter(object sender, EventArgs e)
        {
            buttonTeslimAlma.Font = new Font(buttonTeslimAlma.Font.Name, buttonTeslimAlma.Font.Size, buttonTeslimAlma.Font.Style ^ FontStyle.Bold);
        }

        private void buttonTeslimAlma_MouseLeave(object sender, EventArgs e)
        {
            buttonTeslimAlma.Font = new Font(buttonTeslimAlma.Font.Name, buttonTeslimAlma.Font.Size, buttonTeslimAlma.Font.Style ^ FontStyle.Bold);
        }
    }
}
