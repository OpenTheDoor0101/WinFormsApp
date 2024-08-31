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
using System.Data.OleDb;
using System.Linq.Expressions;
using System.Globalization;

namespace DershaneOtomasyonEkranlari
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public void FormMenu_Load(object sender, EventArgs e)
        {
            panelPersIslemleri.Visible = false;
            panelOgrIslemleri.Visible = false;
            panelKarsılama.Visible = true;

            //Öğrenci kayıtları getirme.
            try
            {
                sqlBaglanti.Open();

                string sqlOgrListele = "SELECT OgrenciNo, Ad, Soyad FROM OgrenciBilgileri";
                SqlCommand sqlCommandOgrListele = new SqlCommand(sqlOgrListele, sqlBaglanti);
                SqlDataReader sqlReaderOgrListele = sqlCommandOgrListele.ExecuteReader();

                while (sqlReaderOgrListele.Read())
                {
                    Button btn = new Button();
                    btn.Name = sqlReaderOgrListele[0].ToString();
                    btn.Text = "Öğrenci No: " + sqlReaderOgrListele[0].ToString() + "    " +
                               "Ad Soyad: " + sqlReaderOgrListele[1].ToString() + " " + sqlReaderOgrListele[2].ToString();
                    btn.Width = 424;
                    btn.Height = 50;
                    btn.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                    btn.BackColor = Color.AntiqueWhite;
                    btn.FlatAppearance.BorderColor = Color.AntiqueWhite;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
                    btn.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += new EventHandler(btnOgr_Click);
                    flowLayoutPanelOgrenci.Controls.Add(btn);
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

            //Personel kayıtları getirme.
            try
            {
                sqlBaglanti.Open();

                string sqlPersListele = "SELECT ID, Ad, Soyad FROM PersonelBilgileri";
                SqlCommand sqlCommandPersListele = new SqlCommand(sqlPersListele, sqlBaglanti);
                SqlDataReader sqlReaderPersListele = sqlCommandPersListele.ExecuteReader();

                while (sqlReaderPersListele.Read())
                {
                    Button btn = new Button();
                    btn.Name = sqlReaderPersListele[0].ToString();
                    btn.Text = "Personel ID: " + sqlReaderPersListele[0].ToString() + "    " +
                               "Ad Soyad: " + sqlReaderPersListele[1].ToString() + " " + sqlReaderPersListele[2].ToString();
                    btn.Width = 424;
                    btn.Height = 100;
                    btn.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                    btn.BackColor = Color.AntiqueWhite;
                    btn.FlatAppearance.BorderColor = Color.AntiqueWhite;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
                    btn.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += new EventHandler(btnPers_Click);
                    flowLayoutPanelPersonel.Controls.Add(btn);
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

        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=Minuteman-III\SQLEXPRESS;Initial Catalog=StajProjesiOgrenciKayitOtomasyonuDB;Integrated Security=True; MultipleActiveResultSets=True;");

        public void btnPers_Click(object sender, EventArgs e) //Personel dinamik buton click olayı
        {
            panelPersIslemleri.Visible = true;
            panelOgrIslemleri.Visible = false;
            panelKarsılama.Visible = false;

            string selectedBtnName = ((Button)sender).Name;
            try
            {
                sqlBaglanti.Open();

                string personelBirim = "SELECT DISTINCT Birim FROM Birimler";
                string personelUnvan = "SELECT DISTINCT Unvan FROM Birimler";
                string personelDuzey = "SELECT DISTINCT Duzey FROM Birimler";

                SqlCommand birimSorgu = new SqlCommand(personelBirim, sqlBaglanti);
                SqlDataReader birimOku = birimSorgu.ExecuteReader();
                while (birimOku.Read())
                {
                    comboBoxPersBirim.Items.Add(birimOku[0]);
                }
                birimOku.Close();

                SqlCommand unvanSorgu = new SqlCommand(personelUnvan, sqlBaglanti);
                SqlDataReader unvanOku = unvanSorgu.ExecuteReader();
                while (unvanOku.Read())
                {
                    comboBoxPersUnvan.Items.Add(unvanOku[0]);
                }
                unvanOku.Close();

                SqlCommand duzeySorgu = new SqlCommand(personelDuzey, sqlBaglanti);
                SqlDataReader duzeyOku = duzeySorgu.ExecuteReader();
                while (duzeyOku.Read())
                {
                    comboBoxPersDuzey.Items.Add(duzeyOku[0]);
                }
                duzeyOku.Close();

                string sqlPersBilgiGetir = "SELECT CepNo, " +
                                                   "Email," +
                                                   " il," +
                                                   " ilce," +
                                                   " AcikAdres," +
                                                   " Birim," +
                                                   " Unvan," +
                                                   " Duzey," +
                                                   " SistemGirisSifresi," +
                                                   " SozlesmeTarihi," +
                                                   " ID," +
                                                   " TC," +
                                                   " Ad," +
                                                   " Soyad," +
                                                   " Cinsiyet," +
                                                   " DogumTarihi," +
                                                   " DogumYeri," +
                                                   " KanGrubu," +
                                                   " AnneAdi," +
                                                   " BabaAdi" +
                                                   " FROM PersonelBilgileri WHERE ID = '" + selectedBtnName + "' ";
                SqlCommand sqlCommandPersBilgiGetir = new SqlCommand(sqlPersBilgiGetir, sqlBaglanti);
                SqlDataReader sqlReaderPersBilgiGetir = sqlCommandPersBilgiGetir.ExecuteReader();

                if (sqlReaderPersBilgiGetir.Read())
                {
                    textBoxPersCepNo.Text = sqlReaderPersBilgiGetir[0].ToString();
                    textBoxPersEmail.Text = sqlReaderPersBilgiGetir[1].ToString();
                    textBoxPers_il.Text = sqlReaderPersBilgiGetir[2].ToString();
                    textBoxPers_ilce.Text = sqlReaderPersBilgiGetir[3].ToString();
                    textBoxPersAcikAdres.Text = sqlReaderPersBilgiGetir[4].ToString();
                    comboBoxPersBirim.Text = sqlReaderPersBilgiGetir[5].ToString();
                    comboBoxPersUnvan.Text = sqlReaderPersBilgiGetir[6].ToString();
                    comboBoxPersDuzey.Text = sqlReaderPersBilgiGetir[7].ToString();
                    textBoxPersSifre.Text = sqlReaderPersBilgiGetir[8].ToString();
                    dateTimePickerPersSozTrh.Text = sqlReaderPersBilgiGetir[9].ToString();
                    textBoxPersID.Text = sqlReaderPersBilgiGetir[10].ToString();
                    textBoxPersTC.Text = sqlReaderPersBilgiGetir[11].ToString();
                    textBoxPersAd.Text = sqlReaderPersBilgiGetir[12].ToString();
                    textBoxPersSoyad.Text = sqlReaderPersBilgiGetir[13].ToString();
                    textBoxPersCinsiyet.Text = sqlReaderPersBilgiGetir[14].ToString();
                    dateTimePickerPersDgmTrh.Text = sqlReaderPersBilgiGetir[15].ToString();
                    textBoxPersDgmYr.Text = sqlReaderPersBilgiGetir[16].ToString();
                    textBoxPersKanGrubu.Text = sqlReaderPersBilgiGetir[17].ToString();
                    textBoxPersAnneAdi.Text = sqlReaderPersBilgiGetir[18].ToString();
                    textBoxPersBabaAdi.Text = sqlReaderPersBilgiGetir[19].ToString();
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

        public void btnOgr_Click(object sender, EventArgs e) //Öğrenci dinamik buton click olayı
        {
            panelOgrIslemleri.Visible = true;
            panelPersIslemleri.Visible = false;
            panelKarsılama.Visible = false;

            string selectedBtnName = ((Button)sender).Name;
            try
            {
                sqlBaglanti.Open();

                string sqlOgrGunc = "SELECT CepNo, Email, il, ilce, AcikAdres, OgrenciNo, OgrenciTCno, Ad, Soyad, Cinsiyet, DogumTarihi, DogumYeri, AnneAdi, BabaAdi, KanGrubu FROM OgrenciBilgileri WHERE OgrenciNo = '" + selectedBtnName + "' ";
                SqlCommand sqlCommandOgrGunc = new SqlCommand(sqlOgrGunc, sqlBaglanti);
                SqlDataReader sqlReaderOgrGunc = sqlCommandOgrGunc.ExecuteReader();

                string sqlKayitGetir = "SELECT YillikTutar, KalanYillikTutar, AylikTutar, TaksitSayisi, KalanTaksitSayisi, KayitTarihi, KayitBitisTarihi FROM OgrenciKayitBilgileri WHERE OgrenciNo = '" + selectedBtnName + "' ";
                SqlCommand sqlCommandKayitGetir = new SqlCommand(sqlKayitGetir, sqlBaglanti);
                SqlDataReader sqlReaderKayitGetir = sqlCommandKayitGetir.ExecuteReader();

                if (sqlReaderOgrGunc.Read())
                {
                    if (sqlReaderKayitGetir.Read())
                    {
                        textBoxOgrNo.Text = selectedBtnName;
                        textBoxCepNo.Text = sqlReaderOgrGunc[0].ToString();
                        textBoxEmail.Text = sqlReaderOgrGunc[1].ToString();
                        textBoxIl.Text = sqlReaderOgrGunc[2].ToString();
                        textBoxIlce.Text = sqlReaderOgrGunc[3].ToString();
                        textBoxAcikAdres.Text = sqlReaderOgrGunc[4].ToString();
                        textBoxOgrNo.Text = sqlReaderOgrGunc[5].ToString();
                        textBoxOgrTCNo.Text = sqlReaderOgrGunc[6].ToString();
                        textBoxOgrAd.Text = sqlReaderOgrGunc[7].ToString();
                        textBoxOgrSoyad.Text = sqlReaderOgrGunc[8].ToString();
                        textBoxOgrCinsiyet.Text = sqlReaderOgrGunc[9].ToString();
                        dateTimePickerOgrDgmTrh.Text = sqlReaderOgrGunc[10].ToString();
                        textBoxOgrDgmYeri.Text = sqlReaderOgrGunc[11].ToString();
                        textBoxOgrAnneAdi.Text = sqlReaderOgrGunc[12].ToString();
                        textBoxOgrBabaAdi.Text = sqlReaderOgrGunc[13].ToString();
                        textBoxOgrKanGrb.Text = sqlReaderOgrGunc[14].ToString();
                        textBoxUcretOgrNo.Text = selectedBtnName;
                        textBoxKalanTaksit.Text = sqlReaderKayitGetir[4].ToString();
                        textBoxTaksitSayisi.Text = sqlReaderKayitGetir[3].ToString();
                        textBoxAylikUcret.Text = sqlReaderKayitGetir[2].ToString();
                        textBoxYillikKalanUcret.Text = sqlReaderKayitGetir[1].ToString();
                        textBoxYillikUcret.Text = sqlReaderKayitGetir[0].ToString();
                        dateTimePickerOgrKayitTrh.Text = sqlReaderKayitGetir[5].ToString();
                        dateTimePickerOgrKayitBts.Text = sqlReaderKayitGetir[6].ToString();

                    }
                }
                else
                {
                    MessageBox.Show("Bu öğrenci numarasıyla ilgili bilgi bulunamadı.");
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

            try
            {
                sqlBaglanti.Open();

                string sqlTaksitGetir = "SELECT KalanTaksitSayisi FROM OgrenciKayitBilgileri WHERE OgrenciNo = '" + textBoxUcretOgrNo.Text + "' ";
                SqlCommand sqlCommandTaksitGetir = new SqlCommand(sqlTaksitGetir, sqlBaglanti);
                SqlDataReader sqlReaderTaksitGetir = sqlCommandTaksitGetir.ExecuteReader();

                comboBoxOdemeTaksit.Items.Clear();
                if (sqlReaderTaksitGetir.Read())
                {
                    int tkstSayisi = Convert.ToInt32(sqlReaderTaksitGetir[0]);

                    for (int i = 0; i < tkstSayisi; tkstSayisi--)
                    {
                        comboBoxOdemeTaksit.Items.Add(tkstSayisi.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlBaglanti.Close();
            }
        }

        public void buttonOgrAra_Click(object sender, EventArgs e)
        {
            panelKarsılama.Visible = true;
            panelOgrIslemleri.Visible = false;
            panelPersIslemleri.Visible = false;

            try
            {
                sqlBaglanti.Open();

                string sqlOgrListele = "SELECT OgrenciNo, Ad, Soyad, Cinsiyet FROM OgrenciBilgileri WHERE OgrenciNo LIKE '%" + (textBoxOgrAra.Text) + "%' OR Ad LIKE '%" + (textBoxOgrAra.Text) + "%' OR Soyad LIKE '%" + (textBoxOgrAra.Text) + "%' ";
                SqlCommand sqlCommandOgrListele = new SqlCommand(sqlOgrListele, sqlBaglanti);
                SqlDataReader sqlReaderOgrListele = sqlCommandOgrListele.ExecuteReader();

                textBoxOgrNo.Clear();
                textBoxCepNo.Clear();
                textBoxEmail.Clear();
                textBoxIl.Clear();
                textBoxIlce.Clear();
                textBoxAcikAdres.Clear();
                textBoxUcretOgrNo.Clear();
                textBoxAylikUcret.Clear();
                textBoxYillikKalanUcret.Clear();
                textBoxYillikUcret.Clear();
                flowLayoutPanelOgrenci.Controls.Clear();
                while (sqlReaderOgrListele.Read())
                {
                    Button btn = new Button();
                    btn.Name = sqlReaderOgrListele[0].ToString();
                    btn.Text = "Öğrenci No: " + sqlReaderOgrListele[0].ToString() + "    " +
                               "Ad Soyad: " + sqlReaderOgrListele[1].ToString() + " " + sqlReaderOgrListele[2].ToString();
                    btn.Width = 424;
                    btn.Height = 50;
                    btn.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                    btn.BackColor = Color.AntiqueWhite;
                    btn.FlatAppearance.BorderColor = Color.AntiqueWhite;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
                    btn.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += new EventHandler(btnOgr_Click);
                    flowLayoutPanelOgrenci.Controls.Add(btn);
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

        private void buttonPersAra_Click(object sender, EventArgs e)
        {
            panelKarsılama.Visible = true;
            panelOgrIslemleri.Visible = false;
            panelPersIslemleri.Visible = false;

            try
            {
                sqlBaglanti.Open();

                string sqlPersListele = "SELECT ID, Ad, Soyad, Birim, Unvan, Duzey, Cinsiyet FROM PersonelBilgileri WHERE ID LIKE '%" + (textBoxPersAra.Text) + "%' OR Ad LIKE '%" + (textBoxPersAra.Text) + "%' OR Soyad LIKE '%" + (textBoxPersAra.Text) + "%' ";
                SqlCommand sqlCommandPersListele = new SqlCommand(sqlPersListele, sqlBaglanti);
                SqlDataReader sqlReaderPersListele = sqlCommandPersListele.ExecuteReader();

                textBoxPersID.Clear();
                textBoxPers_il.Clear();
                textBoxPers_ilce.Clear();
                textBoxPersAcikAdres.Clear();
                textBoxPersCepNo.Clear();
                textBoxPersEmail.Clear();
                textBoxPersSifre.Clear();
                flowLayoutPanelPersonel.Controls.Clear();
                while (sqlReaderPersListele.Read())
                {
                    Button btn = new Button();
                    btn.Name = sqlReaderPersListele[0].ToString();
                    btn.Text = "Personel ID: " + sqlReaderPersListele[0].ToString() + "    " +
                               "Ad Soyad: " + sqlReaderPersListele[1].ToString() + " " + sqlReaderPersListele[2].ToString();
                    btn.Width = 424;
                    btn.Height = 100;
                    btn.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
                    btn.BackColor = Color.AntiqueWhite;
                    btn.FlatAppearance.BorderColor = Color.AntiqueWhite;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
                    btn.FlatAppearance.MouseOverBackColor = Color.Crimson;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Click += new EventHandler(btnPers_Click);
                    flowLayoutPanelPersonel.Controls.Add(btn);
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

        void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxOgrNo.Text == "" ||
                textBoxCepNo.Text == "" ||
                textBoxEmail.Text == "" ||
                textBoxIl.Text == "" ||
                textBoxIlce.Text == "" ||
                textBoxAcikAdres.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurunuz!");
                return;
            }

            else
            {
                try
                {
                    sqlBaglanti.Open();

                    string sqlOgrBilgiGunc = "UPDATE OgrenciBilgileri SET CepNo = '" + textBoxCepNo.Text + "', Email = '" + textBoxEmail.Text + "', il = '" + textBoxIl.Text + "', ilce = '" + textBoxIlce.Text + "', AcikAdres = '" + textBoxAcikAdres.Text + "' WHERE OgrenciNo = '" + textBoxOgrNo.Text + "' ";
                    SqlCommand sqlCommand = new SqlCommand(sqlOgrBilgiGunc, sqlBaglanti);

                    int etkilenenSatirSayisi = sqlCommand.ExecuteNonQuery();

                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Öğrenci bilgi güncellemesi başarılı!");
                        textBoxOgrNo.Clear();
                        textBoxCepNo.Clear();
                        textBoxEmail.Clear();
                        textBoxIl.Clear();
                        textBoxIlce.Clear();
                        textBoxAcikAdres.Clear();
                    }

                    else
                    {
                        MessageBox.Show("Güncelleme başarısız! Hatalı veri girişi!");
                        textBoxOgrNo.Clear();
                        textBoxCepNo.Clear();
                        textBoxEmail.Clear();
                        textBoxIl.Clear();
                        textBoxIlce.Clear();
                        textBoxAcikAdres.Clear();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı veri girişi!");
                    MessageBox.Show(ex.Message);
                    textBoxOgrNo.Clear();
                    textBoxCepNo.Clear();
                    textBoxEmail.Clear();
                    textBoxIl.Clear();
                    textBoxIlce.Clear();
                    textBoxAcikAdres.Clear();
                }
                finally
                {
                    sqlBaglanti.Close();
                }
            }
        }

        private void buttonKayitYap_Click(object sender, EventArgs e)
        {
            FormSecim kayitSecim = new FormSecim();
            kayitSecim.ShowDialog();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (textBoxOgrNo.Text == "")
            {
                textBoxOgrNo.Clear();
                textBoxCepNo.Clear();
                textBoxEmail.Clear();
                textBoxIl.Clear();
                textBoxIlce.Clear();
                textBoxAcikAdres.Clear();
                MessageBox.Show("Öğrenci no giriniz ya da listeden öğrenci seçiniz.");
                return;
            }

            else
            {
                try
                {
                    sqlBaglanti.Open();

                    string sqlKomutOgrBilgiSil = "DELETE FROM OgrenciBilgileri WHERE OgrenciNo = '" + textBoxOgrNo.Text + "' ";
                    string sqlKomutOgrKayitSil = "DELETE FROM OgrenciKayitBilgileri WHERE OgrenciNo = '" + textBoxOgrNo.Text + "' ";
                    SqlCommand sqlCommandSilBilgi = new SqlCommand(sqlKomutOgrBilgiSil, sqlBaglanti);
                    SqlCommand sqlCommandSilKayit = new SqlCommand(sqlKomutOgrKayitSil, sqlBaglanti);

                    int etkiSatirBilgi = sqlCommandSilBilgi.ExecuteNonQuery();
                    int etkiSatirKayit = sqlCommandSilKayit.ExecuteNonQuery();

                    if (etkiSatirBilgi > 0)
                    {
                        MessageBox.Show("Öğrenci bilgi silme işlemi başarılı! \nKayıt silme durumu mesajını bekleyiniz!");

                        if (etkiSatirKayit > 0)
                        {
                            MessageBox.Show("Öğrenci kayıt silme işlemi başarılı!");
                            textBoxOgrNo.Clear();
                            textBoxCepNo.Clear();
                            textBoxEmail.Clear();
                            textBoxIl.Clear();
                            textBoxIlce.Clear();
                            textBoxAcikAdres.Clear();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yanlış öğrenci no. Silme işlemi başarısız!");
                        textBoxOgrNo.Clear();
                        textBoxCepNo.Clear();
                        textBoxEmail.Clear();
                        textBoxIl.Clear();
                        textBoxIlce.Clear();
                        textBoxAcikAdres.Clear();
                        return;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Veri tabanı hatası!");
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlBaglanti.Close();
                }
            }
        }

        string odemeYapan;
        private void buttonOde_Click(object sender, EventArgs e)
        {
            if (comboBoxOdemeYapan.Text == "" ||
                comboBoxOdemeTaksit.Text == "")
            {
                MessageBox.Show("Lütfen ödeme yapacak kişiyi ve taksit sayısını seçiniz.");
                return;
            }
            else
            {
                try
                {
                    sqlBaglanti.Open();

                    /*Bu sql komutları if sorgusunda veri tabanından gelen bilgileri kontrol ederek doğru bilgiyi almak için var. Önceden aşağıdaki işlemde olan
                      değerler kullanılarak if sorgusu yapılıyordu fakat if sorgusundan önce işlem yapılduığı için taksitlerin hepsi ödenmek istediği zaman bug 
                      ortaya çıkıyordu: Ödenecek borç yoktur uyarısı gelmesine rağmen borçlar duruyordu.*/
                    string sqlYillikUcretOgrenme = "select KalanYillikTutar from OgrenciKayitBilgileri WHERE OgrenciNo = '" + textBoxOgrNo.Text + "' ";
                    SqlCommand sqlCommandYillikUcretOgrenme = new SqlCommand(sqlYillikUcretOgrenme, sqlBaglanti);
                    object yillikUcretObj = sqlCommandYillikUcretOgrenme.ExecuteScalar();
                    decimal kalanYillikTutar = yillikUcretObj != null ? Convert.ToDecimal(yillikUcretObj) : 0;

                    /*Bu sql komutları if sorgusunda veri tabanından gelen bilgileri kontrol ederek doğru bilgiyi almak için var. Önceden aşağıdaki işlemde olan
                      değerler kullanılarak if sorgusu yapılıyordu fakat if sorgusundan önce işlem yapılduığı için taksitlerin hepsi ödenmek istediği zaman bug 
                      ortaya çıkıyordu: Ödenecek borç yoktur uyarısı gelmesine rağmen borçlar duruyordu.*/
                    string sqlKalanTaksitOgrenme = "select KalanTaksitSayisi from OgrenciKayitBilgileri WHERE OgrenciNo = '" + textBoxOgrNo.Text + "' ";
                    SqlCommand sqlCommandKalanTaksitOgrenme = new SqlCommand(sqlKalanTaksitOgrenme, sqlBaglanti);
                    object kalanTaksitObj = sqlCommandKalanTaksitOgrenme.ExecuteScalar();
                    decimal kalanYillikTaksit = kalanTaksitObj != null ? Convert.ToDecimal(kalanTaksitObj) : 0;


                    decimal aylikUcret = Convert.ToDecimal(textBoxAylikUcret.Text);
                    decimal kalanYillikUcret = Convert.ToDecimal(textBoxYillikKalanUcret.Text);
                    int kalanTaksitSayisi = Convert.ToInt32(textBoxKalanTaksit.Text);
                    int OdenecekTaksit = Convert.ToInt32(comboBoxOdemeTaksit.Text);
                    int ucretOgrNo = Convert.ToInt32(textBoxUcretOgrNo.Text);

                    decimal kalanYUK = (decimal)kalanYillikUcret - (OdenecekTaksit * aylikUcret);
                    int kalanTaksit = kalanTaksitSayisi - OdenecekTaksit;

                    if (kalanYillikTutar == 0)
                    {
                        if (kalanYillikTaksit == 0)
                        {
                            MessageBox.Show("Ödenecek borç bulunmamaktadır.");
                            return;
                        }
                    }
                    else
                    {
                        string sqlUcretGuncelleme = "UPDATE OgrenciKayitBilgileri SET KalanYillikTutar = @kalanYUK, KalanTaksitSayisi = @kalanTaksit WHERE OgrenciNo = @OgrNo";
                        SqlCommand sqlCommandUcretGuncelleme = new SqlCommand(sqlUcretGuncelleme, sqlBaglanti);
                        sqlCommandUcretGuncelleme.Parameters.AddWithValue("@kalanYUK", kalanYUK.ToString("F", CultureInfo.InvariantCulture));
                        sqlCommandUcretGuncelleme.Parameters.AddWithValue("@kalanTaksit", kalanTaksit);
                        sqlCommandUcretGuncelleme.Parameters.AddWithValue("@OgrNo", ucretOgrNo);

                        int etkilenenSatirSayisi = sqlCommandUcretGuncelleme.ExecuteNonQuery();


                        if (etkilenenSatirSayisi > 0)
                        {
                            MessageBox.Show("Ödeme başarılı!");

                            if (comboBoxOdemeYapan.Text == "Annesi")
                            {
                                string MusteriAdiSoyadi = textBoxOgrAnneAdi.Text + " " + textBoxOgrSoyad.Text;
                                odemeYapan = MusteriAdiSoyadi.ToString();
                            }
                            else
                            {
                                string MusteriAdiSoyadi = textBoxOgrBabaAdi.Text + " " + textBoxOgrSoyad.Text;
                                odemeYapan = MusteriAdiSoyadi.ToString();
                            }

                            string odemeYapanMakbuz = odemeYapan.ToString();

                            DateTime simdikiTarih = DateTime.Now;
                            string formatliSimdikiTarih = simdikiTarih.ToString("yyyy.MM.dd");

                            string vadeTarihi = formatliSimdikiTarih.ToString();

                            string taksitSayisi = OdenecekTaksit.ToString();

                            decimal MakbuzTutarHesabi = OdenecekTaksit * aylikUcret;
                            string makbuzTutar = MakbuzTutarHesabi.ToString("F", CultureInfo.InvariantCulture);

                            FormMakbuz makbuz = new FormMakbuz();

                            makbuz.OdemeYapanMakbuz = odemeYapanMakbuz;
                            makbuz.FormatliSimdikitarih = formatliSimdikiTarih;
                            makbuz.VadeTarihi = vadeTarihi;
                            makbuz.TaksitSayisi = taksitSayisi;
                            makbuz.MakbuzTutar = makbuzTutar;
                            makbuz.OgrNo = textBoxOgrNo.Text;

                            makbuz.ShowDialog();



                            textBoxOgrNo.Clear();
                            textBoxCepNo.Clear();
                            textBoxEmail.Clear();
                            textBoxIl.Clear();
                            textBoxIlce.Clear();
                            textBoxAcikAdres.Clear();
                            textBoxUcretOgrNo.Clear();
                            textBoxKalanTaksit.Clear();
                            textBoxTaksitSayisi.Clear();
                            textBoxAylikUcret.Clear();
                            textBoxYillikKalanUcret.Clear();
                            textBoxYillikUcret.Clear();
                            comboBoxOdemeTaksit.Items.Clear();
                            textBoxOgrAd.Clear();
                            textBoxOgrSoyad.Clear();
                            textBoxOgrTCNo.Clear();
                            textBoxOgrCinsiyet.Clear();
                            textBoxOgrDgmYeri.Clear();
                            textBoxOgrKanGrb.Clear();
                            textBoxOgrAnneAdi.Clear();
                            textBoxOgrBabaAdi.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Hata!");
                        }
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

        private void buttonPersGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxPers_il.Text == "" ||
                textBoxPers_ilce.Text == "" ||
                textBoxPersAcikAdres.Text == "" ||
                textBoxPersCepNo.Text == "" ||
                textBoxPersEmail.Text == "" ||
                textBoxPersSifre.Text == "")
            {
                MessageBox.Show("Tüm alanları doldurunuz!");
                return;
            }

            else
            {
                try
                {
                    sqlBaglanti.Open();

                    string sqlPersBilgiGunc = "UPDATE PersonelBilgileri SET il = '" + textBoxPers_il.Text + "', ilce = '" + textBoxPers_ilce.Text + "', AcikAdres = '" + textBoxPersAcikAdres.Text + "', CepNo = '" + textBoxPersCepNo.Text + "', Email = '" + textBoxPersEmail.Text + "', SistemGirisSifresi = '" + textBoxPersSifre.Text + "' WHERE ID = '" + textBoxPersID.Text + "' ";
                    SqlCommand sqlCommand = new SqlCommand(sqlPersBilgiGunc, sqlBaglanti);

                    int etkilenenSatirSayisi = sqlCommand.ExecuteNonQuery();

                    if (etkilenenSatirSayisi > 0)
                    {
                        MessageBox.Show("Personel bilgi güncellemesi başarılı!");
                        textBoxPersID.Clear();
                        textBoxPers_il.Clear();
                        textBoxPers_ilce.Clear();
                        textBoxPersAcikAdres.Clear();
                        textBoxPersCepNo.Clear();
                        textBoxPersEmail.Clear();
                        textBoxPersSifre.Clear();
                    }

                    else
                    {
                        MessageBox.Show("Güncelleme başarısız! Hatalı veri girişi!");
                        textBoxPersID.Clear();
                        textBoxPers_il.Clear();
                        textBoxPers_ilce.Clear();
                        textBoxPersAcikAdres.Clear();
                        textBoxPersCepNo.Clear();
                        textBoxPersEmail.Clear();
                        textBoxPersSifre.Clear();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Hatalı veri girişi!");
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlBaglanti.Close();
                }
            }
        }

        private void buttonPersSil_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();

                string sqlKomutPersBilgiSil = "DELETE FROM PersonelBilgileri WHERE ID = '" + textBoxPersID.Text + "' ";
                SqlCommand sqlCommandSilPersBilgi = new SqlCommand(sqlKomutPersBilgiSil, sqlBaglanti);

                int etkiSatirPersBilgi = sqlCommandSilPersBilgi.ExecuteNonQuery();

                if (etkiSatirPersBilgi > 0)
                {
                    MessageBox.Show("Personel bilgi silme işlemi başarılı!");
                    textBoxPersID.Clear();
                    textBoxPers_il.Clear();
                    textBoxPers_ilce.Clear();
                    textBoxPersAcikAdres.Clear();
                    textBoxPersCepNo.Clear();
                    textBoxPersEmail.Clear();
                    textBoxPersSifre.Clear();
                }
                else
                {
                    MessageBox.Show("Yanlış personel ID. Silme işlemi başarısız!");
                    textBoxPersID.Clear();
                    textBoxPers_il.Clear();
                    textBoxPers_ilce.Clear();
                    textBoxPersAcikAdres.Clear();
                    textBoxPersCepNo.Clear();
                    textBoxPersEmail.Clear();
                    textBoxPersSifre.Clear();
                    return;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Veri tabanı hatası!");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlBaglanti.Close();
            }
        }

        private void buttonPersKayit_Click(object sender, EventArgs e)
        {
            FormSecim kayitSecim = new FormSecim();
            kayitSecim.ShowDialog();
        }
    }
}
