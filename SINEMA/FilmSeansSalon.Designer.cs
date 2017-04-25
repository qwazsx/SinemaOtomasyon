namespace SINEMA
{
    partial class FilmSeansSalon
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
            this.cmbFilmAd = new System.Windows.Forms.ComboBox();
            this.cmbSalon = new System.Windows.Forms.ComboBox();
            this.cmbSeans = new System.Windows.Forms.ComboBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinemaOtomasyonDataSet5 = new SINEMA.SinemaOtomasyonDataSet5();
            this.seansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seansTableAdapter = new SINEMA.SinemaOtomasyonDataSet5TableAdapters.SeansTableAdapter();
            this.seansIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sinemaOtomasyonDataSet6 = new SINEMA.SinemaOtomasyonDataSet6();
            this.filmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new SINEMA.SinemaOtomasyonDataSet6TableAdapters.FilmTableAdapter();
            this.sinemaOtomasyonDataSet7 = new SINEMA.SinemaOtomasyonDataSet7();
            this.salonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonTableAdapter = new SINEMA.SinemaOtomasyonDataSet7TableAdapters.SalonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seans :";
            // 
            // cmbFilmAd
            // 
            this.cmbFilmAd.DataSource = this.filmBindingSource;
            this.cmbFilmAd.DisplayMember = "FilmAd";
            this.cmbFilmAd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilmAd.FormattingEnabled = true;
            this.cmbFilmAd.Location = new System.Drawing.Point(90, 50);
            this.cmbFilmAd.Name = "cmbFilmAd";
            this.cmbFilmAd.Size = new System.Drawing.Size(258, 24);
            this.cmbFilmAd.TabIndex = 0;
            this.cmbFilmAd.ValueMember = "FilmID";
            // 
            // cmbSalon
            // 
            this.cmbSalon.DataSource = this.salonBindingSource;
            this.cmbSalon.DisplayMember = "SalonAd";
            this.cmbSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalon.FormattingEnabled = true;
            this.cmbSalon.Location = new System.Drawing.Point(90, 108);
            this.cmbSalon.Name = "cmbSalon";
            this.cmbSalon.Size = new System.Drawing.Size(258, 24);
            this.cmbSalon.TabIndex = 1;
            this.cmbSalon.ValueMember = "SalonID";
            // 
            // cmbSeans
            // 
            this.cmbSeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeans.FormattingEnabled = true;
            this.cmbSeans.Items.AddRange(new object[] {
            "9:00 ",
            "12:00",
            "15:00",
            "17:00",
            "21:00",
            "23:30"});
            this.cmbSeans.Location = new System.Drawing.Point(90, 156);
            this.cmbSeans.Name = "cmbSeans";
            this.cmbSeans.Size = new System.Drawing.Size(258, 24);
            this.cmbSeans.TabIndex = 2;
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.Location = new System.Drawing.Point(377, 50);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(141, 52);
            this.btnYeniKayit.TabIndex = 3;
            this.btnYeniKayit.Text = "Yeni Kayit";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(377, 128);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(141, 52);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(561, 50);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(141, 52);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(561, 128);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(141, 52);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seansIDDataGridViewTextBoxColumn,
            this.seansNoDataGridViewTextBoxColumn,
            this.filmIDDataGridViewTextBoxColumn,
            this.salonIDDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.seansBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 199);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(686, 222);
            this.dataGridView1.TabIndex = 7;
            // 
            // sinemaOtomasyonDataSet5
            // 
            this.sinemaOtomasyonDataSet5.DataSetName = "SinemaOtomasyonDataSet5";
            this.sinemaOtomasyonDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seansBindingSource
            // 
            this.seansBindingSource.DataMember = "Seans";
            this.seansBindingSource.DataSource = this.sinemaOtomasyonDataSet5;
            // 
            // seansTableAdapter
            // 
            this.seansTableAdapter.ClearBeforeFill = true;
            // 
            // seansIDDataGridViewTextBoxColumn
            // 
            this.seansIDDataGridViewTextBoxColumn.DataPropertyName = "SeansID";
            this.seansIDDataGridViewTextBoxColumn.HeaderText = "SeansID";
            this.seansIDDataGridViewTextBoxColumn.Name = "seansIDDataGridViewTextBoxColumn";
            this.seansIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seansNoDataGridViewTextBoxColumn
            // 
            this.seansNoDataGridViewTextBoxColumn.DataPropertyName = "SeansNo";
            this.seansNoDataGridViewTextBoxColumn.HeaderText = "SeansNo";
            this.seansNoDataGridViewTextBoxColumn.Name = "seansNoDataGridViewTextBoxColumn";
            this.seansNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmIDDataGridViewTextBoxColumn
            // 
            this.filmIDDataGridViewTextBoxColumn.DataPropertyName = "FilmID";
            this.filmIDDataGridViewTextBoxColumn.HeaderText = "FilmID";
            this.filmIDDataGridViewTextBoxColumn.Name = "filmIDDataGridViewTextBoxColumn";
            this.filmIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salonIDDataGridViewTextBoxColumn
            // 
            this.salonIDDataGridViewTextBoxColumn.DataPropertyName = "SalonID";
            this.salonIDDataGridViewTextBoxColumn.HeaderText = "SalonID";
            this.salonIDDataGridViewTextBoxColumn.Name = "salonIDDataGridViewTextBoxColumn";
            this.salonIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // sinemaOtomasyonDataSet6
            // 
            this.sinemaOtomasyonDataSet6.DataSetName = "SinemaOtomasyonDataSet6";
            this.sinemaOtomasyonDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource
            // 
            this.filmBindingSource.DataMember = "Film";
            this.filmBindingSource.DataSource = this.sinemaOtomasyonDataSet6;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // sinemaOtomasyonDataSet7
            // 
            this.sinemaOtomasyonDataSet7.DataSetName = "SinemaOtomasyonDataSet7";
            this.sinemaOtomasyonDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salonBindingSource
            // 
            this.salonBindingSource.DataMember = "Salon";
            this.salonBindingSource.DataSource = this.sinemaOtomasyonDataSet7;
            // 
            // salonTableAdapter
            // 
            this.salonTableAdapter.ClearBeforeFill = true;
            // 
            // FilmSeansSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.cmbSeans);
            this.Controls.Add(this.cmbSalon);
            this.Controls.Add(this.cmbFilmAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(728, 478);
            this.MinimumSize = new System.Drawing.Size(728, 478);
            this.Name = "FilmSeansSalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Film Seans Salon";
            this.Load += new System.EventHandler(this.FilmSeansSalon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilmAd;
        private System.Windows.Forms.ComboBox cmbSalon;
        private System.Windows.Forms.ComboBox cmbSeans;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SinemaOtomasyonDataSet5 sinemaOtomasyonDataSet5;
        private System.Windows.Forms.BindingSource seansBindingSource;
        private SinemaOtomasyonDataSet5TableAdapters.SeansTableAdapter seansTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seansIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seansNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private SinemaOtomasyonDataSet6 sinemaOtomasyonDataSet6;
        private System.Windows.Forms.BindingSource filmBindingSource;
        private SinemaOtomasyonDataSet6TableAdapters.FilmTableAdapter filmTableAdapter;
        private SinemaOtomasyonDataSet7 sinemaOtomasyonDataSet7;
        private System.Windows.Forms.BindingSource salonBindingSource;
        private SinemaOtomasyonDataSet7TableAdapters.SalonTableAdapter salonTableAdapter;
    }
}