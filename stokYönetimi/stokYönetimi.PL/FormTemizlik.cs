using stokYönetimi.BL;
using stokYönetimi.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;
using stokYönetimi.PL;

namespace stokYönetimi
{
    public partial class FormTemizlik : Form
    {
        private readonly StokBL _stokBL;
        public FormTemizlik()
        {
            InitializeComponent();
            _stokBL = new StokBL();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // BL katmanından Temizlik Ürünlerini al
                List<TemizlikUrunleri> temizlikUrunleri = _stokBL.GetTemizlikUrunleri();

                // DataGridView'e veriyi bağla
                dataGridViewTemizlik.DataSource = temizlikUrunleri;

                // DataGridView sütun başlıklarını düzenle
                dataGridViewTemizlik.Columns["TemizlikUrunID"].HeaderText = "ID";
                dataGridViewTemizlik.Columns["TemizlikUrunAd"].HeaderText = "Temizlik Ürünü Adı";
                dataGridViewTemizlik.Columns["TemizlikUrunStok"].HeaderText = "Stok Miktarı";
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
                            pdfDoc.Add(new Paragraph("Temizlik Ürünleri Stok Bilgileri"));
                            pdfDoc.Add(new Paragraph(" ")); // Boşluk

                            // Tablo
                            PdfPTable table = new PdfPTable(dataGridViewTemizlik.Columns.Count);
                            table.WidthPercentage = 100;

                            // Sütun başlıklarını ekle
                            foreach (DataGridViewColumn column in dataGridViewTemizlik.Columns)
                            {
                                table.AddCell(new Phrase(column.HeaderText));
                            }

                            // Satırları ekle
                            foreach (DataGridViewRow row in dataGridViewTemizlik.Rows)
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
                // Chart kontrolünü temizleyelim
                chartTemizlik.Series.Clear();

                // Chart için yeni bir seri ekleyelim
                Series series = new Series("Temizlik Ürünleri");
                series.ChartType = SeriesChartType.Pie; // Pasta dilimi grafik tipi

                // DataGridView'deki verileri grafik için hazırlıyoruz
                foreach (DataGridViewRow row in dataGridViewTemizlik.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // Her satırdan Temizlik Ürün adı ve stok miktarını alıyoruz
                        string temizlikUrunAd = row.Cells["TemizlikUrunAd"].Value.ToString();
                        int stokMiktari = Convert.ToInt32(row.Cells["TemizlikUrunStok"].Value);

                        // Grafikte bu verileri ekliyoruz
                        series.Points.AddXY(temizlikUrunAd, stokMiktari);
                    }
                }

                // Grafik özelliklerini ayarlayalım
                chartTemizlik.Series.Add(series);

                // Grafik başlığını ayarlayalım
                chartTemizlik.Titles.Clear();
                chartTemizlik.Titles.Add("Temizlik Ürünleri Stok Durumu");
                chartTemizlik.Titles[0].Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
                chartTemizlik.Titles[0].ForeColor = Color.DarkSlateGray;

                // Chart alanını özelleştirelim
                chartTemizlik.ChartAreas[0].BackColor = Color.AliceBlue;
                chartTemizlik.ChartAreas[0].BorderColor = Color.LightSlateGray;
                chartTemizlik.ChartAreas[0].BorderWidth = 2;

                // Eksen özelliklerini ayarlayalım
                chartTemizlik.ChartAreas[0].AxisX.Enabled = AxisEnabled.False; // X eksenini devre dışı bırakıyoruz çünkü pasta grafiği eksen gerektirmez.
                chartTemizlik.ChartAreas[0].AxisY.Enabled = AxisEnabled.False;

                // Grafik dilimlerinin özelliklerini değiştirelim
                series["PieLabelStyle"] = "Outside"; // Etiketleri dilimlerin dışında gösterelim
                series["PieDrawingStyle"] = "SoftEdge"; // Yumuşak kenarlı dilimler
                series["ExplodedPieDistance"] = "10"; // Dilimlerin birbirinden uzaklık mesafesi
                series["PieStartAngle"] = "90"; // Grafik başlangıç açısını ayarlayalım

                // Pasta dilimi grafiklerde veri etiketlerini gösterelim
                series.IsValueShownAsLabel = true;

                // Grafik dilimlerinin renklerini rastgele ayarlayalım
                Random random = new Random();
                foreach (DataPoint point in series.Points)
                {
                    point.Color = Color.FromArgb(random.Next(100, 256), random.Next(100, 256), random.Next(100, 256));
                    point.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold); // Etiket fontu
                }
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

        private void dataGridViewTemizlik_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCif formCif = new FormCif();
            formCif.Show();
            this.Hide(); // FormTemizlikÜrünleri'ni gizle
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormCamasirSuyu formCamasirSuyu = new FormCamasirSuyu();
            formCamasirSuyu.Show();
            this.Hide(); // FormTemizlikÜrünleri'ni gizle
        }
    }
}
