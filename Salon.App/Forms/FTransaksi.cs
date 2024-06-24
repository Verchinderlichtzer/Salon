using Salon.Shared.Models;
using System.Windows.Forms;

namespace Salon.App.Forms;
public partial class FTransaksi : Form, ITransaksiForm
{
    private readonly ITransaksiRepository _transaksiRepository;
    private readonly IProdukRepository _produkRepository;
    private readonly ILayananRepository _layananRepository;
    private readonly ICustomerRepository _customerRepository;
    private bool _isNew = true;
    private bool _locked = true;

    public FTransaksi(ITransaksiRepository transaksiRepository, IProdukRepository produkRepository, ILayananRepository layananRepository, ICustomerRepository customerRepository)
    {
        InitializeComponent();
        _transaksiRepository = transaksiRepository;
        _produkRepository = produkRepository;
        _layananRepository = layananRepository;
        _customerRepository = customerRepository;
    }

    public void ShowForm() => new FTransaksi(_transaksiRepository, _produkRepository, _layananRepository, _customerRepository).Show();

    public async Task LoadData()
    {
        cID.DataSource = (await _transaksiRepository.GetAsync()).ConvertAll(x => x.Id);
        cCustomer.DataSource = (await _customerRepository.GetAsync()).ConvertAll(x => $"{x.Nama} — {x.Id}");
        cDaftarProduk.DataSource = (await _produkRepository.GetAsync()).ConvertAll(x => $"{x.Nama} — {x.Id}");
        cDaftarLayanan.DataSource = (await _layananRepository.GetAsync()).ConvertAll(x => $"{x.Nama} — {x.Id}");
        dgvProduk.Rows.Clear();
        dgvLayanan.Rows.Clear();
    }

    private async void FTransaksi_Load(object sender, EventArgs e)
    {
        await LoadData();
        cID.SelectedIndex = -1;
        cCustomer.SelectedIndex = -1;
        cDaftarProduk.SelectedIndex = -1;
        cDaftarLayanan.SelectedIndex = -1;
        cTanggal.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm");
        _locked = false;
    }

    private void Hitung()
    {
        int biayaProduk = 0;
        int biayaLayanan = 0;

        foreach (DataGridViewRow row in dgvProduk.Rows)
        {
            int qty = ToInt(row.Cells[2].Value);
            int price = ToInt(row.Cells[3].Value);
            biayaProduk += qty * price;
        }
        foreach (DataGridViewRow row in dgvLayanan.Rows)
        {
            biayaLayanan += ToInt(row.Cells[2].Value);
        }

        lblBiayaProduk.Text = "Rp " + biayaProduk.ToString("N0");
        lblBiayaLayanan.Text = "Rp " + biayaLayanan.ToString("N0");

        cTotalBiaya.Text = "Rp " + (biayaProduk + biayaLayanan).ToString("N0");
        cKembali.Text = "Rp " + Math.Abs(ToInt(cBayar.Text) - (biayaProduk + biayaLayanan)).ToString("N0");
        lblKembali.Text = ToInt(cBayar.Text) >= (biayaProduk + biayaLayanan) ? "Kembali" : "Kurang";
    }

    private async void cID_SelectedValueChanged(object sender, EventArgs e)
    {
        string idTransaksi = cID.SelectedItem?.ToString()!;
        if (string.IsNullOrEmpty(idTransaksi) || _locked) return;

        Transaksi transaksi = await _transaksiRepository.FindAsync(idTransaksi, [nameof(Customer), nameof(DetailProduk), nameof(DetailLayanan)]);
        cCustomer.SelectedValue = $"{transaksi.Customer.Nama} — {transaksi.Customer.Id}";
        cTanggal.Text = transaksi.Tanggal.ToString("dd MMMM yyyy");
        cBayar.Text = transaksi.Bayar.ToString();

        dgvProduk.DataSource = transaksi.DetailProduk;
        dgvProduk.DataSource = transaksi.DetailLayanan;

        Hitung();

        btnSimpan.Text = "Ubah";
        btnSimpan.BackColor = Color.Gold;
        _isNew = false;
    }

    private async void btnSimpan_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(cCustomer.Text) || GetNumber(cTotalBiaya.Text) == 0 || GetNumber(cTotalBiaya.Text) > ToInt(cBayar.Text))
        {
            MessageBox.Show("""
            Form yang wajib diisi :
            1. Customer
            2. Produk / Layanan
            3. Pembayaran Lunas
            """, "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
        if (_isNew)
        {
            bool result = await _transaksiRepository.AddAsync(new()
            {
                IdUser = Global.IdUser,
                IdCustomer = cCustomer.Text.Right(7),
                BiayaProduk = GetNumber(lblBiayaProduk.Text),
                BiayaLayanan = GetNumber(lblBiayaLayanan.Text),
                Bayar = ToInt(cBayar.Text)
            });
            if (!result)
                MessageBox.Show("Transaksi gagal ditambah", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            bool result = await _transaksiRepository.UpdateAsync(new()
            {
                Id = cID.SelectedText,
                IdUser = Global.IdUser,
                IdCustomer = cCustomer.Text.Right(7),
                BiayaProduk = GetNumber(lblBiayaProduk.Text),
                BiayaLayanan = GetNumber(lblBiayaLayanan.Text),
                Bayar = ToInt(cBayar.Text)
            });
            if (!result)
                MessageBox.Show("Transaksi gagal diubah", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        btnRefresh.PerformClick();
    }

    //private async void btnHapus_Click(object sender, EventArgs e)
    //{
    //    var id = dgvProduk.CurrentRow.Cells[0].Value.ToString();
    //    DialogResult dr = MessageBox.Show($"Hapus {id}?", "Konfirmasi hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
    //    if (dr == DialogResult.Yes)
    //    {
    //        bool result = await _transaksiRepository.DeleteAsync(id!);
    //        if (!result)
    //            MessageBox.Show("Transaksi gagal dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //        btnRefresh.PerformClick();
    //    }
    //}

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        cID.SelectedIndex = -1;
        cCustomer.SelectedIndex = -1;
        cTanggal.Text = DateTime.Now.ToString("dd MMMM yyyy HH:mm");
        cTotalBiaya.Text = "Rp 0";
        cBayar.Clear();
        cKembali.Text = "Rp 0";
        cDaftarProduk.SelectedIndex = -1;
        cDaftarLayanan.SelectedIndex = -1;
        await LoadData();
        //46 - 290 - 59 - 89 ||| 47 - 354 - 83
        btnSimpan.Text = "Simpan";
        btnSimpan.BackColor = Color.LimeGreen;
        _isNew = true;
        //Clipboard.SetText(string.Join(" - ", dgvProduk.Columns.Cast<DataGridViewColumn>().Select(c => c.Width).Concat(dgvLayanan.Columns.Cast<DataGridViewColumn>().Select(c => c.Width))));
    }

    private async void cDaftarProduk_SelectedValueChanged(object sender, EventArgs e)
    {
        string idProduk = cDaftarProduk.SelectedItem?.ToString()!.Right(6)!;
        if (string.IsNullOrEmpty(idProduk) || _locked) return;
        foreach (DataGridViewRow row in dgvProduk.Rows)
        {
            if (row.Cells[0].Value?.ToString() == idProduk)
            {
                MessageBox.Show("Produk sudah dipilih");
                return;
            }
        }
        Produk x = await _produkRepository.FindAsync(idProduk);
        dgvProduk.Rows.Add(x.Id, x.Nama, 1, x.Harga);
    }

    private async void cDaftarLayanan_SelectedValueChanged(object sender, EventArgs e)
    {
        string idLayanan = cDaftarLayanan.SelectedItem?.ToString()!.Right(5)!;
        if (string.IsNullOrEmpty(idLayanan) || _locked) return;
        foreach (DataGridViewRow row in dgvLayanan.Rows)
        {
            if (row.Cells[0].Value?.ToString() == idLayanan)
            {
                MessageBox.Show("Layanan sudah dipilih");
                return;
            }
        }
        Layanan x = await _layananRepository.FindAsync(idLayanan);
        dgvLayanan.Rows.Add(x.Id, x.Nama, x.Tarif);
    }

    private void dgv_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
        {
            DataGridViewRow selectedRow = ((DataGridView)sender).CurrentRow;
            if (selectedRow?.IsNewRow == false) ((DataGridView)sender).Rows.Remove(selectedRow);
        }
    }

    private void dgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
    {
        Hitung();
    }

    private void cBayar_TextChanged(object sender, EventArgs e)
    {
        Hitung();
    }

    private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
    {
        Hitung();
    }

    private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
    {
        Hitung();
    }
}