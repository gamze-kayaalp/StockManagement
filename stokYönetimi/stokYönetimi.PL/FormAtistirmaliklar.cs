using stokYönetimi.BL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using stokYönetimi.Entities;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using stokYönetimi.PL;


namespace stokYönetimi
{
    public partial class FormAtistirmaliklar : Form
    {
        private readonly StokBL stokBL; // BL sınıfından bir nesne




        public FormAtistirmaliklar()
        {
            InitializeComponent();
            stokBL = new StokBL(); // BL sınıfını başlat


        }


        // string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\StokYonetimi1.accdb";

        private void FormAtistirmaliklar_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Verileri BL katmanından al
                List<Atistirmalik> atistirmaliklar = stokBL.GetAllAtistirmaliklar();

                // DataGridView'e bağla
                dataGridView1.DataSource = atistirmaliklar;

                // DataGridView sütun başlıklarını düzenle
                dataGridView1.Columns["ID"].HeaderText = "ID";
                dataGridView1.Columns["Ad"].HeaderText = "Atıştırmalık Adı";
                dataGridView1.Columns["Stok"].HeaderText = "Stok Miktarı";
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
                            pdfDoc.Add(new Paragraph("Atıştırmalık Stok Bilgileri"));
                            pdfDoc.Add(new Paragraph(" ")); // Boşluk

                            // Tablo
                            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
                            table.WidthPercentage = 100;

                            // Sütun başlıklarını ekle
                            foreach (DataGridViewColumn column in dataGridView1.Columns)
                            {
                                table.AddCell(new Phrase(column.HeaderText));
                            }

                            // Satırları ekle
                            foreach (DataGridViewRow row in dataGridView1.Rows)
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
            
            // Chart kontrolüne veri eklemeden önce boşaltalım
            chart1.Series.Clear();

            // Chart için yeni bir seri ekleyelim
            Series series = new Series("Atistirmaliklar");
            series.ChartType = SeriesChartType.Pie; // Pasta dilimi grafik tipi

            // DataGridView'deki verileri grafik için hazırlıyoruz
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Her satırdan Atıştırmalık adı ve stok miktarını alıyoruz
                    string atistirmalikAd = row.Cells["Ad"].Value.ToString();
                    int stokMiktari = Convert.ToInt32(row.Cells["Stok"].Value);

                    // Grafikte bu verileri ekliyoruz
                    series.Points.AddXY(atistirmalikAd, stokMiktari);
                }
            }

            // Grafik özelliklerini ayarlayalım
            chart1.Series.Add(series);

            // Grafik başlığını ayarlayalım
            chart1.Titles.Clear();
            chart1.Titles.Add("Atıştırmalık Stok Miktarları");
            chart1.Titles[0].Font = new System.Drawing.Font("Arial", 16, FontStyle.Bold);
            chart1.Titles[0].ForeColor = Color.DarkSlateGray;

            // Chart alanını özelleştirelim
            chart1.ChartAreas[0].BackColor = Color.AliceBlue;
            chart1.ChartAreas[0].BorderColor = Color.LightSlateGray;
            chart1.ChartAreas[0].BorderWidth = 2;

            // Eksen özelliklerini ayarlayalım
            chart1.ChartAreas[0].AxisX.Enabled = AxisEnabled.False; // X eksenini devre dışı bırakıyoruz çünkü pasta grafiği olduğunda eksenlere gerek yok.
            chart1.ChartAreas[0].AxisY.Enabled = AxisEnabled.False; // Y eksenini devre dışı bırakıyoruz.

            // Grafik dilimlerinin renklerini ve diğer özelliklerini değiştirelim
            series["PieLabelStyle"] = "Outside"; // Etiketleri dilimlerin dışında gösterelim
            series["PieDrawingStyle"] = "SoftEdge"; // Yumuşak kenarlı dilimler
            series["ExplodedPieDistance"] = "10"; // Dilimlerin birbirinden uzaklık mesafesi
            series["PieStartAngle"] = "90"; // Grafik başlangıç açısını ayarlayalım

            // Grafik dilimlerinin renklerini değiştirelim
            series.Color = Color.Orange; // Varsayılan renkten farklı bir renk

            // Veri noktalarındaki etiket fontlarını değiştirelim
            foreach (DataPoint point in series.Points)
            {
                point.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold); // Veri noktalarındaki etiketlerin fontunu değiştirelim
            }

            // Pasta dilimi grafiklerde veri etiketlerini gösterelim
            series.IsValueShownAsLabel = true;
            series.LabelForeColor = Color.White; // Etiket yazı rengini beyaz yapalım
            series.LabelBackColor = Color.Transparent; // Etiket arka plan rengini saydam yapalım
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Mevcut formu kapatıyoruz
            this.Close();

            // Form2'yi açıyoruz
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCikolata formCikolata = new FormCikolata();
            formCikolata.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormCips formCips = new FormCips();
            formCips.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormDondurma formDondurma = new FormDondurma();
            formDondurma.Show();
            this.Hide(); // FormAtistirmaliklar'ı gizle
        }
    }

}


    

       

       

        
    
