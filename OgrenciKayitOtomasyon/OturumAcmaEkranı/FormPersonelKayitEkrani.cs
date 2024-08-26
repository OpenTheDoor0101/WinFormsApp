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
    public partial class FormPersonelKayitEkrani : Form
    {
        public FormPersonelKayitEkrani()
        {
            InitializeComponent();
        }

        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=Minuteman-III\SQLEXPRESS;Initial Catalog=StajProjesiOgrenciKayitOtomasyonuDB;Integrated Security=True");

        private void FormPersonelKayitEkrani_Load(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();

                string? personelBirim = "SELECT DISTINCT Birim FROM Birimler";
                string? personelUnvan = "SELECT DISTINCT Unvan FROM Birimler";
                string? personelDuzey = "SELECT DISTINCT Duzey FROM Birimler";

                SqlCommand birimSorgu = new SqlCommand(personelBirim, sqlBaglanti);
                SqlDataReader birimOku = birimSorgu.ExecuteReader();
                while (birimOku.Read())
                {
                    comboBoxBirim.Items.Add(birimOku[0]);
                }
                birimOku.Close();

                SqlCommand unvanSorgu = new SqlCommand(personelUnvan, sqlBaglanti);
                SqlDataReader unvanOku = unvanSorgu.ExecuteReader();
                while (unvanOku.Read())
                {
                    comboBoxUnvan.Items.Add(unvanOku[0]);
                }
                unvanOku.Close();

                SqlCommand duzeySorgu = new SqlCommand(personelDuzey, sqlBaglanti);
                SqlDataReader duzeyOku = duzeySorgu.ExecuteReader();
                while (duzeyOku.Read())
                {
                    comboBoxDuzey.Items.Add(duzeyOku[0]);
                }
                duzeyOku.Close();

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
        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();

                if (textBoxTC.Text == "" ||
                    textBoxAd.Text == "" ||
                    textBoxSoyad.Text == "" ||
                    comboBoxCinsiyet.Text == "" ||
                    dateTimePickerDogumTarihi.Text == "" ||
                    textBoxDogumYeri.Text == "" ||
                    comboBoxKanGrubu.Text == "" ||
                    textBoxAnneAdi.Text == "" ||
                    textBoxBabaAdi.Text == "" ||
                    textBoxCepNo.Text == "" ||
                    textBoxEmail.Text == "" ||
                    textBoxIL.Text == "" ||
                    textBoxIlçe.Text == "" ||
                    textBoxAcikAdres.Text == "" ||
                    comboBoxBirim.Text == "" ||
                    comboBoxUnvan.Text == "" ||
                    comboBoxDuzey.Text == "" ||
                    textBoxGirisSifresi.Text == "" ||
                    dateTimePickerSozlesmeTarihi.Text == "")
                {
                    MessageBox.Show("Tüm alanları doldurunuz.");
                    return;
                }

                string? sqlPersonelKayit = "INSERT INTO PersonelBilgileri (TC, Ad, Soyad, Cinsiyet, DogumTarihi, DogumYeri, KanGrubu, AnneAdi, BabaAdi, CepNo, Email, il, ilce, AcikAdres, Birim, Unvan, Duzey, SistemGirisSifresi, SozlesmeTarihi) VALUES ('"
                    + textBoxTC.Text + "','" +
                    textBoxAd.Text + "','" +
                    textBoxSoyad.Text + "','" +
                    comboBoxCinsiyet.Text + "','" +
                    dateTimePickerDogumTarihi.Text + "','" +
                    textBoxDogumYeri.Text + "','" +
                    comboBoxKanGrubu.Text + "','" +
                    textBoxAnneAdi.Text + "','" +
                    textBoxBabaAdi.Text + "','" +
                    textBoxCepNo.Text + "','" +
                    textBoxEmail.Text + "','" +
                    textBoxIL.Text + "','" +
                    textBoxIlçe.Text + "','" +
                    textBoxAcikAdres.Text + "','" +
                    comboBoxBirim.Text + "','" +
                    comboBoxUnvan.Text + "','" +
                    comboBoxDuzey.Text + "','" +
                    textBoxGirisSifresi.Text + "','" +
                    dateTimePickerSozlesmeTarihi.Text + "')";

                SqlCommand sqlKomutu = new SqlCommand(sqlPersonelKayit, sqlBaglanti);
                sqlKomutu.ExecuteNonQuery();
                MessageBox.Show("Personel kaydı başarılı.");

                textBoxTC.Clear();
                textBoxAd.Clear();
                textBoxSoyad.Clear();
                textBoxDogumYeri.Clear();
                textBoxAnneAdi.Clear();
                textBoxBabaAdi.Clear();
                textBoxCepNo.Clear();
                textBoxEmail.Clear();
                textBoxIL.Clear();
                textBoxIlçe.Clear();
                textBoxAcikAdres.Clear();
                textBoxGirisSifresi.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt sırasında hata oluştu!");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (sqlBaglanti != null)
                {
                    sqlBaglanti.Close();
                }
            }
        }
    }
}