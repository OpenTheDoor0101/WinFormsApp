namespace DershaneOtomasyonEkranlari
{
    partial class FormSecim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecim));
            buttonOgrKayit = new Button();
            buttonPersKayit = new Button();
            pictureBoxOgr = new PictureBox();
            pictureBoxPers = new PictureBox();
            buttonKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOgr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPers).BeginInit();
            SuspendLayout();
            // 
            // buttonOgrKayit
            // 
            buttonOgrKayit.BackColor = Color.SeaGreen;
            buttonOgrKayit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOgrKayit.ForeColor = SystemColors.Control;
            buttonOgrKayit.Location = new Point(102, 364);
            buttonOgrKayit.Name = "buttonOgrKayit";
            buttonOgrKayit.Size = new Size(172, 50);
            buttonOgrKayit.TabIndex = 0;
            buttonOgrKayit.Text = "Öğrenci Kaydı";
            buttonOgrKayit.UseVisualStyleBackColor = false;
            buttonOgrKayit.Click += buttonOgrKayit_Click;
            // 
            // buttonPersKayit
            // 
            buttonPersKayit.BackColor = Color.SeaGreen;
            buttonPersKayit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPersKayit.ForeColor = SystemColors.Control;
            buttonPersKayit.Location = new Point(476, 364);
            buttonPersKayit.Name = "buttonPersKayit";
            buttonPersKayit.Size = new Size(180, 50);
            buttonPersKayit.TabIndex = 0;
            buttonPersKayit.Text = "Personel Kaydı";
            buttonPersKayit.UseVisualStyleBackColor = false;
            buttonPersKayit.Click += buttonPersKayit_Click;
            // 
            // pictureBoxOgr
            // 
            pictureBoxOgr.Image = (Image)resources.GetObject("pictureBoxOgr.Image");
            pictureBoxOgr.Location = new Point(37, 49);
            pictureBoxOgr.Name = "pictureBoxOgr";
            pictureBoxOgr.Size = new Size(319, 278);
            pictureBoxOgr.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOgr.TabIndex = 1;
            pictureBoxOgr.TabStop = false;
            // 
            // pictureBoxPers
            // 
            pictureBoxPers.Image = (Image)resources.GetObject("pictureBoxPers.Image");
            pictureBoxPers.Location = new Point(395, 49);
            pictureBoxPers.Name = "pictureBoxPers";
            pictureBoxPers.Size = new Size(328, 278);
            pictureBoxPers.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPers.TabIndex = 1;
            pictureBoxPers.TabStop = false;
            // 
            // buttonKapat
            // 
            buttonKapat.BackColor = Color.Crimson;
            buttonKapat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonKapat.ForeColor = SystemColors.Control;
            buttonKapat.Location = new Point(672, 2);
            buttonKapat.Name = "buttonKapat";
            buttonKapat.Size = new Size(75, 31);
            buttonKapat.TabIndex = 2;
            buttonKapat.Text = "Kapat";
            buttonKapat.UseVisualStyleBackColor = false;
            buttonKapat.Click += buttonKapat_Click;
            // 
            // FormSecim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(759, 436);
            ControlBox = false;
            Controls.Add(buttonKapat);
            Controls.Add(pictureBoxPers);
            Controls.Add(pictureBoxOgr);
            Controls.Add(buttonPersKayit);
            Controls.Add(buttonOgrKayit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSecim";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSecim";
            TopMost = true;
            TransparencyKey = Color.Transparent;
            Load += FormSecim_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxOgr).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOgrKayit;
        private Button buttonPersKayit;
        private PictureBox pictureBoxOgr;
        private PictureBox pictureBoxPers;
        private Button buttonKapat;
    }
}