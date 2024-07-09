using Microsoft.Reporting.WinForms;

namespace Salon.App.Forms;
public partial class FLaporan : Form, ILaporanForm
{
    private readonly IProdukRepository _produkRepository;
    private readonly ICustomerRepository _customerRepository;
    private readonly ILayananRepository _layananRepository;
    private readonly ITransaksiRepository _transaksiRepository;

    public FLaporan(IProdukRepository produkRepository, ICustomerRepository customerRepository, ILayananRepository layananRepository, ITransaksiRepository transaksiRepository)
    {
        InitializeComponent();
        _produkRepository = produkRepository;
        _customerRepository = customerRepository;
        _layananRepository = layananRepository;
        _transaksiRepository = transaksiRepository;
    }

    public void ShowForm() => (new FLaporan(_produkRepository, _customerRepository, _layananRepository, _transaksiRepository)).Show();

    public async Task LoadData()
    {
        lbDetailTransaksi.DataSource = (await _transaksiRepository.GetAsync([nameof(Customer)])).Select(x => $"{x.Id} ({x.Customer.Nama})").Where(x => x.Search(cCariTransaksi.Text)).ToList();
        lbTransaksiCustomer.DataSource = (await _customerRepository.GetAsync()).Select(x => $"{x.Id} — {x.Nama}").Where(x => x.Search(cCariCustomer.Text)).ToList();

        cTahun.Items.Clear();
        for (int year = DateTime.Today.Year; year >= 2022; year--) cTahun.Items.Add(year);
    }

    private async void FLaporan_Load(object sender, EventArgs e)
    {
        int year = DateTime.Today.Year, month = DateTime.Today.Month;
        int last = DateTime.DaysInMonth(year, month);
        cDari.Value = new DateTime(year, month, 1);
        cSampai.Value = new DateTime(year, month, last);
        await LoadData();
        cTahun.SelectedItem = DateTime.Today.Year;
    }

    public void GenerateReport<T>(ReportType judul, IEnumerable<T> data, string filterText = "")
    {
        using Stream reportDefinition = new FileStream($"Reports/Laporan{judul}.rdlc", FileMode.Open);
        LocalReport report = new();
        report.LoadReportDefinition(reportDefinition);
        if (judul == ReportType.Grafik)
        {
            report.SetParameters(new ReportParameter("Tahun", filterText));
            report.DataSources.Add(new ReportDataSource("DataSetGrafik", data));
        }
        else if (judul == ReportType.DetailTransaksi)
        {
            report.SetParameters(new ReportParameter("Keterangan", filterText));
            var aku = (IEnumerable<DetailTransaksiDTO>)data;
            report.DataSources.Add(new ReportDataSource("DataSetDetailTransaksi", aku.Select(x => new { x.Id, x.NamaCustomer, x.Tanggal, x.BiayaProduk, x.BiayaLayanan, x.TotalBiaya })));
            report.DataSources.Add(new ReportDataSource("DataSetDetailProduk", aku.First().DetailProdukDTO));
            report.DataSources.Add(new ReportDataSource("DataSetDetailLayanan", aku.First().DetailLayananDTO));
        }
        else
        {
            report.SetParameters(new ReportParameter("Keterangan", filterText));
            report.DataSources.Add(new ReportDataSource($"DataSet{judul}", data));
        }
        byte[] pdf = report.Render("PDF");
        string fileName = $"Laporan {judul.ToString().SeparateByCase()} {DateTime.Now:dd-MM-yy hh.mm.ss tt}.pdf";

        using var stream = new MemoryStream(pdf);
        string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string outputPath = Path.Combine(documentsFolder, fileName);

        using FileStream fileStream = new(outputPath, FileMode.Create);
        stream.WriteTo(fileStream);
        MessageBox.Show("Laporan berhasil dibuat", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private async void btnProduk_Click(object sender, EventArgs e)
    {
        var data = (await _produkRepository.GetAsync()).Select(x => new
        {
            x.Id,
            x.Nama,
            x.Satuan,
            x.Harga
        });
        GenerateReport(ReportType.MasterProduk, data, "Laporan produk");
    }

    private async void btnCustomer_Click(object sender, EventArgs e)
    {
        var data = (await _customerRepository.GetAsync()).Select(x => new
        {
            x.Id,
            x.Nama,
            JenisKelamin = x.JenisKelamin.ToString(),
            x.TanggalLahir,
            x.Alamat,
            x.Telepon
        });
        GenerateReport(ReportType.MasterCustomer, data, "Laporan customer");
    }

    private async void btnLayanan_Click(object sender, EventArgs e)
    {
        var data = (await _layananRepository.GetAsync()).Select(x => new
        {
            x.Id,
            x.Nama,
            x.Tarif
        });
        GenerateReport(ReportType.MasterLayanan, data, "Laporan layanan");
    }

    private async void btnTransaksi_Click(object sender, EventArgs e)
    {
        var data = (await _transaksiRepository.GetAsync([nameof(Customer)])).Where(x => x.Tanggal.Date >= cDari.Value.Date && x.Tanggal.Date <= cSampai.Value.Date).Select(x => new
        {
            x.Id,
            Customer = x.Customer.Nama,
            x.Tanggal,
            x.BiayaProduk,
            x.BiayaLayanan,
            x.Bayar
        });
        GenerateReport(ReportType.Transaksi, data, $"Laporan transaksi antara tanggal {cDari.Value:dd/MM/yyyy} sampai {cSampai.Value:dd/MM/yyyy}");
    }

    private async void btnGrafik_Click(object sender, EventArgs e)
    {
        var data = (await _transaksiRepository.GetAsync()).Where(x => x.Tanggal.Year == ToInt(cTahun.SelectedItem)).Select(x => new
        {
            x.Id,
            x.Tanggal,
            Nominal = x.TotalBiaya
        });
        GenerateReport(ReportType.Grafik, data, $"GRAFIK TAHUN {cTahun.SelectedItem}");
    }

    private async void btnDetailTransaksi_Click(object sender, EventArgs e)
    {
        var data = (await _transaksiRepository.GetAsync([nameof(Customer), nameof(Produk), nameof(Layanan)])).Where(x => x.Id == lbDetailTransaksi.SelectedItem!.ToString()!.Left(11)).Select(x => new DetailTransaksiDTO
        {
            Id = x.Id,
            NamaCustomer = x.Customer.Nama,
            Tanggal = x.Tanggal,
            BiayaProduk = x.BiayaProduk,
            BiayaLayanan = x.BiayaLayanan,
            TotalBiaya = x.TotalBiaya,
            DetailProdukDTO = x.DetailProduk.ConvertAll(x => new DetailProdukDTO()
            {
                NamaProduk = x.Produk.Nama,
                Harga = x.Harga,
                Jumlah = x.Jumlah,
                Total = x.Total
            }),
            DetailLayananDTO = x.DetailLayanan.ConvertAll(x => new DetailLayananDTO()
            {
                NamaLayanan = x.Layanan.Nama,
                Tarif = x.Tarif
            })
        });
        GenerateReport(ReportType.DetailTransaksi, data, $"Laporan transaksi dengan id \"{lbDetailTransaksi.SelectedItem!.ToString()!.Left(11)}\"");
    }

    private async void btnTransaksiCustomer_Click(object sender, EventArgs e)
    {
        var data = (await _transaksiRepository.GetAsync([nameof(Customer)])).Where(x => x.IdCustomer == lbTransaksiCustomer.SelectedItem!.ToString()!.Left(7)).Select(x => new
        {
            x.Id,
            x.Customer.Nama,
            JenisKelamin = x.Customer.JenisKelamin.ToString(),
            x.Customer.TanggalLahir,
            x.Customer.Alamat,
            x.Customer.Telepon,
            IdTransaksi = x.Id,
            x.Tanggal,
            x.BiayaProduk,
            x.BiayaLayanan,
            x.TotalBiaya
        });
        GenerateReport(ReportType.TransaksiCustomer, data, $"Laporan transaksi oleh customer \"{lbTransaksiCustomer.SelectedItem!.ToString()!.Mid(10)}\"");
    }

    private async void cCariTransaksi_TextChanged(object sender, EventArgs e)
    {
        lbDetailTransaksi.DataSource = (await _transaksiRepository.GetAsync([nameof(Customer)])).Select(x => $"{x.Id} ({x.Customer.Nama})").Where(x => x.Search(cCariTransaksi.Text)).ToList();
    }

    private async void cCariCustomer_TextChanged(object sender, EventArgs e)
    {
        lbTransaksiCustomer.DataSource = (await _customerRepository.GetAsync()).Select(x => $"{x.Id} — {x.Nama}").Where(x => x.Search(cCariCustomer.Text)).ToList();
    }

    #region Enums

    [Flags]
    public enum Section
    {
        None = 0,
        Master = 1,
        Transaksi = 1 << 1,
        Grafik = 1 << 2,
        Periodik = 1 << 3,
        Bulanan = 1 << 4,
        Tahunan = 1 << 5,
        JenisTransaksi = 1 << 6,
        Entitas = 1 << 7
    }

    public enum ReportType : byte
    {
        None,
        MasterProduk,
        MasterCustomer,
        MasterLayanan,
        Transaksi,
        Grafik,
        DetailTransaksi,
        TransaksiCustomer
    }

    [Flags]
    public enum ReportFilter : byte
    {
        None = 0,
        Periodik = 1,
        Bulanan = 1 << 1,
        Tahunan = 1 << 2,
        JenisTransaksi = 1 << 3
    }

    #endregion
}
