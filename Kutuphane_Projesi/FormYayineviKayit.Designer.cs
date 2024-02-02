namespace Kutuphane_Projesi
{
    partial class FormYayineviKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYayineviKayit));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxATam = new System.Windows.Forms.RichTextBox();
            this.comboBoxAilce = new System.Windows.Forms.ComboBox();
            this.comboBoxAil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerKurulusTarih = new System.Windows.Forms.DateTimePicker();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKurucu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewYayinevi = new System.Windows.Forms.DataGridView();
            this.YEId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEKurucusu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEKurulusTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresilAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresilceAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAdresTam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAdresilid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEAdresilceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonIstatistik = new System.Windows.Forms.Button();
            this.buttonGoruntule = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYayinevi)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.comboBoxAilce);
            this.groupBox1.Controls.Add(this.comboBoxAil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerKurulusTarih);
            this.groupBox1.Controls.Add(this.buttonTemizle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxKurucu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yayınevi Kayıt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxATam);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.groupBox2.Location = new System.Drawing.Point(10, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 127);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tam Adres:";
            // 
            // richTextBoxATam
            // 
            this.richTextBoxATam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxATam.Location = new System.Drawing.Point(3, 25);
            this.richTextBoxATam.Name = "richTextBoxATam";
            this.richTextBoxATam.Size = new System.Drawing.Size(257, 99);
            this.richTextBoxATam.TabIndex = 0;
            this.richTextBoxATam.Text = "";
            // 
            // comboBoxAilce
            // 
            this.comboBoxAilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAilce.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAilce.FormattingEnabled = true;
            this.comboBoxAilce.Location = new System.Drawing.Point(120, 143);
            this.comboBoxAilce.Name = "comboBoxAilce";
            this.comboBoxAilce.Size = new System.Drawing.Size(142, 25);
            this.comboBoxAilce.TabIndex = 5;
            this.comboBoxAilce.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxAilce_MouseClick);
            // 
            // comboBoxAil
            // 
            this.comboBoxAil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAil.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAil.FormattingEnabled = true;
            this.comboBoxAil.Location = new System.Drawing.Point(120, 112);
            this.comboBoxAil.Name = "comboBoxAil";
            this.comboBoxAil.Size = new System.Drawing.Size(142, 25);
            this.comboBoxAil.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(78, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // dateTimePickerKurulusTarih
            // 
            this.dateTimePickerKurulusTarih.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerKurulusTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerKurulusTarih.Location = new System.Drawing.Point(120, 81);
            this.dateTimePickerKurulusTarih.Name = "dateTimePickerKurulusTarih";
            this.dateTimePickerKurulusTarih.Size = new System.Drawing.Size(142, 25);
            this.dateTimePickerKurulusTarih.TabIndex = 3;
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTemizle.Location = new System.Drawing.Point(40, 307);
            this.buttonTemizle.Name = "buttonTemizle";
            this.buttonTemizle.Size = new System.Drawing.Size(82, 30);
            this.buttonTemizle.TabIndex = 7;
            this.buttonTemizle.Text = "Temizle";
            this.buttonTemizle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTemizle.UseVisualStyleBackColor = true;
            this.buttonTemizle.Click += new System.EventHandler(this.buttonTemizle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(48, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres İl:";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(120, 19);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(142, 25);
            this.textBoxAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(36, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kurucusu:";
            // 
            // textBoxKurucu
            // 
            this.textBoxKurucu.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKurucu.Location = new System.Drawing.Point(120, 50);
            this.textBoxKurucu.Name = "textBoxKurucu";
            this.textBoxKurucu.Size = new System.Drawing.Size(142, 25);
            this.textBoxKurucu.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(33, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres İlçe:";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("buttonKaydet.Image")));
            this.buttonKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKaydet.Location = new System.Drawing.Point(159, 307);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(78, 30);
            this.buttonKaydet.TabIndex = 6;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kuruluş Tarihi:";
            // 
            // dataGridViewYayinevi
            // 
            this.dataGridViewYayinevi.AllowUserToDeleteRows = false;
            this.dataGridViewYayinevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewYayinevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYayinevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.YEId,
            this.YEAdi,
            this.YEKurucusu,
            this.YEKurulusTarihi,
            this.AdresilAdi,
            this.AdresilceAdi,
            this.YEAdresTam,
            this.YEAdresilid,
            this.YEAdresilceid});
            this.dataGridViewYayinevi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewYayinevi.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewYayinevi.MultiSelect = false;
            this.dataGridViewYayinevi.Name = "dataGridViewYayinevi";
            this.dataGridViewYayinevi.ReadOnly = true;
            this.dataGridViewYayinevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewYayinevi.Size = new System.Drawing.Size(562, 323);
            this.dataGridViewYayinevi.TabIndex = 1;
            this.dataGridViewYayinevi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewYayinevi_CellDoubleClick);
            // 
            // YEId
            // 
            this.YEId.DataPropertyName = "YEId";
            this.YEId.HeaderText = "Column1";
            this.YEId.Name = "YEId";
            this.YEId.ReadOnly = true;
            this.YEId.Visible = false;
            // 
            // YEAdi
            // 
            this.YEAdi.DataPropertyName = "YEAdi";
            this.YEAdi.HeaderText = "Adı";
            this.YEAdi.Name = "YEAdi";
            this.YEAdi.ReadOnly = true;
            // 
            // YEKurucusu
            // 
            this.YEKurucusu.DataPropertyName = "YEKurucusu";
            this.YEKurucusu.HeaderText = "Kurucu";
            this.YEKurucusu.Name = "YEKurucusu";
            this.YEKurucusu.ReadOnly = true;
            // 
            // YEKurulusTarihi
            // 
            this.YEKurulusTarihi.DataPropertyName = "YEKurulusTarihi";
            this.YEKurulusTarihi.HeaderText = "Kuruluş Tarihi";
            this.YEKurulusTarihi.Name = "YEKurulusTarihi";
            this.YEKurulusTarihi.ReadOnly = true;
            // 
            // AdresilAdi
            // 
            this.AdresilAdi.DataPropertyName = "AdresilAdi";
            this.AdresilAdi.HeaderText = "İl";
            this.AdresilAdi.Name = "AdresilAdi";
            this.AdresilAdi.ReadOnly = true;
            // 
            // AdresilceAdi
            // 
            this.AdresilceAdi.DataPropertyName = "AdresilceAdi";
            this.AdresilceAdi.HeaderText = "İlçe";
            this.AdresilceAdi.Name = "AdresilceAdi";
            this.AdresilceAdi.ReadOnly = true;
            // 
            // YEAdresTam
            // 
            this.YEAdresTam.DataPropertyName = "YEAdresTam";
            this.YEAdresTam.HeaderText = "Adres";
            this.YEAdresTam.Name = "YEAdresTam";
            this.YEAdresTam.ReadOnly = true;
            // 
            // YEAdresilid
            // 
            this.YEAdresilid.DataPropertyName = "YEAdresilid";
            this.YEAdresilid.HeaderText = "Column1";
            this.YEAdresilid.Name = "YEAdresilid";
            this.YEAdresilid.ReadOnly = true;
            this.YEAdresilid.Visible = false;
            // 
            // YEAdresilceid
            // 
            this.YEAdresilceid.DataPropertyName = "YEAdresilceid";
            this.YEAdresilceid.HeaderText = "Column1";
            this.YEAdresilceid.Name = "YEAdresilceid";
            this.YEAdresilceid.ReadOnly = true;
            this.YEAdresilceid.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dataGridViewYayinevi);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(490, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(568, 346);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yayın Evleri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonIstatistik);
            this.groupBox4.Controls.Add(this.buttonGoruntule);
            this.groupBox4.Controls.Add(this.buttonSil);
            this.groupBox4.Controls.Add(this.buttonGuncelle);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(297, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 208);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Diğer Seçenekler";
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
            // FormYayineviKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1070, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 409);
            this.MinimumSize = new System.Drawing.Size(1086, 409);
            this.Name = "FormYayineviKayit";
            this.Text = "Yayınevi İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormYayinEviKayit_FormClosed);
            this.Load += new System.EventHandler(this.FormYayinEviKayit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYayinevi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerKurulusTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKurucu;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxATam;
        private System.Windows.Forms.ComboBox comboBoxAilce;
        private System.Windows.Forms.ComboBox comboBoxAil;
        private System.Windows.Forms.DataGridView dataGridViewYayinevi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonIstatistik;
        private System.Windows.Forms.Button buttonGoruntule;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEId;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEKurucusu;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEKurulusTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresilAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresilceAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAdresTam;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAdresilid;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEAdresilceid;
    }
}