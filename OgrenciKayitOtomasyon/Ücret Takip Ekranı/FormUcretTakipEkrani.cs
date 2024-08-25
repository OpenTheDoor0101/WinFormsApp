using MathNet.Numerics;
using NPOI.SS.Formula.Functions;
using System.Data.SqlClient;
using static NPOI.SS.Formula.PTG.ArrayPtg;

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

                string sqlUcretSorgu = "SELECT YillikTutar, AylikTutar, TaksitSayisi FROM OgrenciKayitBilgileri WHERE OgrenciNo = ('" + (textBoxOgrenciNo.Text) + "')";
                SqlCommand sqlCommandUcret = new SqlCommand(sqlUcretSorgu, sqlBaglanti);
                SqlDataReader sqlUcretOku = sqlCommandUcret.ExecuteReader();

                if (textBoxOgrenciNo.Text == "")
                {
                    MessageBox.Show("Lütfen öğrenci no giriniz.");
                    return;
                }

                else
                {
                    while (sqlUcretOku.Read())
                    {
                        string? yillikTutar = sqlUcretOku[0].ToString();
                        string? aylikTutar = sqlUcretOku[1].ToString();
                        string? taksitSayisi = sqlUcretOku[2].ToString();

                        richTextBoxSorgular.Text = richTextBoxSorgular.Text + "Yıllık Tutar: " + yillikTutar + "  Aylık Tutar: " + aylikTutar + "  Taksit Sayısı: " + taksitSayisi + "\n\n";
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