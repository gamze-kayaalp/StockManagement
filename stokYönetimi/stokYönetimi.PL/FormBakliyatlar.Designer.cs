namespace stokYönetimi
{
    partial class FormBakliyatlar
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBakliyat = new System.Windows.Forms.DataGridView();
            this.chartBakliyat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBakliyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBakliyat)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(572, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "PDF indir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(572, 196);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 52);
            this.button2.TabIndex = 3;
            this.button2.Text = "Grafik görüntüle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "BAKLİYATLAR";
            // 
            // dataGridViewBakliyat
            // 
            this.dataGridViewBakliyat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBakliyat.Location = new System.Drawing.Point(58, 78);
            this.dataGridViewBakliyat.Name = "dataGridViewBakliyat";
            this.dataGridViewBakliyat.RowHeadersWidth = 51;
            this.dataGridViewBakliyat.RowTemplate.Height = 24;
            this.dataGridViewBakliyat.Size = new System.Drawing.Size(407, 287);
            this.dataGridViewBakliyat.TabIndex = 6;
            // 
            // chartBakliyat
            // 
            chartArea3.Name = "ChartArea1";
            this.chartBakliyat.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartBakliyat.Legends.Add(legend3);
            this.chartBakliyat.Location = new System.Drawing.Point(572, 299);
            this.chartBakliyat.Name = "chartBakliyat";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartBakliyat.Series.Add(series3);
            this.chartBakliyat.Size = new System.Drawing.Size(300, 300);
            this.chartBakliyat.TabIndex = 7;
            this.chartBakliyat.Text = "chartBakliyat";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(58, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(407, 53);
            this.button3.TabIndex = 8;
            this.button3.Text = "STOK VERİLERİNİ GETİR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(481, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 26);
            this.button4.TabIndex = 9;
            this.button4.Text = "SEÇ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(481, 154);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 26);
            this.button5.TabIndex = 10;
            this.button5.Text = "SEÇ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(481, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 26);
            this.button6.TabIndex = 11;
            this.button6.Text = "SEÇ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(825, 47);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 42);
            this.button7.TabIndex = 12;
            this.button7.Text = "GERİ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // FormBakliyatlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(1019, 650);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chartBakliyat);
            this.Controls.Add(this.dataGridViewBakliyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormBakliyatlar";
            this.Text = "FormBakliyatlar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBakliyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBakliyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBakliyat;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBakliyat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}