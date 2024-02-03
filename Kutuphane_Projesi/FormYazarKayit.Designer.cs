namespace Kutuphane_Projesi
{
    partial class FormYazarKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYazarKayit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonIstatistikler = new System.Windows.Forms.Button();
            this.buttonGoruntule = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewYazarlar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDTarihi = new System.Windows.Forms.DateTimePicker();
            this.radioButtonKadin = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.YazarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YazarAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YazarSoyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YazarCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YazarDogumTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YazarSilinme = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYazarlar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(471, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonIstatistikler);
            this.groupBox3.Controls.Add(this.buttonGoruntule);
            this.groupBox3.Controls.Add(this.buttonSil);
            this.groupBox3.Controls.Add(this.buttonGuncelle);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(268, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diğer Seçenekler";
            // 
            // buttonIstatistikler
            // 
            this.buttonIstatistikler.Image = ((System.Drawing.Image)(resources.GetObject("buttonIstatistikler.Image")));
            this.buttonIstatistikler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIstatistikler.Location = new System.Drawing.Point(6, 152);
            this.buttonIstatistikler.Name = "buttonIstatistikler";
            this.buttonIstatistikler.Size = new System.Drawing.Size(175, 33);
            this.buttonIstatistikler.TabIndex = 4;
            this.buttonIstatistikler.Text = "İstatistikler";
            this.buttonIstatistikler.UseVisualStyleBackColor = true;
            this.buttonIstatistikler.Click += new System.EventHandler(this.buttonIstatistikler_Click);
            // 
            // buttonGoruntule
            // 
            this.buttonGoruntule.Image = ((System.Drawing.Image)(resources.GetObject("buttonGoruntule.Image")));
            this.buttonGoruntule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoruntule.Location = new System.Drawing.Point(6, 35);
            this.buttonGoruntule.Name = "buttonGoruntule";
            this.buttonGoruntule.Size = new System.Drawing.Size(175, 33);
            this.buttonGoruntule.TabIndex = 1;
            this.buttonGoruntule.Text = "Görüntüle";
            this.buttonGoruntule.UseVisualStyleBackColor = true;
            this.buttonGoruntule.Click += new System.EventHandler(this.buttonGoruntule_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Image = ((System.Drawing.Image)(resources.GetObject("buttonSil.Image")));
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.Location = new System.Drawing.Point(6, 113);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(175, 33);
            this.buttonSil.TabIndex = 3;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuncelle.Image")));
            this.buttonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuncelle.Location = new System.Drawing.Point(6, 74);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(175, 33);
            this.buttonGuncelle.TabIndex = 2;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewYazarlar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 329);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yazarlar";
            // 
            // dataGridViewYazarlar
            // 
            this.dataGridViewYazarlar.AllowUserToDeleteRows = false;
            this.dataGridViewYazarlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewYazarlar.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYazarlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.YazarId,
            this.YazarAdi,
            this.YazarSoyadi,
            this.YazarCinsiyet,
            this.YazarDogumTarihi,
            this.YazarSilinme});
            this.dataGridViewYazarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewYazarlar.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewYazarlar.MultiSelect = false;
            this.dataGridViewYazarlar.Name = "dataGridViewYazarlar";
            this.dataGridViewYazarlar.ReadOnly = true;
            this.dataGridViewYazarlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewYazarlar.Size = new System.Drawing.Size(638, 306);
            this.dataGridViewYazarlar.TabIndex = 1;
            this.dataGridViewYazarlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewYazarlar_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerDTarihi);
            this.groupBox1.Controls.Add(this.radioButtonKadin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButtonErkek);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTemizle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSoyad);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.textBoxAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 206);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazar Kayıt";
            // 
            // dateTimePickerDTarihi
            // 
            this.dateTimePickerDTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDTarihi.Location = new System.Drawing.Point(114, 76);
            this.dateTimePickerDTarihi.Name = "dateTimePickerDTarihi";
            this.dateTimePickerDTarihi.Size = new System.Drawing.Size(125, 24);
            this.dateTimePickerDTarihi.TabIndex = 3;
            this.dateTimePickerDTarihi.Value = new System.DateTime(2023, 5, 8, 20, 47, 49, 0);
            // 
            // radioButtonKadin
            // 
            this.radioButtonKadin.AutoSize = true;
            this.radioButtonKadin.Location = new System.Drawing.Point(179, 106);
            this.radioButtonKadin.Name = "radioButtonKadin";
            this.radioButtonKadin.Size = new System.Drawing.Size(63, 22);
            this.radioButtonKadin.TabIndex = 5;
            this.radioButtonKadin.TabStop = true;
            this.radioButtonKadin.Text = "Kadın";
            this.radioButtonKadin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cinsiyeti:";
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Location = new System.Drawing.Point(110, 106);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(65, 22);
            this.radioButtonErkek.TabIndex = 4;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTemizle.Location = new System.Drawing.Point(31, 153);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(82, 30);
            this.buttonTemizle.TabIndex = 7;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(48, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(114, 48);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(125, 22);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("buttonKaydet.Image")));
            this.buttonKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKaydet.Location = new System.Drawing.Point(148, 152);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(78, 30);
            this.buttonKaydet.TabIndex = 6;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(114, 20);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(125, 22);
            this.textBoxAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(2, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // YazarId
            // 
            this.YazarId.DataPropertyName = "YazarId";
            this.YazarId.HeaderText = "ID";
            this.YazarId.Name = "YazarId";
            this.YazarId.ReadOnly = true;
            this.YazarId.Visible = false;
            // 
            // YazarAdi
            // 
            this.YazarAdi.DataPropertyName = "YazarAdi";
            this.YazarAdi.HeaderText = "Ad";
            this.YazarAdi.Name = "YazarAdi";
            this.YazarAdi.ReadOnly = true;
            // 
            // YazarSoyadi
            // 
            this.YazarSoyadi.DataPropertyName = "YazarSoyadi";
            this.YazarSoyadi.HeaderText = "Soyad";
            this.YazarSoyadi.Name = "YazarSoyadi";
            this.YazarSoyadi.ReadOnly = true;
            // 
            // YazarCinsiyet
            // 
            this.YazarCinsiyet.DataPropertyName = "YazarCinsiyet";
            this.YazarCinsiyet.HeaderText = "Cinsiyet";
            this.YazarCinsiyet.Name = "YazarCinsiyet";
            this.YazarCinsiyet.ReadOnly = true;
            // 
            // YazarDogumTarihi
            // 
            this.YazarDogumTarihi.DataPropertyName = "YazarDogumTarihi";
            this.YazarDogumTarihi.HeaderText = "Doğum Tarihi";
            this.YazarDogumTarihi.Name = "YazarDogumTarihi";
            this.YazarDogumTarihi.ReadOnly = true;
            // 
            // YazarSilinme
            // 
            this.YazarSilinme.DataPropertyName = "YazarSilinme";
            this.YazarSilinme.HeaderText = "Yazar Silinme";
            this.YazarSilinme.Name = "YazarSilinme";
            this.YazarSilinme.ReadOnly = true;
            this.YazarSilinme.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.YazarSilinme.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.YazarSilinme.Visible = false;
            // 
            // FormYazarKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(668, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(684, 750);
            this.MinimumSize = new System.Drawing.Size(684, 604);
            this.Name = "FormYazarKayit";
            this.Text = "Yazar İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormYazarKayit_FormClosed);
            this.Load += new System.EventHandler(this.FormYazarKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYazarlar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIstatistikler;
        private System.Windows.Forms.Button buttonGoruntule;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewYazarlar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDTarihi;
        private System.Windows.Forms.RadioButton radioButtonKadin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn YazarId;
        private System.Windows.Forms.DataGridViewTextBoxColumn YazarAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YazarSoyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YazarCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn YazarDogumTarihi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YazarSilinme;
    }
}