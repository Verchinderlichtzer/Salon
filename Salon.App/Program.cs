using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;

namespace Salon.App;
//https://www.youtube.com/watch?v=yfPGFapabAY
internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        CultureInfo ci = new("id-ID");
        Thread.CurrentThread.CurrentUICulture = ci;
        Thread.CurrentThread.CurrentCulture = ci;
        CultureInfo.DefaultThreadCurrentCulture = ci;
        CultureInfo.DefaultThreadCurrentUICulture = ci;

        var host = CreateHostBuilder().Build();

        using (var scope = host.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            db.Database.Migrate();
        }

        ServiceProvider = host.Services;

        Application.Run(ServiceProvider.GetRequiredService<FLogin>());
    }

    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<AppDbContext>(o => o.UseSqlite("Data Source=Salon.db"));

                services.AddSingleton<FLogin>();
                services.AddTransient<IDashboardForm, FDashboard>();

                services.AddTransient<ICustomerForm, FCustomer>();
                services.AddTransient<ILaporanForm, FLaporan>();
                services.AddTransient<ILayananForm, FLayanan>();
                services.AddTransient<IProdukForm, FProduk>();
                services.AddTransient<IDaftarTransaksiForm, FDaftarTransaksi>();
                services.AddTransient<ITransaksiForm, FTransaksi>();
                services.AddTransient<IUserForm, FUser>();

                services.AddSingleton<ICustomerRepository, CustomerRepository>();
                services.AddSingleton<ILayananRepository, LayananRepository>();
                services.AddSingleton<IProdukRepository, ProdukRepository>();
                services.AddSingleton<ITransaksiRepository, TransaksiRepository>();
                services.AddSingleton<IUserRepository, UserRepository>();
            });
    }
}