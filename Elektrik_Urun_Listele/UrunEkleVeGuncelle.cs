using Elektrik_Urun_Listele.DBContext;
using Elektrik_Urun_Listele.DesignPatterns.SingLetonPattern;
using Elektrik_Urun_Listele.Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elektrik_Urun_Listele
{
    public partial class UrunEkleVeGuncelle : Form
    {
        Context _db;
        public UrunEkleVeGuncelle()
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
        }

        private void btnGorselEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pboxUrunGorsel.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (pboxUrunGorsel.Image != null || txtFiyat.Text != null || txtKutuAdet != null || txtMarka.Text != null || txtModelNo.Text != null || rtxtBoxAciklama.Text != null)
            {
                try
                {
                    // Fotoğrafı byte dizisine dönüştürme
                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pboxUrunGorsel.Image.Save(ms, ImageFormat.Jpeg);
                        imageBytes = ms.ToArray();
                    }
                    _db.Products.Add(new Product
                    {
                        ModelNo = txtModelNo.Text,
                        Image = imageBytes,
                        Description = rtxtBoxAciklama.Text,
                        Price = Convert.ToDecimal(txtFiyat.Text),
                        BoxCount = Convert.ToInt32(txtKutuAdet.Text),
                        Brand = txtMarka.Text
                    });
                    _db.SaveChanges();

                }
                catch (Exception m)
                {

                    MessageBox.Show(m.ToString());
                }

                // Veritabanına fotoğrafı kaydetme işlemi

                MessageBox.Show("Fotoğraf başarıyla kaydedildi.");

            }
            else
            {
                MessageBox.Show("Lütfen bir fotoğraf seçin.");
            }
        }

        private void btnUrunleriGoster_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }

        private void UrunEkleVeGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
