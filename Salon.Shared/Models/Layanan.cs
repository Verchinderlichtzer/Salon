using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Shared.Models;
public class Layanan
{
    public string Id { get; set; } = null!;

    public string Nama { get; set; } = string.Empty;
    public int Tarif { get; set; }

    public List<DetailLayanan> DetailLayanan { get; set; } = null!;
}
