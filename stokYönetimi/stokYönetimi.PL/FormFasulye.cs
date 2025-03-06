using stokYönetimi.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stokYönetimi.PL
{
    public partial class FormFasulye : Form
    {

        private readonly StokBL stokBL;
        public FormFasulye()
        {
            InitializeComponent();
            stokBL = new StokBL(); // StokBL nesnesi oluşturuldu
        }

        private void FormFasulye_Load(object sender, EventArgs e)
        {
            try
            {
                // Fasulye stok bilgisini al ve ekrana yaz
                int mevcutStok = stokBL.GetFasulyeStok(); // Fasulye'nin ID'si 3
                label1.Text = $"Mevcut Stok: {mevcutStok}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stok bilgisi yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcıdan alınan stok miktarını kontrol et
                if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out int yeniStok))
                {
                    MessageBox.Show("Lütfen geçerli bir stok miktarı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Fasulye stok güncelleme işlemini gerçekleştir
                stokBL.UpdateFasulyeStok(yeniStok); // Fasulye'nin ID'si 3
                MessageBox.Show("Stok başarıyla güncellendi!");

                // Güncellenmiş stok bilgisini ekrana yaz
                label1.Text = $"Mevcut Stok: {yeniStok}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stok güncellenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBakliyatlar formBakliyatlar = new FormBakliyatlar(); // FormBakliyatlar nesnesi oluşturulur
            formBakliyatlar.Show(); // FormBakliyatlar açılır
            this.Close(); // Mevcut FormNohut kapatılır
        }
    }
}
