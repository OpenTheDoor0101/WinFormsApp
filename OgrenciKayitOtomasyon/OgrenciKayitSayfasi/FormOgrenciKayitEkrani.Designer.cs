namespace DershaneOtomasyonEkranlari
{
    partial class FormOgrenciKayitEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgrenciKayitEkrani));
            labelOgrenciAd = new Label();
            textBoxOgrenciAd = new TextBox();
            textBoxOgrenciSoyad = new TextBox();
            labelOgrenciSoyad = new Label();
            labelOgrenciTCNo = new Label();
            textBoxOgrenciTC = new TextBox();
            labelDogumTarihi = new Label();
            labelDogumYeri = new Label();
            labelAnneAdi = new Label();
            labelBabaAdi = new Label();
            labelKanGrubu = new Label();
            labelCepNo = new Label();
            labelEmail = new Label();
            labelil = new Label();
            labelilçe = new Label();
            labelAcikAdres = new Label();
            textBoxDogumYeri = new TextBox();
            textBoxAnneAdi = new TextBox();
            textBoxBabaAdi = new TextBox();
            comboBoxKanGrubu = new ComboBox();
            textBoxCepNo = new TextBox();
            textBoxEmail = new TextBox();
            textBoxil = new TextBox();
            textBoxilçe = new TextBox();
            textBoxAcikAdres = new TextBox();
            buttonOgrKaydet = new Button();
            dateTimePickerDogumTarihi = new DateTimePicker();
            SuspendLayout();
            // 
            // labelOgrenciAd
            // 
            labelOgrenciAd.AutoSize = true;
            labelOgrenciAd.BackColor = Color.DarkKhaki;
            labelOgrenciAd.BorderStyle = BorderStyle.Fixed3D;
            labelOgrenciAd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelOgrenciAd.Location = new Point(26, 44);
            labelOgrenciAd.Name = "labelOgrenciAd";
            labelOgrenciAd.Size = new Size(72, 17);
            labelOgrenciAd.TabIndex = 0;
            labelOgrenciAd.Text = "İsim Giriniz:";
            // 
            // textBoxOgrenciAd
            // 
            textBoxOgrenciAd.Location = new Point(122, 41);
            textBoxOgrenciAd.Name = "textBoxOgrenciAd";
            textBoxOgrenciAd.Size = new Size(250, 23);
            textBoxOgrenciAd.TabIndex = 1;
            // 
            // textBoxOgrenciSoyad
            // 
            textBoxOgrenciSoyad.Location = new Point(122, 70);
            textBoxOgrenciSoyad.Name = "textBoxOgrenciSoyad";
            textBoxOgrenciSoyad.Size = new Size(250, 23);
            textBoxOgrenciSoyad.TabIndex = 1;
            // 
            // labelOgrenciSoyad
            // 
            labelOgrenciSoyad.AutoSize = true;
            labelOgrenciSoyad.BackColor = Color.DarkKhaki;
            labelOgrenciSoyad.BorderStyle = BorderStyle.Fixed3D;
            labelOgrenciSoyad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelOgrenciSoyad.Location = new Point(7, 73);
            labelOgrenciSoyad.Name = "labelOgrenciSoyad";
            labelOgrenciSoyad.Size = new Size(91, 17);
            labelOgrenciSoyad.TabIndex = 0;
            labelOgrenciSoyad.Text = "Soyisim Giriniz:";
            // 
            // labelOgrenciTCNo
            // 
            labelOgrenciTCNo.AutoSize = true;
            labelOgrenciTCNo.BackColor = Color.DarkKhaki;
            labelOgrenciTCNo.BorderStyle = BorderStyle.Fixed3D;
            labelOgrenciTCNo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelOgrenciTCNo.Location = new Point(12, 15);
            labelOgrenciTCNo.Name = "labelOgrenciTCNo";
            labelOgrenciTCNo.Size = new Size(86, 17);
            labelOgrenciTCNo.TabIndex = 2;
            labelOgrenciTCNo.Text = "T.C. Kimlik No:";
            // 
            // textBoxOgrenciTC
            // 
            textBoxOgrenciTC.Location = new Point(122, 12);
            textBoxOgrenciTC.Name = "textBoxOgrenciTC";
            textBoxOgrenciTC.Size = new Size(250, 23);
            textBoxOgrenciTC.TabIndex = 3;
            // 
            // labelDogumTarihi
            // 
            labelDogumTarihi.AutoSize = true;
            labelDogumTarihi.BackColor = Color.DarkKhaki;
            labelDogumTarihi.BorderStyle = BorderStyle.Fixed3D;
            labelDogumTarihi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDogumTarihi.Location = new Point(13, 104);
            labelDogumTarihi.Name = "labelDogumTarihi";
            labelDogumTarihi.Size = new Size(85, 17);
            labelDogumTarihi.TabIndex = 4;
            labelDogumTarihi.Text = "Doğum Tarihi:\r\n";
            // 
            // labelDogumYeri
            // 
            labelDogumYeri.AutoSize = true;
            labelDogumYeri.BackColor = Color.DarkKhaki;
            labelDogumYeri.BorderStyle = BorderStyle.Fixed3D;
            labelDogumYeri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDogumYeri.Location = new Point(23, 129);
            labelDogumYeri.Name = "labelDogumYeri";
            labelDogumYeri.Size = new Size(75, 17);
            labelDogumYeri.TabIndex = 4;
            labelDogumYeri.Text = "Doğum Yeri:";
            // 
            // labelAnneAdi
            // 
            labelAnneAdi.AutoSize = true;
            labelAnneAdi.BackColor = Color.DarkKhaki;
            labelAnneAdi.BorderStyle = BorderStyle.Fixed3D;
            labelAnneAdi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAnneAdi.Location = new Point(37, 158);
            labelAnneAdi.Name = "labelAnneAdi";
            labelAnneAdi.Size = new Size(61, 17);
            labelAnneAdi.TabIndex = 4;
            labelAnneAdi.Text = "Anne Adı:";
            // 
            // labelBabaAdi
            // 
            labelBabaAdi.AutoSize = true;
            labelBabaAdi.BackColor = Color.DarkKhaki;
            labelBabaAdi.BorderStyle = BorderStyle.Fixed3D;
            labelBabaAdi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBabaAdi.Location = new Point(39, 187);
            labelBabaAdi.Name = "labelBabaAdi";
            labelBabaAdi.Size = new Size(59, 17);
            labelBabaAdi.TabIndex = 4;
            labelBabaAdi.Text = "Baba Adı:";
            // 
            // labelKanGrubu
            // 
            labelKanGrubu.AutoSize = true;
            labelKanGrubu.BackColor = Color.DarkKhaki;
            labelKanGrubu.BorderStyle = BorderStyle.Fixed3D;
            labelKanGrubu.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelKanGrubu.Location = new Point(30, 216);
            labelKanGrubu.Name = "labelKanGrubu";
            labelKanGrubu.Size = new Size(68, 17);
            labelKanGrubu.TabIndex = 4;
            labelKanGrubu.Text = "Kan Grubu:";
            // 
            // labelCepNo
            // 
            labelCepNo.AutoSize = true;
            labelCepNo.BackColor = Color.DarkKhaki;
            labelCepNo.BorderStyle = BorderStyle.Fixed3D;
            labelCepNo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCepNo.Location = new Point(47, 245);
            labelCepNo.Name = "labelCepNo";
            labelCepNo.Size = new Size(51, 17);
            labelCepNo.TabIndex = 4;
            labelCepNo.Text = "Cep No:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.DarkKhaki;
            labelEmail.BorderStyle = BorderStyle.Fixed3D;
            labelEmail.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(52, 274);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 17);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "E-mail:";
            // 
            // labelil
            // 
            labelil.AutoSize = true;
            labelil.BackColor = Color.DarkKhaki;
            labelil.BorderStyle = BorderStyle.Fixed3D;
            labelil.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelil.Location = new Point(79, 305);
            labelil.Name = "labelil";
            labelil.Size = new Size(19, 17);
            labelil.TabIndex = 4;
            labelil.Text = "İl:";
            // 
            // labelilçe
            // 
            labelilçe.AutoSize = true;
            labelilçe.BackColor = Color.DarkKhaki;
            labelilçe.BorderStyle = BorderStyle.Fixed3D;
            labelilçe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelilçe.Location = new Point(67, 334);
            labelilçe.Name = "labelilçe";
            labelilçe.Size = new Size(31, 17);
            labelilçe.TabIndex = 4;
            labelilçe.Text = "İlçe:";
            // 
            // labelAcikAdres
            // 
            labelAcikAdres.AutoSize = true;
            labelAcikAdres.BackColor = Color.DarkKhaki;
            labelAcikAdres.BorderStyle = BorderStyle.Fixed3D;
            labelAcikAdres.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAcikAdres.Location = new Point(30, 363);
            labelAcikAdres.Name = "labelAcikAdres";
            labelAcikAdres.Size = new Size(68, 17);
            labelAcikAdres.TabIndex = 4;
            labelAcikAdres.Text = "Açık Adres:";
            // 
            // textBoxDogumYeri
            // 
            textBoxDogumYeri.Location = new Point(122, 126);
            textBoxDogumYeri.Name = "textBoxDogumYeri";
            textBoxDogumYeri.Size = new Size(250, 23);
            textBoxDogumYeri.TabIndex = 1;
            // 
            // textBoxAnneAdi
            // 
            textBoxAnneAdi.Location = new Point(122, 155);
            textBoxAnneAdi.Name = "textBoxAnneAdi";
            textBoxAnneAdi.Size = new Size(250, 23);
            textBoxAnneAdi.TabIndex = 1;
            // 
            // textBoxBabaAdi
            // 
            textBoxBabaAdi.Location = new Point(122, 184);
            textBoxBabaAdi.Name = "textBoxBabaAdi";
            textBoxBabaAdi.Size = new Size(250, 23);
            textBoxBabaAdi.TabIndex = 1;
            // 
            // comboBoxKanGrubu
            // 
            comboBoxKanGrubu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxKanGrubu.FormattingEnabled = true;
            comboBoxKanGrubu.Items.AddRange(new object[] { "AB+", "AB-", "B+", "B-", "A+", "A-", "0+", "0-" });
            comboBoxKanGrubu.Location = new Point(122, 213);
            comboBoxKanGrubu.Name = "comboBoxKanGrubu";
            comboBoxKanGrubu.Size = new Size(250, 23);
            comboBoxKanGrubu.TabIndex = 6;
            // 
            // textBoxCepNo
            // 
            textBoxCepNo.Location = new Point(122, 242);
            textBoxCepNo.Name = "textBoxCepNo";
            textBoxCepNo.Size = new Size(250, 23);
            textBoxCepNo.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(122, 271);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(250, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxil
            // 
            textBoxil.Location = new Point(122, 302);
            textBoxil.Name = "textBoxil";
            textBoxil.Size = new Size(250, 23);
            textBoxil.TabIndex = 1;
            // 
            // textBoxilçe
            // 
            textBoxilçe.Location = new Point(122, 331);
            textBoxilçe.Name = "textBoxilçe";
            textBoxilçe.Size = new Size(250, 23);
            textBoxilçe.TabIndex = 1;
            // 
            // textBoxAcikAdres
            // 
            textBoxAcikAdres.Location = new Point(122, 360);
            textBoxAcikAdres.Name = "textBoxAcikAdres";
            textBoxAcikAdres.Size = new Size(250, 23);
            textBoxAcikAdres.TabIndex = 1;
            // 
            // buttonOgrKaydet
            // 
            buttonOgrKaydet.BackColor = Color.Crimson;
            buttonOgrKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOgrKaydet.ForeColor = SystemColors.InactiveBorder;
            buttonOgrKaydet.Location = new Point(156, 400);
            buttonOgrKaydet.Name = "buttonOgrKaydet";
            buttonOgrKaydet.Size = new Size(166, 40);
            buttonOgrKaydet.TabIndex = 7;
            buttonOgrKaydet.Text = "Kaydet";
            buttonOgrKaydet.UseVisualStyleBackColor = false;
            buttonOgrKaydet.Click += buttonOgrKaydet_Click;
            // 
            // dateTimePickerDogumTarihi
            // 
            dateTimePickerDogumTarihi.CustomFormat = "yyyy-MM-dd";
            dateTimePickerDogumTarihi.Format = DateTimePickerFormat.Custom;
            dateTimePickerDogumTarihi.Location = new Point(122, 98);
            dateTimePickerDogumTarihi.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerDogumTarihi.Name = "dateTimePickerDogumTarihi";
            dateTimePickerDogumTarihi.Size = new Size(250, 23);
            dateTimePickerDogumTarihi.TabIndex = 8;
            // 
            // FormOgrenciKayitEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(384, 470);
            Controls.Add(dateTimePickerDogumTarihi);
            Controls.Add(buttonOgrKaydet);
            Controls.Add(comboBoxKanGrubu);
            Controls.Add(labelAcikAdres);
            Controls.Add(labelilçe);
            Controls.Add(labelil);
            Controls.Add(labelEmail);
            Controls.Add(labelCepNo);
            Controls.Add(labelKanGrubu);
            Controls.Add(labelBabaAdi);
            Controls.Add(labelAnneAdi);
            Controls.Add(labelDogumYeri);
            Controls.Add(labelDogumTarihi);
            Controls.Add(textBoxOgrenciTC);
            Controls.Add(labelOgrenciTCNo);
            Controls.Add(textBoxAcikAdres);
            Controls.Add(textBoxilçe);
            Controls.Add(textBoxil);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxCepNo);
            Controls.Add(textBoxBabaAdi);
            Controls.Add(textBoxAnneAdi);
            Controls.Add(textBoxDogumYeri);
            Controls.Add(textBoxOgrenciSoyad);
            Controls.Add(textBoxOgrenciAd);
            Controls.Add(labelOgrenciSoyad);
            Controls.Add(labelOgrenciAd);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(400, 509);
            MinimumSize = new Size(400, 509);
            Name = "FormOgrenciKayitEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenci Kayıt Ekranı";
            Load += FormOgrenciKayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private Label labelOgrenciAd;
        private TextBox textBoxOgrenciAd;
        private TextBox textBoxOgrenciSoyad;
        private Label labelOgrenciSoyad;
        private Label labelOgrenciTCNo;
        private TextBox textBoxOgrenciTC;
        private Label labelDogumTarihi;
        private Label labelDogumYeri;
        private Label labelAnneAdi;
        private Label labelBabaAdi;
        private Label labelKanGrubu;
        private Label labelCepNo;
        private Label labelEmail;
        private Label labelil;
        private Label labelilçe;
        private Label labelAcikAdres;
        private TextBox textBoxDogumYeri;
        private TextBox textBoxAnneAdi;
        private TextBox textBoxBabaAdi;
        private ComboBox comboBoxKanGrubu;
        private TextBox textBoxCepNo;
        private TextBox textBoxEmail;
        private TextBox textBoxil;
        private TextBox textBoxilçe;
        private TextBox textBoxAcikAdres;
        private Button buttonOgrKaydet;
        private DateTimePicker dateTimePickerDogumTarihi;
    }
}