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
                    textBoxil�e.Text == "" ||
                    textBoxAcikAdres.Text == "")
                {
                    MessageBox.Show("T�m alanlar� doldurunuz!");
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
                                                                              textBoxil�e.Text + "','" +
                                                                              textBoxAcikAdres.Text + "')";

                SqlCommand sqlCommand = new SqlCommand(sqlKomutu, sqlBaglanti);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("��renci kayd� ba�ar�l�!");
                textBoxOgrenciTC.Clear();
                textBoxOgrenciAd.Clear();
                textBoxOgrenciSoyad.Clear();
                textBoxDogumYeri.Clear();
                textBoxAnneAdi.Clear();
                textBoxBabaAdi.Clear();

                textBoxCepNo.Clear();
                textBoxEmail.Clear();
                textBoxil.Clear();
                textBoxil�e.Clear();
                textBoxAcikAdres.Clear();

            }

            catch (Exception ex)
            {
                MessageBox.Show("Kay�t s�ras�nda hata olu�tu!");
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