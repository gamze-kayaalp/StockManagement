using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stokYönetimi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBakliyatlar_Click(object sender, EventArgs e)
        {
            FormBakliyatlar bakliyatlarForm = new FormBakliyatlar(); // Bakliyatlar formunu oluştur
            bakliyatlarForm.Show(); // Formu göster
            this.Hide(); // Form2'yi gizle
        }

        private void btnAtıştırmalıklar_Click(object sender, EventArgs e)
        {
            FormAtistirmaliklar atistirmaliklarForm = new FormAtistirmaliklar(); // Atıştırmalıklar formunu oluştur
            atistirmaliklarForm.Show(); // Formu göster
            this.Hide(); // Form2'yi gizle
        }

        private void btnİçecekler_Click(object sender, EventArgs e)
        {
            FormIcecekler iceceklerForm = new FormIcecekler(); // İçecekler formunu oluştur
            iceceklerForm.Show(); // Formu göster
            this.Hide(); // Form2'yi gizle
        }

        private void btnTemizlik_Click(object sender, EventArgs e)
        {
            FormTemizlik temizlikForm = new FormTemizlik(); // Temizlik formunu oluştur
            temizlikForm.Show(); // Formu göster
            this.Hide(); // Form2'yi gizle
        }
    }
}
