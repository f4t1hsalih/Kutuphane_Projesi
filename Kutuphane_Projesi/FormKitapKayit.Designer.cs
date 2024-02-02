namespace Kutuphane_Projesi
{
    partial class FormKitapKayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitapKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKitapAd = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxSayfaSayisi = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxKitapISBN = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxYayinevi = new System.Windows.Forms.ComboBox();
            this.comboBoxKitapYazar = new System.Windows.Forms.ComboBox();
            this.comboBoxTur = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewKitaplar = new System.Windows.Forms.DataGridView();
            this.KitapISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapSayfa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TurAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YazarAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonIstatistik = new System.Windows.Forms.Button();
            this.buttonGoruntule = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitabın Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitabın Türü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitabın Yazarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitabın Sayfa Sayısı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kitabın Yayınevi:";
            // 
            // textBoxKitapAd
            // 
            this.textBoxKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKitapAd.Location = new System.Drawing.Point(156, 51);
            this.textBoxKitapAd.Name = "textBoxKitapAd";
            this.textBoxKitapAd.Size = new System.Drawing.Size(117, 22);
            this.textBoxKitapAd.TabIndex = 2;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.Transparent;
            this.buttonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("buttonKaydet.Image")));
            this.buttonKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKaydet.Location = new System.Drawing.Point(175, 197);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(78, 30);
            this.buttonKaydet.TabIndex = 7;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTemizle.Location = new System.Drawing.Point(49, 197);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(82, 30);
            this.buttonTemizle.TabIndex = 8;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBoxSayfaSayisi);
            this.groupBox1.Controls.Add(this.maskedTextBoxKitapISBN);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxYayinevi);
            this.groupBox1.Controls.Add(this.comboBoxKitapYazar);
            this.groupBox1.Controls.Add(this.comboBoxTur);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonTemizle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxKitapAd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Kayıt";
            // 
            // maskedTextBoxSayfaSayisi
            // 
            this.maskedTextBoxSayfaSayisi.Location = new System.Drawing.Point(156, 79);
            this.maskedTextBoxSayfaSayisi.Mask = "0000";
            this.maskedTextBoxSayfaSayisi.Name = "maskedTextBoxSayfaSayisi";
            this.maskedTextBoxSayfaSayisi.Size = new System.Drawing.Size(117, 24);
            this.maskedTextBoxSayfaSayisi.TabIndex = 5;
            this.maskedTextBoxSayfaSayisi.ValidatingType = typeof(int);
            // 
            // maskedTextBoxKitapISBN
            // 
            this.maskedTextBoxKitapISBN.Location = new System.Drawing.Point(156, 21);
            this.maskedTextBoxKitapISBN.Mask = "0000000000000";
            this.maskedTextBoxKitapISBN.Name = "maskedTextBoxKitapISBN";
            this.maskedTextBoxKitapISBN.Size = new System.Drawing.Size(117, 24);
            this.maskedTextBoxKitapISBN.TabIndex = 1;
            this.maskedTextBoxKitapISBN.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Kitabın ISBN:";
            // 
            // comboBoxYayinevi
            // 
            this.comboBoxYayinevi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYayinevi.DropDownWidth = 170;
            this.comboBoxYayinevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxYayinevi.FormattingEnabled = true;
            this.comboBoxYayinevi.Location = new System.Drawing.Point(156, 169);
            this.comboBoxYayinevi.Name = "comboBoxYayinevi";
            this.comboBoxYayinevi.Size = new System.Drawing.Size(117, 24);
            this.comboBoxYayinevi.TabIndex = 6;
            // 
            // comboBoxKitapYazar
            // 
            this.comboBoxKitapYazar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKitapYazar.DropDownWidth = 150;
            this.comboBoxKitapYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxKitapYazar.FormattingEnabled = true;
            this.comboBoxKitapYazar.Location = new System.Drawing.Point(156, 139);
            this.comboBoxKitapYazar.Name = "comboBoxKitapYazar";
            this.comboBoxKitapYazar.Size = new System.Drawing.Size(117, 24);
            this.comboBoxKitapYazar.TabIndex = 4;
            // 
            // comboBoxTur
            // 
            this.comboBoxTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxTur.FormattingEnabled = true;
            this.comboBoxTur.Location = new System.Drawing.Point(156, 109);
            this.comboBoxTur.Name = "comboBoxTur";
            this.comboBoxTur.Size = new System.Drawing.Size(117, 24);
            this.comboBoxTur.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewKitaplar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 294);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitaplar";
            // 
            // dataGridViewKitaplar
            // 
            this.dataGridViewKitaplar.AllowUserToDeleteRows = false;
            this.dataGridViewKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKitaplar.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKitaplar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KitapISBN,
            this.KitapAdi,
            this.KitapSayfa,
            this.TurAdi,
            this.YazarAdi,
            this.YEAdi});
            this.dataGridViewKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKitaplar.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewKitaplar.MultiSelect = false;
            this.dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            this.dataGridViewKitaplar.ReadOnly = true;
            this.dataGridViewKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKitaplar.Size = new System.Drawing.Size(654, 271);
            this.dataGridViewKitaplar.TabIndex = 0;
            this.dataGridViewKitaplar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKitaplar_CellDoubleClick);
            // 
            // KitapISBN
            // 
            this.KitapISBN.DataPropertyName = "KitapISBN";
            this.KitapISBN.HeaderText = "ISBN";
            this.KitapISBN.Name = "KitapISBN";
            this.KitapISBN.ReadOnly = true;
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "Ad";
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.ReadOnly = true;
            // 
            // KitapSayfa
            // 
            this.KitapSayfa.DataPropertyName = "KitapSayfa";
            this.KitapSayfa.HeaderText = "Sayfa Sayısı";
            this.KitapSayfa.Name = "KitapSayfa";
            this.KitapSayfa.ReadOnly = true;
            // 
            // TurAdi
            // 
            this.TurAdi.DataPropertyName = "TurAdi";
            this.TurAdi.HeaderText = "Tür";
            this.TurAdi.Name = "TurAdi";
            this.TurAdi.ReadOnly = true;
            // 
            // YazarAdi
            // 
            this.YazarAdi.DataPropertyName = "YazarAdi";
            this.YazarAdi.HeaderText = "Yazar";
            this.YazarAdi.Name = "YazarAdi";
            this.YazarAdi.ReadOnly = true;
            // 
            // YEAdi
            // 
            this.YEAdi.DataPropertyName = "YEAdi";
            this.YEAdi.HeaderText = "Yayınevi";
            this.YEAdi.Name = "YEAdi";
            this.YEAdi.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonIstatistik);
            this.groupBox3.Controls.Add(this.buttonGoruntule);
            this.groupBox3.Controls.Add(this.buttonSil);
            this.groupBox3.Controls.Add(this.buttonGuncelle);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(297, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diğer Seçenekler";
            // 
            // buttonIstatistik
            // 
            this.buttonIstatistik.BackColor = System.Drawing.Color.Transparent;
            this.buttonIstatistik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonIstatistik.Image = ((System.Drawing.Image)(resources.GetObject("buttonIstatistik.Image")));
            this.buttonIstatistik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIstatistik.Location = new System.Drawing.Point(6, 152);
            this.buttonIstatistik.Name = "buttonIstatistik";
            this.buttonIstatistik.Size = new System.Drawing.Size(175, 33);
            this.buttonIstatistik.TabIndex = 4;
            this.buttonIstatistik.Text = "İstatistikler";
            this.buttonIstatistik.UseVisualStyleBackColor = false;
            this.buttonIstatistik.Click += new System.EventHandler(this.buttonIstatistik_Click);
            // 
            // buttonGoruntule
            // 
            this.buttonGoruntule.BackColor = System.Drawing.Color.Transparent;
            this.buttonGoruntule.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGoruntule.Image = ((System.Drawing.Image)(resources.GetObject("buttonGoruntule.Image")));
            this.buttonGoruntule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoruntule.Location = new System.Drawing.Point(6, 35);
            this.buttonGoruntule.Name = "buttonGoruntule";
            this.buttonGoruntule.Size = new System.Drawing.Size(175, 33);
            this.buttonGoruntule.TabIndex = 1;
            this.buttonGoruntule.Text = "Görüntüle";
            this.buttonGoruntule.UseVisualStyleBackColor = false;
            this.buttonGoruntule.Click += new System.EventHandler(this.buttonGoruntule_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.Transparent;
            this.buttonSil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSil.Image = ((System.Drawing.Image)(resources.GetObject("buttonSil.Image")));
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.Location = new System.Drawing.Point(6, 113);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(175, 33);
            this.buttonSil.TabIndex = 3;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuncelle.Image")));
            this.buttonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuncelle.Location = new System.Drawing.Point(6, 74);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(175, 33);
            this.buttonGuncelle.TabIndex = 2;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(490, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormKitapKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(684, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 800);
            this.MinimumSize = new System.Drawing.Size(700, 590);
            this.Name = "FormKitapKayit";
            this.Text = "Kitap İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKitapKayit_FormClosed);
            this.Load += new System.EventHandler(this.FormKitapKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKitaplar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKitapAd;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewKitaplar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIstatistik;
        private System.Windows.Forms.Button buttonGoruntule;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxTur;
        private System.Windows.Forms.ComboBox comboBoxKitapYazar;
        private System.Windows.Forms.ComboBox comboBoxYayinevi;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKitapISBN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSayfaSayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapSayfa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TurAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YazarAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAdi;
    }
}