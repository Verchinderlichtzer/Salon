using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Shared.Models;

public class DetailTransaksiDTO
{
    public string Id { get; set; } = string.Empty;
    public string NamaCustomer { get; set; } = string.Empty;
    public DateTime Tanggal { get; set; }
    public int BiayaProduk { get; set; }
    public int BiayaLayanan { get; set; }
    public int TotalBiaya { get; set; }

    public List<DetailProdukDTO> DetailProdukDTO { get; set; } = null!;
    public List<DetailLayananDTO> DetailLayananDTO { get; set; } = null!;
}

public class DetailProdukDTO
{
    public string NamaProduk { get; set; } = string.Empty;
    public int Harga { get; set; }
    public int Jumlah { get; set; }
    public int Total { get; set; }
}

public class DetailLayananDTO
{
    public string NamaLayanan { get; set; } = string.Empty;
    public int Tarif { get; set; }
}