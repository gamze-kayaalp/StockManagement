using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stokYönetimi.BL;
using System.Net.Mail;
using System.IO;

namespace stokYönetimi
{
    public partial class Form2 : Form
    {

        private readonly StokBL stokBL;
        public Form2()
        {
            InitializeComponent();
            stokBL = new StokBL(); // StokBL nesnesi oluşturuldu
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new MailAddress(email);
                return true; // Geçerli bir e-posta adresi
            }
            catch
            {
                return false; // Geçersiz bir e-posta adresi
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcının girdiği alıcı e-posta adresini al
                string toAddress = textBox1.Text.Trim();

                // Alıcı adresi kontrolü
                if (string.IsNullOrWhiteSpace(toAddress) || !IsValidEmail(toAddress))
                {
                    MessageBox.Show("Geçerli bir alıcı e-posta adresi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tüm stok bilgilerini birleştirme
                StringBuilder bodyBuilder = new StringBuilder();
                bodyBuilder.AppendLine("Güncel stok bilgileri:");
                bodyBuilder.AppendLine();

                // Atıştırmalıklar
                var atistirmaliklar = stokBL.GetAllAtistirmaliklar();
                bodyBuilder.AppendLine("Atıştırmalıklar:");
                foreach (var item in atistirmaliklar)
                {
                    bodyBuilder.AppendLine($"- {item.Ad}: {item.Stok} adet");
                }
                bodyBuilder.AppendLine();

                // Bakliyatlar
                var bakliyatlar = stokBL.GetAllBakliyatlar();
                bodyBuilder.AppendLine("Bakliyatlar:");
                foreach (var item in bakliyatlar)
                {
                    bodyBuilder.AppendLine($"- {item.BakliyatAd}: {item.BakliyatStok} kg");
                }
                bodyBuilder.AppendLine();

                // İçecekler
                var icecekler = stokBL.GetIcecekler();
                bodyBuilder.AppendLine("İçecekler:");
                foreach (var item in icecekler)
                {
                    bodyBuilder.AppendLine($"- {item.IcecekAd}: {item.IcecekStok} litre");
                }
                bodyBuilder.AppendLine();

                // Temizlik Ürünleri
                var temizlikUrunleri = stokBL.GetTemizlikUrunleri();
                bodyBuilder.AppendLine("Temizlik Ürünleri:");
                foreach (var item in temizlikUrunleri)
                {
                    bodyBuilder.AppendLine($"- {item.TemizlikUrunAd}: {item.TemizlikUrunStok} adet");
                }

                // Mail içeriği
                string body = bodyBuilder.ToString();

                // Mail gönderim ayarları
                string fromAddress = "yarengamzestokcular@gmail.com"; // Gönderici e-posta adresi
                string fromPassword = "razelzmuelqvvzkk"; // Gönderici e-posta şifresi
                string subject = "Güncel Stok Bilgileri"; // E-posta konusu

                // SMTP istemcisi ayarları (örneğin, Gmail için)
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(fromAddress, fromPassword),
                    EnableSsl = true
                };

                // MailMessage oluşturma
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(fromAddress),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true // HTML destekliyorsa true yapabilirsiniz
                };

                mailMessage.To.Add(toAddress);

                // Mail gönder
                smtpClient.Send(mailMessage);

                MessageBox.Show("Mail başarıyla gönderildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                File.WriteAllText("error_log.txt", ex.ToString());
                MessageBox.Show($"Mail gönderilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }

    }
}

