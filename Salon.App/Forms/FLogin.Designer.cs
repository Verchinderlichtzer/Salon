namespace Salon.App.Forms;

partial class FLogin
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
        label9 = new Label();
        label2 = new Label();
        cID = new TextBox();
        label1 = new Label();
        cPassword = new TextBox();
        btnOk = new Button();
        SuspendLayout();
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new Font("Segoe UI", 14F);
        label9.Location = new Point(163, 12);
        label9.Name = "label9";
        label9.Size = new Size(59, 25);
        label9.TabIndex = 17;
        label9.Text = "Login";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11F);
        label2.Location = new Point(12, 51);
        label2.Name = "label2";
        label2.Size = new Size(55, 20);
        label2.TabIndex = 19;
        label2.Text = "Id User";
        // 
        // cID
        // 
        cID.Font = new Font("Segoe UI", 11F);
        cID.Location = new Point(88, 48);
        cID.Name = "cID";
        cID.Size = new Size(284, 27);
        cID.TabIndex = 0;
        cID.KeyPress += OnKeyPress;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11F);
        label1.Location = new Point(12, 84);
        label1.Name = "label1";
        label1.Size = new Size(70, 20);
        label1.TabIndex = 21;
        label1.Text = "Password";
        // 
        // cPassword
        // 
        cPassword.Font = new Font("Segoe UI", 11F);
        cPassword.Location = new Point(88, 81);
        cPassword.Name = "cPassword";
        cPassword.Size = new Size(284, 27);
        cPassword.TabIndex = 1;
        cPassword.UseSystemPasswordChar = true;
        cPassword.KeyPress += OnKeyPress;
        // 
        // btnOk
        // 
        btnOk.BackColor = Color.PaleGreen;
        btnOk.FlatAppearance.BorderSize = 0;
        btnOk.FlatStyle = FlatStyle.Flat;
        btnOk.Font = new Font("Segoe UI", 10F);
        btnOk.Location = new Point(12, 121);
        btnOk.Name = "btnOk";
        btnOk.Size = new Size(360, 28);
        btnOk.TabIndex = 2;
        btnOk.Text = "Ok";
        btnOk.UseVisualStyleBackColor = false;
        btnOk.Click += btnOk_Click;
        // 
        // FLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 161);
        Controls.Add(btnOk);
        Controls.Add(label1);
        Controls.Add(cPassword);
        Controls.Add(label2);
        Controls.Add(cID);
        Controls.Add(label9);
        MaximizeBox = false;
        MaximumSize = new Size(400, 200);
        MinimumSize = new Size(400, 200);
        Name = "FLogin";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login - Salon";
        Load += FLogin_Load;
        VisibleChanged += FLogin_VisibleChanged;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label9;
    private Label label2;
    private TextBox cID;
    private Label label1;
    private TextBox cPassword;
    private Button btnOk;
}