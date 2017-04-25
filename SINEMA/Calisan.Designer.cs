namespace SINEMA
{
    partial class Calisan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtKullaniciAd = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.dateIseGiris = new System.Windows.Forms.DateTimePicker();
            this.dateDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbCalisanKategori = new System.Windows.Forms.ComboBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinemaOtomasyonDataSet3 = new SINEMA.SinemaOtomasyonDataSet3();
            this.calisanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calisanTableAdapter = new SINEMA.SinemaOtomasyonDataSet3TableAdapters.CalisanTableAdapter();
            this.calisanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıseGirisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calisanKategoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(153, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(130, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(91, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(128, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parola :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(648, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Doğum Tarih :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(648, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "İşe Giriş Tarih :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(719, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "TC :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(625, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Çalışan Kategori :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(197, 49);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(303, 22);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(196, 101);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(303, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtKullaniciAd
            // 
            this.txtKullaniciAd.Location = new System.Drawing.Point(196, 143);
            this.txtKullaniciAd.Name = "txtKullaniciAd";
            this.txtKullaniciAd.Size = new System.Drawing.Size(303, 22);
            this.txtKullaniciAd.TabIndex = 2;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(196, 184);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(303, 22);
            this.txtParola.TabIndex = 3;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(761, 49);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(303, 22);
            this.txtTC.TabIndex = 4;
            // 
            // dateIseGiris
            // 
            this.dateIseGiris.Location = new System.Drawing.Point(761, 100);
            this.dateIseGiris.Name = "dateIseGiris";
            this.dateIseGiris.Size = new System.Drawing.Size(303, 22);
            this.dateIseGiris.TabIndex = 5;
            // 
            // dateDogumTarih
            // 
            this.dateDogumTarih.Location = new System.Drawing.Point(761, 141);
            this.dateDogumTarih.Name = "dateDogumTarih";
            this.dateDogumTarih.Size = new System.Drawing.Size(303, 22);
            this.dateDogumTarih.TabIndex = 6;
            // 
            // cmbCalisanKategori
            // 
            this.cmbCalisanKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalisanKategori.FormattingEnabled = true;
            this.cmbCalisanKategori.Items.AddRange(new object[] {
            "Admin",
            "Biletçi"});
            this.cmbCalisanKategori.Location = new System.Drawing.Point(761, 181);
            this.cmbCalisanKategori.Name = "cmbCalisanKategori";
            this.cmbCalisanKategori.Size = new System.Drawing.Size(303, 24);
            this.cmbCalisanKategori.TabIndex = 7;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.Location = new System.Drawing.Point(217, 234);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(156, 42);
            this.btnYeniKayit.TabIndex = 8;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(419, 234);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(156, 42);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(693, 234);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(156, 42);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(887, 234);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(156, 42);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.calisanIDDataGridViewTextBoxColumn,
            this.kullaniciAdDataGridViewTextBoxColumn,
            this.parolaDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.dogumTarihDataGridViewTextBoxColumn,
            this.ıseGirisDataGridViewTextBoxColumn,
            this.calisanKategoriIDDataGridViewTextBoxColumn,
            this.tCNODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calisanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 282);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1344, 326);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // sinemaOtomasyonDataSet3
            // 
            this.sinemaOtomasyonDataSet3.DataSetName = "SinemaOtomasyonDataSet3";
            this.sinemaOtomasyonDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calisanBindingSource
            // 
            this.calisanBindingSource.DataMember = "Calisan";
            this.calisanBindingSource.DataSource = this.sinemaOtomasyonDataSet3;
            // 
            // calisanTableAdapter
            // 
            this.calisanTableAdapter.ClearBeforeFill = true;
            // 
            // calisanIDDataGridViewTextBoxColumn
            // 
            this.calisanIDDataGridViewTextBoxColumn.DataPropertyName = "CalisanID";
            this.calisanIDDataGridViewTextBoxColumn.HeaderText = "CalisanID";
            this.calisanIDDataGridViewTextBoxColumn.Name = "calisanIDDataGridViewTextBoxColumn";
            this.calisanIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kullaniciAdDataGridViewTextBoxColumn
            // 
            this.kullaniciAdDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAd";
            this.kullaniciAdDataGridViewTextBoxColumn.HeaderText = "KullaniciAd";
            this.kullaniciAdDataGridViewTextBoxColumn.Name = "kullaniciAdDataGridViewTextBoxColumn";
            this.kullaniciAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // parolaDataGridViewTextBoxColumn
            // 
            this.parolaDataGridViewTextBoxColumn.DataPropertyName = "Parola";
            this.parolaDataGridViewTextBoxColumn.HeaderText = "Parola";
            this.parolaDataGridViewTextBoxColumn.Name = "parolaDataGridViewTextBoxColumn";
            this.parolaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dogumTarihDataGridViewTextBoxColumn
            // 
            this.dogumTarihDataGridViewTextBoxColumn.DataPropertyName = "DogumTarih";
            this.dogumTarihDataGridViewTextBoxColumn.HeaderText = "DogumTarih";
            this.dogumTarihDataGridViewTextBoxColumn.Name = "dogumTarihDataGridViewTextBoxColumn";
            this.dogumTarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıseGirisDataGridViewTextBoxColumn
            // 
            this.ıseGirisDataGridViewTextBoxColumn.DataPropertyName = "IseGiris";
            this.ıseGirisDataGridViewTextBoxColumn.HeaderText = "IseGiris";
            this.ıseGirisDataGridViewTextBoxColumn.Name = "ıseGirisDataGridViewTextBoxColumn";
            this.ıseGirisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // calisanKategoriIDDataGridViewTextBoxColumn
            // 
            this.calisanKategoriIDDataGridViewTextBoxColumn.DataPropertyName = "CalisanKategoriID";
            this.calisanKategoriIDDataGridViewTextBoxColumn.HeaderText = "CalisanKategoriID";
            this.calisanKategoriIDDataGridViewTextBoxColumn.Name = "calisanKategoriIDDataGridViewTextBoxColumn";
            this.calisanKategoriIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tCNODataGridViewTextBoxColumn
            // 
            this.tCNODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tCNODataGridViewTextBoxColumn.DataPropertyName = "TCNO";
            this.tCNODataGridViewTextBoxColumn.HeaderText = "TCNO";
            this.tCNODataGridViewTextBoxColumn.Name = "tCNODataGridViewTextBoxColumn";
            this.tCNODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Calisan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.cmbCalisanKategori);
            this.Controls.Add(this.dateDogumTarih);
            this.Controls.Add(this.dateIseGiris);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtKullaniciAd);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(1400, 682);
            this.MinimumSize = new System.Drawing.Size(1400, 682);
            this.Name = "Calisan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan";
            this.Load += new System.EventHandler(this.Calisan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calisanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtKullaniciAd;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.DateTimePicker dateIseGiris;
        private System.Windows.Forms.DateTimePicker dateDogumTarih;
        private System.Windows.Forms.ComboBox cmbCalisanKategori;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SinemaOtomasyonDataSet3 sinemaOtomasyonDataSet3;
        private System.Windows.Forms.BindingSource calisanBindingSource;
        private SinemaOtomasyonDataSet3TableAdapters.CalisanTableAdapter calisanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıseGirisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calisanKategoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCNODataGridViewTextBoxColumn;
    }
}