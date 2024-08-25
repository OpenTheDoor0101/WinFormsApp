using System.Data.SqlClient;

namespace Ücret_Takip_Ekranı
{
    public partial class FormUcretTakipEkrani : Form
    {
        public FormUcretTakipEkrani()
        {
            InitializeComponent();
        }

        private void FormUcretTakipEkrani_Load(object sender, EventArgs e)
        {

        }

        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog = StajProjesiOgrenciKayitOtomasyonuDB; Integrated Security = True;  MultipleActiveResultSets=True;");
        private void buttonSorgula_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();

                string sqlUcretSorgu = "SELECT Ad, Soyad, YillikTutar, AylikTutar, TaksitSayisi FROM OgrenciBilgileri INNER JOIN OgrenciKayitBilgileri ON OgrenciBilgileri.ID = OgrenciKayitBilgileri.ID WHERE OgrenciBilgileri.OgrenciNo = ('" + (textBoxOgrenciNo.Text) + "')";
                SqlCommand sqlCommandUcret = new SqlCommand(sqlUcretSorgu, sqlBaglanti);
                SqlDataReader sqlUcretOku = sqlCommandUcret.ExecuteReader();

                if (textBoxOgrenciNo.Text == "")
                {
                    richTextBoxSorgular.Clear();
                    MessageBox.Show("Lütfen öğrenci no giriniz.");
                    return;
                }

                else
                {
                    while (sqlUcretOku.Read())
                    {
                        richTextBoxSorgular.Clear();
                        string? OgrAd = sqlUcretOku[0].ToString();
                        string? OgrSoyad = sqlUcretOku[1].ToString();
                        string? yillikTutar = sqlUcretOku[2].ToString();
                        string? aylikTutar = sqlUcretOku[3].ToString();
                        string? taksitSayisi = sqlUcretOku[4].ToString();

                        richTextBoxSorgular.Text = richTextBoxSorgular.Text + " Ad: " + OgrAd + "  Soyad: " + OgrSoyad + "\n Yıllık Tutar (TL): " + yillikTutar + "\n Aylık Tutar (TL): " + aylikTutar + "\n Taksit Sayısı: " + taksitSayisi + "\n\n";
                        return;
                    }
                }

                if (sqlUcretOku.Read() != true)
                {
                    MessageBox.Show("Yanlış öğrenci no girdiniz.");
                    return;
                }

                sqlUcretOku.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu!");
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlBaglanti.Close();
            }
        }

        private void FormUcretTakipEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}