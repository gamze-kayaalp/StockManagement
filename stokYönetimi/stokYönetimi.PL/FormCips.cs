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
    public partial class FormCips : Form
    {

        private readonly StokBL stokBL;

        public FormCips()
        {
            InitializeComponent();
            stokBL = new StokBL(); // StokBL nesnesi oluşturuldu
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

                // Stok güncelleme işlemi
                stokBL.UpdateCipsStok(yeniStok); // Yeni stok bilgisi güncellenir
                MessageBox.Show("Stok başarıyla güncellendi!");

                // Güncellenmiş stok bilgisini görüntüle
                label1.Text = $"Mevcut Stok: {yeniStok}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stok güncellenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void FormCips_Load(object sender, EventArgs e)
        {
            try
            {
                // Mevcut stok bilgisini yükleyip görüntüle
                int mevcutStok = stokBL.GetCipsStok(); // Cips'e özel stok
                label1.Text = $"Mevcut Stok: {mevcutStok}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Stok bilgisi yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAtistirmaliklar formAtistirmaliklar = new FormAtistirmaliklar(); // FormAtistirmaliklar nesnesi oluşturulur
            formAtistirmaliklar.Show(); // FormAtistirmaliklar açılır
            this.Close(); // Mevcut FormCikolata kapatılır
        }
    }
}
