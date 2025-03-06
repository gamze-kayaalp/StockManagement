namespace stokYönetimi
{
    partial class FormIcecekler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewIcecek = new System.Windows.Forms.DataGridView();
            this.btnGetir = new System.Windows.Forms.Button();
            this.chartIcecekler = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIcecek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIcecekler)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(598, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Grafik görüntüle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(598, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pdf indir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(105, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "İÇECEKLER";
            // 
            // dataGridViewIcecek
            // 
            this.dataGridViewIcecek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIcecek.Location = new System.Drawing.Point(71, 103);
            this.dataGridViewIcecek.Name = "dataGridViewIcecek";
            this.dataGridViewIcecek.RowHeadersWidth = 51;
            this.dataGridViewIcecek.RowTemplate.Height = 24;
            this.dataGridViewIcecek.Size = new System.Drawing.Size(425, 264);
            this.dataGridViewIcecek.TabIndex = 6;
            // 
            // btnGetir
            // 
            this.btnGetir.BackColor = System.Drawing.Color.Purple;
            this.btnGetir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGetir.Location = new System.Drawing.Point(108, 407);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(367, 51);
            this.btnGetir.TabIndex = 7;
            this.btnGetir.Text = "STOK VERİLERİNİ GETİR";
            this.btnGetir.UseVisualStyleBackColor = false;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // chartIcecekler
            // 
            chartArea3.Name = "ChartArea1";
            this.chartIcecekler.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartIcecekler.Legends.Add(legend3);
            this.chartIcecekler.Location = new System.Drawing.Point(584, 256);
            this.chartIcecekler.Name = "chartIcecekler";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartIcecekler.Series.Add(series3);
            this.chartIcecekler.Size = new System.Drawing.Size(300, 300);
            this.chartIcecekler.TabIndex = 8;
            this.chartIcecekler.Text = "chart1";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(833, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 42);
            this.button4.TabIndex = 9;
            this.button4.Text = "GERİ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(502, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 26);
            this.button3.TabIndex = 10;
            this.button3.Text = "SEÇ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(502, 160);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 26);
            this.button5.TabIndex = 11;
            this.button5.Text = "SEÇ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(502, 192);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 26);
            this.button6.TabIndex = 12;
            this.button6.Text = "SEÇ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormIcecekler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(1020, 625);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chartIcecekler);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.dataGridViewIcecek);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "FormIcecekler";
            this.Text = "FormIcecekler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIcecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartIcecekler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewIcecek;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIcecekler;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}