using System.Data.SqlClient;

namespace OgrenciKayitSayfasi
{
    public partial class FormOgrenciKayit : Form
    {
        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=StajProjesiOgrenciKayitOtomasyonuDB;Integrated Security=True");

        public FormOgrenciKayit()
        {
            InitializeComponent();
        }

        private void FormOgrenciKayit_Load(object sender, EventArgs e)
        {

        }

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
                    MessageBox.Show("Tüm alanlarý doldurunuz!");
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
                MessageBox.Show("Öðrenci kaydý baþarýlý!");
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
                MessageBox.Show("Kayýt sýrasýnda hata oluþtu!");
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