namespace Ücret_Takip_Ekranı
{
    partial class FormUcretTakipEkrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUcretTakipEkrani));
            labelOgrenciNo = new Label();
            textBoxOgrenciNo = new TextBox();
            buttonSorgula = new Button();
            richTextBoxSorgular = new RichTextBox();
            SuspendLayout();
            // 
            // labelOgrenciNo
            // 
            labelOgrenciNo.AutoSize = true;
            labelOgrenciNo.BackColor = Color.SaddleBrown;
            labelOgrenciNo.BorderStyle = BorderStyle.Fixed3D;
            labelOgrenciNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelOgrenciNo.ForeColor = SystemColors.Control;
            labelOgrenciNo.Location = new Point(12, 87);
            labelOgrenciNo.Name = "labelOgrenciNo";
            labelOgrenciNo.Size = new Size(100, 23);
            labelOgrenciNo.TabIndex = 0;
            labelOgrenciNo.Text = "Öğrenci No:";
            // 
            // textBoxOgrenciNo
            // 
            textBoxOgrenciNo.Location = new Point(132, 87);
            textBoxOgrenciNo.Margin = new Padding(3, 2, 3, 2);
            textBoxOgrenciNo.Name = "textBoxOgrenciNo";
            textBoxOgrenciNo.Size = new Size(108, 23);
            textBoxOgrenciNo.TabIndex = 1;
            // 
            // buttonSorgula
            // 
            buttonSorgula.BackColor = Color.Goldenrod;
            buttonSorgula.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSorgula.ForeColor = Color.Navy;
            buttonSorgula.Location = new Point(65, 179);
            buttonSorgula.Name = "buttonSorgula";
            buttonSorgula.Size = new Size(106, 44);
            buttonSorgula.TabIndex = 2;
            buttonSorgula.Text = "Sorgula";
            buttonSorgula.UseVisualStyleBackColor = false;
            buttonSorgula.Click += buttonSorgula_Click;
            // 
            // richTextBoxSorgular
            // 
            richTextBoxSorgular.Location = new Point(271, 22);
            richTextBoxSorgular.Name = "richTextBoxSorgular";
            richTextBoxSorgular.Size = new Size(262, 245);
            richTextBoxSorgular.TabIndex = 3;
            richTextBoxSorgular.Text = "";
            // 
            // FormUcretTakipEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(576, 310);
            Controls.Add(richTextBoxSorgular);
            Controls.Add(buttonSorgula);
            Controls.Add(textBoxOgrenciNo);
            Controls.Add(labelOgrenciNo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(592, 349);
            MinimumSize = new Size(592, 349);
            Name = "FormUcretTakipEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ücret Takip Ekranı";
            FormClosed += FormUcretTakipEkrani_FormClosed;
            Load += FormUcretTakipEkrani_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelOgrenciNo;
        private TextBox textBoxOgrenciNo;
        private Button buttonSorgula;
        private RichTextBox richTextBoxSorgular;
    }
}