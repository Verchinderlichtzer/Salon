using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Salon.Shared.Repositories;
using System;

namespace Salon.App;

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

        var host = CreateHostBuilder().Build();

        using (var scope = host.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
            db.Database.Migrate();
        }

        ServiceProvider = host.Services;

        Application.Run(ServiceProvider.GetRequiredService<FDashboard>());
    }

    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<AppDbContext>(o => o.UseSqlite("Data Source=Salon.db"));

                services.AddSingleton<FDashboard>();

                services.AddTransient<ICustomerForm, FCustomer>();
                services.AddTransient<ILayananForm, FLayanan>();
                services.AddTransient<IProdukForm, FProduk>();
                services.AddTransient<ITransaksiForm, FTransaksi>();
                services.AddTransient<IUserForm, FUser>();

                services.AddSingleton<ICustomerRepository, CustomerRepository>();
                services.AddSingleton<IProdukRepository, ProdukRepository>();
                services.AddSingleton<IUserRepository, UserRepository>();
            });
    }
}