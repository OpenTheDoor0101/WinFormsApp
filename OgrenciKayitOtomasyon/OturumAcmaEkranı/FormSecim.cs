using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DershaneOtomasyonEkranlari
{
    public partial class FormSecim : Form
    {
        public FormSecim()
        {
            InitializeComponent();
        }

        private void FormSecim_Load(object sender, EventArgs e)
        {

        }

        private void buttonKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonOgrKayit_Click(object sender, EventArgs e)
        {
            FormOgrenciKayitEkrani FormOgrKayit = new FormOgrenciKayitEkrani();
            FormOgrKayit.ShowDialog();
        }

        private void buttonPersKayit_Click(object sender, EventArgs e)
        {
            FormPersonelKayitEkrani FormPersKayit = new FormPersonelKayitEkrani();
            FormPersKayit.ShowDialog();
        }
    }
}
