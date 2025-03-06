using iTextSharp.text.pdf;
using iTextSharp.text;
using stokYönetimi.BL;
using stokYönetimi.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using stokYönetimi.PL;

namespace stokYönetimi
{
    public partial class FormBakliyatlar : Form
    {


        private readonly StokBL stokBL;

        public FormBakliyatlar()
        {
            InitializeComponent();
            stokBL = new StokBL(); // BL sınıfını başlat

        }

        private void LoadBakliyatlarData()
        {
            try
            {
                // Verileri BL katmanından al
                List<Bakliyatlar> bakliyatlar = stokBL.GetAllBakliyatlar(); // Bakliyatlar'ı kullanıyoruz

                // DataGridView'e bağla
                dataGridViewBakliyat.DataSource = bakliyatlar;

                // DataGridView sütun başlıklarını düzenle
                if (dataGridViewBakliyat.Columns.Count > 0) // Sütunlar kontrolü
                {
                    dataGridViewBakliyat.Columns["BakliyatID"].HeaderText = "Bakliyat ID";
                    dataGridViewBakliyat.Columns["BakliyatAd"].HeaderText = "Bakliyat Adı";
                    dataGridViewBakliyat.Columns["BakliyatStok"].HeaderText = "Bakliyat Miktarı";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler getirilirken bir hata oluştu: " + ex.Message);
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            LoadBakliyatlarData();
        }

        //private void CreateGraph()
        //{
        //    // Grafiğin genel tasarımını yapıyoruz
        //    chartBakliyat.Series.Clear();
        //    chartBakliyat.ChartAreas.Clear();

        //    // Yeni bir ChartArea ekliyoruz
        //    ChartArea chartArea = new ChartArea("BakliyatlarArea");
        //    chartBakliyat.ChartAreas.Add(chartArea);

        //    // Grafik serisi oluşturuluyor
        //    Series series = new Series("Stoklar");
        //    series.ChartType = SeriesChartType.Bar; // Bar grafik tipi
        //    series.XValueMember = "Ad";
        //    series.YValueMembers = "Stok";

        //    // DataGridView'deki verileri grafikle eşleştiriyoruz
        //    chartBakliyat.DataSource = dataGridViewBakliyat.DataSource;
        //    chartBakliyat.Series.Add(series);
        //    chartBakliyat.DataBind();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            // Pasta grafik verilerini eklemek için bir list oluşturuyoruz
            List<string> labels = new List<string>();
            List<int> values = new List<int>();

            // DataGridView'den verileri alıyoruz
            foreach (DataGridViewRow row in dataGridViewBakliyat.Rows)
            {
                if (!row.IsNewRow)
                {
                    string kategori = row.Cells["BakliyatAd"].Value.ToString(); // Ürün adı
                    int stok = Convert.ToInt32(row.Cells["BakliyatStok"].Value); // Stok miktarı

                    labels.Add(kategori);  // Ürün adı listesine ekliyoruz
                    values.Add(stok);      // Stok miktarlarını listesine ekliyoruz
                }
            }

            // Pasta grafik için veri seti oluşturuyoruz
            chartBakliyat.Series.Clear();  // Önceki serileri temizle
            var series = chartBakliyat.Series.Add("Stok Durumu");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;  // Pasta grafik tipi
            series.IsValueShownAsLabel = true;  // Değerlerin etiket olarak gösterilmesi

            // Etiket ve değerleri ekliyoruz
            for (int i = 0; i < labels.Count; i++)
            {
                series.Points.AddXY(labels[i], values[i]);
            }

            // Grafik görünümünü özelleştirelim
            series["PieLabelStyle"] = "Outside";  // Etiketleri dışarıya yerleştirme
            series["PieLineColor"] = "Black";    // Dilimlerin kenar çizgisi rengi
            series["ExplodedRadius"] = "10";     // Dilimlerin patlatılma mesafesi

            // Grafik başlığını ekliyoruz
            chartBakliyat.Titles.Clear();  // Önceki başlıkları temizle
            chartBakliyat.Titles.Add("Bakliyatlar Stok Durumu");  // Yeni başlık ekle
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
                            pdfDoc.Add(new Paragraph("Bakliyat Stok Bilgileri"));
                            pdfDoc.Add(new Paragraph(" ")); // Boşluk

                            // Tablo
                            PdfPTable table = new PdfPTable(dataGridViewBakliyat.Columns.Count);
                            table.WidthPercentage = 100;

                            // Sütun başlıklarını ekle
                            foreach (DataGridViewColumn column in dataGridViewBakliyat.Columns)
                            {
                                table.AddCell(new Phrase(column.HeaderText));
                            }

                            // Satırları ekle
                            foreach (DataGridViewRow row in dataGridViewBakliyat.Rows)
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

        private void button7_Click(object sender, EventArgs e)
        {
            // Mevcut formu kapatıyoruz
            this.Close();

            // Form2'yi açıyoruz
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormNohut formNohut = new FormNohut();
            formNohut.Show();
            this.Hide(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMercimek formMercimek = new FormMercimek();
            formMercimek.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormFasulye formfasulye = new FormFasulye();
            formfasulye.Show();
            this.Hide();
        }
    }
}
