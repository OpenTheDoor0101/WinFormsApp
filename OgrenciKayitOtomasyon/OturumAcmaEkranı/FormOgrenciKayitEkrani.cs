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
using System.Globalization;

namespace DershaneOtomasyonEkranlari
{
    public partial class FormOgrenciKayitEkrani : Form
    {
        public FormOgrenciKayitEkrani()
        {
            InitializeComponent();
        }

        private void FormOgrenciKayit_Load(object sender, EventArgs e)
        {

        }

        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=StajProjesiOgrenciKayitOtomasyonuDB;Integrated Security=True");
        private void buttonOgrKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();

                if (textBoxOgrenciTC.Text == "" ||
                    textBoxOgrenciAd.Text == "" ||
                    textBoxOgrenciSoyad.Text == "" ||
                    comboBoxCinsiyet.Text == "" ||
                    dateTimePickerDogumTarihi.Text == "" ||
                    textBoxDogumYeri.Text == "" ||
                    textBoxAnneAdi.Text == "" ||
                    textBoxBabaAdi.Text == "" ||
                    comboBoxKanGrubu.Text == "" ||
                    textBoxCepNo.Text == "" ||
                    textBoxEmail.Text == "" ||
                    textBoxil.Text == "" ||
                    textBoxilçe.Text == "" ||
                    textBoxAcikAdres.Text == "" ||
                    dateTimePickerKayitTarihi.Text == "" ||
                    dateTimePickerKayitBitisTarihi.Text == "" ||
                    textBoxYillikTutar.Text == "" ||
                    textBoxAylikTutar.Text == "" ||
                    comboBoxTaksitSayisi.Text == "" ||
                    textBoxKalanYillikTutar.Text == "")
                {
                    MessageBox.Show("Tüm alanları doldurunuz!");
                    return;
                }

                string sqlKomutuOgrenciBilgi = "INSERT INTO OgrenciBilgileri (OgrenciTCno, Ad, Soyad, Cinsiyet, DogumTarihi, DogumYeri, AnneAdi, BabaAdi, KanGrubu, CepNo, Email, il, ilce, AcikAdres) VALUES ('"
                    + textBoxOgrenciTC.Text + "','" +
                    textBoxOgrenciAd.Text + "','" +
                    textBoxOgrenciSoyad.Text + "','" +
                    comboBoxCinsiyet.Text + "', '" +
                    dateTimePickerDogumTarihi.Text + "','" +
                    textBoxDogumYeri.Text + "','" +
                    textBoxAnneAdi.Text + "','" +
                    textBoxBabaAdi.Text + "','" +
                    comboBoxKanGrubu.Text + "','" +
                    textBoxCepNo.Text + "','" +
                    textBoxEmail.Text + "','" +
                    textBoxil.Text + "','" +
                    textBoxilçe.Text + "','" +
                    textBoxAcikAdres.Text + "' )";

                SqlCommand sqlCommandOgrBilgi = new SqlCommand(sqlKomutuOgrenciBilgi, sqlBaglanti);
                SqlDataReader sqlDataReaderOgrBilgi = sqlCommandOgrBilgi.ExecuteReader();
                
                if (sqlDataReaderOgrBilgi.Read())
                {
                    sqlCommandOgrBilgi.ExecuteNonQuery();

                    string KayitOgrNo = "SELECT TOP 1 OgrenciNo FROM OgrenciBilgileri ORDER BY OgrenciNo DESC";
                    SqlCommand SqlCommandKayitOgrNo = new SqlCommand(KayitOgrNo, sqlBaglanti);
                    SqlDataReader SqlReaderKayitOgrNo = SqlCommandKayitOgrNo.ExecuteReader();

                    if (SqlReaderKayitOgrNo.Read())
                    {
                        string OgrNoKayit = SqlReaderKayitOgrNo[0].ToString();

                        string sqlKomutuOgrenciKayitBilgi = "INSERT INTO OgrenciKayitBilgileri (OgrenciNo, KayitTarihi, KayitBitisTarihi, YillikTutar, KalanYillikTutar, AylikTutar, TaksitSayisi) VALUES ('" +
                        OgrNoKayit + "', '" +
                        dateTimePickerKayitTarihi.Text + "','" +
                        dateTimePickerKayitBitisTarihi.Text + "','" +
                        textBoxYillikTutar.Text + "','" +
                        textBoxKalanYillikTutar.Text + "','" +
                        textBoxAylikTutar.Text + "'," +
                        comboBoxTaksitSayisi.Text + ")";

                        Convert.ToInt32(OgrNoKayit);
                        Convert.ToDecimal(textBoxYillikTutar.Text);
                        Convert.ToDecimal(textBoxAylikTutar.Text);
                        Convert.ToInt16(comboBoxTaksitSayisi.Text);
                        Convert.ToDecimal(textBoxKalanYillikTutar.Text);
                        SqlReaderKayitOgrNo.Close();

                        SqlCommand sqlCommandKayitBilgi = new SqlCommand(sqlKomutuOgrenciKayitBilgi, sqlBaglanti);
                        sqlCommandKayitBilgi.ExecuteNonQuery();

                        MessageBox.Show("Öğrenci kaydı başarılı.");

                        textBoxOgrenciTC.Clear();
                        textBoxOgrenciAd.Clear();
                        textBoxOgrenciSoyad.Clear();
                        textBoxDogumYeri.Clear();
                        textBoxAnneAdi.Clear();
                        textBoxBabaAdi.Clear();
                        textBoxCepNo.Clear();
                        textBoxEmail.Clear();
                        textBoxil.Clear();
                        textBoxilçe.Clear();
                        textBoxAcikAdres.Clear();
                        textBoxYillikTutar.Clear();
                        textBoxAylikTutar.Clear();
                        textBoxKalanYillikTutar.Clear();
                    }
                }

                
            }

            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu!");
                MessageBox.Show(ex.Message);
            }

            finally
            {
                if (sqlBaglanti != null)
                    sqlBaglanti.Close();
            }
        }
    }
}