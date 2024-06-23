namespace Salon.Shared.Repositories;

/// <summary>
/// GET Includable :
/// <br/>
/// • One to Many - <see cref="DetailProduk"/>
/// </summary>
public interface IProdukRepository
{
    #region Produk

    Task<List<Produk>> GetAsync(List<string> includes = null!);

    Task<Produk> FindAsync(string id, List<string> includes = null!);

    Task<bool> AddAsync(Produk produk);

    Task<bool> UpdateAsync(Produk produk);

    Task<bool> DeleteAsync(string id);

    #endregion Produk
}

public class ProdukRepository(AppDbContext appDbContext) : IProdukRepository
{
    #region Produk

    public async Task<List<Produk>> GetAsync(List<string> includes = null!)
    {
        try
        {
            IQueryable<Produk> models = appDbContext.Produk;

            if (includes != null)
            {
                if (includes.Contains(nameof(DetailProduk))) models = models.Include(x => x.DetailProduk);
            }

            return await models.OrderBy(x => x.Nama).ToListAsync();
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<Produk> FindAsync(string id, List<string> includes = null!)
    {
        try
        {
            IQueryable<Produk> model = appDbContext.Produk;

            if (includes != null)
            {
                if (includes.Contains(nameof(DetailProduk))) model = model.Include(x => x.DetailProduk);
            }

            return (await model.FirstOrDefaultAsync(x => x.Id == id))!;
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<bool> AddAsync(Produk produk)
    {
        try
        {
            produk.Id = GenerateId(await appDbContext.Produk.Select(x => x.Id).ToListAsync(), 4, "P");
            var model = await appDbContext.Produk.AddAsync(produk);
            int result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> UpdateAsync(Produk produk)
    {
        try
        {
            Produk model = (await appDbContext.Produk.FirstOrDefaultAsync(x => x.Id == produk.Id))!;
            if (model != null)
            {
                model.Nama = produk.Nama;
                model.Satuan = produk.Satuan;
                model.Harga = produk.Harga;
                model.Stok = produk.Stok;
            }
            int result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> DeleteAsync(string id)
    {
        try
        {
            Produk model = (await appDbContext.Produk.FirstOrDefaultAsync(x => x.Id == id))!;
            if (model != null)
            {
                bool removable = await appDbContext.Produk.Include(x => x.DetailProduk).AnyAsync(x => x.Id == id && x.DetailProduk.Count == 0);
                if (!removable) return false;
                appDbContext.Produk.Remove(model);
            }
            int result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    #endregion Produk
}