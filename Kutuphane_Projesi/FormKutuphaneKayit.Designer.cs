namespace Kutuphane_Projesi
{
    partial class FormKutuphaneKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKutuphaneKayit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonIstatistik = new System.Windows.Forms.Button();
            this.buttonGoruntule = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewKutuphaneler = new System.Windows.Forms.DataGridView();
            this.KutuphaneId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KutuphaneAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KutuphaneKurucusu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresilAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdresilceAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KutuphaneAdresTam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresilid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresilceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxAil = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBoxATam = new System.Windows.Forms.RichTextBox();
            this.comboBoxAilce = new System.Windows.Forms.ComboBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKurucu = new System.Windows.Forms.TextBox();
            this.textBoxKutuphaneAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKutuphaneler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.groupBox3.Location = new System.Drawing.Point(272, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(183, 298);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Diğer Seçenekler";
            // 
            // buttonIstatistik
            // 
            this.buttonIstatistik.Image = ((System.Drawing.Image)(resources.GetObject("buttonIstatistik.Image")));
            this.buttonIstatistik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIstatistik.Location = new System.Drawing.Point(6, 186);
            this.buttonIstatistik.Name = "buttonIstatistik";
            this.buttonIstatistik.Size = new System.Drawing.Size(171, 33);
            this.buttonIstatistik.TabIndex = 4;
            this.buttonIstatistik.Text = "İstatistikler";
            this.buttonIstatistik.UseVisualStyleBackColor = true;
            this.buttonIstatistik.Click += new System.EventHandler(this.buttonIstatistik_Click);
            // 
            // buttonGoruntule
            // 
            this.buttonGoruntule.Image = ((System.Drawing.Image)(resources.GetObject("buttonGoruntule.Image")));
            this.buttonGoruntule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGoruntule.Location = new System.Drawing.Point(6, 60);
            this.buttonGoruntule.Name = "buttonGoruntule";
            this.buttonGoruntule.Size = new System.Drawing.Size(171, 33);
            this.buttonGoruntule.TabIndex = 1;
            this.buttonGoruntule.Text = "Görüntüle";
            this.buttonGoruntule.UseVisualStyleBackColor = true;
            this.buttonGoruntule.Click += new System.EventHandler(this.buttonGoruntule_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Image = ((System.Drawing.Image)(resources.GetObject("buttonSil.Image")));
            this.buttonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSil.Location = new System.Drawing.Point(6, 144);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(171, 33);
            this.buttonSil.TabIndex = 3;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("buttonGuncelle.Image")));
            this.buttonGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuncelle.Location = new System.Drawing.Point(6, 102);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(171, 33);
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
            this.groupBox2.Controls.Add(this.dataGridViewKutuphaneler);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(666, 244);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kütüphaneler";
            // 
            // dataGridViewKutuphaneler
            // 
            this.dataGridViewKutuphaneler.AllowUserToDeleteRows = false;
            this.dataGridViewKutuphaneler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKutuphaneler.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewKutuphaneler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKutuphaneler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KutuphaneId,
            this.KutuphaneAdi,
            this.KutuphaneKurucusu,
            this.AdresilAdi,
            this.AdresilceAdi,
            this.KutuphaneAdresTam,
            this.Adresilid,
            this.Adresilceid});
            this.dataGridViewKutuphaneler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKutuphaneler.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewKutuphaneler.MultiSelect = false;
            this.dataGridViewKutuphaneler.Name = "dataGridViewKutuphaneler";
            this.dataGridViewKutuphaneler.ReadOnly = true;
            this.dataGridViewKutuphaneler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKutuphaneler.Size = new System.Drawing.Size(660, 221);
            this.dataGridViewKutuphaneler.TabIndex = 0;
            this.dataGridViewKutuphaneler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKutuphaneler_CellDoubleClick);
            // 
            // KutuphaneId
            // 
            this.KutuphaneId.DataPropertyName = "KutuphaneId";
            this.KutuphaneId.HeaderText = "Column1";
            this.KutuphaneId.Name = "KutuphaneId";
            this.KutuphaneId.ReadOnly = true;
            this.KutuphaneId.Visible = false;
            // 
            // KutuphaneAdi
            // 
            this.KutuphaneAdi.DataPropertyName = "KutuphaneAdi";
            this.KutuphaneAdi.HeaderText = "Adı";
            this.KutuphaneAdi.Name = "KutuphaneAdi";
            this.KutuphaneAdi.ReadOnly = true;
            // 
            // KutuphaneKurucusu
            // 
            this.KutuphaneKurucusu.DataPropertyName = "KutuphaneKurucusu";
            this.KutuphaneKurucusu.HeaderText = "Kurucusu";
            this.KutuphaneKurucusu.Name = "KutuphaneKurucusu";
            this.KutuphaneKurucusu.ReadOnly = true;
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
            // KutuphaneAdresTam
            // 
            this.KutuphaneAdresTam.DataPropertyName = "KutuphaneAdresTam";
            this.KutuphaneAdresTam.HeaderText = "Tam Adres";
            this.KutuphaneAdresTam.Name = "KutuphaneAdresTam";
            this.KutuphaneAdresTam.ReadOnly = true;
            // 
            // Adresilid
            // 
            this.Adresilid.DataPropertyName = "Adresilid";
            this.Adresilid.HeaderText = "Column1";
            this.Adresilid.Name = "Adresilid";
            this.Adresilid.ReadOnly = true;
            this.Adresilid.Visible = false;
            // 
            // Adresilceid
            // 
            this.Adresilceid.DataPropertyName = "Adresilceid";
            this.Adresilceid.HeaderText = "Column1";
            this.Adresilceid.Name = "Adresilceid";
            this.Adresilceid.ReadOnly = true;
            this.Adresilceid.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAil);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.comboBoxAilce);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTemizle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxKurucu);
            this.groupBox1.Controls.Add(this.textBoxKutuphaneAd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kütüphane Kayıt";
            // 
            // comboBoxAil
            // 
            this.comboBoxAil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAil.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAil.FormattingEnabled = true;
            this.comboBoxAil.Location = new System.Drawing.Point(93, 87);
            this.comboBoxAil.Name = "comboBoxAil";
            this.comboBoxAil.Size = new System.Drawing.Size(144, 25);
            this.comboBoxAil.TabIndex = 8;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBoxATam);
            this.groupBox4.Location = new System.Drawing.Point(10, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 98);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Adres Tam:";
            // 
            // richTextBoxATam
            // 
            this.richTextBoxATam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxATam.Location = new System.Drawing.Point(3, 20);
            this.richTextBoxATam.Name = "richTextBoxATam";
            this.richTextBoxATam.Size = new System.Drawing.Size(221, 75);
            this.richTextBoxATam.TabIndex = 1;
            this.richTextBoxATam.Text = "";
            // 
            // comboBoxAilce
            // 
            this.comboBoxAilce.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAilce.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxAilce.FormattingEnabled = true;
            this.comboBoxAilce.Location = new System.Drawing.Point(93, 118);
            this.comboBoxAilce.Name = "comboBoxAilce";
            this.comboBoxAilce.Size = new System.Drawing.Size(144, 25);
            this.comboBoxAilce.TabIndex = 4;
            this.comboBoxAilce.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxAilce_MouseClick_1);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("buttonKaydet.Image")));
            this.buttonKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKaydet.Location = new System.Drawing.Point(136, 253);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(78, 30);
            this.buttonKaydet.TabIndex = 6;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı:";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTemizle.Location = new System.Drawing.Point(25, 253);
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
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres İlçe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kurucusu:";
            // 
            // textBoxKurucu
            // 
            this.textBoxKurucu.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKurucu.Location = new System.Drawing.Point(93, 56);
            this.textBoxKurucu.Name = "textBoxKurucu";
            this.textBoxKurucu.Size = new System.Drawing.Size(144, 25);
            this.textBoxKurucu.TabIndex = 2;
            // 
            // textBoxKutuphaneAd
            // 
            this.textBoxKutuphaneAd.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKutuphaneAd.Location = new System.Drawing.Point(93, 25);
            this.textBoxKutuphaneAd.Name = "textBoxKutuphaneAd";
            this.textBoxKutuphaneAd.Size = new System.Drawing.Size(144, 25);
            this.textBoxKutuphaneAd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres İl:";
            // 
            // FormKutuphaneKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(690, 572);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(706, 800);
            this.MinimumSize = new System.Drawing.Size(706, 611);
            this.Name = "FormKutuphaneKayit";
            this.Text = "Kütüphane İşlemleri";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKutuphaneKayit_FormClosed);
            this.Load += new System.EventHandler(this.FormKutuphaneKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKutuphaneler)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewKutuphaneler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBoxATam;
        private System.Windows.Forms.ComboBox comboBoxAilce;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKurucu;
        private System.Windows.Forms.TextBox textBoxKutuphaneAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAil;
        private System.Windows.Forms.DataGridViewTextBoxColumn KutuphaneId;
        private System.Windows.Forms.DataGridViewTextBoxColumn KutuphaneAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KutuphaneKurucusu;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresilAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdresilceAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KutuphaneAdresTam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresilid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresilceid;
    }
}