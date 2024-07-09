namespace Salon.App.Forms;

partial class FDaftarTransaksi
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
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        panel2 = new Panel();
        btnRefresh = new Button();
        btnHapus = new Button();
        panel3 = new Panel();
        lblLayanan = new Label();
        lblProduk = new Label();
        label1 = new Label();
        dgvLayanan = new DataGridView();
        dgvProduk = new DataGridView();
        cCariTransaksi = new TextBox();
        dgv = new DataGridView();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        ((ISupportInitialize)dgvLayanan).BeginInit();
        ((ISupportInitialize)dgvProduk).BeginInit();
        ((ISupportInitialize)dgv).BeginInit();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.Controls.Add(btnRefresh);
        panel2.Controls.Add(btnHapus);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0, 535);
        panel2.Name = "panel2";
        panel2.Size = new Size(934, 46);
        panel2.TabIndex = 1;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.Gray;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Font = new Font("Segoe UI", 12F);
        btnRefresh.Location = new Point(470, 6);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(458, 32);
        btnRefresh.TabIndex = 2;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // btnHapus
        // 
        btnHapus.BackColor = Color.LightCoral;
        btnHapus.Enabled = false;
        btnHapus.FlatAppearance.BorderSize = 0;
        btnHapus.FlatStyle = FlatStyle.Flat;
        btnHapus.Font = new Font("Segoe UI", 12F);
        btnHapus.Location = new Point(6, 6);
        btnHapus.Name = "btnHapus";
        btnHapus.Size = new Size(458, 32);
        btnHapus.TabIndex = 1;
        btnHapus.Text = "Hapus";
        btnHapus.UseVisualStyleBackColor = false;
        btnHapus.Click += btnHapus_Click;
        // 
        // panel3
        // 
        panel3.Controls.Add(lblLayanan);
        panel3.Controls.Add(lblProduk);
        panel3.Controls.Add(label1);
        panel3.Controls.Add(dgvLayanan);
        panel3.Controls.Add(dgvProduk);
        panel3.Controls.Add(cCariTransaksi);
        panel3.Controls.Add(dgv);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(934, 535);
        panel3.TabIndex = 2;
        // 
        // lblLayanan
        // 
        lblLayanan.Font = new Font("Segoe UI", 14F);
        lblLayanan.Location = new Point(500, 338);
        lblLayanan.Name = "lblLayanan";
        lblLayanan.Size = new Size(400, 25);
        lblLayanan.TabIndex = 13;
        lblLayanan.Text = "Layanan";
        lblLayanan.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblProduk
        // 
        lblProduk.Font = new Font("Segoe UI", 14F);
        lblProduk.Location = new Point(33, 338);
        lblProduk.Name = "lblProduk";
        lblProduk.Size = new Size(400, 25);
        lblProduk.TabIndex = 12;
        lblProduk.Text = "Produk";
        lblProduk.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F);
        label1.Location = new Point(395, 7);
        label1.Name = "label1";
        label1.Size = new Size(145, 25);
        label1.TabIndex = 11;
        label1.Text = "Daftar Transaksi";
        // 
        // dgvLayanan
        // 
        dgvLayanan.AllowUserToAddRows = false;
        dgvLayanan.AllowUserToDeleteRows = false;
        dgvLayanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvLayanan.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgvLayanan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvLayanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvLayanan.Location = new Point(470, 366);
        dgvLayanan.Name = "dgvLayanan";
        dgvLayanan.ReadOnly = true;
        dgvLayanan.RowHeadersVisible = false;
        dgvLayanan.Size = new Size(461, 163);
        dgvLayanan.TabIndex = 10;
        // 
        // dgvProduk
        // 
        dgvProduk.AllowUserToAddRows = false;
        dgvProduk.AllowUserToDeleteRows = false;
        dgvProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProduk.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle2.BackColor = SystemColors.Control;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgvProduk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProduk.Location = new Point(3, 366);
        dgvProduk.Name = "dgvProduk";
        dgvProduk.ReadOnly = true;
        dgvProduk.RowHeadersVisible = false;
        dgvProduk.Size = new Size(461, 163);
        dgvProduk.TabIndex = 9;
        // 
        // cCariTransaksi
        // 
        cCariTransaksi.Location = new Point(3, 36);
        cCariTransaksi.Name = "cCariTransaksi";
        cCariTransaksi.PlaceholderText = "Cari transaksi...";
        cCariTransaksi.Size = new Size(778, 23);
        cCariTransaksi.TabIndex = 7;
        cCariTransaksi.TextChanged += cCariDaftarTransaksi_TextChanged;
        // 
        // dgv
        // 
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.BorderStyle = BorderStyle.None;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle3.BackColor = SystemColors.Control;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv.Location = new Point(3, 65);
        dgv.Name = "dgv";
        dgv.ReadOnly = true;
        dgv.RowHeadersVisible = false;
        dgv.Size = new Size(928, 252);
        dgv.TabIndex = 8;
        dgv.CellClick += dgv_CellClick;
        // 
        // FDaftarTransaksi
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(934, 581);
        Controls.Add(panel3);
        Controls.Add(panel2);
        MaximizeBox = false;
        MaximumSize = new Size(950, 620);
        MinimumSize = new Size(950, 620);
        Name = "FDaftarTransaksi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Daftar Transaksi";
        Load += FDaftarTransaksi_Load;
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((ISupportInitialize)dgvLayanan).EndInit();
        ((ISupportInitialize)dgvProduk).EndInit();
        ((ISupportInitialize)dgv).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Panel panel2;
    private Panel panel3;
    private DataGridView dgv;
    private Button btnRefresh;
    private Button btnHapus;
    private TextBox cCariTransaksi;
    private DataGridView dgvProduk;
    private DataGridView dgvLayanan;
    private Label label1;
    private Label lblLayanan;
    private Label lblProduk;
}