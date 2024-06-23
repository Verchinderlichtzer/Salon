
using Microsoft.Extensions.DependencyInjection;
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
public partial class FCustomer : Form, ICustomerForm
{
    private readonly ICustomerRepository _customerRepository;

    public FCustomer(ICustomerRepository customerRepository)
    {
        InitializeComponent();
        _customerRepository = customerRepository;
    }

    public void ShowForm() => new FCustomer(_customerRepository).Show();

    public async Task RefreshDGV() => dgv.DataSource = await _customerRepository.GetAsync();

    private async void FCustomer_Load(object sender, EventArgs e)
    {
        await RefreshDGV();
    }

    private async void btnSimpan_Click(object sender, EventArgs e)
    {
        await _customerRepository.AddAsync(new()
        {
            Nama = cNama.Text,
            Alamat = cAlamat.Text,
            Telepon = cTelepon.Text,
            JenisKelamin = cLakiLaki.Checked ? JenisKelamin.Pria : JenisKelamin.Wanita,
            TanggalLahir = cTanggalLahir.Value
        });
        await RefreshDGV();
    }

    private async void btnHapus_Click(object sender, EventArgs e)
    {
        var id = dgv.CurrentRow.Cells[0].Value.ToString();
        await _customerRepository.DeleteAsync(id!);
        await RefreshDGV();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {

    }

    private void cCariData_TextChanged(object sender, EventArgs e)
    {

    }
}
