using Elektrik_Urun_Listele.DBContext;
using Elektrik_Urun_Listele.DesignPatterns.SingLetonPattern;
using Elektrik_Urun_Listele.Entity;
using System.Windows.Forms;

namespace Elektrik_Urun_Listele
{
    public partial class Form1 : Form
    {
        Context _db;
        public Form1()
        {
            InitializeComponent();
            _db = DBTool.DBInstance;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUrunEkleme_Click(object sender, EventArgs e)
        {
            this.Hide();
            UrunEkleVeGuncelle form2 = new UrunEkleVeGuncelle();
            form2.ShowDialog();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
            dgvUrunler.DataSource = _db.Products.ToList();
            dgvUrunler.Columns[2].Width = 444;
            dgvUrunler.Columns[3].Width = 777;
            dgvUrunler.Columns[0].Width = 44;
            dgvUrunler.Columns[1].Width = 111;
        

        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
