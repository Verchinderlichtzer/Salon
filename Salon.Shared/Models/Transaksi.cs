﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon.Shared.Models;
public class Transaksi
{
    public string Id { get; set; } = null!;
    public string IdUser { get; set; } = null!;
    public string IdCustomer { get; set; } = null!;

    public DateTime Tanggal { get; set; } = DateTime.Now;
    public int BiayaProduk { get; set; }
    public int BiayaLayanan { get; set; }
    public int Bayar { get; set; }

    public User User { get; set; } = null!;
    public Customer Customer { get; set; } = null!;
    public List<DetailProduk> DetailProduk { get; set; } = null!;
    public List<DetailLayanan> DetailLayanan { get; set; } = null!;

    public int TotalBiaya => BiayaProduk + BiayaLayanan;
    public int Kembali => Bayar - TotalBiaya;
}
