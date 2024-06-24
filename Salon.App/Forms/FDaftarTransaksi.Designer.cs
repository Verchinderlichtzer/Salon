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
        panel2 = new Panel();
        btnRefresh = new Button();
        btnHapus = new Button();
        panel3 = new Panel();
        cCariTransaksi = new TextBox();
        dgv = new DataGridView();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
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
        panel3.Controls.Add(cCariTransaksi);
        panel3.Controls.Add(dgv);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 0);
        panel3.Name = "panel3";
        panel3.Size = new Size(934, 535);
        panel3.TabIndex = 2;
        // 
        // cCariTransaksi
        // 
        cCariTransaksi.Location = new Point(3, 6);
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
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dataGridViewCellStyle1.BackColor = SystemColors.Control;
        dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv.Location = new Point(3, 35);
        dgv.Name = "dgv";
        dgv.ReadOnly = true;
        dgv.RowHeadersVisible = false;
        dgv.Size = new Size(928, 494);
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
}