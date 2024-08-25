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
                    dateTimePickerDogumTarihi.Text == "" ||
                    textBoxDogumYeri.Text == "" ||
                    textBoxAnneAdi.Text == "" ||
                    textBoxBabaAdi.Text == "" ||
                    comboBoxKanGrubu.Text == "" ||
                    textBoxCepNo.Text == "" ||
                    textBoxEmail.Text == "" ||
                    textBoxil.Text == "" ||
                    textBoxilçe.Text == "" ||
                    textBoxAcikAdres.Text == "")
                {
                    MessageBox.Show("Tüm alanları doldurunuz!");
                    return;
                }

                string sqlKomutu = "INSERT INTO OgrenciBilgileri VALUES ('" + textBoxOgrenciTC.Text + "','" +
                                                                              textBoxOgrenciAd.Text + "','" +
                                                                              textBoxOgrenciSoyad.Text + "','" +
                                                                              dateTimePickerDogumTarihi.Text + "','" +
                                                                              textBoxDogumYeri.Text + "','" +
                                                                              textBoxAnneAdi.Text + "','" +
                                                                              textBoxBabaAdi.Text + "','" +
                                                                              comboBoxKanGrubu.Text + "','" +
                                                                              textBoxCepNo.Text + "','" +
                                                                              textBoxEmail.Text + "','" +
                                                                              textBoxil.Text + "','" +
                                                                              textBoxilçe.Text + "','" +
                                                                              textBoxAcikAdres.Text + "')";

                SqlCommand sqlCommand = new SqlCommand(sqlKomutu, sqlBaglanti);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Öğrenci kaydı başarılı!");
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
