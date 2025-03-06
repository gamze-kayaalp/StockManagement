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
    public partial class FormNohut : Form
    {

        private readonly StokBL stokBL;

        public FormNohut()
        {
            InitializeComponent();
            stokBL = new StokBL(); // StokBL nesnesi oluşturuldu

        }

        private void FormNohut_Load(object sender, EventArgs e)
        {
            try
            {
                // Nohut stok bilgisini al ve ekrana yaz
                int mevcutStok = stokBL.GetNohutStok(); // Nohut'un ID'si 1
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

                // Nohut stok güncelleme işlemini gerçekleştir
                stokBL.UpdateNohutStok(yeniStok); // Nohut'un ID'si 1
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
