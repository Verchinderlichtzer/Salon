namespace Salon.App.Forms;
public partial class FProduk : Form, IProdukForm
{
    private readonly IProdukRepository _produkRepository;

    public FProduk(IProdukRepository produkRepository)
    {
        InitializeComponent();
        _produkRepository = produkRepository;
    }

    public void ShowForm() => new FProduk(_produkRepository).Show();

    public async Task RefreshDGV()
    {
        dgv.DataSource = (await _produkRepository.GetAsync()).Where(x => x.Nama.Search(cCariProduk.Text)).ToList();
    }

    private async void FProduk_Load(object sender, EventArgs e)
    {
        await RefreshDGV();
        cSatuan.Items.Add((await _produkRepository.GetAsync()).ConvertAll(x => x.Satuan));

        dgv.Columns[0].Width = 79;
        dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns[1].Width = 394;
        dgv.Columns[2].Width = 129;
        dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns[3].Width = 97;
        dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        dgv.Columns[3].DefaultCellStyle.Format = "N0";
        dgv.Columns[4].Width = 78;
        dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    }

    private async void btnSimpan_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(cNama.Text) || string.IsNullOrEmpty(cSatuan.Text) || ToInt(cHarga.Text) == 0)
        {
            MessageBox.Show("""
                Form yang wajib diisi :
                1. Nama
                2. Satuan
                3. Harga
                """, "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
        if (string.IsNullOrEmpty(cID.Text))
        {
            bool result = await _produkRepository.AddAsync(new()
            {
                Nama = cNama.Text,
                Satuan = cSatuan.Text,
                Harga = ToInt(cHarga.Text),
                Stok = ToInt(cStok.Text)
            });
            if (!result)
                MessageBox.Show("Produk gagal ditambah", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            bool result = await _produkRepository.UpdateAsync(new()
            {
                Id = cID.Text,
                Nama = cNama.Text,
                Satuan = cSatuan.Text,
                Harga = ToInt(cHarga.Text),
                Stok = ToInt(cStok.Text)
            });
            if (!result)
                MessageBox.Show("Produk gagal diubah", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        btnRefresh.PerformClick();
    }

    private async void btnHapus_Click(object sender, EventArgs e)
    {
        var id = dgv.CurrentRow.Cells[0].Value.ToString();
        DialogResult dr = MessageBox.Show($"Hapus {id}?", "Konfirmasi hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            bool result = await _produkRepository.DeleteAsync(id!);
            if (!result)
                MessageBox.Show("Produk gagal dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnRefresh.PerformClick();
        }
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        cID.Clear();
        cNama.Clear();
        cHarga.Clear();
        cSatuan.Text = "";
        cStok.Clear();
        cCariProduk.Clear();
        await RefreshDGV();

        cSatuan.Items.Clear();
        cSatuan.Items.Add((await _produkRepository.GetAsync()).ConvertAll(x => x.Satuan));

        btnSimpan.Text = "Simpan";
        btnSimpan.BackColor = Color.LimeGreen;
        btnHapus.Enabled = false;
        //Clipboard.SetText(string.Join(" - ", dgv.Columns.Cast<DataGridViewColumn>().Select(c => c.Width)));
    }

    private async void cCariProduk_TextChanged(object sender, EventArgs e)
    {
        await RefreshDGV();
    }

    private async void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        cID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
        var result = await _produkRepository.FindAsync(cID.Text);
        cNama.Text = result.Nama;
        cSatuan.Text = result.Satuan;
        cHarga.Text = result.Harga.ToString();
        cStok.Text = result.Stok.ToString();

        btnSimpan.Text = "Ubah";
        btnSimpan.BackColor = Color.Gold;
        btnHapus.Enabled = true;
    }
}