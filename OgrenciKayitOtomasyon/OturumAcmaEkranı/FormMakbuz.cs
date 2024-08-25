using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DershaneOtomasyonEkranlari
{
    public partial class FormMakbuz : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-R1R5QMJ\SQLEXPRESS;Initial Catalog=StajProjesiOgrenciKayitOtomasyonuDB;Integrated Security=True; MultipleActiveResultSets=True;");

        public FormMakbuz()
        {
            InitializeComponent();
        }

        public string OdemeYapanMakbuz { get; set; }
        public string FormatliSimdikitarih { get; set; }
        public string VadeTarihi { get; set; }
        public string TaksitSayisi { get; set; }
        public string MakbuzTutar { get; set; }
        public string OgrNo { get; set; }

        private void FormMakbuz_Load(object sender, EventArgs e)
        {
            labelMakbuzTarihBilgi.Text = FormatliSimdikitarih.ToString();
            labelMakbuzMustBilgi.Text = OdemeYapanMakbuz.ToString();
            labelVadeTrhBilgi.Text = VadeTarihi.ToString();
            labelTaksitSayisiBilgi.Text = TaksitSayisi.ToString();
            labelTutarBilgi.Text = MakbuzTutar.ToString() + " " + "₺";
            labelTopTutarBilgi.Text = MakbuzTutar.ToString() + " " + "₺";
            labelOdemeYapanKisi.Text = OdemeYapanMakbuz.ToString();
            string OgrenciNo = OgrNo.ToString();

            try
            {
                sqlBaglanti.Open();

                string sqlKomut = "INSERT INTO MakbuzBilgileri (OgrenciNo, OdemeTarihi, Musteri, OdenenTaksitSayisi, VadeTarihi, TahsilatTipi, Tutar, Aciklama) VALUES (" +
                    " '" + OgrenciNo + "', " +
                    "'" + labelMakbuzTarihBilgi.Text + "', " +
                    "'" + labelMakbuzMustBilgi.Text + "', " +
                    "'" + labelTaksitSayisiBilgi.Text + "', " +
                    "'" + labelVadeTrhBilgi.Text + "', " +
                    "'" + labelTahsilatTipiBilgi.Text + "', " +
                    "'" + MakbuzTutar.ToString() + "', " +
                    "'" + labelMakbuzAciklamaBilgi.Text + "') ";

                Convert.ToInt32(OgrenciNo);
                Convert.ToInt32(labelTaksitSayisiBilgi.Text);
                Convert.ToDecimal(MakbuzTutar.ToString());

                SqlCommand makbuzKaydetme = new SqlCommand(sqlKomut, sqlBaglanti);

                if (makbuzKaydetme.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Makbuz kaydedilmiştir!");
                }
                else
                {
                    MessageBox.Show("Kayıt sırasında hata oldu!");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata!");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlBaglanti.Close();
            }
        }
    }
}
