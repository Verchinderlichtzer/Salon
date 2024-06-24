namespace Salon.App.Forms;

partial class FUser
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
        cJenisUser = new ComboBox();
        label6 = new Label();
        cID = new TextBox();
        label3 = new Label();
        label4 = new Label();
        cWanita = new RadioButton();
        label1 = new Label();
        cPria = new RadioButton();
        label5 = new Label();
        label2 = new Label();
        cTelepon = new TextBox();
        cPassword = new TextBox();
        cNama = new TextBox();
        panel2 = new Panel();
        btnRefresh = new Button();
        btnSimpan = new Button();
        btnHapus = new Button();
        panel3 = new Panel();
        cCariUser = new TextBox();
        dgv = new DataGridView();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        panel3.SuspendLayout();
        ((ISupportInitialize)dgv).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Controls.Add(cJenisUser);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(cID);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(cWanita);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(cPria);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(cTelepon);
        panel1.Controls.Add(cPassword);
        panel1.Controls.Add(cNama);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(784, 110);
        panel1.TabIndex = 0;
        // 
        // cJenisUser
        // 
        cJenisUser.DropDownStyle = ComboBoxStyle.DropDownList;
        cJenisUser.FormattingEnabled = true;
        cJenisUser.Items.AddRange(new object[] { "Admin", "Karyawan" });
        cJenisUser.Location = new Point(575, 68);
        cJenisUser.Name = "cJenisUser";
        cJenisUser.Size = new Size(148, 23);
        cJenisUser.TabIndex = 6;
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
        cID.Location = new Point(75, 12);
        cID.Name = "cID";
        cID.Size = new Size(203, 23);
        cID.TabIndex = 0;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(476, 73);
        label3.Name = "label3";
        label3.Size = new Size(58, 15);
        label3.TabIndex = 2;
        label3.Text = "Jenis User";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(12, 76);
        label4.Name = "label4";
        label4.Size = new Size(57, 15);
        label4.TabIndex = 3;
        label4.Text = "Password";
        // 
        // cWanita
        // 
        cWanita.AutoSize = true;
        cWanita.Location = new Point(656, 42);
        cWanita.Name = "cWanita";
        cWanita.Size = new Size(62, 19);
        cWanita.TabIndex = 5;
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
        cPria.TabIndex = 4;
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
        // cPassword
        // 
        cPassword.Location = new Point(75, 73);
        cPassword.Name = "cPassword";
        cPassword.Size = new Size(375, 23);
        cPassword.TabIndex = 3;
        cPassword.UseSystemPasswordChar = true;
        // 
        // cNama
        // 
        cNama.Location = new Point(75, 44);
        cNama.Name = "cNama";
        cNama.Size = new Size(203, 23);
        cNama.TabIndex = 1;
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
        btnRefresh.Font = new Font("Segoe UI", 12F);
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
        btnSimpan.Font = new Font("Segoe UI", 12F);
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
        btnHapus.Font = new Font("Segoe UI", 12F);
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
        panel3.Controls.Add(cCariUser);
        panel3.Controls.Add(dgv);
        panel3.Dock = DockStyle.Fill;
        panel3.Location = new Point(0, 110);
        panel3.Name = "panel3";
        panel3.Size = new Size(784, 405);
        panel3.TabIndex = 2;
        // 
        // cCariUser
        // 
        cCariUser.Location = new Point(3, 6);
        cCariUser.Name = "cCariUser";
        cCariUser.PlaceholderText = "Cari user...";
        cCariUser.Size = new Size(778, 23);
        cCariUser.TabIndex = 7;
        cCariUser.TextChanged += cCariUser_TextChanged;
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
        dgv.Size = new Size(778, 367);
        dgv.TabIndex = 8;
        dgv.CellClick += dgv_CellClick;
        // 
        // FUser
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
        Name = "FUser";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "User";
        Load += FUser_Load;
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
    private RadioButton cWanita;
    private RadioButton cPria;
    private TextBox cTelepon;
    private TextBox cPassword;
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
    private TextBox cCariUser;
    private Label label6;
    private TextBox cID;
    private ComboBox cJenisUser;
}