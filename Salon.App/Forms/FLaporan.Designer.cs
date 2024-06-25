namespace Salon.App.Forms;

partial class FLaporan
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FLaporan));
        btnProduk = new Button();
        groupBox1 = new GroupBox();
        lbTransaksiCustomer = new ListBox();
        btnTransaksiCustomer = new Button();
        cCariCustomer = new TextBox();
        groupBox2 = new GroupBox();
        lbDetailTransaksi = new ListBox();
        btnDetailTransaksi = new Button();
        cCariTransaksi = new TextBox();
        btnLayanan = new Button();
        btnCustomer = new Button();
        groupBox3 = new GroupBox();
        groupBox4 = new GroupBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        cTahun = new ComboBox();
        label1 = new Label();
        cSampai = new DateTimePicker();
        cDari = new DateTimePicker();
        btnGrafik = new Button();
        btnTransaksi = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        SuspendLayout();
        // 
        // btnProduk
        // 
        btnProduk.BackColor = SystemColors.Control;
        resources.ApplyResources(btnProduk, "btnProduk");
        btnProduk.Name = "btnProduk";
        btnProduk.UseVisualStyleBackColor = false;
        btnProduk.Click += btnProduk_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(lbTransaksiCustomer);
        groupBox1.Controls.Add(btnTransaksiCustomer);
        groupBox1.Controls.Add(cCariCustomer);
        resources.ApplyResources(groupBox1, "groupBox1");
        groupBox1.Name = "groupBox1";
        groupBox1.TabStop = false;
        // 
        // lbTransaksiCustomer
        // 
        lbTransaksiCustomer.FormattingEnabled = true;
        resources.ApplyResources(lbTransaksiCustomer, "lbTransaksiCustomer");
        lbTransaksiCustomer.Name = "lbTransaksiCustomer";
        // 
        // btnTransaksiCustomer
        // 
        btnTransaksiCustomer.BackColor = SystemColors.Control;
        resources.ApplyResources(btnTransaksiCustomer, "btnTransaksiCustomer");
        btnTransaksiCustomer.Name = "btnTransaksiCustomer";
        btnTransaksiCustomer.UseVisualStyleBackColor = false;
        btnTransaksiCustomer.Click += btnTransaksiCustomer_Click;
        // 
        // cCariCustomer
        // 
        resources.ApplyResources(cCariCustomer, "cCariCustomer");
        cCariCustomer.Name = "cCariCustomer";
        cCariCustomer.TextChanged += OnPencarianChanged;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(lbDetailTransaksi);
        groupBox2.Controls.Add(btnDetailTransaksi);
        groupBox2.Controls.Add(cCariTransaksi);
        resources.ApplyResources(groupBox2, "groupBox2");
        groupBox2.Name = "groupBox2";
        groupBox2.TabStop = false;
        // 
        // lbDetailTransaksi
        // 
        lbDetailTransaksi.FormattingEnabled = true;
        resources.ApplyResources(lbDetailTransaksi, "lbDetailTransaksi");
        lbDetailTransaksi.Name = "lbDetailTransaksi";
        // 
        // btnDetailTransaksi
        // 
        btnDetailTransaksi.BackColor = SystemColors.Control;
        resources.ApplyResources(btnDetailTransaksi, "btnDetailTransaksi");
        btnDetailTransaksi.Name = "btnDetailTransaksi";
        btnDetailTransaksi.UseVisualStyleBackColor = false;
        btnDetailTransaksi.Click += btnDetailTransaksi_Click;
        // 
        // cCariTransaksi
        // 
        resources.ApplyResources(cCariTransaksi, "cCariTransaksi");
        cCariTransaksi.Name = "cCariTransaksi";
        cCariTransaksi.TextChanged += OnPencarianChanged;
        // 
        // btnLayanan
        // 
        btnLayanan.BackColor = SystemColors.Control;
        resources.ApplyResources(btnLayanan, "btnLayanan");
        btnLayanan.Name = "btnLayanan";
        btnLayanan.UseVisualStyleBackColor = false;
        btnLayanan.Click += btnLayanan_Click;
        // 
        // btnCustomer
        // 
        btnCustomer.BackColor = SystemColors.Control;
        resources.ApplyResources(btnCustomer, "btnCustomer");
        btnCustomer.Name = "btnCustomer";
        btnCustomer.UseVisualStyleBackColor = false;
        btnCustomer.Click += btnCustomer_Click;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(btnLayanan);
        groupBox3.Controls.Add(btnProduk);
        groupBox3.Controls.Add(btnCustomer);
        resources.ApplyResources(groupBox3, "groupBox3");
        groupBox3.Name = "groupBox3";
        groupBox3.TabStop = false;
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(label4);
        groupBox4.Controls.Add(label3);
        groupBox4.Controls.Add(label2);
        groupBox4.Controls.Add(cTahun);
        groupBox4.Controls.Add(label1);
        groupBox4.Controls.Add(cSampai);
        groupBox4.Controls.Add(cDari);
        groupBox4.Controls.Add(btnGrafik);
        groupBox4.Controls.Add(btnTransaksi);
        resources.ApplyResources(groupBox4, "groupBox4");
        groupBox4.Name = "groupBox4";
        groupBox4.TabStop = false;
        // 
        // label4
        // 
        resources.ApplyResources(label4, "label4");
        label4.Name = "label4";
        // 
        // label3
        // 
        resources.ApplyResources(label3, "label3");
        label3.Name = "label3";
        // 
        // label2
        // 
        resources.ApplyResources(label2, "label2");
        label2.Name = "label2";
        // 
        // cTahun
        // 
        cTahun.DropDownStyle = ComboBoxStyle.DropDownList;
        cTahun.FormattingEnabled = true;
        resources.ApplyResources(cTahun, "cTahun");
        cTahun.Name = "cTahun";
        // 
        // label1
        // 
        resources.ApplyResources(label1, "label1");
        label1.Name = "label1";
        // 
        // cSampai
        // 
        resources.ApplyResources(cSampai, "cSampai");
        cSampai.Format = DateTimePickerFormat.Custom;
        cSampai.Name = "cSampai";
        // 
        // cDari
        // 
        resources.ApplyResources(cDari, "cDari");
        cDari.Format = DateTimePickerFormat.Custom;
        cDari.Name = "cDari";
        // 
        // btnGrafik
        // 
        btnGrafik.BackColor = SystemColors.Control;
        resources.ApplyResources(btnGrafik, "btnGrafik");
        btnGrafik.Name = "btnGrafik";
        btnGrafik.UseVisualStyleBackColor = false;
        btnGrafik.Click += btnGrafik_Click;
        // 
        // btnTransaksi
        // 
        btnTransaksi.BackColor = SystemColors.Control;
        resources.ApplyResources(btnTransaksi, "btnTransaksi");
        btnTransaksi.Name = "btnTransaksi";
        btnTransaksi.UseVisualStyleBackColor = false;
        btnTransaksi.Click += btnTransaksi_Click;
        // 
        // FLaporan
        // 
        resources.ApplyResources(this, "$this");
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox4);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        MaximizeBox = false;
        Name = "FLaporan";
        Load += FLaporan_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox4.ResumeLayout(false);
        groupBox4.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button btnProduk;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private TextBox cCariCustomer;
    private Button btnTransaksiCustomer;
    private Button btnLayanan;
    private Button btnCustomer;
    private GroupBox groupBox4;
    private Button btnGrafik;
    private Button btnTransaksi;
    private ListBox lbTransaksiCustomer;
    private ListBox lbDetailTransaksi;
    private Button btnDetailTransaksi;
    private TextBox cCariTransaksi;
    private DateTimePicker cDari;
    private Label label4;
    private Label label3;
    private Label label2;
    private ComboBox cTahun;
    private Label label1;
    private DateTimePicker cSampai;
}