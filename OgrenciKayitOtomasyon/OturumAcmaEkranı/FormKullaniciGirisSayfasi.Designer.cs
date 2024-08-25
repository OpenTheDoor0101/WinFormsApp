namespace KullaniciGirisSayfasi
{
    partial class FormKullaniciGirisSayfasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullaniciGirisSayfasi));
            buttonOturumAc = new Button();
            labelPersonelID = new Label();
            textBoxPersonelID = new TextBox();
            textBoxSifre = new TextBox();
            labelSifre = new Label();
            checkBoxSifreGoster = new CheckBox();
            buttonKayitOl = new Button();
            pictureBoxGirisBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGirisBack).BeginInit();
            SuspendLayout();
            // 
            // buttonOturumAc
            // 
            buttonOturumAc.BackColor = Color.LimeGreen;
            buttonOturumAc.FlatAppearance.BorderColor = Color.LimeGreen;
            buttonOturumAc.FlatAppearance.BorderSize = 0;
            buttonOturumAc.FlatAppearance.MouseDownBackColor = Color.PaleGreen;
            buttonOturumAc.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            buttonOturumAc.FlatStyle = FlatStyle.Flat;
            buttonOturumAc.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOturumAc.ForeColor = SystemColors.ControlText;
            buttonOturumAc.Location = new Point(368, 285);
            buttonOturumAc.Name = "buttonOturumAc";
            buttonOturumAc.Size = new Size(149, 44);
            buttonOturumAc.TabIndex = 0;
            buttonOturumAc.Text = "OTURUM AÇ";
            buttonOturumAc.UseVisualStyleBackColor = false;
            buttonOturumAc.Click += buttonOturumAc_Click;
            // 
            // labelPersonelID
            // 
            labelPersonelID.AutoSize = true;
            labelPersonelID.BackColor = Color.LightGreen;
            labelPersonelID.BorderStyle = BorderStyle.Fixed3D;
            labelPersonelID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPersonelID.Location = new Point(265, 138);
            labelPersonelID.Name = "labelPersonelID";
            labelPersonelID.Size = new Size(92, 22);
            labelPersonelID.TabIndex = 1;
            labelPersonelID.Text = "Personel ID:";
            // 
            // textBoxPersonelID
            // 
            textBoxPersonelID.Location = new Point(368, 134);
            textBoxPersonelID.Name = "textBoxPersonelID";
            textBoxPersonelID.Size = new Size(196, 27);
            textBoxPersonelID.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(368, 193);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.PasswordChar = '*';
            textBoxSifre.Size = new Size(196, 27);
            textBoxSifre.TabIndex = 2;
            // 
            // labelSifre
            // 
            labelSifre.AutoSize = true;
            labelSifre.BackColor = Color.LightGreen;
            labelSifre.BorderStyle = BorderStyle.Fixed3D;
            labelSifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelSifre.Location = new Point(307, 197);
            labelSifre.Name = "labelSifre";
            labelSifre.Size = new Size(46, 22);
            labelSifre.TabIndex = 1;
            labelSifre.Text = "Şifre:";
            // 
            // checkBoxSifreGoster
            // 
            checkBoxSifreGoster.AutoSize = true;
            checkBoxSifreGoster.BackColor = Color.Turquoise;
            checkBoxSifreGoster.FlatAppearance.BorderSize = 0;
            checkBoxSifreGoster.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxSifreGoster.ForeColor = SystemColors.ControlText;
            checkBoxSifreGoster.Location = new Point(368, 230);
            checkBoxSifreGoster.Margin = new Padding(3, 4, 3, 4);
            checkBoxSifreGoster.Name = "checkBoxSifreGoster";
            checkBoxSifreGoster.Size = new Size(141, 27);
            checkBoxSifreGoster.TabIndex = 3;
            checkBoxSifreGoster.Text = "Şifreyi Göster";
            checkBoxSifreGoster.UseVisualStyleBackColor = false;
            checkBoxSifreGoster.CheckedChanged += checkBoxSifreGoster_CheckedChanged;
            // 
            // buttonKayitOl
            // 
            buttonKayitOl.BackColor = Color.Cyan;
            buttonKayitOl.FlatAppearance.BorderSize = 0;
            buttonKayitOl.FlatAppearance.MouseDownBackColor = Color.Azure;
            buttonKayitOl.FlatAppearance.MouseOverBackColor = Color.SpringGreen;
            buttonKayitOl.FlatStyle = FlatStyle.Flat;
            buttonKayitOl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonKayitOl.ForeColor = Color.Navy;
            buttonKayitOl.Location = new Point(222, 292);
            buttonKayitOl.Margin = new Padding(3, 4, 3, 4);
            buttonKayitOl.Name = "buttonKayitOl";
            buttonKayitOl.Size = new Size(88, 37);
            buttonKayitOl.TabIndex = 4;
            buttonKayitOl.Text = "Kayıt Ol";
            buttonKayitOl.UseVisualStyleBackColor = false;
            buttonKayitOl.Click += buttonKayitOl_Click;
            // 
            // pictureBoxGirisBack
            // 
            pictureBoxGirisBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxGirisBack.Image = (Image)resources.GetObject("pictureBoxGirisBack.Image");
            pictureBoxGirisBack.Location = new Point(-3, -2);
            pictureBoxGirisBack.Name = "pictureBoxGirisBack";
            pictureBoxGirisBack.Size = new Size(871, 481);
            pictureBoxGirisBack.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGirisBack.TabIndex = 5;
            pictureBoxGirisBack.TabStop = false;
            // 
            // FormKullaniciGirisSayfasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(862, 475);
            Controls.Add(buttonKayitOl);
            Controls.Add(checkBoxSifreGoster);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxPersonelID);
            Controls.Add(labelSifre);
            Controls.Add(labelPersonelID);
            Controls.Add(buttonOturumAc);
            Controls.Add(pictureBoxGirisBack);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(880, 522);
            MinimumSize = new Size(880, 522);
            Name = "FormKullaniciGirisSayfasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Giriş Ekranı";
            TopMost = true;
            Load += FormKullaniciGirisSayfasi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxGirisBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOturumAc;
        private Label labelPersonelID;
        private TextBox textBoxPersonelID;
        private TextBox textBoxSifre;
        private Label labelSifre;
        private CheckBox checkBoxSifreGoster;
        private Button buttonKayitOl;
        private PictureBox pictureBoxGirisBack;
    }
}