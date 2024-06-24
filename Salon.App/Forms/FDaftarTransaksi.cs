using System.Windows.Forms;

namespace Salon.App.Forms;
public partial class FDaftarTransaksi : Form, IDaftarTransaksiForm
{
    private readonly ITransaksiRepository _transaksiRepository;

    public FDaftarTransaksi(ITransaksiRepository transaksiRepository)
    {
        InitializeComponent();
        _transaksiRepository = transaksiRepository;
    }

    public void ShowForm() => new FDaftarTransaksi(_transaksiRepository).Show();

    public async Task RefreshDGV()
    {
        dgv.DataSource = (await _transaksiRepository.GetAsync([nameof(User), nameof(Customer), nameof(DetailLayanan), nameof(DetailProduk)])).Where(x => x.Customer.Nama.Search(cCariTransaksi.Text) || x.Id.Search(cCariTransaksi.Text) || x.Tanggal.ToString("dd MMMM yyyy").Search(cCariTransaksi.Text)).Select(x => new {
            x.Id,
            Customer = $"{x.IdCustomer} — {x.Customer.Nama}",
            x.Tanggal,
            x.BiayaProduk,
            x.BiayaLayanan,
            x.TotalBiaya,
            x.Bayar,
            User = x.User.Nama
        }).ToList();
    }

    private async void FDaftarTransaksi_Load(object sender, EventArgs e)
    {
        await RefreshDGV();

        dgv.Columns[0].Width = 83;
        dgv.Columns[1].Width = 231;
        dgv.Columns[2].Width = 89;
        dgv.Columns[3].Width = 99;
        dgv.Columns[4].Width = 107;
        dgv.Columns[5].Width = 88;
        dgv.Columns[6].Width = 59;
        dgv.Columns[7].Width = 171;

        dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        dgv.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        dgv.Columns[3].DefaultCellStyle.Format = "N0";
        dgv.Columns[4].DefaultCellStyle.Format = "N0";
        dgv.Columns[5].DefaultCellStyle.Format = "N0";
        dgv.Columns[6].DefaultCellStyle.Format = "N0";
        dgv.Columns["Tanggal"].DefaultCellStyle.Format = "dd MMM yyyy";
        dgv.Columns["BiayaProduk"].HeaderText = "Biaya Produk";
        dgv.Columns["BiayaLayanan"].HeaderText = "Biaya Layanan";
        dgv.Columns["TotalBiaya"].HeaderText = "Total Biaya";
    }

    private async void btnHapus_Click(object sender, EventArgs e)
    {
        var id = dgv.CurrentRow.Cells[0].Value.ToString();
        DialogResult dr = MessageBox.Show($"Hapus {id}?", "Konfirmasi hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            bool result = await _transaksiRepository.DeleteAsync(id!);
            if (!result)
                MessageBox.Show("DaftarTransaksi gagal dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnRefresh.PerformClick();
        }
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        cCariTransaksi.Clear();
        await RefreshDGV();

        btnHapus.Enabled = false;
        //Clipboard.SetText(string.Join(" - ", dgv.Columns.Cast<DataGridViewColumn>().Select(c => c.Width)));
    }

    private async void cCariDaftarTransaksi_TextChanged(object sender, EventArgs e)
    {
        await RefreshDGV();
    }

    private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        btnHapus.Enabled = true;
    }
}