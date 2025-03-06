using stokYönetimi.BL;
using stokYönetimi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using System.Threading;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using stokYönetimi.PL;

namespace stokYönetimi
{
    public partial class FormIcecekler : Form
    {
        private readonly StokBL _stokBL;

        public FormIcecekler()
        {
            InitializeComponent();
            _stokBL = new StokBL();  // _stokBL nesnesi burada başlatılmalı
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            try
            {
                // BL katmanından içecek verilerini al
                List<Icecekler> icecekler = _stokBL.GetIcecekler();

                // DataGridView'e veriyi bağla
                dataGridViewIcecek.DataSource = icecekler;

                // DataGridView sütun başlıklarını düzenle
                dataGridViewIcecek.Columns["IcecekID"].HeaderText = "ID";
                dataGridViewIcecek.Columns["IcecekAd"].HeaderText = "İçecek Adı";
                dataGridViewIcecek.Columns["IcecekStok"].HeaderText = "Stok Miktarı";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler getirilirken bir hata oluştu: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                try
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PDF Dosyası|*.pdf",
                        Title = "PDF olarak kaydet"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            // Başlık
                            pdfDoc.Add(new Paragraph("İçecek Stok Bilgileri"));
                            pdfDoc.Add(new Paragraph(" ")); // Boşluk

                            // Tablo
                            PdfPTable table = new PdfPTable(dataGridViewIcecek.Columns.Count);
                            table.WidthPercentage = 100;

                            // Sütun başlıklarını ekle
                            foreach (DataGridViewColumn column in dataGridViewIcecek.Columns)
                            {
                                table.AddCell(new Phrase(column.HeaderText));
                            }

                            // Satırları ekle
                            foreach (DataGridViewRow row in dataGridViewIcecek.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                                }
                            }

                            pdfDoc.Add(table);
                            pdfDoc.Close();
                            stream.Close();

                            MessageBox.Show("PDF başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("PDF oluşturulurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Verileri BL katmanından al
                List<Icecekler> iceceklerList = _stokBL.GetIcecekler();

                // Chart kontrolünü temizle
                chartIcecekler.Series.Clear();
                chartIcecekler.Legends.Clear();

                // Pasta grafiği için yeni bir seri oluştur
                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Stok Durumu",
                    IsValueShownAsLabel = true,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
                };

                // Icecekler verilerini grafiğe ekle
                foreach (var icecek in iceceklerList)
                {
                    // Her bir iceceğin adını ve stok miktarını grafiğe ekle
                    series.Points.AddXY(icecek.IcecekAd, icecek.IcecekStok);
                }

                // Grafiği ekle
                chartIcecekler.Series.Add(series);

                // Grafik başlığı ekle
                chartIcecekler.Titles.Clear();
                chartIcecekler.Titles.Add("Icecek Stok Durumu");

                // Grafik ayarlarını yap
                chartIcecekler.ChartAreas[0].Area3DStyle.Enable3D = true;
                chartIcecekler.ChartAreas[0].AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep90;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Grafik oluşturulurken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Mevcut formu kapatıyoruz
            this.Close();

            // Form2'yi açıyoruz
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSu formSu = new FormSu();
            formSu.Show();
            this.Hide(); // FormAtistirmaliklar'ı gizle
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormKola formKola = new FormKola();
            formKola.Show();
            this.Hide(); // FormIcecekler'i gizle
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSoda formSoda = new FormSoda();
            formSoda.Show();
            this.Hide(); // FormIcecekler'i gizle
        }
    }
}
