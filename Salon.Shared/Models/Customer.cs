using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Shared.Models;
public class Customer
{
    public string Id { get; set; } = string.Empty;

    public string Nama { get; set; } = string.Empty;
    public JenisKelamin JenisKelamin { get; set; }
    public DateTime TanggalLahir { get; set; } = DateTime.Today;
    public string Alamat { get; set; } = string.Empty;
    public string? Telepon { get; set; } = string.Empty;

    public List<Transaksi> Transaksi { get; set; } = null!;
}
