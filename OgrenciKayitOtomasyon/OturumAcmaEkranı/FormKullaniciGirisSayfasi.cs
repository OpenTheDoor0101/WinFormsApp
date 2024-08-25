using DershaneOtomasyonEkranlari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KullaniciGirisSayfasi;
using Ücret_Takip_Ekranı;

namespace KullaniciGirisSayfasi
{
    public partial class FormKullaniciGirisSayfasi : Form
    {


        public FormKullaniciGirisSayfasi()
        {
            InitializeComponent();
        }

        private void FormKullaniciGirisSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxSifreGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSifreGoster.Checked == true)
            {
                textBoxSifre.PasswordChar = '\0';
            }
            else
            {
                textBoxSifre.PasswordChar = '*';
            }
        }

        SqlConnection sqlBaglanti = new SqlConnection(@"Data Source=DESKTOP-R1R5QMJ\SQLEXPRESS;Initial Catalog=StajProjesiOgrenciKayitOtomasyonuDB;Integrated Security=True; MultipleActiveResultSets=True;");
        private void buttonOturumAc_Click(object sender, EventArgs e)
        {
            try
            {
                sqlBaglanti.Open();

                string sqlPersIDQuery = "SELECT ID FROM PersonelBilgileri WHERE ID = '" + (textBoxPersonelID.Text) + "' ";
                string sqlSifreQuery = "SELECT SistemGirisSifresi FROM PersonelBilgileri WHERE SistemGirisSifresi = '" + (textBoxSifre.Text) + "' ";
                SqlCommand sqlCommandPersonID = new SqlCommand(sqlPersIDQuery, sqlBaglanti);
                SqlCommand sqlCommandSifre = new SqlCommand(sqlSifreQuery, sqlBaglanti);
                SqlDataReader readerPersonID = sqlCommandPersonID.ExecuteReader();
                SqlDataReader readerSifre = sqlCommandSifre.ExecuteReader();

                if (textBoxPersonelID.Text == "")
                {
                    MessageBox.Show("Personel ID ve şifre giriniz.");
                    return;
                }

                if (readerPersonID.Read())
                {
                    if (readerSifre.Read())
                    {
                        textBoxPersonelID.Clear();
                        textBoxSifre.Clear();
                        Form formBackground = new Form();
                        try
                        {
                            using (FormMenu uu = new FormMenu())
                            {
                                formBackground.StartPosition = FormStartPosition.Manual;
                                formBackground.FormBorderStyle = FormBorderStyle.None;
                                formBackground.Opacity = .50d;
                                formBackground.BackColor = Color.Black;
                                formBackground.WindowState = FormWindowState.Maximized;
                                formBackground.TopMost = true;
                                formBackground.Location = this.Location;
                                formBackground.ShowInTaskbar = false;
                                formBackground.Show();

                                uu.Owner = formBackground;
                                uu.ShowDialog();

                                formBackground.Dispose();
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                        finally
                        {
                            formBackground.Dispose();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Yanlış şifre.");
                    }
                }
                else
                {
                    MessageBox.Show("Yanlış personel ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu!", ex.Message);
            }
            finally
            {
                sqlBaglanti.Close();
            }
        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            textBoxPersonelID.Clear();
            textBoxSifre.Clear();
            FormKullaniciGirisSayfasi GizleGiris = new FormKullaniciGirisSayfasi();
            GizleGiris.Hide();

            Form formBackground = new Form();
            try
            {
                using (FormSecim uu = new FormSecim())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    uu.Owner = formBackground;
                    uu.ShowDialog();

                    formBackground.Dispose();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                formBackground.Dispose();
            }
        }
    }
}
