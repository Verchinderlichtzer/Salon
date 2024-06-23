using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Shared.Models;
public class DetailLayanan
{
    public int Id { get; set; }
    public string IdLayanan { get; set; } = string.Empty;

    public int Tarif { get; set; }

    public Layanan Layanan { get; set; } = null!;
}
