﻿namespace Salon.App.Forms;
public partial class FDashboard : Form
{
    private readonly ICustomerForm _customerForm;
    private readonly ILaporanForm _laporanForm;
    private readonly ILayananForm _layananForm;
    private readonly IProdukForm _produkForm;
    private readonly IDaftarTransaksiForm _daftarTransaksiForm;
    private readonly ITransaksiForm _transaksiForm;
    private readonly IUserForm _userForm;

    public FDashboard(ICustomerForm customerForm, ILaporanForm laporanForm, ILayananForm layananForm, IProdukForm produkForm, IDaftarTransaksiForm daftarTransaksiForm, ITransaksiForm transaksiForm, IUserForm userForm)
    {
        InitializeComponent();
        _customerForm = customerForm;
        _laporanForm = laporanForm;
        _layananForm = layananForm;
        _produkForm = produkForm;
        _daftarTransaksiForm = daftarTransaksiForm;
        _transaksiForm = transaksiForm;
        _userForm = userForm;
    }

    private void FDashboard_Load(object sender, EventArgs e)
    {
    }

    private void btnUser_Click(object sender, EventArgs e)
    {
        _userForm.ShowForm();
    }

    private void btnProduk_Click(object sender, EventArgs e)
    {
        _produkForm.ShowForm();
    }

    private void btnCustomer_Click(object sender, EventArgs e)
    {
        _customerForm.ShowForm();
    }

    private void btnLayanan_Click(object sender, EventArgs e)
    {
        _layananForm.ShowForm();
    }

    private void btnDaftarTransaksi_Click(object sender, EventArgs e)
    {
        _daftarTransaksiForm.ShowForm();
    }

    private void btnTransaksi_Click(object sender, EventArgs e)
    {
        _transaksiForm.ShowForm();
    }

    private void btnLaporan_Click(object sender, EventArgs e)
    {
        _laporanForm.ShowForm();
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {

    }
}