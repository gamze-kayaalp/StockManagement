namespace stokYönetimi
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtıştırmalıklar = new System.Windows.Forms.Button();
            this.btnBakliyatlar = new System.Windows.Forms.Button();
            this.btnİçecekler = new System.Windows.Forms.Button();
            this.btnTemizlik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN KATAGORİLERİ";
            // 
            // btnAtıştırmalıklar
            // 
            this.btnAtıştırmalıklar.Location = new System.Drawing.Point(50, 153);
            this.btnAtıştırmalıklar.Name = "btnAtıştırmalıklar";
            this.btnAtıştırmalıklar.Size = new System.Drawing.Size(125, 23);
            this.btnAtıştırmalıklar.TabIndex = 1;
            this.btnAtıştırmalıklar.Text = "Atıştırmalıklar";
            this.btnAtıştırmalıklar.UseVisualStyleBackColor = true;
            this.btnAtıştırmalıklar.Click += new System.EventHandler(this.btnAtıştırmalıklar_Click);
            // 
            // btnBakliyatlar
            // 
            this.btnBakliyatlar.Location = new System.Drawing.Point(248, 153);
            this.btnBakliyatlar.Name = "btnBakliyatlar";
            this.btnBakliyatlar.Size = new System.Drawing.Size(125, 23);
            this.btnBakliyatlar.TabIndex = 2;
            this.btnBakliyatlar.Text = "Bakliyatlar";
            this.btnBakliyatlar.UseVisualStyleBackColor = true;
            this.btnBakliyatlar.Click += new System.EventHandler(this.btnBakliyatlar_Click);
            // 
            // btnİçecekler
            // 
            this.btnİçecekler.Location = new System.Drawing.Point(415, 153);
            this.btnİçecekler.Name = "btnİçecekler";
            this.btnİçecekler.Size = new System.Drawing.Size(125, 23);
            this.btnİçecekler.TabIndex = 3;
            this.btnİçecekler.Text = "İçecekler";
            this.btnİçecekler.UseVisualStyleBackColor = true;
            this.btnİçecekler.Click += new System.EventHandler(this.btnİçecekler_Click);
            // 
            // btnTemizlik
            // 
            this.btnTemizlik.Location = new System.Drawing.Point(576, 153);
            this.btnTemizlik.Name = "btnTemizlik";
            this.btnTemizlik.Size = new System.Drawing.Size(125, 23);
            this.btnTemizlik.TabIndex = 4;
            this.btnTemizlik.Text = "Temizlik";
            this.btnTemizlik.UseVisualStyleBackColor = true;
            this.btnTemizlik.Click += new System.EventHandler(this.btnTemizlik_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemizlik);
            this.Controls.Add(this.btnİçecekler);
            this.Controls.Add(this.btnBakliyatlar);
            this.Controls.Add(this.btnAtıştırmalıklar);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtıştırmalıklar;
        private System.Windows.Forms.Button btnBakliyatlar;
        private System.Windows.Forms.Button btnİçecekler;
        private System.Windows.Forms.Button btnTemizlik;
    }
}