namespace Salon.App.Forms;

partial class FCustomer
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
        panel1 = new Panel();
        label6 = new Label();
        cID = new TextBox();
        label3 = new Label();
        label4 = new Label();
        cWanita = new RadioButton();
        label1 = new Label();
        cPria = new RadioButton();
        label5 = new Label();
        cTanggalLahir = new DateTimePicker();
        label2 = new Label();
        cTelepon = new TextBox();
        cAlamat = new TextBox();
        cNama = new TextBox();
        panel2 = new Panel();
        btnRefresh = new Button();
        btnSimpan = new Button();
        btnHapus = new Button();
        panel3 = new Panel();
        cCariCustomer = new TextBox();
        dgv = new DataGridView();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        ((ISupportInitialize)dgv).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(label6);
        panel1.Controls.Add(cID);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(cWanita);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(cPria);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(cTanggalLahir);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(cTelepon);
        panel1.Controls.Add(cAlamat);
        panel1.Controls.Add(cNama);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(784, 110);
        panel1.TabIndex = 0;
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
        // cID
        // 
        cID.Enabled = false;
        cID.Location = new Point(67, 12);
        cID.Name = "cID";
        cID.Size = new Size(100, 23);
        cID.TabIndex = 6;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(476, 73);
        label3.Name = "label3";
        label3.Size = new Size(78, 15);
        label3.TabIndex = 2;
        label3.Text = "Tanggal Lahir";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(12, 76);
        label4.Name = "label4";
        label4.Size = new Size(45, 15);
        label4.TabIndex = 3;
        label4.Text = "Alamat";
        // 
        // cWanita
        // 
        cWanita.AutoSize = true;
        cWanita.Location = new Point(656, 42);
        cWanita.Name = "cWanita";
        cWanita.Size = new Size(62, 19);
        cWanita.TabIndex = 4;
        cWanita.TabStop = true;
        cWanita.Text = "Wanita";
        cWanita.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 47);
        label1.Name = "label1";
        label1.Size = new Size(39, 15);
        label1.TabIndex = 0;
        label1.Text = "Nama";
        // 
        // cPria
        // 
        cPria.AutoSize = true;
        cPria.Location = new Point(591, 42);
        cPria.Name = "cPria";
        cPria.Size = new Size(45, 19);
        cPria.TabIndex = 3;
        cPria.TabStop = true;
        cPria.Text = "Pria";
        cPria.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(297, 47);
        label5.Name = "label5";
        label5.Size = new Size(49, 15);
        label5.TabIndex = 4;
        label5.Text = "Telepon";
        // 
        // cTanggalLahir
        // 
        cTanggalLahir.CustomFormat = "";
        cTanggalLahir.Location = new Point(567, 70);
        cTanggalLahir.Name = "cTanggalLahir";
        cTanggalLahir.Size = new Size(200, 23);
        cTanggalLahir.TabIndex = 5;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(476, 44);
        label2.Name = "label2";
        label2.Size = new Size(78, 15);
        label2.TabIndex = 1;
        label2.Text = "Jenis Kelamin";
        // 
        // cTelepon
        // 
        cTelepon.Location = new Point(352, 44);
        cTelepon.Name = "cTelepon";
        cTelepon.Size = new Size(98, 23);
        cTelepon.TabIndex = 2;
        // 
        // cAlamat
        // 
        cAlamat.Location = new Point(67, 73);
        cAlamat.Name = "cAlamat";
        cAlamat.Size = new Size(383, 23);
        cAlamat.TabIndex = 1;
        // 
        // cNama
        // 
        cNama.Location = new Point(67, 44);
        cNama.Name = "cNama";
        cNama.Size = new Size(211, 23);
        cNama.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.Controls.Add(btnRefresh);
        panel2.Controls.Add(btnSimpan);
        panel2.Controls.Add(btnHapus);
        panel2.Dock = DockStyle.Bottom;
        panel2.Location = new Point(0, 515);
        panel2.Name = "panel2";
        panel2.Size = new Size(784, 46);
        panel2.TabIndex = 1;
        // 
        // btnRefresh
        // 
        btnRefresh.BackColor = Color.Gray;
        btnRefresh.FlatAppearance.BorderSize = 0;
        btnRefresh.FlatStyle = FlatStyle.Flat;
        btnRefresh.Location = new Point(524, 6);
        btnRefresh.Name = "btnRefresh";
        btnRefresh.Size = new Size(252, 32);
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
        btnSimpan.Location = new Point(8, 6);
        btnSimpan.Name = "btnSimpan";
        btnSimpan.Size = new Size(252, 32);
        btnSimpan.TabIndex = 0;
        btnSimpan.Text = "Simpan";
        btnSimpan.UseVisualStyleBackColor = false;
        btnSimpan.Click += btnSimpan_Click;
        // 
        // btnHapus
        // 
        btnHapus.BackColor = Color.LightCoral;
        btnHapus.Enabled = false;
        btnHapus.FlatAppearance.BorderSize = 0;
        btnHapus.FlatStyle = FlatStyle.Flat;
        btnHapus.Location = new Point(266, 6);
        btnHapus.Name = "btnHapus";
        btnHapus.Size = new Size(252, 32);
        btnHapus.TabIndex = 1;
        btnHapus.Text = "Hapus";
        btnHapus.UseVisualStyleBackColor = false;
        btnHapus.Click += btnHapus_Click;
        // 
        // panel3
        // 
        panel3.Controls.Add(cCariCustomer);
        panel3.Controls.Add(dgv);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 110);
        panel3.Name = "panel3";
        panel3.Size = new Size(784, 405);
        panel3.TabIndex = 2;
        // 
        // cCariCustomer
        // 
        cCariCustomer.Location = new Point(3, 6);
        cCariCustomer.Name = "cCariCustomer";
        cCariCustomer.PlaceholderText = "Cari customer...";
        cCariCustomer.Size = new Size(778, 23);
        cCariCustomer.TabIndex = 4;
        cCariCustomer.TextChanged += cCariCustomer_TextChanged;
        // 
        // dgv
        // 
        dgv.AllowUserToAddRows = false;
        dgv.AllowUserToDeleteRows = false;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.BorderStyle = BorderStyle.None;
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv.Location = new Point(3, 35);
        dgv.Name = "dgv";
        dgv.ReadOnly = true;
        dgv.Size = new Size(778, 367);
        dgv.TabIndex = 3;
        dgv.CellClick += dgv_CellClick;
        // 
        // FCustomer
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 561);
        Controls.Add(panel3);
        Controls.Add(panel2);
        Controls.Add(panel1);
        MaximizeBox = false;
        MaximumSize = new Size(800, 600);
        MinimumSize = new Size(800, 600);
        Name = "FCustomer";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Customer";
        Load += FCustomer_Load;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel3.ResumeLayout(false);
        panel3.PerformLayout();
        ((ISupportInitialize)dgv).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Panel panel2;
    private Panel panel3;
    private DateTimePicker cTanggalLahir;
    private RadioButton cWanita;
    private RadioButton cPria;
    private TextBox cTelepon;
    private TextBox cAlamat;
    private TextBox cNama;
    private Label label3;
    private Label label4;
    private Label label1;
    private Label label5;
    private Label label2;
    private DataGridView dgv;
    private Button btnRefresh;
    private Button btnHapus;
    private Button btnSimpan;
    private TextBox cCariCustomer;
    private Label label6;
    private TextBox cID;
}