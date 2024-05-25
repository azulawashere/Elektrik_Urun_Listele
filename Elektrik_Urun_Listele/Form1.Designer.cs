namespace Elektrik_Urun_Listele
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvUrunler = new DataGridView();
            btnUrunEkleme = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(2064, 63);
            label1.TabIndex = 0;
            label1.Text = "Coşkun Elektrik";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // dgvUrunler
            // 
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Dock = DockStyle.Fill;
            dgvUrunler.Location = new Point(0, 63);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvUrunler.RowTemplate.Height = 122;
            dgvUrunler.Size = new Size(2064, 913);
            dgvUrunler.TabIndex = 3;
            dgvUrunler.CellContentClick += dgvUrunler_CellContentClick;
            // 
            // btnUrunEkleme
            // 
            btnUrunEkleme.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunEkleme.Location = new Point(12, 12);
            btnUrunEkleme.Name = "btnUrunEkleme";
            btnUrunEkleme.Size = new Size(212, 45);
            btnUrunEkleme.TabIndex = 4;
            btnUrunEkleme.Text = "Ürün Ekle";
            btnUrunEkleme.UseVisualStyleBackColor = true;
            btnUrunEkleme.Click += btnUrunEkleme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2064, 976);
            Controls.Add(btnUrunEkleme);
            Controls.Add(dgvUrunler);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dgvUrunler;
        private Button btnUrunEkleme;
    }
}
