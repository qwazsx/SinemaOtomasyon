namespace SINEMA
{
    partial class Film_Kategori_İşlemleri
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
            this.txtKategoriAd = new System.Windows.Forms.TextBox();
            this.cmbGeneIIzleyici = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnYaniKayit = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.sinemaOtomasyonDataSet2 = new SINEMA.SinemaOtomasyonDataSet2();
            this.filmKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmKategoriTableAdapter = new SINEMA.SinemaOtomasyonDataSet2TableAdapters.FilmKategoriTableAdapter();
            this.kategoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genelIzleyiciDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genel İzleyici :";
            // 
            // txtKategoriAd
            // 
            this.txtKategoriAd.Location = new System.Drawing.Point(139, 58);
            this.txtKategoriAd.Name = "txtKategoriAd";
            this.txtKategoriAd.Size = new System.Drawing.Size(286, 22);
            this.txtKategoriAd.TabIndex = 0;
            // 
            // cmbGeneIIzleyici
            // 
            this.cmbGeneIIzleyici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGeneIIzleyici.FormattingEnabled = true;
            this.cmbGeneIIzleyici.Items.AddRange(new object[] {
            "Genel İzleyici",
            "Genel İzleyici Değil"});
            this.cmbGeneIIzleyici.Location = new System.Drawing.Point(138, 110);
            this.cmbGeneIIzleyici.Name = "cmbGeneIIzleyici";
            this.cmbGeneIIzleyici.Size = new System.Drawing.Size(287, 24);
            this.cmbGeneIIzleyici.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kategoriIDDataGridViewTextBoxColumn,
            this.kategoriAdDataGridViewTextBoxColumn,
            this.genelIzleyiciDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.filmKategoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 245);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(711, 192);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnYaniKayit
            // 
            this.btnYaniKayit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYaniKayit.Location = new System.Drawing.Point(28, 161);
            this.btnYaniKayit.Name = "btnYaniKayit";
            this.btnYaniKayit.Size = new System.Drawing.Size(152, 45);
            this.btnYaniKayit.TabIndex = 2;
            this.btnYaniKayit.Text = "Yeni Kayıt";
            this.btnYaniKayit.UseVisualStyleBackColor = true;
            this.btnYaniKayit.Click += new System.EventHandler(this.btnYaniKayit_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(212, 161);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(152, 45);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(388, 161);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(152, 45);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(571, 161);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(152, 45);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // sinemaOtomasyonDataSet2
            // 
            this.sinemaOtomasyonDataSet2.DataSetName = "SinemaOtomasyonDataSet2";
            this.sinemaOtomasyonDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmKategoriBindingSource
            // 
            this.filmKategoriBindingSource.DataMember = "FilmKategori";
            this.filmKategoriBindingSource.DataSource = this.sinemaOtomasyonDataSet2;
            // 
            // filmKategoriTableAdapter
            // 
            this.filmKategoriTableAdapter.ClearBeforeFill = true;
            // 
            // kategoriIDDataGridViewTextBoxColumn
            // 
            this.kategoriIDDataGridViewTextBoxColumn.DataPropertyName = "KategoriID";
            this.kategoriIDDataGridViewTextBoxColumn.HeaderText = "KategoriID";
            this.kategoriIDDataGridViewTextBoxColumn.Name = "kategoriIDDataGridViewTextBoxColumn";
            this.kategoriIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // kategoriAdDataGridViewTextBoxColumn
            // 
            this.kategoriAdDataGridViewTextBoxColumn.DataPropertyName = "KategoriAd";
            this.kategoriAdDataGridViewTextBoxColumn.HeaderText = "KategoriAd";
            this.kategoriAdDataGridViewTextBoxColumn.Name = "kategoriAdDataGridViewTextBoxColumn";
            this.kategoriAdDataGridViewTextBoxColumn.ReadOnly = true;
            this.kategoriAdDataGridViewTextBoxColumn.Width = 200;
            // 
            // genelIzleyiciDataGridViewCheckBoxColumn
            // 
            this.genelIzleyiciDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.genelIzleyiciDataGridViewCheckBoxColumn.DataPropertyName = "GenelIzleyici";
            this.genelIzleyiciDataGridViewCheckBoxColumn.HeaderText = "GenelIzleyici";
            this.genelIzleyiciDataGridViewCheckBoxColumn.Name = "genelIzleyiciDataGridViewCheckBoxColumn";
            this.genelIzleyiciDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // Film_Kategori_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 457);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYaniKayit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbGeneIIzleyici);
            this.Controls.Add(this.txtKategoriAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(764, 504);
            this.MinimumSize = new System.Drawing.Size(764, 504);
            this.Name = "Film_Kategori_İşlemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Kategori İşlemleri";
            this.Load += new System.EventHandler(this.Film_Kategori_İşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmKategoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKategoriAd;
        private System.Windows.Forms.ComboBox cmbGeneIIzleyici;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnYaniKayit;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private SinemaOtomasyonDataSet2 sinemaOtomasyonDataSet2;
        private System.Windows.Forms.BindingSource filmKategoriBindingSource;
        private SinemaOtomasyonDataSet2TableAdapters.FilmKategoriTableAdapter filmKategoriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn genelIzleyiciDataGridViewCheckBoxColumn;
    }
}