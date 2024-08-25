namespace DershaneOtomasyonEkranlari
{
    partial class FormPersonelKayitEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonelKayitEkrani));
            labelTC = new Label();
            textBoxTC = new TextBox();
            labelAd = new Label();
            textBoxAd = new TextBox();
            labelSoyad = new Label();
            textBoxSoyad = new TextBox();
            labelCinsiyet = new Label();
            comboBoxCinsiyet = new ComboBox();
            labelDogumTarihi = new Label();
            dateTimePickerDogumTarihi = new DateTimePicker();
            labelDogumYeri = new Label();
            textBoxDogumYeri = new TextBox();
            labelKanGrubu = new Label();
            comboBoxKanGrubu = new ComboBox();
            labelAnneAdi = new Label();
            textBoxAnneAdi = new TextBox();
            labelBabaAdi = new Label();
            textBoxBabaAdi = new TextBox();
            labelCepNo = new Label();
            textBoxCepNo = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelIL = new Label();
            textBoxIL = new TextBox();
            labelIlçe = new Label();
            textBoxIlçe = new TextBox();
            labelAcikAdres = new Label();
            textBoxAcikAdres = new TextBox();
            labelBirim = new Label();
            comboBoxBirim = new ComboBox();
            labelUnvan = new Label();
            comboBoxUnvan = new ComboBox();
            labelGirisSifresi = new Label();
            textBoxGirisSifresi = new TextBox();
            dateTimePickerSozlesmeTarihi = new DateTimePicker();
            labelSozlesmeTarihi = new Label();
            buttonKaydet = new Button();
            labelDuzey = new Label();
            comboBoxDuzey = new ComboBox();
            SuspendLayout();
            // 
            // labelTC
            // 
            labelTC.AutoSize = true;
            labelTC.BackColor = Color.DarkGoldenrod;
            labelTC.BorderStyle = BorderStyle.Fixed3D;
            labelTC.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelTC.ForeColor = Color.Navy;
            labelTC.Location = new Point(45, 26);
            labelTC.Name = "labelTC";
            labelTC.Size = new Size(95, 19);
            labelTC.TabIndex = 0;
            labelTC.Text = "T.C. Kimlik No:";
            // 
            // textBoxTC
            // 
            textBoxTC.Location = new Point(168, 25);
            textBoxTC.Name = "textBoxTC";
            textBoxTC.Size = new Size(210, 23);
            textBoxTC.TabIndex = 1;
            // 
            // labelAd
            // 
            labelAd.AutoSize = true;
            labelAd.BackColor = Color.DarkGoldenrod;
            labelAd.BorderStyle = BorderStyle.Fixed3D;
            labelAd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAd.ForeColor = Color.Navy;
            labelAd.Location = new Point(109, 55);
            labelAd.Name = "labelAd";
            labelAd.Size = new Size(38, 19);
            labelAd.TabIndex = 0;
            labelAd.Text = "İsim:";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(168, 54);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(210, 23);
            textBoxAd.TabIndex = 1;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.BackColor = Color.DarkGoldenrod;
            labelSoyad.BorderStyle = BorderStyle.Fixed3D;
            labelSoyad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSoyad.ForeColor = Color.Navy;
            labelSoyad.Location = new Point(86, 85);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(59, 19);
            labelSoyad.TabIndex = 0;
            labelSoyad.Text = "Soyisim:";
            // 
            // textBoxSoyad
            // 
            textBoxSoyad.Location = new Point(168, 83);
            textBoxSoyad.Name = "textBoxSoyad";
            textBoxSoyad.Size = new Size(210, 23);
            textBoxSoyad.TabIndex = 1;
            // 
            // labelCinsiyet
            // 
            labelCinsiyet.AutoSize = true;
            labelCinsiyet.BackColor = Color.DarkGoldenrod;
            labelCinsiyet.BorderStyle = BorderStyle.Fixed3D;
            labelCinsiyet.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCinsiyet.ForeColor = Color.Navy;
            labelCinsiyet.Location = new Point(84, 113);
            labelCinsiyet.Name = "labelCinsiyet";
            labelCinsiyet.Size = new Size(60, 19);
            labelCinsiyet.TabIndex = 0;
            labelCinsiyet.Text = "Cinsiyet:";
            // 
            // comboBoxCinsiyet
            // 
            comboBoxCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCinsiyet.FormattingEnabled = true;
            comboBoxCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBoxCinsiyet.Location = new Point(168, 112);
            comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            comboBoxCinsiyet.Size = new Size(210, 23);
            comboBoxCinsiyet.TabIndex = 2;
            // 
            // labelDogumTarihi
            // 
            labelDogumTarihi.AutoSize = true;
            labelDogumTarihi.BackColor = Color.DarkGoldenrod;
            labelDogumTarihi.BorderStyle = BorderStyle.Fixed3D;
            labelDogumTarihi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDogumTarihi.ForeColor = Color.Navy;
            labelDogumTarihi.Location = new Point(47, 142);
            labelDogumTarihi.Name = "labelDogumTarihi";
            labelDogumTarihi.Size = new Size(94, 19);
            labelDogumTarihi.TabIndex = 0;
            labelDogumTarihi.Text = "Doğum Tarihi:";
            // 
            // dateTimePickerDogumTarihi
            // 
            dateTimePickerDogumTarihi.CustomFormat = "yyyy-MM-dd";
            dateTimePickerDogumTarihi.Format = DateTimePickerFormat.Custom;
            dateTimePickerDogumTarihi.Location = new Point(168, 141);
            dateTimePickerDogumTarihi.Name = "dateTimePickerDogumTarihi";
            dateTimePickerDogumTarihi.Size = new Size(210, 23);
            dateTimePickerDogumTarihi.TabIndex = 3;
            dateTimePickerDogumTarihi.Value = new DateTime(2023, 9, 8, 15, 10, 34, 0);
            // 
            // labelDogumYeri
            // 
            labelDogumYeri.AutoSize = true;
            labelDogumYeri.BackColor = Color.DarkGoldenrod;
            labelDogumYeri.BorderStyle = BorderStyle.Fixed3D;
            labelDogumYeri.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDogumYeri.ForeColor = Color.Navy;
            labelDogumYeri.Location = new Point(59, 172);
            labelDogumYeri.Name = "labelDogumYeri";
            labelDogumYeri.Size = new Size(84, 19);
            labelDogumYeri.TabIndex = 0;
            labelDogumYeri.Text = "Doğum Yeri:";
            // 
            // textBoxDogumYeri
            // 
            textBoxDogumYeri.Location = new Point(168, 170);
            textBoxDogumYeri.Name = "textBoxDogumYeri";
            textBoxDogumYeri.Size = new Size(210, 23);
            textBoxDogumYeri.TabIndex = 1;
            // 
            // labelKanGrubu
            // 
            labelKanGrubu.AutoSize = true;
            labelKanGrubu.BackColor = Color.DarkGoldenrod;
            labelKanGrubu.BorderStyle = BorderStyle.Fixed3D;
            labelKanGrubu.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelKanGrubu.ForeColor = Color.Navy;
            labelKanGrubu.Location = new Point(65, 200);
            labelKanGrubu.Name = "labelKanGrubu";
            labelKanGrubu.Size = new Size(78, 19);
            labelKanGrubu.TabIndex = 0;
            labelKanGrubu.Text = "Kan Grubu:";
            // 
            // comboBoxKanGrubu
            // 
            comboBoxKanGrubu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKanGrubu.FormattingEnabled = true;
            comboBoxKanGrubu.Items.AddRange(new object[] { "AB+", "AB-", "B+", "B-", "A+", "A-", "0+", "0-" });
            comboBoxKanGrubu.Location = new Point(168, 199);
            comboBoxKanGrubu.Name = "comboBoxKanGrubu";
            comboBoxKanGrubu.Size = new Size(210, 23);
            comboBoxKanGrubu.TabIndex = 2;
            // 
            // labelAnneAdi
            // 
            labelAnneAdi.AutoSize = true;
            labelAnneAdi.BackColor = Color.DarkGoldenrod;
            labelAnneAdi.BorderStyle = BorderStyle.Fixed3D;
            labelAnneAdi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAnneAdi.ForeColor = Color.Navy;
            labelAnneAdi.Location = new Point(75, 229);
            labelAnneAdi.Name = "labelAnneAdi";
            labelAnneAdi.Size = new Size(69, 19);
            labelAnneAdi.TabIndex = 0;
            labelAnneAdi.Text = "Anne Adı:";
            // 
            // textBoxAnneAdi
            // 
            textBoxAnneAdi.Location = new Point(168, 228);
            textBoxAnneAdi.Name = "textBoxAnneAdi";
            textBoxAnneAdi.Size = new Size(210, 23);
            textBoxAnneAdi.TabIndex = 1;
            // 
            // labelBabaAdi
            // 
            labelBabaAdi.AutoSize = true;
            labelBabaAdi.BackColor = Color.DarkGoldenrod;
            labelBabaAdi.BorderStyle = BorderStyle.Fixed3D;
            labelBabaAdi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelBabaAdi.ForeColor = Color.Navy;
            labelBabaAdi.Location = new Point(77, 259);
            labelBabaAdi.Name = "labelBabaAdi";
            labelBabaAdi.Size = new Size(67, 19);
            labelBabaAdi.TabIndex = 0;
            labelBabaAdi.Text = "Baba Adı:";
            // 
            // textBoxBabaAdi
            // 
            textBoxBabaAdi.Location = new Point(168, 257);
            textBoxBabaAdi.Name = "textBoxBabaAdi";
            textBoxBabaAdi.Size = new Size(210, 23);
            textBoxBabaAdi.TabIndex = 1;
            // 
            // labelCepNo
            // 
            labelCepNo.AutoSize = true;
            labelCepNo.BackColor = Color.DarkGoldenrod;
            labelCepNo.BorderStyle = BorderStyle.Fixed3D;
            labelCepNo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelCepNo.ForeColor = Color.Navy;
            labelCepNo.Location = new Point(453, 26);
            labelCepNo.Name = "labelCepNo";
            labelCepNo.Size = new Size(58, 19);
            labelCepNo.TabIndex = 0;
            labelCepNo.Text = "Cep No:";
            // 
            // textBoxCepNo
            // 
            textBoxCepNo.Location = new Point(550, 25);
            textBoxCepNo.Name = "textBoxCepNo";
            textBoxCepNo.Size = new Size(210, 23);
            textBoxCepNo.TabIndex = 1;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.DarkGoldenrod;
            labelEmail.BorderStyle = BorderStyle.Fixed3D;
            labelEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.Navy;
            labelEmail.Location = new Point(468, 56);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(45, 19);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(550, 54);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(210, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // labelIL
            // 
            labelIL.AutoSize = true;
            labelIL.BackColor = Color.DarkGoldenrod;
            labelIL.BorderStyle = BorderStyle.Fixed3D;
            labelIL.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelIL.ForeColor = Color.Navy;
            labelIL.Location = new Point(496, 85);
            labelIL.Name = "labelIL";
            labelIL.Size = new Size(20, 19);
            labelIL.TabIndex = 0;
            labelIL.Text = "İl:";
            // 
            // textBoxIL
            // 
            textBoxIL.Location = new Point(550, 83);
            textBoxIL.Name = "textBoxIL";
            textBoxIL.Size = new Size(210, 23);
            textBoxIL.TabIndex = 1;
            // 
            // labelIlçe
            // 
            labelIlçe.AutoSize = true;
            labelIlçe.BackColor = Color.DarkGoldenrod;
            labelIlçe.BorderStyle = BorderStyle.Fixed3D;
            labelIlçe.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelIlçe.ForeColor = Color.Navy;
            labelIlçe.Location = new Point(481, 113);
            labelIlçe.Name = "labelIlçe";
            labelIlçe.Size = new Size(33, 19);
            labelIlçe.TabIndex = 0;
            labelIlçe.Text = "İlçe:";
            // 
            // textBoxIlçe
            // 
            textBoxIlçe.Location = new Point(550, 112);
            textBoxIlçe.Name = "textBoxIlçe";
            textBoxIlçe.Size = new Size(210, 23);
            textBoxIlçe.TabIndex = 1;
            // 
            // labelAcikAdres
            // 
            labelAcikAdres.AutoSize = true;
            labelAcikAdres.BackColor = Color.DarkGoldenrod;
            labelAcikAdres.BorderStyle = BorderStyle.Fixed3D;
            labelAcikAdres.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAcikAdres.ForeColor = Color.Navy;
            labelAcikAdres.Location = new Point(434, 142);
            labelAcikAdres.Name = "labelAcikAdres";
            labelAcikAdres.Size = new Size(77, 19);
            labelAcikAdres.TabIndex = 0;
            labelAcikAdres.Text = "Açık Adres:";
            // 
            // textBoxAcikAdres
            // 
            textBoxAcikAdres.Location = new Point(550, 141);
            textBoxAcikAdres.Name = "textBoxAcikAdres";
            textBoxAcikAdres.Size = new Size(210, 23);
            textBoxAcikAdres.TabIndex = 1;
            // 
            // labelBirim
            // 
            labelBirim.AutoSize = true;
            labelBirim.BackColor = Color.DarkGoldenrod;
            labelBirim.BorderStyle = BorderStyle.Fixed3D;
            labelBirim.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirim.ForeColor = Color.Navy;
            labelBirim.Location = new Point(470, 172);
            labelBirim.Name = "labelBirim";
            labelBirim.Size = new Size(44, 19);
            labelBirim.TabIndex = 0;
            labelBirim.Text = "Birim:";
            // 
            // comboBoxBirim
            // 
            comboBoxBirim.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBirim.FormattingEnabled = true;
            comboBoxBirim.Location = new Point(550, 170);
            comboBoxBirim.Name = "comboBoxBirim";
            comboBoxBirim.Size = new Size(210, 23);
            comboBoxBirim.TabIndex = 2;
            // 
            // labelUnvan
            // 
            labelUnvan.AutoSize = true;
            labelUnvan.BackColor = Color.DarkGoldenrod;
            labelUnvan.BorderStyle = BorderStyle.Fixed3D;
            labelUnvan.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelUnvan.ForeColor = Color.Navy;
            labelUnvan.Location = new Point(460, 200);
            labelUnvan.Name = "labelUnvan";
            labelUnvan.Size = new Size(52, 19);
            labelUnvan.TabIndex = 0;
            labelUnvan.Text = "Unvan:";
            // 
            // comboBoxUnvan
            // 
            comboBoxUnvan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUnvan.FormattingEnabled = true;
            comboBoxUnvan.Location = new Point(550, 199);
            comboBoxUnvan.Name = "comboBoxUnvan";
            comboBoxUnvan.Size = new Size(210, 23);
            comboBoxUnvan.TabIndex = 2;
            // 
            // labelGirisSifresi
            // 
            labelGirisSifresi.AutoSize = true;
            labelGirisSifresi.BackColor = Color.DarkGoldenrod;
            labelGirisSifresi.BorderStyle = BorderStyle.Fixed3D;
            labelGirisSifresi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelGirisSifresi.ForeColor = Color.Navy;
            labelGirisSifresi.Location = new Point(436, 259);
            labelGirisSifresi.Name = "labelGirisSifresi";
            labelGirisSifresi.Size = new Size(78, 19);
            labelGirisSifresi.TabIndex = 0;
            labelGirisSifresi.Text = "Giriş Şifresi:";
            // 
            // textBoxGirisSifresi
            // 
            textBoxGirisSifresi.Location = new Point(550, 258);
            textBoxGirisSifresi.Name = "textBoxGirisSifresi";
            textBoxGirisSifresi.Size = new Size(210, 23);
            textBoxGirisSifresi.TabIndex = 1;
            // 
            // dateTimePickerSozlesmeTarihi
            // 
            dateTimePickerSozlesmeTarihi.CustomFormat = "yyyy-MM-dd";
            dateTimePickerSozlesmeTarihi.Format = DateTimePickerFormat.Custom;
            dateTimePickerSozlesmeTarihi.Location = new Point(168, 286);
            dateTimePickerSozlesmeTarihi.Name = "dateTimePickerSozlesmeTarihi";
            dateTimePickerSozlesmeTarihi.Size = new Size(210, 23);
            dateTimePickerSozlesmeTarihi.TabIndex = 3;
            // 
            // labelSozlesmeTarihi
            // 
            labelSozlesmeTarihi.AutoSize = true;
            labelSozlesmeTarihi.BackColor = Color.DarkGoldenrod;
            labelSozlesmeTarihi.BorderStyle = BorderStyle.Fixed3D;
            labelSozlesmeTarihi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelSozlesmeTarihi.ForeColor = Color.Navy;
            labelSozlesmeTarihi.Location = new Point(35, 287);
            labelSozlesmeTarihi.Name = "labelSozlesmeTarihi";
            labelSozlesmeTarihi.Size = new Size(105, 19);
            labelSozlesmeTarihi.TabIndex = 0;
            labelSozlesmeTarihi.Text = "Sözleşme Tarihi:";
            // 
            // buttonKaydet
            // 
            buttonKaydet.BackColor = Color.DarkOliveGreen;
            buttonKaydet.FlatAppearance.BorderColor = Color.DarkOliveGreen;
            buttonKaydet.FlatAppearance.BorderSize = 0;
            buttonKaydet.FlatAppearance.MouseDownBackColor = Color.Lime;
            buttonKaydet.FlatAppearance.MouseOverBackColor = Color.Crimson;
            buttonKaydet.FlatStyle = FlatStyle.Flat;
            buttonKaydet.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonKaydet.ForeColor = Color.LemonChiffon;
            buttonKaydet.Location = new Point(550, 308);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(162, 49);
            buttonKaydet.TabIndex = 4;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = false;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // labelDuzey
            // 
            labelDuzey.AutoSize = true;
            labelDuzey.BackColor = Color.DarkGoldenrod;
            labelDuzey.BorderStyle = BorderStyle.Fixed3D;
            labelDuzey.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDuzey.ForeColor = Color.Navy;
            labelDuzey.Location = new Point(462, 230);
            labelDuzey.Name = "labelDuzey";
            labelDuzey.Size = new Size(50, 19);
            labelDuzey.TabIndex = 0;
            labelDuzey.Text = "Düzey:";
            // 
            // comboBoxDuzey
            // 
            comboBoxDuzey.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDuzey.FormattingEnabled = true;
            comboBoxDuzey.Location = new Point(550, 228);
            comboBoxDuzey.Name = "comboBoxDuzey";
            comboBoxDuzey.Size = new Size(210, 23);
            comboBoxDuzey.TabIndex = 2;
            // 
            // FormPersonelKayitEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(790, 387);
            Controls.Add(buttonKaydet);
            Controls.Add(dateTimePickerSozlesmeTarihi);
            Controls.Add(dateTimePickerDogumTarihi);
            Controls.Add(comboBoxDuzey);
            Controls.Add(comboBoxUnvan);
            Controls.Add(comboBoxBirim);
            Controls.Add(comboBoxKanGrubu);
            Controls.Add(comboBoxCinsiyet);
            Controls.Add(textBoxDogumYeri);
            Controls.Add(textBoxSoyad);
            Controls.Add(textBoxAd);
            Controls.Add(textBoxGirisSifresi);
            Controls.Add(textBoxAcikAdres);
            Controls.Add(textBoxIlçe);
            Controls.Add(textBoxIL);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxCepNo);
            Controls.Add(textBoxBabaAdi);
            Controls.Add(textBoxAnneAdi);
            Controls.Add(textBoxTC);
            Controls.Add(labelKanGrubu);
            Controls.Add(labelDogumYeri);
            Controls.Add(labelSozlesmeTarihi);
            Controls.Add(labelDogumTarihi);
            Controls.Add(labelCinsiyet);
            Controls.Add(labelSoyad);
            Controls.Add(labelAd);
            Controls.Add(labelDuzey);
            Controls.Add(labelGirisSifresi);
            Controls.Add(labelUnvan);
            Controls.Add(labelBirim);
            Controls.Add(labelAcikAdres);
            Controls.Add(labelIlçe);
            Controls.Add(labelIL);
            Controls.Add(labelEmail);
            Controls.Add(labelCepNo);
            Controls.Add(labelBabaAdi);
            Controls.Add(labelAnneAdi);
            Controls.Add(labelTC);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(806, 426);
            MinimumSize = new Size(806, 426);
            Name = "FormPersonelKayitEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personel Kayıt Ekranı";
            TopMost = true;
            Load += FormPersonelKayitEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTC;
        private TextBox textBoxTC;
        private Label labelAd;
        private TextBox textBoxAd;
        private Label labelSoyad;
        private TextBox textBoxSoyad;
        private Label labelCinsiyet;
        private ComboBox comboBoxCinsiyet;
        private Label labelDogumTarihi;
        private DateTimePicker dateTimePickerDogumTarihi;
        private Label labelDogumYeri;
        private TextBox textBoxDogumYeri;
        private Label labelKanGrubu;
        private ComboBox comboBoxKanGrubu;
        private Label labelAnneAdi;
        private TextBox textBoxAnneAdi;
        private Label labelBabaAdi;
        private TextBox textBoxBabaAdi;
        private Label labelCepNo;
        private TextBox textBoxCepNo;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelIL;
        private TextBox textBoxIL;
        private Label labelIlçe;
        private TextBox textBoxIlçe;
        private Label labelAcikAdres;
        private TextBox textBoxAcikAdres;
        private Label labelBirim;
        private ComboBox comboBoxBirim;
        private Label labelUnvan;
        private ComboBox comboBoxUnvan;
        private Label labelGirisSifresi;
        private TextBox textBoxGirisSifresi;
        private DateTimePicker dateTimePickerSozlesmeTarihi;
        private Label labelSozlesmeTarihi;
        private Button buttonKaydet;
        private Label labelDuzey;
        private ComboBox comboBoxDuzey;
    }
}