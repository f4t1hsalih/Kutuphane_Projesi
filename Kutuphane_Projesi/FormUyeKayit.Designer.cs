namespace Kutuphane_Projesi
{
    partial class FormUyeKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeKayit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonIstatistik = new System.Windows.Forms.Button();
            this.buttonGoruntule = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUyeler = new System.Windows.Forms.DataGridView();
            this.UyeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeEPosta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresilAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresilceAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeAdresTam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeAdresilid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeAdresilceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.comboBoxAilce = new System.Windows.Forms.ComboBox();
            this.comboBoxAil = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBoxATam = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.maskedTextBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonKadin = new System.Windows.Forms.RadioButton();
            this.radioButtonErkek = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUyeler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(324, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonIstatistik);
            this.groupBox3.Controls.Add(this.buttonGoruntule);
            this.groupBox3.Controls.Add(this.buttonSil);
            this.groupBox3.Controls.Add(this.buttonGuncelle);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(297, 188);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 208);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diğer Seçenekler";
            // 
            // buttonIstatistik
            // 
            this.buttonIstatistik.Image = ((System.Drawing.Image)(resources.GetObject("buttonIstatistik.Image")));
            this.buttonIstatistik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIstatistik.Location = new System.Drawing.Point(6, 152);
            this.buttonIstatistik.Name = "buttonIstatistik";
            this.buttonIstatistik.Size = new System.Drawing.Size(175, 33);
            this.buttonIstatistik.TabIndex = 4;
            this.buttonIstatistik.Text = "İstatistikler";
            this.buttonIstatistik.UseVisualStyleBackColor = true;
            this.buttonIstatistik.Click += new System.EventHandler(this.buttonIstatistik_Click);
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
            this.groupBox2.Controls.Add(this.dataGridViewUyeler);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(498, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 384);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üyeler";
            // 
            // dataGridViewUyeler
            // 
            this.dataGridViewUyeler.AllowUserToDeleteRows = false;
            this.dataGridViewUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUyeler.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUyeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UyeId,
            this.UyeAd,
            this.UyeSoyad,
            this.UyeCinsiyet,
            this.UyeTelefon,
            this.UyeEPosta,
            this.AdresilAdi,
            this.AdresilceAdi,
            this.UyeAdresTam,
            this.UyeAdresilid,
            this.UyeAdresilceid});
            this.dataGridViewUyeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUyeler.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewUyeler.MultiSelect = false;
            this.dataGridViewUyeler.Name = "dataGridViewUyeler";
            this.dataGridViewUyeler.ReadOnly = true;
            this.dataGridViewUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUyeler.Size = new System.Drawing.Size(731, 361);
            this.dataGridViewUyeler.TabIndex = 0;
            this.dataGridViewUyeler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUyeler_CellDoubleClick);
            // 
            // UyeId
            // 
            this.UyeId.DataPropertyName = "UyeId";
            this.UyeId.HeaderText = "Column1";
            this.UyeId.Name = "UyeId";
            this.UyeId.ReadOnly = true;
            this.UyeId.Visible = false;
            // 
            // UyeAd
            // 
            this.UyeAd.DataPropertyName = "UyeAd";
            this.UyeAd.HeaderText = "Ad";
            this.UyeAd.Name = "UyeAd";
            this.UyeAd.ReadOnly = true;
            // 
            // UyeSoyad
            // 
            this.UyeSoyad.DataPropertyName = "UyeSoyad";
            this.UyeSoyad.HeaderText = "Soyad";
            this.UyeSoyad.Name = "UyeSoyad";
            this.UyeSoyad.ReadOnly = true;
            // 
            // UyeCinsiyet
            // 
            this.UyeCinsiyet.DataPropertyName = "UyeCinsiyet";
            this.UyeCinsiyet.HeaderText = "Cinsiyet";
            this.UyeCinsiyet.Name = "UyeCinsiyet";
            this.UyeCinsiyet.ReadOnly = true;
            // 
            // UyeTelefon
            // 
            this.UyeTelefon.DataPropertyName = "UyeTelefon";
            this.UyeTelefon.HeaderText = "Telefon";
            this.UyeTelefon.Name = "UyeTelefon";
            this.UyeTelefon.ReadOnly = true;
            // 
            // UyeEPosta
            // 
            this.UyeEPosta.DataPropertyName = "UyeEPosta";
            this.UyeEPosta.HeaderText = "E-posta";
            this.UyeEPosta.Name = "UyeEPosta";
            this.UyeEPosta.ReadOnly = true;
            // 
            // AdresilAdi
            // 
            this.AdresilAdi.DataPropertyName = "AdresilAdi";
            this.AdresilAdi.HeaderText = "Adres İl";
            this.AdresilAdi.Name = "AdresilAdi";
            this.AdresilAdi.ReadOnly = true;
            // 
            // AdresilceAdi
            // 
            this.AdresilceAdi.DataPropertyName = "AdresilceAdi";
            this.AdresilceAdi.HeaderText = "Adres İlçe";
            this.AdresilceAdi.Name = "AdresilceAdi";
            this.AdresilceAdi.ReadOnly = true;
            // 
            // UyeAdresTam
            // 
            this.UyeAdresTam.DataPropertyName = "UyeAdresTam";
            this.UyeAdresTam.HeaderText = "Adres Tam";
            this.UyeAdresTam.Name = "UyeAdresTam";
            this.UyeAdresTam.ReadOnly = true;
            // 
            // UyeAdresilid
            // 
            this.UyeAdresilid.DataPropertyName = "UyeAdresilid";
            this.UyeAdresilid.HeaderText = "Column1";
            this.UyeAdresilid.Name = "UyeAdresilid";
            this.UyeAdresilid.ReadOnly = true;
            this.UyeAdresilid.Visible = false;
            // 
            // UyeAdresilceid
            // 
            this.UyeAdresilceid.DataPropertyName = "UyeAdresilceid";
            this.UyeAdresilceid.HeaderText = "Column1";
            this.UyeAdresilceid.Name = "UyeAdresilceid";
            this.UyeAdresilceid.ReadOnly = true;
            this.UyeAdresilceid.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSoyad);
            this.groupBox1.Controls.Add(this.comboBoxAilce);
            this.groupBox1.Controls.Add(this.comboBoxAil);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonTemizle);
            this.groupBox1.Controls.Add(this.maskedTextBoxTel);
            this.groupBox1.Controls.Add(this.radioButtonKadin);
            this.groupBox1.Controls.Add(this.radioButtonErkek);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxMail);
            this.groupBox1.Controls.Add(this.textBoxAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 384);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye Kayıt";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(146, 54);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(121, 25);
            this.textBoxSoyad.TabIndex = 2;
            // 
            // comboBoxAilce
            // 
            this.comboBoxAilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAilce.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAilce.FormattingEnabled = true;
            this.comboBoxAilce.Location = new System.Drawing.Point(146, 202);
            this.comboBoxAilce.Name = "comboBoxAilce";
            this.comboBoxAilce.Size = new System.Drawing.Size(121, 25);
            this.comboBoxAilce.TabIndex = 8;
            this.comboBoxAilce.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxAilce_MouseClick);
            // 
            // comboBoxAil
            // 
            this.comboBoxAil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAil.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAil.FormattingEnabled = true;
            this.comboBoxAil.Location = new System.Drawing.Point(146, 171);
            this.comboBoxAil.Name = "comboBoxAil";
            this.comboBoxAil.Size = new System.Drawing.Size(121, 25);
            this.comboBoxAil.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBoxATam);
            this.groupBox4.Location = new System.Drawing.Point(11, 231);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(256, 108);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adres Tam:";
            // 
            // richTextBoxATam
            // 
            this.richTextBoxATam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxATam.Location = new System.Drawing.Point(3, 20);
            this.richTextBoxATam.Name = "richTextBoxATam";
            this.richTextBoxATam.Size = new System.Drawing.Size(250, 85);
            this.richTextBoxATam.TabIndex = 1;
            this.richTextBoxATam.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Adres İlçe:";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("buttonKaydet.Image")));
            this.buttonKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKaydet.Location = new System.Drawing.Point(168, 348);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(78, 30);
            this.buttonKaydet.TabIndex = 10;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Adres İl:";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTemizle.Location = new System.Drawing.Point(45, 348);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(82, 30);
            this.buttonTemizle.TabIndex = 11;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // maskedTextBoxTel
            // 
            this.maskedTextBoxTel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBoxTel.Location = new System.Drawing.Point(146, 109);
            this.maskedTextBoxTel.Mask = "(999) 000-0000";
            this.maskedTextBoxTel.Name = "maskedTextBoxTel";
            this.maskedTextBoxTel.Size = new System.Drawing.Size(121, 25);
            this.maskedTextBoxTel.TabIndex = 5;
            // 
            // radioButtonKadin
            // 
            this.radioButtonKadin.AutoSize = true;
            this.radioButtonKadin.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonKadin.Location = new System.Drawing.Point(208, 82);
            this.radioButtonKadin.Name = "radioButtonKadin";
            this.radioButtonKadin.Size = new System.Drawing.Size(59, 21);
            this.radioButtonKadin.TabIndex = 4;
            this.radioButtonKadin.TabStop = true;
            this.radioButtonKadin.Text = "Kadın";
            this.radioButtonKadin.UseVisualStyleBackColor = true;
            // 
            // radioButtonErkek
            // 
            this.radioButtonErkek.AutoSize = true;
            this.radioButtonErkek.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButtonErkek.Location = new System.Drawing.Point(145, 82);
            this.radioButtonErkek.Name = "radioButtonErkek";
            this.radioButtonErkek.Size = new System.Drawing.Size(57, 21);
            this.radioButtonErkek.TabIndex = 3;
            this.radioButtonErkek.TabStop = true;
            this.radioButtonErkek.Text = "Erkek";
            this.radioButtonErkek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label1.Location = new System.Drawing.Point(104, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "E Posta Adresi:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxMail.Location = new System.Drawing.Point(146, 140);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(121, 25);
            this.textBoxMail.TabIndex = 6;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(146, 23);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(121, 25);
            this.textBoxAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet:";
            // 
            // FormUyeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1247, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 447);
            this.MinimumSize = new System.Drawing.Size(1155, 447);
            this.Name = "FormUyeKayit";
            this.Text = "Üye İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUyeKayit_FormClosed);
            this.Load += new System.EventHandler(this.FormUyeKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUyeler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonIstatistik;
        private System.Windows.Forms.Button buttonGoruntule;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewUyeler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAilce;
        private System.Windows.Forms.ComboBox comboBoxAil;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBoxATam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTel;
        private System.Windows.Forms.RadioButton radioButtonKadin;
        private System.Windows.Forms.RadioButton radioButtonErkek;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeEPosta;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresilAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresilceAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeAdresTam;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeAdresilid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeAdresilceid;
    }
}