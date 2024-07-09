namespace Salon.App.Forms;

partial class FTransaksi
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
        panel1 = new Panel();
        cTanggal = new DateTimePicker();
        cID = new ComboBox();
        label2 = new Label();
        label3 = new Label();
        cBayar = new TextBox();
        cTotalBiaya = new TextBox();
        cCustomer = new ComboBox();
        label7 = new Label();
        label6 = new Label();
        label1 = new Label();
        lblKembali = new Label();
        cKembali = new TextBox();
        panel2 = new Panel();
        btnRefresh = new Button();
        btnSimpan = new Button();
        panel3 = new Panel();
        panel5 = new Panel();
        label11 = new Label();
        lblBiayaLayanan = new Label();
        label10 = new Label();
        label9 = new Label();
        cDaftarLayanan = new ComboBox();
        cDaftarProduk = new ComboBox();
        panel4 = new Panel();
        label8 = new Label();
        lblBiayaProduk = new Label();
        dgvLayanan = new DataGridView();
        dgvProduk = new DataGridView();
        dgvProdukId = new DataGridViewTextBoxColumn();
        dgvProdukNama = new DataGridViewTextBoxColumn();
        dgvProdukJumlah = new DataGridViewTextBoxColumn();
        dgvProdukHarga = new DataGridViewTextBoxColumn();
        dgvLayananId = new DataGridViewTextBoxColumn();
        dgvLayananNama = new DataGridViewTextBoxColumn();
        dgvLayananTarif = new DataGridViewTextBoxColumn();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        panel5.SuspendLayout();
        panel4.SuspendLayout();
        ((ISupportInitialize)dgvLayanan).BeginInit();
        ((ISupportInitialize)dgvProduk).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(cTanggal);
        panel1.Controls.Add(cID);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(cBayar);
        panel1.Controls.Add(cTotalBiaya);
        panel1.Controls.Add(cCustomer);
        panel1.Controls.Add(label7);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(lblKembali);
        panel1.Controls.Add(cKembali);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(984, 106);
        panel1.TabIndex = 0;
        // 
        // cTanggal
        // 
        cTanggal.Location = new Point(81, 73);
        cTanggal.Name = "cTanggal";
        cTanggal.Size = new Size(254, 23);
        cTanggal.TabIndex = 15;
        // 
        // cID
        // 
        cID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        cID.AutoCompleteSource = AutoCompleteSource.ListItems;
        cID.FormattingEnabled = true;
        cID.Location = new Point(81, 12);
        cID.Name = "cID";
        cID.Size = new Size(125, 23);
        cID.TabIndex = 14;
        cID.SelectedValueChanged += cID_SelectedValueChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(641, 76);
        label2.Name = "label2";
        label2.Size = new Size(47, 15);
        label2.TabIndex = 12;
        label2.Text = "Dibayar";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(641, 47);
        label3.Name = "label3";
        label3.Size = new Size(63, 15);
        label3.TabIndex = 10;
        label3.Text = "Total Biaya";
        // 
        // cBayar
        // 
        cBayar.Location = new Point(711, 73);
        cBayar.Name = "cBayar";
        cBayar.Size = new Size(88, 23);
        cBayar.TabIndex = 2;
        cBayar.TextChanged += cBayar_TextChanged;
        // 
        // cTotalBiaya
        // 
        cTotalBiaya.Location = new Point(711, 44);
        cTotalBiaya.Name = "cTotalBiaya";
        cTotalBiaya.ReadOnly = true;
        cTotalBiaya.Size = new Size(254, 23);
        cTotalBiaya.TabIndex = 3;
        cTotalBiaya.Text = "Rp 0";
        // 
        // cCustomer
        // 
        cCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        cCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
        cCustomer.FormattingEnabled = true;
        cCustomer.Location = new Point(81, 44);
        cCustomer.Name = "cCustomer";
        cCustomer.Size = new Size(312, 23);
        cCustomer.TabIndex = 0;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(12, 47);
        label7.Name = "label7";
        label7.Size = new Size(59, 15);
        label7.TabIndex = 9;
        label7.Text = "Customer";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(12, 15);
        label6.Name = "label6";
        label6.Size = new Size(18, 15);
        label6.TabIndex = 7;
        label6.Text = "ID";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 76);
        label1.Name = "label1";
        label1.Size = new Size(48, 15);
        label1.TabIndex = 0;
        label1.Text = "Tanggal";
        // 
        // lblKembali
        // 
        lblKembali.AutoSize = true;
        lblKembali.Location = new Point(818, 76);
        lblKembali.Name = "lblKembali";
        lblKembali.Size = new Size(50, 15);
        lblKembali.TabIndex = 4;
        lblKembali.Text = "Kembali";
        // 
        // cKembali
        // 
        cKembali.Location = new Point(877, 73);
        cKembali.Name = "cKembali";
        cKembali.ReadOnly = true;
        cKembali.Size = new Size(88, 23);
        cKembali.TabIndex = 4;
        cKembali.Text = "Rp 0";
        // 
        // panel2
        // 
        panel2.Controls.Add(btnRefresh);
        panel2.Controls.Add(btnSimpan);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0, 565);
        panel2.Name = "panel2";
        panel2.Size = new Size(984, 46);
        panel2.TabIndex = 1;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.Gray;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Font = new Font("Segoe UI", 12F);
        btnRefresh.Location = new Point(496, 6);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(476, 32);
        btnRefresh.TabIndex = 2;
        btnRefresh.Text = "Refresh";
        btnRefresh.UseVisualStyleBackColor = false;
        btnRefresh.Click += btnRefresh_Click;
        // 
        // btnSimpan
        // 
        btnSimpan.BackColor = Color.LimeGreen;
        btnSimpan.FlatAppearance.BorderSize = 0;
        btnSimpan.FlatStyle = FlatStyle.Flat;
        btnSimpan.Font = new Font("Segoe UI", 12F);
        btnSimpan.Location = new Point(8, 6);
        btnSimpan.Name = "btnSimpan";
        btnSimpan.Size = new Size(480, 32);
        btnSimpan.TabIndex = 0;
        btnSimpan.Text = "Simpan";
        btnSimpan.UseVisualStyleBackColor = false;
        btnSimpan.Click += btnSimpan_Click;
        // 
        // panel3
        // 
        panel3.Controls.Add(panel5);
        panel3.Controls.Add(label10);
        panel3.Controls.Add(label9);
        panel3.Controls.Add(cDaftarLayanan);
        panel3.Controls.Add(cDaftarProduk);
        panel3.Controls.Add(panel4);
        panel3.Controls.Add(dgvLayanan);
        panel3.Controls.Add(dgvProduk);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 106);
        panel3.Name = "panel3";
        panel3.Size = new Size(984, 459);
        panel3.TabIndex = 2;
        // 
        // panel5
        // 
        panel5.BorderStyle = BorderStyle.FixedSingle;
        panel5.Controls.Add(label11);
        panel5.Controls.Add(lblBiayaLayanan);
        panel5.Location = new Point(496, 391);
        panel5.Name = "panel5";
        panel5.Size = new Size(485, 32);
        panel5.TabIndex = 18;
        // 
        // label11
        // 
        label11.Dock = DockStyle.Left;
        label11.Font = new Font("Segoe UI", 16F);
        label11.Location = new Point(0, 0);
        label11.Name = "label11";
        label11.Size = new Size(162, 30);
        label11.TabIndex = 14;
        label11.Text = "Biaya Layanan :";
        label11.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblBiayaLayanan
        // 
        lblBiayaLayanan.Dock = DockStyle.Right;
        lblBiayaLayanan.Font = new Font("Segoe UI", 16F);
        lblBiayaLayanan.Location = new Point(166, 0);
        lblBiayaLayanan.Name = "lblBiayaLayanan";
        lblBiayaLayanan.Size = new Size(317, 30);
        lblBiayaLayanan.TabIndex = 13;
        lblBiayaLayanan.Text = "Rp 0";
        lblBiayaLayanan.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new Font("Segoe UI", 14F);
        label10.Location = new Point(669, 14);
        label10.Name = "label10";
        label10.Size = new Size(139, 25);
        label10.TabIndex = 17;
        label10.Text = "Daftar Layanan";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 14F);
        label9.Location = new Point(181, 14);
        label9.Name = "label9";
        label9.Size = new Size(129, 25);
        label9.TabIndex = 16;
        label9.Text = "Daftar Produk";
        // 
        // cDaftarLayanan
        // 
        cDaftarLayanan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        cDaftarLayanan.AutoCompleteSource = AutoCompleteSource.ListItems;
        cDaftarLayanan.FormattingEnabled = true;
        cDaftarLayanan.Location = new Point(496, 42);
        cDaftarLayanan.Name = "cDaftarLayanan";
        cDaftarLayanan.Size = new Size(485, 23);
        cDaftarLayanan.TabIndex = 6;
        cDaftarLayanan.SelectedValueChanged += cDaftarLayanan_SelectedValueChanged;
        // 
        // cDaftarProduk
        // 
        cDaftarProduk.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        cDaftarProduk.AutoCompleteSource = AutoCompleteSource.ListItems;
        cDaftarProduk.FormattingEnabled = true;
        cDaftarProduk.Location = new Point(3, 42);
        cDaftarProduk.Name = "cDaftarProduk";
        cDaftarProduk.Size = new Size(485, 23);
        cDaftarProduk.TabIndex = 5;
        cDaftarProduk.SelectedValueChanged += cDaftarProduk_SelectedValueChanged;
        // 
        // panel4
        // 
        panel4.BorderStyle = BorderStyle.FixedSingle;
        panel4.Controls.Add(label8);
        panel4.Controls.Add(lblBiayaProduk);
        panel4.Location = new Point(3, 391);
        panel4.Name = "panel4";
        panel4.Size = new Size(485, 32);
        panel4.TabIndex = 10;
        // 
        // label8
        // 
        label8.Dock = DockStyle.Left;
        label8.Font = new Font("Segoe UI", 16F);
        label8.Location = new Point(0, 0);
        label8.Name = "label8";
        label8.Size = new Size(162, 30);
        label8.TabIndex = 14;
        label8.Text = "Biaya Produk :";
        label8.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblBiayaProduk
        // 
        lblBiayaProduk.Dock = DockStyle.Right;
        lblBiayaProduk.Font = new Font("Segoe UI", 16F);
        lblBiayaProduk.Location = new Point(166, 0);
        lblBiayaProduk.Name = "lblBiayaProduk";
        lblBiayaProduk.Size = new Size(317, 30);
        lblBiayaProduk.TabIndex = 13;
        lblBiayaProduk.Text = "Rp 0";
        lblBiayaProduk.TextAlign = ContentAlignment.MiddleRight;
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
        dgvLayanan.Columns.AddRange(new DataGridViewColumn[] { dgvLayananId, dgvLayananNama, dgvLayananTarif });
        dgvLayanan.Location = new Point(496, 71);
        dgvLayanan.Name = "dgvLayanan";
        dgvLayanan.RowHeadersVisible = false;
        dgvLayanan.Size = new Size(485, 315);
        dgvLayanan.TabIndex = 9;
        dgvLayanan.CellEndEdit += dgv_CellEndEdit;
        dgvLayanan.RowsAdded += dgv_RowsAdded;
        dgvLayanan.RowsRemoved += dgv_RowsRemoved;
        dgvLayanan.KeyDown += dgv_KeyDown;
        // 
        // dgvProduk
        // 
        dgvProduk.AllowUserToAddRows = false;
        dgvProduk.AllowUserToDeleteRows = false;
        dgvProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvProduk.BorderStyle = BorderStyle.None;
        dgvProduk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProduk.Columns.AddRange(new DataGridViewColumn[] { dgvProdukId, dgvProdukNama, dgvProdukJumlah, dgvProdukHarga });
        dgvProduk.Location = new Point(3, 71);
        dgvProduk.Name = "dgvProduk";
        dgvProduk.RowHeadersVisible = false;
        dgvProduk.Size = new Size(485, 315);
        dgvProduk.TabIndex = 8;
        dgvProduk.CellEndEdit += dgv_CellEndEdit;
        dgvProduk.RowsAdded += dgv_RowsAdded;
        dgvProduk.RowsRemoved += dgv_RowsRemoved;
        dgvProduk.KeyDown += dgv_KeyDown;
        // 
        // dgvProdukId
        // 
        dgvProdukId.FillWeight = 46F;
        dgvProdukId.HeaderText = "Id";
        dgvProdukId.Name = "dgvProdukId";
        dgvProdukId.ReadOnly = true;
        // 
        // dgvProdukNama
        // 
        dgvProdukNama.FillWeight = 290F;
        dgvProdukNama.HeaderText = "Nama";
        dgvProdukNama.Name = "dgvProdukNama";
        dgvProdukNama.ReadOnly = true;
        // 
        // dgvProdukJumlah
        // 
        dgvProdukJumlah.FillWeight = 59F;
        dgvProdukJumlah.HeaderText = "Jumlah";
        dgvProdukJumlah.Name = "dgvProdukJumlah";
        // 
        // dgvProdukHarga
        // 
        dgvProdukHarga.FillWeight = 89F;
        dgvProdukHarga.HeaderText = "Harga";
        dgvProdukHarga.Name = "dgvProdukHarga";
        // 
        // dgvLayananId
        // 
        dgvLayananId.FillWeight = 47F;
        dgvLayananId.HeaderText = "Id";
        dgvLayananId.Name = "dgvLayananId";
        dgvLayananId.ReadOnly = true;
        // 
        // dgvLayananNama
        // 
        dgvLayananNama.FillWeight = 354F;
        dgvLayananNama.HeaderText = "Nama";
        dgvLayananNama.Name = "dgvLayananNama";
        dgvLayananNama.ReadOnly = true;
        // 
        // dgvLayananTarif
        // 
        dgvLayananTarif.FillWeight = 83F;
        dgvLayananTarif.HeaderText = "Tarif";
        dgvLayananTarif.Name = "dgvLayananTarif";
        // 
        // FTransaksi
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(984, 611);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        MaximizeBox = false;
        MaximumSize = new Size(1000, 650);
        MinimumSize = new Size(1000, 650);
        Name = "FTransaksi";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Transaksi";
        Load += FTransaksi_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        panel5.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ((ISupportInitialize)dgvLayanan).EndInit();
        ((ISupportInitialize)dgvProduk).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private TextBox cKembali;
    private Label label1;
    private Label lblKembali;
    private DataGridView dgvProduk;
    private Button btnRefresh;
    private Button btnSimpan;
    private Label label6;
    private ComboBox cCustomer;
    private Label label7;
    private Label label2;
    private Label label3;
    private TextBox cBayar;
    private TextBox cTotalBiaya;
    private DataGridView dgvLayanan;
    private ComboBox cDaftarLayanan;
    private ComboBox cDaftarProduk;
    private Panel panel4;
    private Label lblBiayaProduk;
    private Label label8;
    private Panel panel5;
    private Label label11;
    private Label lblBiayaLayanan;
    private Label label10;
    private Label label9;
    private ComboBox cID;
    private DateTimePicker cTanggal;
    private DataGridViewTextBoxColumn dgvLayananId;
    private DataGridViewTextBoxColumn dgvLayananNama;
    private DataGridViewTextBoxColumn dgvLayananTarif;
    private DataGridViewTextBoxColumn dgvProdukId;
    private DataGridViewTextBoxColumn dgvProdukNama;
    private DataGridViewTextBoxColumn dgvProdukJumlah;
    private DataGridViewTextBoxColumn dgvProdukHarga;
}