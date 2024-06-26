using static Salon.Shared.Extensions.EncryptionHelper;

namespace Salon.App.Forms;
public partial class FUser : Form, IUserForm
{
    private readonly IUserRepository _userRepository;
    private bool _isNew = true;

    public FUser(IUserRepository userRepository)
    {
        InitializeComponent();
        _userRepository = userRepository;
    }

    public void ShowForm() => new FUser(_userRepository).Show();

    public async Task RefreshDGV()
    {
        dgv.DataSource = (await _userRepository.GetAsync()).Where(x => x.Id.Search(cCariUser.Text) || x.Nama.Search(cCariUser.Text) || x.Telepon!.Search(cCariUser.Text) || x.JenisKelamin.ToString().Search(cCariUser.Text)).ToList();
    }

    private async void FUser_Load(object sender, EventArgs e)
    {
        cJenisUser.SelectedItem = "Karyawan";
        await RefreshDGV();

        dgv.Columns[0].Width = 127;
        dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns[1].Visible = false;
        dgv.Columns[2].Width = 285;
        dgv.Columns[3].Width = 105;
        dgv.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns[4].Width = 116;
        dgv.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns[5].Width = 104;
        dgv.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        dgv.Columns["JenisUser"].HeaderText = "Jenis User";
        dgv.Columns["JenisKelamin"].HeaderText = "Jenis Kelamin";
    }

    private async void btnSimpan_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(cNama.Text) || (!cPria.Checked && !cWanita.Checked))
        {
            MessageBox.Show("""
                Form yang wajib diisi :
                1. Nama
                2. Password
                3. Telepon
                4. Jenis Kelamin
                """, "Data Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
        if (_isNew)
        {
            bool result = await _userRepository.AddAsync(new()
            {
                Id = cID.Text,
                Nama = cNama.Text,
                Password = cPassword.Text,
                Telepon = cTelepon.Text,
                JenisKelamin = cPria.Checked ? JenisKelamin.Pria : JenisKelamin.Wanita,
                JenisUser = cJenisUser.SelectedItem!.ToString()!.ToEnum<JenisUser>()
            });
            if (!result)
                MessageBox.Show("User gagal ditambah", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            bool result = await _userRepository.UpdateAsync(new()
            {
                Id = cID.Text,
                Nama = cNama.Text,
                Password = cPassword.Text,
                Telepon = cTelepon.Text,
                JenisKelamin = cPria.Checked ? JenisKelamin.Pria : JenisKelamin.Wanita,
                JenisUser = cJenisUser.SelectedItem!.ToString()!.ToEnum<JenisUser>()
            });
            if (!result)
                MessageBox.Show("User gagal diubah", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        btnRefresh.PerformClick();
    }

    private async void btnHapus_Click(object sender, EventArgs e)
    {
        var id = dgv.CurrentRow.Cells[0].Value.ToString();
        if (id == "Admin") return;
        DialogResult dr = MessageBox.Show($"Hapus {id}?", "Konfirmasi hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (dr == DialogResult.Yes)
        {
            bool result = await _userRepository.DeleteAsync(id!);
            if (!result)
                MessageBox.Show("User gagal dihapus", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            btnRefresh.PerformClick();
        }
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        _isNew = cID.Enabled = true;
        cID.Clear();
        cNama.Clear();
        cPassword.Clear();
        cTelepon.Clear();
        cPria.Checked = false;
        cWanita.Checked = false;
        cJenisUser.SelectedItem = "Karyawan";
        cCariUser.Clear();
        await RefreshDGV();

        btnSimpan.Text = "Simpan";
        btnSimpan.BackColor = Color.LimeGreen;
        btnHapus.Enabled = false;
        //Clipboard.SetText(string.Join(" - ", dgv.Columns.Cast<DataGridViewColumn>().Select(c => c.Width)));
    }

    private async void cCariUser_TextChanged(object sender, EventArgs e)
    {
        await RefreshDGV();
    }

    private async void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        _isNew = cID.Enabled = false;
        cID.Text = dgv.CurrentRow.Cells[0].Value.ToString();
        var result = await _userRepository.FindAsync(cID.Text);
        cNama.Text = result.Nama;
        cTelepon.Text = result.Telepon;
        cPria.Checked = result.JenisKelamin == JenisKelamin.Pria;
        cWanita.Checked = result.JenisKelamin == JenisKelamin.Wanita;
        cJenisUser.SelectedItem = result.JenisUser.ToString();

        btnSimpan.Text = "Ubah";
        btnSimpan.BackColor = Color.Gold;
        btnHapus.Enabled = true;
    }
}