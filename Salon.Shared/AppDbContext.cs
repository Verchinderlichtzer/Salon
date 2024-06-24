using Microsoft.EntityFrameworkCore;

namespace Salon.Shared;

public class AppDbContext : DbContext
{
    #region DbSet

    public DbSet<Customer> Customer { get; set; }
    public DbSet<DetailLayanan> DetailLayanan { get; set; }
    public DbSet<DetailProduk> DetailProduk { get; set; }
    public DbSet<Layanan> Layanan { get; set; }
    public DbSet<Produk> Produk { get; set; }
    public DbSet<Transaksi> Transaksi { get; set; }
    public DbSet<User> User { get; set; }

    #endregion DbSet

    public AppDbContext() { }

    public AppDbContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=Salon.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Model Configuration

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(e =>
        {
            e.HasKey(x => x.Id);
        });

        modelBuilder.Entity<Transaksi>(e =>
        {
            e.HasOne(x => x.Customer).WithMany(x => x.Transaksi).HasForeignKey(x => x.IdCustomer);
            e.HasOne(x => x.User).WithMany(x => x.Transaksi).HasForeignKey(x => x.IdUser);
        });

        modelBuilder.Entity<DetailProduk>(e =>
        {
            e.HasOne(x => x.Transaksi).WithMany(x => x.DetailProduk).HasForeignKey(x => x.IdTransaksi);
            e.HasOne(x => x.Produk).WithMany(x => x.DetailProduk).HasForeignKey(x => x.IdProduk);
        });

        modelBuilder.Entity<DetailLayanan>(e =>
        {
            e.HasOne(x => x.Transaksi).WithMany(x => x.DetailLayanan).HasForeignKey(x => x.IdTransaksi);
            e.HasOne(x => x.Layanan).WithMany(x => x.DetailLayanan).HasForeignKey(x => x.IdLayanan);
        });

        #endregion Model Configuration

        #region Data Initializer

        modelBuilder.Entity<User>().HasData(
        new User
        {
            Id = "Admin",
            Password = "3jqbFvenDDp2g3HTQ6ABlw==",
            Nama = "Rosma Nelli",
            JenisKelamin = JenisKelamin.Wanita,
            Telepon = "083665519043"
        });

        modelBuilder.Entity<Customer>().HasData(
        new Customer
        {
            Id = "C-00001",
            Nama = "Putri",
            JenisKelamin = JenisKelamin.Wanita,
            TanggalLahir = new(2000, 12, 12),
            Alamat = "Bekasi",
            Telepon = "0853 4677 3443"
        },
        new Customer
        {
            Id = "C-00002",
            Nama = "Andi",
            JenisKelamin = JenisKelamin.Pria,
            TanggalLahir = new(1997, 4, 7),
            Alamat = "Jakarta",
            Telepon = "0833 5275 9486"
        });

        modelBuilder.Entity<Produk>().HasData(
        new Produk
        {
            Id = "P-0001",
            Nama = "Wardah",
            Satuan = "Pcs",
            Harga = 10000
        },
        new Produk
        {
            Id = "P-0002",
            Nama = "Purbasari",
            Satuan = "Pcs",
            Harga = 90000
        },
        new Produk
        {
            Id = "P-0003",
            Nama = "Bedak Lulur",
            Satuan = "Botol",
            Harga = 20000
        },
        new Produk
        {
            Id = "P-0004",
            Nama = "Pemutih Wajah",
            Satuan = "Cepuk",
            Harga = 15000
        },
        new Produk
        {
            Id = "P-0005",
            Nama = "Masker Wajah",
            Satuan = "Botol",
            Harga = 20000
        },
        new Produk
        {
            Id = "P-0006",
            Nama = "Creambath",
            Satuan = "Botol",
            Harga = 51000
        });

        modelBuilder.Entity<Layanan>().HasData(
        new Layanan
        {
            Id = "L-001",
            Nama = "Cukur",
            Tarif = 23000
        },
        new Layanan
        {
            Id = "L-002",
            Nama = "Smoothing",
            Tarif = 150000
        },
        new Layanan
        {
            Id = "L-003",
            Nama = "Coloring",
            Tarif = 150000
        },
        new Layanan
        {
            Id = "L-004",
            Nama = "Rebonding",
            Tarif = 135000
        },
        new Layanan
        {
            Id = "L-005",
            Nama = "Catok",
            Tarif = 31000
        },
        new Layanan
        {
            Id = "L-006",
            Nama = "Blow",
            Tarif = 31000
        },
        new Layanan
        {
            Id = "L-007",
            Nama = "Curly",
            Tarif = 35000
        });

        #endregion Data Initializer
    }
}