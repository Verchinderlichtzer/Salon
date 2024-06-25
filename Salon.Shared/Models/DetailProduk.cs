﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Shared.Models;
public class DetailProduk
{
    public int Id { get; set; }
    public string IdTransaksi { get; set; } = null!;
    public string IdProduk { get; set; } = null!;

    public int Harga { get; set; }
    public int Jumlah { get; set; }
    public int Total { get; set; }

    public Produk Produk { get; set; } = null!;
    public Transaksi Transaksi { get; set; } = null!;
}
