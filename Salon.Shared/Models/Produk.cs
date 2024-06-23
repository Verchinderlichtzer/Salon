namespace Salon.Shared.Models;

public class Produk
{
    public string Id { get; set; } = null!;

    public string Nama { get; set; } = string.Empty;
    public string Satuan { get; set; } = string.Empty;
    public int Harga { get; set; }
    public int Stok { get; set; }

    public List<DetailProduk> DetailProduk { get; set; } = null!;
}
