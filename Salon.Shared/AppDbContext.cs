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
            e.HasOne(x => x.Produk).WithMany(x => x.DetailProduk).HasForeignKey(x => x.IdProduk);
        });

        modelBuilder.Entity<DetailLayanan>(e =>
        {
            e.HasOne(x => x.Layanan).WithMany(x => x.DetailLayanan).HasForeignKey(x => x.IdLayanan);
        });

        #endregion Model Configuration

        #region Data Initializer

        //modelBuilder.Entity<User>().HasData(
        //new User
        //{
        //    Id = "sujudihanif36@gmail.com",
        //    Password = "IvCkErOjG9A8DPW7X23rJg==",
        //    Nama = "Sujudi Hanif",
        //    JenisKelamin = JenisKelamin.Pria,
        //    Telepon = "085739194810"
        //});

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
        });

        #endregion Data Initializer
    }
}