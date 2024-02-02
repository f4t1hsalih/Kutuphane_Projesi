namespace Kutuphane_Projesi
{
    partial class FormTeslimAlma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeslimAlma));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTeslimAlma = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelGecenGunSayisi = new System.Windows.Forms.Label();
            this.dateTimePickerAldigiTarih = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKitapAdi = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTemizle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxKutuphaneAdi = new System.Windows.Forms.TextBox();
            this.textBoxUyeAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IslemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UyeAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KutuphaneAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OduncAlmaTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GeriVermeTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KutuphaneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KitapISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uyeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeslimAlma)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.dataGridViewTeslimAlma);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 275);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kayıtlar";
            // 
            // dataGridViewTeslimAlma
            // 
            this.dataGridViewTeslimAlma.AllowUserToDeleteRows = false;
            this.dataGridViewTeslimAlma.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTeslimAlma.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridViewTeslimAlma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeslimAlma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IslemId,
            this.UyeAd,
            this.KutuphaneAdi,
            this.KitapAdi,
            this.OduncAlmaTarihi,
            this.GeriVermeTarihi,
            this.KutuphaneNo,
            this.KitapISBN,
            this.Uyeno});
            this.dataGridViewTeslimAlma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTeslimAlma.Location = new System.Drawing.Point(3, 20);
            this.dataGridViewTeslimAlma.MultiSelect = false;
            this.dataGridViewTeslimAlma.Name = "dataGridViewTeslimAlma";
            this.dataGridViewTeslimAlma.ReadOnly = true;
            this.dataGridViewTeslimAlma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeslimAlma.Size = new System.Drawing.Size(671, 252);
            this.dataGridViewTeslimAlma.TabIndex = 0;
            this.dataGridViewTeslimAlma.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeslimAlma_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelGecenGunSayisi);
            this.groupBox1.Controls.Add(this.dateTimePickerAldigiTarih);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxKitapAdi);
            this.groupBox1.Controls.Add(this.buttonKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonTemizle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxKutuphaneAdi);
            this.groupBox1.Controls.Add(this.textBoxUyeAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(695, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 275);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // labelGecenGunSayisi
            // 
            this.labelGecenGunSayisi.AutoSize = true;
            this.labelGecenGunSayisi.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGecenGunSayisi.Location = new System.Drawing.Point(154, 165);
            this.labelGecenGunSayisi.Name = "labelGecenGunSayisi";
            this.labelGecenGunSayisi.Size = new System.Drawing.Size(31, 21);
            this.labelGecenGunSayisi.TabIndex = 12;
            this.labelGecenGunSayisi.Text = "***";
            // 
            // dateTimePickerAldigiTarih
            // 
            this.dateTimePickerAldigiTarih.Enabled = false;
            this.dateTimePickerAldigiTarih.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerAldigiTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAldigiTarih.Location = new System.Drawing.Point(129, 132);
            this.dateTimePickerAldigiTarih.Name = "dateTimePickerAldigiTarih";
            this.dateTimePickerAldigiTarih.Size = new System.Drawing.Size(129, 25);
            this.dateTimePickerAldigiTarih.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Geçen Gün S.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ödünç Verme T.:";
            // 
            // textBoxKitapAdi
            // 
            this.textBoxKitapAdi.Enabled = false;
            this.textBoxKitapAdi.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKitapAdi.Location = new System.Drawing.Point(129, 101);
            this.textBoxKitapAdi.Name = "textBoxKitapAdi";
            this.textBoxKitapAdi.Size = new System.Drawing.Size(129, 25);
            this.textBoxKitapAdi.TabIndex = 8;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("buttonKaydet.Image")));
            this.buttonKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonKaydet.Location = new System.Drawing.Point(146, 209);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(94, 30);
            this.buttonKaydet.TabIndex = 6;
            this.buttonKaydet.Text = "Teslim Al";
            this.buttonKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Adı:";
            // 
            // buttonTemizle
            // 
            this.buttonTemizle.Image = ((System.Drawing.Image)(resources.GetObject("buttonTemizle.Image")));
            this.buttonTemizle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTemizle.Location = new System.Drawing.Point(32, 209);
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
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kütüphane:";
            // 
            // textBoxKutuphaneAdi
            // 
            this.textBoxKutuphaneAdi.Enabled = false;
            this.textBoxKutuphaneAdi.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKutuphaneAdi.Location = new System.Drawing.Point(129, 70);
            this.textBoxKutuphaneAdi.Name = "textBoxKutuphaneAdi";
            this.textBoxKutuphaneAdi.Size = new System.Drawing.Size(129, 25);
            this.textBoxKutuphaneAdi.TabIndex = 2;
            // 
            // textBoxUyeAdi
            // 
            this.textBoxUyeAdi.Enabled = false;
            this.textBoxUyeAdi.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxUyeAdi.Location = new System.Drawing.Point(129, 39);
            this.textBoxUyeAdi.Name = "textBoxUyeAdi";
            this.textBoxUyeAdi.Size = new System.Drawing.Size(129, 25);
            this.textBoxUyeAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap:";
            // 
            // IslemId
            // 
            this.IslemId.DataPropertyName = "IslemId";
            this.IslemId.HeaderText = "Column1";
            this.IslemId.Name = "IslemId";
            this.IslemId.ReadOnly = true;
            this.IslemId.Visible = false;
            // 
            // UyeAd
            // 
            this.UyeAd.DataPropertyName = "UyeAd";
            this.UyeAd.HeaderText = "Üye Adı";
            this.UyeAd.Name = "UyeAd";
            this.UyeAd.ReadOnly = true;
            // 
            // KutuphaneAdi
            // 
            this.KutuphaneAdi.DataPropertyName = "KutuphaneAdi";
            this.KutuphaneAdi.HeaderText = "Kütüphane Adı";
            this.KutuphaneAdi.Name = "KutuphaneAdi";
            this.KutuphaneAdi.ReadOnly = true;
            // 
            // KitapAdi
            // 
            this.KitapAdi.DataPropertyName = "KitapAdi";
            this.KitapAdi.HeaderText = "Kitap Adı";
            this.KitapAdi.Name = "KitapAdi";
            this.KitapAdi.ReadOnly = true;
            // 
            // OduncAlmaTarihi
            // 
            this.OduncAlmaTarihi.DataPropertyName = "OduncAlmaTarihi";
            this.OduncAlmaTarihi.HeaderText = "Ödünç Alma Tarihi";
            this.OduncAlmaTarihi.Name = "OduncAlmaTarihi";
            this.OduncAlmaTarihi.ReadOnly = true;
            // 
            // GeriVermeTarihi
            // 
            this.GeriVermeTarihi.DataPropertyName = "GeriVermeTarihi";
            this.GeriVermeTarihi.HeaderText = "Teslim Alınacak Tarih";
            this.GeriVermeTarihi.Name = "GeriVermeTarihi";
            this.GeriVermeTarihi.ReadOnly = true;
            // 
            // KutuphaneNo
            // 
            this.KutuphaneNo.DataPropertyName = "KutuphaneNo";
            this.KutuphaneNo.HeaderText = "Column2";
            this.KutuphaneNo.Name = "KutuphaneNo";
            this.KutuphaneNo.ReadOnly = true;
            this.KutuphaneNo.Visible = false;
            // 
            // KitapISBN
            // 
            this.KitapISBN.DataPropertyName = "KitapISBN";
            this.KitapISBN.HeaderText = "Column3";
            this.KitapISBN.Name = "KitapISBN";
            this.KitapISBN.ReadOnly = true;
            this.KitapISBN.Visible = false;
            // 
            // Uyeno
            // 
            this.Uyeno.DataPropertyName = "Uyeno";
            this.Uyeno.HeaderText = "Column4";
            this.Uyeno.Name = "Uyeno";
            this.Uyeno.ReadOnly = true;
            this.Uyeno.Visible = false;
            // 
            // FormTeslimAlma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(969, 299);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(985, 600);
            this.MinimumSize = new System.Drawing.Size(985, 338);
            this.Name = "FormTeslimAlma";
            this.Text = "Teslim Alma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTeslimAlma_FormClosed);
            this.Load += new System.EventHandler(this.FormTeslimAlma_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeslimAlma)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewTeslimAlma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxKitapAdi;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTemizle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxKutuphaneAdi;
        private System.Windows.Forms.TextBox textBoxUyeAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelGecenGunSayisi;
        private System.Windows.Forms.DateTimePicker dateTimePickerAldigiTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UyeAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn KutuphaneAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OduncAlmaTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GeriVermeTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KutuphaneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn KitapISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uyeno;
    }
}