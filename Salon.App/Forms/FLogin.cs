using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon.App.Forms;
public partial class FLogin : Form
{
    private readonly IUserRepository _userRepository;
    private readonly IDashboardForm _dashboardForm;

    public FLogin(IUserRepository userRepository, IDashboardForm dashboardForm)
    {
        InitializeComponent();
        _userRepository = userRepository;
        _dashboardForm = dashboardForm;
    }

    private void FLogin_Load(object sender, EventArgs e)
    {
    }

    private async void btnOk_Click(object sender, EventArgs e)
    {
        var user = await _userRepository.LoginAsync(cID.Text, cPassword.Text);
        if (user != null)
        {
            Global.IdUser = cID.Text;
            Global.NamaUser = user.Nama;
            Global.StatusUser = user.JenisUser.ToString();
            _dashboardForm.ShowForm();
            Hide();
        }
        else
        {
            MessageBox.Show("Id / Password salah", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void OnKeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
        {
            btnOk.PerformClick();
        }
    }

    private void FLogin_Shown(object sender, EventArgs e)
    {
        Console.WriteLine("Aku");
    }

    private void FLogin_VisibleChanged(object sender, EventArgs e)
    {
        cID.Clear();
        cPassword.Clear();
        ActiveControl = cID;
    }
}
