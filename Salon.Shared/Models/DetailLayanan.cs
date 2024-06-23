using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Shared.Models;
public class DetailLayanan
{
    public int Id { get; set; }
    public string IdTransaksi { get; set; } = null!;
    public string IdLayanan { get; set; } = null!;

    public int Tarif { get; set; }

    public Layanan Layanan { get; set; } = null!;
    public Transaksi Transaksi { get; set; } = null!;
}
