namespace Salon.App.Forms;

partial class FDashboard
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
        btnCustomer = new Button();
        panel1 = new Panel();
        panel2 = new Panel();
        pictureBox2 = new PictureBox();
        pictureBox1 = new PictureBox();
        panel3 = new Panel();
        groupBox4 = new GroupBox();
        btnLogout = new Button();
        groupBox3 = new GroupBox();
        btnLaporan = new Button();
        groupBox2 = new GroupBox();
        btnTransaksi = new Button();
        groupBox1 = new GroupBox();
        btnLayanan = new Button();
        btnProduk = new Button();
        btnUser = new Button();
        btnDaftarTransaksi = new Button();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((ISupportInitialize)pictureBox2).BeginInit();
        ((ISupportInitialize)pictureBox1).BeginInit();
        panel3.SuspendLayout();
        groupBox4.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // btnCustomer
        // 
        btnCustomer.FlatAppearance.BorderColor = Color.Gray;
        btnCustomer.FlatStyle = FlatStyle.Flat;
        btnCustomer.Image = Properties.Resources.customer;
        btnCustomer.Location = new Point(208, 22);
        btnCustomer.Name = "btnCustomer";
        btnCustomer.Size = new Size(92, 92);
        btnCustomer.TabIndex = 2;
        btnCustomer.Text = "Customer";
        btnCustomer.TextAlign = ContentAlignment.BottomCenter;
        btnCustomer.UseVisualStyleBackColor = true;
        btnCustomer.Click += btnCustomer_Click;
        // 
        // panel1
        // 
        panel1.Controls.Add(panel2);
        panel1.Controls.Add(panel3);
        panel1.Dock = DockStyle.Fill;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1097, 621);
        panel1.TabIndex = 6;
        // 
        // panel2
        // 
        panel2.Controls.Add(pictureBox2);
        panel2.Controls.Add(pictureBox1);
        panel2.Dock = DockStyle.Fill;
        panel2.Location = new Point(0, 120);
        panel2.Name = "panel2";
        panel2.Size = new Size(1097, 501);
        panel2.TabIndex = 2;
        // 
        // pictureBox2
        // 
        pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
        pictureBox2.Image = Properties.Resources.dua;
        pictureBox2.Location = new Point(723, 6);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(362, 483);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 1;
        pictureBox2.TabStop = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pictureBox1.Image = Properties.Resources.satu;
        pictureBox1.Location = new Point(12, 6);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(705, 483);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // panel3
        // 
        panel3.Controls.Add(groupBox4);
        panel3.Controls.Add(groupBox3);
        panel3.Controls.Add(groupBox2);
        panel3.Controls.Add(groupBox1);
        panel3.Dock = DockStyle.Top;
        panel3.Location = new Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(1097, 120);
        panel3.TabIndex = 1;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(btnLogout);
        groupBox4.Dock = DockStyle.Fill;
        groupBox4.Location = new Point(733, 0);
        groupBox4.Name = "groupBox4";
        groupBox4.Size = new Size(364, 120);
        groupBox4.TabIndex = 7;
        groupBox4.TabStop = false;
        groupBox4.Text = "Lainnya";
        // 
        // btnLogout
        // 
        btnLogout.FlatAppearance.BorderColor = Color.Gray;
        btnLogout.FlatStyle = FlatStyle.Flat;
        btnLogout.Image = Properties.Resources.logout;
        btnLogout.Location = new Point(6, 22);
        btnLogout.Name = "btnLogout";
        btnLogout.Size = new Size(92, 92);
        btnLogout.TabIndex = 7;
        btnLogout.Text = "Logout";
        btnLogout.TextAlign = ContentAlignment.BottomCenter;
        btnLogout.UseVisualStyleBackColor = true;
        btnLogout.Click += btnLogout_Click;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(btnLaporan);
        groupBox3.Dock = DockStyle.Left;
        groupBox3.Location = new Point(626, 0);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(107, 120);
        groupBox3.TabIndex = 8;
        groupBox3.TabStop = false;
        groupBox3.Text = "Laporan";
        // 
        // btnLaporan
        // 
        btnLaporan.FlatAppearance.BorderColor = Color.Gray;
        btnLaporan.FlatStyle = FlatStyle.Flat;
        btnLaporan.Image = Properties.Resources.laporan;
        btnLaporan.Location = new Point(6, 22);
        btnLaporan.Name = "btnLaporan";
        btnLaporan.Size = new Size(92, 92);
        btnLaporan.TabIndex = 6;
        btnLaporan.Text = "Laporan";
        btnLaporan.TextAlign = ContentAlignment.BottomCenter;
        btnLaporan.UseVisualStyleBackColor = true;
        btnLaporan.Click += btnLaporan_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnDaftarTransaksi);
        groupBox2.Controls.Add(btnTransaksi);
        groupBox2.Dock = DockStyle.Left;
        groupBox2.Location = new Point(408, 0);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(218, 120);
        groupBox2.TabIndex = 7;
        groupBox2.TabStop = false;
        groupBox2.Text = "Transaksi";
        // 
        // btnTransaksi
        // 
        btnTransaksi.FlatAppearance.BorderColor = Color.Gray;
        btnTransaksi.FlatStyle = FlatStyle.Flat;
        btnTransaksi.Image = Properties.Resources.transaksi;
        btnTransaksi.Location = new Point(112, 22);
        btnTransaksi.Name = "btnTransaksi";
        btnTransaksi.Size = new Size(100, 92);
        btnTransaksi.TabIndex = 5;
        btnTransaksi.Text = "Form Transaksi";
        btnTransaksi.TextAlign = ContentAlignment.BottomCenter;
        btnTransaksi.UseVisualStyleBackColor = true;
        btnTransaksi.Click += btnTransaksi_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btnLayanan);
        groupBox1.Controls.Add(btnProduk);
        groupBox1.Controls.Add(btnCustomer);
        groupBox1.Controls.Add(btnUser);
        groupBox1.Dock = DockStyle.Left;
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(408, 120);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        groupBox1.Text = "Master";
        // 
        // btnLayanan
        // 
        btnLayanan.FlatAppearance.BorderColor = Color.Gray;
        btnLayanan.FlatStyle = FlatStyle.Flat;
        btnLayanan.Image = Properties.Resources.layanan;
        btnLayanan.Location = new Point(306, 22);
        btnLayanan.Name = "btnLayanan";
        btnLayanan.Size = new Size(92, 92);
        btnLayanan.TabIndex = 3;
        btnLayanan.Text = "Layanan";
        btnLayanan.TextAlign = ContentAlignment.BottomCenter;
        btnLayanan.UseVisualStyleBackColor = true;
        btnLayanan.Click += btnLayanan_Click;
        // 
        // btnProduk
        // 
        btnProduk.FlatAppearance.BorderColor = Color.Gray;
        btnProduk.FlatStyle = FlatStyle.Flat;
        btnProduk.Image = Properties.Resources.produk;
        btnProduk.Location = new Point(110, 22);
        btnProduk.Name = "btnProduk";
        btnProduk.Size = new Size(92, 92);
        btnProduk.TabIndex = 1;
        btnProduk.Text = "Produk";
        btnProduk.TextAlign = ContentAlignment.BottomCenter;
        btnProduk.UseVisualStyleBackColor = true;
        btnProduk.Click += btnProduk_Click;
        // 
        // btnUser
        // 
        btnUser.FlatAppearance.BorderColor = Color.Gray;
        btnUser.FlatStyle = FlatStyle.Flat;
        btnUser.Image = Properties.Resources.user;
        btnUser.Location = new Point(12, 22);
        btnUser.Name = "btnUser";
        btnUser.Size = new Size(92, 92);
        btnUser.TabIndex = 0;
        btnUser.Text = "User";
        btnUser.TextAlign = ContentAlignment.BottomCenter;
        btnUser.UseVisualStyleBackColor = true;
        btnUser.Click += btnUser_Click;
        // 
        // btnDaftarTransaksi
        // 
        btnDaftarTransaksi.FlatAppearance.BorderColor = Color.Gray;
        btnDaftarTransaksi.FlatStyle = FlatStyle.Flat;
        btnDaftarTransaksi.Font = new Font("Segoe UI", 9F);
        btnDaftarTransaksi.Image = Properties.Resources.daftar_transaksi;
        btnDaftarTransaksi.Location = new Point(6, 22);
        btnDaftarTransaksi.Name = "btnDaftarTransaksi";
        btnDaftarTransaksi.Size = new Size(100, 92);
        btnDaftarTransaksi.TabIndex = 4;
        btnDaftarTransaksi.Text = "Daftar Transaksi";
        btnDaftarTransaksi.TextAlign = ContentAlignment.BottomCenter;
        btnDaftarTransaksi.UseVisualStyleBackColor = true;
        btnDaftarTransaksi.Click += btnDaftarTransaksi_Click;
        // 
        // FDashboard
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1097, 621);
        Controls.Add(panel1);
        Name = "FDashboard";
        Text = "FDashboard";
        Load += FDashboard_Load;
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((ISupportInitialize)pictureBox2).EndInit();
        ((ISupportInitialize)pictureBox1).EndInit();
        panel3.ResumeLayout(false);
        groupBox4.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Button btnCustomer;
    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private GroupBox groupBox4;
    private GroupBox groupBox3;
    private GroupBox groupBox2;
    private GroupBox groupBox1;
    private Button btnUser;
    private Button btnTransaksi;
    private PictureBox pictureBox1;
    private Button btnLogout;
    private Button btnLaporan;
    private Button btnLayanan;
    private Button btnProduk;
    private PictureBox pictureBox2;
    private Button btnDaftarTransaksi;
}