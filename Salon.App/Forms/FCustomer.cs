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

    public async Task RefreshDGV()
    {
        dgv.DataSource = (await _customerRepository.GetAsync()).Where(x => x.Nama.Search(cCariCustomer.Text) || x.Alamat.Search(cCariCustomer.Text) || x.Telepon!.Search(cCariCustomer.Text) || x.JenisKelamin.ToString().Search(cCariCustomer.Text)).ToList();
    }

    private async void FCustomer_Load(object sender, EventArgs e)
    {
        await RefreshDGV();

        dgv.Columns[0].Width = 58;
        dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns[1].Width = 133;
        dgv.Columns[2].Width = 102;
        dgv.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns[3].Width = 102;
        dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns[4].Width = 240;
        dgv.Columns[5].Width = 99;
        dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns["TanggalLahir"].HeaderText = "Tanggal Lahir";
        dgv.Columns["JenisKelamin"].HeaderText = "Jenis Kelamin";
        dgv.Columns["TanggalLahir"].DefaultCellStyle.Format = "dd MMM yyyy";
    }

    private async void btnSimpan_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(cNama.Text) || (!cPria.Checked && !cWanita.Checked))
        {
            MessageBox.Show("""
                Form yang wajib diisi :
                1. Nama
                2. Jenis Kelamin
                3. Tanggal Lahir
                """, "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
        if (string.IsNullOrEmpty(cID.Text))
        {
            bool result = await _customerRepository.AddAsync(new()
            {
                Nama = cNama.Text,
                Alamat = cAlamat.Text,
                Telepon = cTelepon.Text,
                JenisKelamin = cPria.Checked ? JenisKelamin.Pria : JenisKelamin.Wanita,
                TanggalLahir = cTanggalLahir.Value
            });
            if (!result)
                MessageBox.Show("Customer gagal ditambah", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            bool result = await _customerRepository.UpdateAsync(new()
            {
                Id = cID.Text,
                Nama = cNama.Text,
                Alamat = cAlamat.Text,
                Telepon = cTelepon.Text,
                JenisKelamin = cPria.Checked ? JenisKelamin.Pria : JenisKelamin.Wanita,
                TanggalLahir = cTanggalLahir.Value
            });
            if (!result)
                MessageBox.Show("Customer gagal diubah", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        btnRefresh.PerformClick();
    }

    private async void btnHapus_Click(object sender, EventArgs e)
    {
        var id = dgv.CurrentRow.Cells[0].Value.ToString();
        DialogResult dr = MessageBox.Show($"Hapus {id}?", "Konfirmasi hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            bool result = await _customerRepository.DeleteAsync(id!);
            if (!result)
                MessageBox.Show("Customer gagal dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnRefresh.PerformClick();
        }
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        cID.Clear();
        cNama.Clear();
        cAlamat.Clear();
        cTelepon.Clear();
        cPria.Checked = false;
        cWanita.Checked = false;
        cTanggalLahir.Value = DateTime.Today;
        cCariCustomer.Clear();
        await RefreshDGV();

        btnSimpan.Text = "Simpan";
        btnSimpan.BackColor = Color.LimeGreen;
        btnHapus.Enabled = false;
        //Clipboard.SetText(string.Join(" - ", dgv.Columns.Cast<DataGridViewColumn>().Select(c => c.Width)));
    }

    private async void cCariCustomer_TextChanged(object sender, EventArgs e)
    {
        await RefreshDGV();
    }

    private async void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        cID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
        var result = await _customerRepository.FindAsync(cID.Text);
        cNama.Text = result.Nama;
        cTelepon.Text = result.Telepon;
        cAlamat.Text = result.Alamat;
        cPria.Checked = result.JenisKelamin == JenisKelamin.Pria;
        cWanita.Checked = result.JenisKelamin == JenisKelamin.Wanita;
        cTanggalLahir.Value = result.TanggalLahir;

        btnSimpan.Text = "Ubah";
        btnSimpan.BackColor = Color.Gold;
        btnHapus.Enabled = true;
    }
}