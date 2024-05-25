namespace Elektrik_Urun_Listele
{
    partial class UrunEkleVeGuncelle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtModelNo = new TextBox();
            txtMarka = new TextBox();
            txtFiyat = new TextBox();
            txtKutuAdet = new TextBox();
            rtxtBoxAciklama = new RichTextBox();
            btnGorselEkle = new Button();
            pboxUrunGorsel = new PictureBox();
            btnKaydet = new Button();
            btnUrunleriGoster = new Button();
            ((System.ComponentModel.ISupportInitialize)pboxUrunGorsel).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "Model No:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            label2.Text = "Görsel:";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 331);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            label3.Text = "Açıklama:";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 530);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 0;
            label4.Text = "Fiyat:";
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(12, 573);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            label5.Text = "Kutu Adeti:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(12, 86);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 0;
            label6.Text = "Marka:";
            // 
            // txtModelNo
            // 
            txtModelNo.Location = new Point(145, 35);
            txtModelNo.Name = "txtModelNo";
            txtModelNo.Size = new Size(424, 23);
            txtModelNo.TabIndex = 1;
            // 
            // txtMarka
            // 
            txtMarka.Location = new Point(145, 86);
            txtMarka.Name = "txtMarka";
            txtMarka.Size = new Size(424, 23);
            txtMarka.TabIndex = 1;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(145, 532);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(424, 23);
            txtFiyat.TabIndex = 1;
            // 
            // txtKutuAdet
            // 
            txtKutuAdet.Location = new Point(145, 573);
            txtKutuAdet.Name = "txtKutuAdet";
            txtKutuAdet.Size = new Size(424, 23);
            txtKutuAdet.TabIndex = 1;
            // 
            // rtxtBoxAciklama
            // 
            rtxtBoxAciklama.Location = new Point(145, 333);
            rtxtBoxAciklama.Name = "rtxtBoxAciklama";
            rtxtBoxAciklama.Size = new Size(424, 170);
            rtxtBoxAciklama.TabIndex = 2;
            rtxtBoxAciklama.Text = "";
            // 
            // btnGorselEkle
            // 
            btnGorselEkle.Location = new Point(145, 131);
            btnGorselEkle.Name = "btnGorselEkle";
            btnGorselEkle.Size = new Size(143, 23);
            btnGorselEkle.TabIndex = 3;
            btnGorselEkle.Text = "Görsel Ekle";
            btnGorselEkle.UseVisualStyleBackColor = true;
            btnGorselEkle.Click += btnGorselEkle_Click;
            // 
            // pboxUrunGorsel
            // 
            pboxUrunGorsel.Location = new Point(145, 170);
            pboxUrunGorsel.Name = "pboxUrunGorsel";
            pboxUrunGorsel.Size = new Size(424, 142);
            pboxUrunGorsel.SizeMode = PictureBoxSizeMode.StretchImage;
            pboxUrunGorsel.TabIndex = 4;
            pboxUrunGorsel.TabStop = false;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(363, 618);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(181, 40);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnUrunleriGoster
            // 
            btnUrunleriGoster.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunleriGoster.Location = new Point(12, 618);
            btnUrunleriGoster.Name = "btnUrunleriGoster";
            btnUrunleriGoster.Size = new Size(120, 52);
            btnUrunleriGoster.TabIndex = 6;
            btnUrunleriGoster.Text = "Ürünlere git";
            btnUrunleriGoster.UseVisualStyleBackColor = true;
            btnUrunleriGoster.Click += btnUrunleriGoster_Click;
            // 
            // UrunEkleVeGuncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 682);
            Controls.Add(btnUrunleriGoster);
            Controls.Add(btnKaydet);
            Controls.Add(pboxUrunGorsel);
            Controls.Add(btnGorselEkle);
            Controls.Add(rtxtBoxAciklama);
            Controls.Add(txtKutuAdet);
            Controls.Add(txtFiyat);
            Controls.Add(txtMarka);
            Controls.Add(txtModelNo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UrunEkleVeGuncelle";
            Text = "UrunEkleVeGuncelle";
            Load += UrunEkleVeGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)pboxUrunGorsel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtModelNo;
        private TextBox txtMarka;
        private TextBox txtFiyat;
        private TextBox txtKutuAdet;
        private RichTextBox rtxtBoxAciklama;
        private Button btnGorselEkle;
        private PictureBox pboxUrunGorsel;
        private Button btnKaydet;
        private Button btnUrunleriGoster;
    }
}