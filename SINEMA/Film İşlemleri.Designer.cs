namespace SINEMA
{
    partial class Film_İşlemleri
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
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.txtYapimci = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFilmAktif = new System.Windows.Forms.ComboBox();
            this.cmbFilmKategori = new System.Windows.Forms.ComboBox();
            this.filmKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaOtomasyonDataSet = new SINEMA.SinemaOtomasyonDataSet();
            this.dateYayinTarih = new System.Windows.Forms.DateTimePicker();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaOtomasyonDataSet1 = new SINEMA.SinemaOtomasyonDataSet1();
            this.filmKategoriTableAdapter = new SINEMA.SinemaOtomasyonDataSetTableAdapters.FilmKategoriTableAdapter();
            this.filmTableAdapter = new SINEMA.SinemaOtomasyonDataSet1TableAdapters.FilmTableAdapter();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yapimciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yapımcı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(76, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Süre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yayın Tarih :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kategori :";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(133, 37);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(323, 22);
            this.txtFilmAd.TabIndex = 0;
            // 
            // txtYapimci
            // 
            this.txtYapimci.Location = new System.Drawing.Point(132, 81);
            this.txtYapimci.Name = "txtYapimci";
            this.txtYapimci.Size = new System.Drawing.Size(323, 22);
            this.txtYapimci.TabIndex = 1;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(132, 119);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(323, 22);
            this.txtSure.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(75, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Aktif :";
            // 
            // cmbFilmAktif
            // 
            this.cmbFilmAktif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmAktif.FormattingEnabled = true;
            this.cmbFilmAktif.Items.AddRange(new object[] {
            "Aktif",
            "Aktif Değil"});
            this.cmbFilmAktif.Location = new System.Drawing.Point(133, 165);
            this.cmbFilmAktif.Name = "cmbFilmAktif";
            this.cmbFilmAktif.Size = new System.Drawing.Size(322, 24);
            this.cmbFilmAktif.TabIndex = 3;
            // 
            // cmbFilmKategori
            // 
            this.cmbFilmKategori.DataSource = this.filmKategoriBindingSource;
            this.cmbFilmKategori.DisplayMember = "KategoriAd";
            this.cmbFilmKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmKategori.FormattingEnabled = true;
            this.cmbFilmKategori.Location = new System.Drawing.Point(133, 210);
            this.cmbFilmKategori.Name = "cmbFilmKategori";
            this.cmbFilmKategori.Size = new System.Drawing.Size(322, 24);
            this.cmbFilmKategori.TabIndex = 4;
            this.cmbFilmKategori.ValueMember = "KategoriID";
            // 
            // filmKategoriBindingSource
            // 
            this.filmKategoriBindingSource.DataMember = "FilmKategori";
            this.filmKategoriBindingSource.DataSource = this.sinemaOtomasyonDataSet;
            // 
            // sinemaOtomasyonDataSet
            // 
            this.sinemaOtomasyonDataSet.DataSetName = "SinemaOtomasyonDataSet";
            this.sinemaOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateYayinTarih
            // 
            this.dateYayinTarih.Location = new System.Drawing.Point(133, 251);
            this.dateYayinTarih.Name = "dateYayinTarih";
            this.dateYayinTarih.Size = new System.Drawing.Size(322, 22);
            this.dateYayinTarih.TabIndex = 5;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.Location = new System.Drawing.Point(536, 36);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(180, 41);
            this.btnYeniKayit.TabIndex = 6;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(536, 100);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(180, 41);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Film Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(536, 165);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(180, 41);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Film Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(536, 232);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(180, 41);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Film Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmIDDataGridViewTextBoxColumn,
            this.kategoriIDDataGridViewTextBoxColumn,
            this.filmAdDataGridViewTextBoxColumn,
            this.yapimciDataGridViewTextBoxColumn,
            this.yayinTarihDataGridViewTextBoxColumn,
            this.sureDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.filmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 297);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 234);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.sinemaOtomasyonDataSet1;
            // 
            // sinemaOtomasyonDataSet1
            // 
            this.sinemaOtomasyonDataSet1.DataSetName = "SinemaOtomasyonDataSet1";
            this.sinemaOtomasyonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmKategoriTableAdapter
            // 
            this.filmKategoriTableAdapter.ClearBeforeFill = true;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sureDataGridViewTextBoxColumn
            // 
            this.sureDataGridViewTextBoxColumn.DataPropertyName = "Sure";
            this.sureDataGridViewTextBoxColumn.HeaderText = "Sure";
            this.sureDataGridViewTextBoxColumn.Name = "sureDataGridViewTextBoxColumn";
            this.sureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yayinTarihDataGridViewTextBoxColumn
            // 
            this.yayinTarihDataGridViewTextBoxColumn.DataPropertyName = "YayinTarih";
            this.yayinTarihDataGridViewTextBoxColumn.HeaderText = "YayinTarih";
            this.yayinTarihDataGridViewTextBoxColumn.Name = "yayinTarihDataGridViewTextBoxColumn";
            this.yayinTarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yapimciDataGridViewTextBoxColumn
            // 
            this.yapimciDataGridViewTextBoxColumn.DataPropertyName = "Yapimci";
            this.yapimciDataGridViewTextBoxColumn.HeaderText = "Yapimci";
            this.yapimciDataGridViewTextBoxColumn.Name = "yapimciDataGridViewTextBoxColumn";
            this.yapimciDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAdDataGridViewTextBoxColumn
            // 
            this.filmAdDataGridViewTextBoxColumn.DataPropertyName = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.HeaderText = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.Name = "filmAdDataGridViewTextBoxColumn";
            this.filmAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kategoriIDDataGridViewTextBoxColumn
            // 
            this.kategoriIDDataGridViewTextBoxColumn.DataPropertyName = "KategoriID";
            this.kategoriIDDataGridViewTextBoxColumn.HeaderText = "KategoriID";
            this.kategoriIDDataGridViewTextBoxColumn.Name = "kategoriIDDataGridViewTextBoxColumn";
            this.kategoriIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmIDDataGridViewTextBoxColumn
            // 
            this.filmIDDataGridViewTextBoxColumn.DataPropertyName = "FilmID";
            this.filmIDDataGridViewTextBoxColumn.HeaderText = "FilmID";
            this.filmIDDataGridViewTextBoxColumn.Name = "filmIDDataGridViewTextBoxColumn";
            this.filmIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Film_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 543);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.dateYayinTarih);
            this.Controls.Add(this.cmbFilmKategori);
            this.Controls.Add(this.cmbFilmAktif);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtYapimci);
            this.Controls.Add(this.txtFilmAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Film_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film İşlemleri";
            this.Load += new System.EventHandler(this.Film_İşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.TextBox txtYapimci;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFilmAktif;
        private System.Windows.Forms.ComboBox cmbFilmKategori;
        private System.Windows.Forms.DateTimePicker dateYayinTarih;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SinemaOtomasyonDataSet sinemaOtomasyonDataSet;
        private System.Windows.Forms.BindingSource filmKategoriBindingSource;
        private SinemaOtomasyonDataSetTableAdapters.FilmKategoriTableAdapter filmKategoriTableAdapter;
        private SinemaOtomasyonDataSet1 sinemaOtomasyonDataSet1;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private SinemaOtomasyonDataSet1TableAdapters.FilmTableAdapter filmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yapimciDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
    }
}