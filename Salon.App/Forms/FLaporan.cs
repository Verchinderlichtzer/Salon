using Microsoft.Reporting.WinForms;
using Salon.Shared.Extensions;
using Salon.Shared.Models;
using System.IO;

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
        lbTransaksiCustomer.DataSource = (await _customerRepository.GetAsync()).Select(x => $"{x.Id} — {x.Nama}").Where(x => x.Search(cCariTransaksi.Text)).ToList();

        cTahun.Items.Clear();
        for (int year = DateTime.Today.Year; year >= 2020; year--) cTahun.Items.Add(year);
    }

    private void FLaporan_Load(object sender, EventArgs e)
    {
        int year = DateTime.Today.Year, month = DateTime.Today.Month;
        int last = DateTime.DaysInMonth(year, month);
        cDari.Value = new DateTime(year, month, 1);
        cSampai.Value = new DateTime(year, month, last);
    }

    public void GenerateReport(LocalReport report)
    {
        var items = new[] {
            new Customer { Id = "1", Nama = "Namanyi", JenisKelamin = JenisKelamin.Wanita, Alamat = "Bekasi", Telepon = "0888554" },
            new Customer { Id = "2", Nama = "Namanya", JenisKelamin = JenisKelamin.Pria, Alamat = "Bandung" }
        };
        var parameters = new[] { new ReportParameter("Title", "Invoice 4/2020") };
        using var fs = new FileStream("Reports/LaporanMasterCustomer.rdlc", FileMode.Open);
        report.LoadReportDefinition(fs);
        report.DataSources.Add(new ReportDataSource("Items", items));
        report.SetParameters(parameters);
    }

    public async Task GenerateReportAsync<T>(ReportType judul, IEnumerable<T> data, string filterText = "")
    {
        using Stream reportDefinition = new FileStream("Reports/LaporanMasterCustomer.rdlc", FileMode.Open);
        LocalReport report = new();
        report.LoadReportDefinition(reportDefinition);
        if (judul != ReportType.Grafik)
        {
            report.SetParameters(new ReportParameter("Keterangan", filterText));
            report.DataSources.Add(new ReportDataSource($"DataSet{judul}", data));
        }
        else if (judul == ReportType.Grafik)
        {
            report.SetParameters(new ReportParameter("Tahun", filterText));
            report.DataSources.Add(new ReportDataSource("DataSetGrafik", data));
        }
        byte[] pdf = report.Render("PDF");
        string fileName = $"Laporan {judul.ToString().SeparateByCase()} {DateTime.Now:dd-MM-yy hh.mm.ss tt}.pdf";

        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;

        using var stream = new MemoryStream(pdf);


        // Assuming 'memoryStream' contains your PDF data
        string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string outputPath = Path.Combine(documentsFolder, "output.pdf");

        using (FileStream fileStream = new FileStream(outputPath, FileMode.Create))
        {
            stream.WriteTo(fileStream);
        }
    }

    /*
     public async Task GenerateReportAsync<T>(ReportType judul, IEnumerable<T> data, string filterText = "")
    {
        using Stream reportDefinition = await FileSystem.Current.OpenAppPackageFileAsync($"Reports/Laporan{judul}.rdlc");
        LocalReport report = new();
        report.LoadReportDefinition(reportDefinition);
        if (judul != ReportType.GrafikBatang && judul != ReportType.GrafikGaris)
        {
            ParameterInfo(await ProfilPerusahaanRepository.GetAsync());
            foreach (var x in _parameters) report.SetParameters(x);
            report.SetParameters(new ReportParameter("Keterangan", filterText));
            report.DataSources.Add(new ReportDataSource($"DataSet{judul}", data));
        }
        else
        {
            report.SetParameters(new ReportParameter("Tahun", filterText));
            report.DataSources.Add(new ReportDataSource("DataSetGrafik", data));
        }
        byte[] pdf = report.Render("PDF");
        string fileName = $"Laporan {judul.ToString().SeparateByCase()} {DateTime.Now:dd-MM-yy hh.mm.ss tt}.pdf";

        var cancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = cancellationTokenSource.Token;

        using var stream = new MemoryStream(pdf);
        var fileSaverResult = await FileSaver.Default.SaveAsync(fileName, stream, cancellationToken);
        if (fileSaverResult.IsSuccessful)
        {

        }
    }
     */

    private void bu_Click(object sender, EventArgs e)
    {
        if (_jenisLaporan.Key == ReportType.MasterProduk)
        {
            await LaporanMasterProdukAsync();
        }
        else if (_jenisLaporan.Key == ReportType.MasterCustomer)
        {
            await LaporanMasterCustomerAsync();
        }
        else if (_jenisLaporan.Key == ReportType.MasterLayanan)
        {
            await LaporanMasterLayananAsync();
        }
        else if (_jenisLaporan.Key == ReportType.Transaksi)
        {
            await LaporanTransaksiAsync();
        }
        else if (_jenisLaporan.Key == ReportType.Grafik)
        {
            await LaporanGrafikAsync();
        }
        else if (_jenisLaporan.Key == ReportType.EntitasTransaksi)
        {
            await LaporanEntitasTransaksiAsync();
        }
        else if (_jenisLaporan.Key == ReportType.EntitasCustomer)
        {
            await LaporanEntitasCustomerAsync();
        }
    }

    private async void OnPencarianChanged(object sender, EventArgs e)
    {
        await LoadData();
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
        await GenerateReportAsync(ReportType.MasterProduk, data);
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
        await GenerateReportAsync(ReportType.MasterCustomer, data);
    }

    private async void btnLayanan_Click(object sender, EventArgs e)
    {
        var data = (await _layananRepository.GetAsync()).Select(x => new
        {
            x.Id,
            x.Nama,
            x.Tarif
        });
        await GenerateReportAsync(ReportType.MasterLayanan, data);
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
        await GenerateReportAsync(ReportType.Transaksi, data);
    }

    private async void btnGrafik_Click(object sender, EventArgs e)
    {
        var data = (await _transaksiRepository.GetAsync()).Where(x => x.Tanggal.Year == ToInt(cTahun.SelectedItem)).Select(x => new
        {
            x.Id,
            x.Tanggal,
            Nominal = x.TotalBiaya
        });
        await GenerateReportAsync(ReportType.Grafik, data);
    }

    private async void btnDetailTransaksi_Click(object sender, EventArgs e)
    {
        var data = (await _transaksiRepository.GetAsync([nameof(Customer)])).Select(x => new
        {
            x.Id,
            NamaCustomer = x.Customer.Nama,
            x.Tanggal,
            x.BiayaProduk,
            x.BiayaLayanan,
            x.TotalBiaya
        });
        await GenerateReportAsync(ReportType.DetailTransaksi, data);
    }

    private async void btnTransaksiCustomer_Click(object sender, EventArgs e)
    {
        var data = (await _transaksiRepository.GetAsync([nameof(Customer)])).Select(x => new
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
        await GenerateReportAsync(ReportType.TransaksiCustomer, data);
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
