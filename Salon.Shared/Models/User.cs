namespace Salon.Shared.Models;

public class User
{
    public string Id { get; set; } = null!;

    public string Password { get; set; } = string.Empty;
    public string Nama { get; set; } = string.Empty;
    public JenisKelamin JenisKelamin { get; set; }
    public string Telepon { get; set; } = string.Empty;
    public JenisUser JenisUser { get; set; }

    public List<Transaksi> Transaksi { get; set; } = null!;
}