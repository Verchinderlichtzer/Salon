namespace Salon.App.Forms;
public partial class FLayanan : Form, ILayananForm
{
    private readonly ILayananRepository _layananRepository;

    public FLayanan(ILayananRepository layananRepository)
    {
        InitializeComponent();
        _layananRepository = layananRepository;
    }

    public void ShowForm() => new FLayanan(_layananRepository).Show();

    public async Task RefreshDGV()
    {
        dgv.DataSource = (await _layananRepository.GetAsync()).Where(x => x.Nama.Search(cCariLayanan.Text)).ToList();
    }

    private async void FLayanan_Load(object sender, EventArgs e)
    {
        await RefreshDGV();

        dgv.Columns[0].Width = 58;
        dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns[1].Width = 400;
        dgv.Columns[2].DefaultCellStyle.Format = "N0";
        dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    }

    private async void btnSimpan_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(cNama.Text) || ToInt(cTarif.Text) == 0)
        {
            MessageBox.Show("""
                Form yang wajib diisi :
                1. Nama
                2. Tarif
                """, "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
        if (string.IsNullOrEmpty(cID.Text))
        {
            bool result = await _layananRepository.AddAsync(new()
            {
                Nama = cNama.Text,
                Tarif = ToInt(cTarif.Text)
            });
            if (!result)
                MessageBox.Show("Layanan gagal ditambah", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Layanan berhasil ditambah", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            bool result = await _layananRepository.UpdateAsync(new()
            {
                Id = cID.Text,
                Nama = cNama.Text,
                Tarif = ToInt(cTarif.Text)
            });
            if (!result)
                MessageBox.Show("Layanan gagal diubah", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Layanan berhasil diubah", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        btnRefresh.PerformClick();
    }

    private async void btnHapus_Click(object sender, EventArgs e)
    {
        var id = dgv.CurrentRow.Cells[0].Value.ToString();
        DialogResult dr = MessageBox.Show($"Hapus {id}?", "Konfirmasi hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            bool result = await _layananRepository.DeleteAsync(id!);
            if (!result)
                MessageBox.Show("Layanan gagal dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Layanan berhasil dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnRefresh.PerformClick();
        }
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        cID.Clear();
        cNama.Clear();
        cTarif.Clear();
        cCariLayanan.Clear();
        await RefreshDGV();

        btnSimpan.Text = "Simpan";
        btnSimpan.BackColor = Color.LimeGreen;
        btnHapus.Enabled = false;
        //Clipboard.SetText(string.Join(" - ", dgv.Columns.Cast<DataGridViewColumn>().Select(c => c.Width)));
    }

    private async void cCariLayanan_TextChanged(object sender, EventArgs e)
    {
        await RefreshDGV();
    }

    private async void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        cID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
        var result = await _layananRepository.FindAsync(cID.Text);
        cNama.Text = result.Nama;
        cTarif.Text = result.Tarif.ToString();

        btnSimpan.Text = "Ubah";
        btnSimpan.BackColor = Color.Gold;
        btnHapus.Enabled = true;
    }
}