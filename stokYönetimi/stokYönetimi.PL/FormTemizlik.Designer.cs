namespace stokYönetimi
{
    partial class FormTemizlik
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTemizlik = new System.Windows.Forms.DataGridView();
            this.chartTemizlik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemizlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemizlik)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(576, 142);
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
            this.button1.Location = new System.Drawing.Point(576, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 51);
            this.button1.TabIndex = 4;
            this.button1.Text = "PDF indir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "TEMİZLİK ÜRÜNLERİ";
            // 
            // dataGridViewTemizlik
            // 
            this.dataGridViewTemizlik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTemizlik.Location = new System.Drawing.Point(70, 80);
            this.dataGridViewTemizlik.Name = "dataGridViewTemizlik";
            this.dataGridViewTemizlik.RowHeadersWidth = 51;
            this.dataGridViewTemizlik.RowTemplate.Height = 24;
            this.dataGridViewTemizlik.Size = new System.Drawing.Size(410, 244);
            this.dataGridViewTemizlik.TabIndex = 6;
            this.dataGridViewTemizlik.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTemizlik_CellContentClick);
            // 
            // chartTemizlik
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTemizlik.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTemizlik.Legends.Add(legend2);
            this.chartTemizlik.Location = new System.Drawing.Point(564, 233);
            this.chartTemizlik.Name = "chartTemizlik";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTemizlik.Series.Add(series2);
            this.chartTemizlik.Size = new System.Drawing.Size(363, 300);
            this.chartTemizlik.TabIndex = 7;
            this.chartTemizlik.Text = "chart1";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(70, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(410, 51);
            this.button3.TabIndex = 8;
            this.button3.Text = "STOK VERİLERİNİ GETİR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(865, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 42);
            this.button4.TabIndex = 9;
            this.button4.Text = "GERİ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(486, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 26);
            this.button5.TabIndex = 10;
            this.button5.Text = "SEÇ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(486, 152);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 33);
            this.button6.TabIndex = 11;
            this.button6.Text = "SEÇ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(486, 191);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 26);
            this.button7.TabIndex = 12;
            this.button7.Text = "SEÇ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // FormTemizlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(1031, 613);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.chartTemizlik);
            this.Controls.Add(this.dataGridViewTemizlik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormTemizlik";
            this.Text = "FormTemizlik";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTemizlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemizlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTemizlik;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemizlik;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}