namespace Salon.Shared.Repositories;

/// <summary>
/// GET Includable :
/// <br/>
/// • One to Many - <see cref="User"/>
/// <br/>
/// • One to Many - <see cref="Customer"/>
/// <br/>
/// • One to Many - <see cref="DetailLayanan"/>
/// <br/>
/// • One to Many - <see cref="DetailProduk"/>
/// </summary>
public interface ITransaksiRepository
{
    #region Transaksi

    Task<List<Transaksi>> GetAsync(List<string> includes = null!);

    Task<Transaksi> FindAsync(string id, List<string> includes = null!);

    Task<bool> AddAsync(Transaksi transaksi);

    Task<bool> UpdateAsync(Transaksi transaksi);

    Task<bool> DeleteAsync(string id);

    #endregion Transaksi
}

public class TransaksiRepository(AppDbContext appDbContext) : ITransaksiRepository
{
    #region Transaksi

    public async Task<List<Transaksi>> GetAsync(List<string> includes = null!)
    {
        try
        {
            IQueryable<Transaksi> models = appDbContext.Transaksi;

            if (includes != null)
            {
                if (includes.Contains(nameof(User))) models = models.Include(x => x.User);
                if (includes.Contains(nameof(Customer))) models = models.Include(x => x.Customer);
                if (includes.Contains(nameof(DetailLayanan))) models = models.Include(x => x.DetailLayanan);
                if (includes.Contains(nameof(Layanan))) models = models.Include(x => x.DetailLayanan).ThenInclude(x => x.Layanan);
                if (includes.Contains(nameof(DetailProduk))) models = models.Include(x => x.DetailProduk);
                if (includes.Contains(nameof(Produk))) models = models.Include(x => x.DetailProduk).ThenInclude(x => x.Produk);
            }

            return await models.OrderByDescending(x => x.Tanggal).ToListAsync();
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<Transaksi> FindAsync(string id, List<string> includes = null!)
    {
        try
        {
            IQueryable<Transaksi> model = appDbContext.Transaksi;

            if (includes != null)
            {
                if (includes.Contains(nameof(User))) model = model.Include(x => x.User);
                if (includes.Contains(nameof(Customer))) model = model.Include(x => x.Customer);
                if (includes.Contains(nameof(DetailLayanan))) model = model.Include(x => x.DetailLayanan);
                if (includes.Contains(nameof(Layanan))) model = model.Include(x => x.DetailLayanan).ThenInclude(x => x.Layanan);
                if (includes.Contains(nameof(DetailProduk))) model = model.Include(x => x.DetailProduk);
                if (includes.Contains(nameof(Produk))) model = model.Include(x => x.DetailProduk).ThenInclude(x => x.Produk);
            }

            return (await model.FirstOrDefaultAsync(x => x.Id == id))!;
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<bool> AddAsync(Transaksi transaksi)
    {
        try
        {
            transaksi.Id = GenerateId("T", 2, transaksi.Tanggal, await appDbContext.Transaksi.Where(x => x.Tanggal.Date == transaksi.Tanggal.Date).Select(x => x.Id).ToListAsync());

            foreach (var dp in transaksi.DetailProduk)
            {
                dp.IdTransaksi = transaksi.Id;
            }

            foreach (var dl in transaksi.DetailLayanan)
            {
                dl.IdTransaksi = transaksi.Id;
            }

            var model = await appDbContext.Transaksi.AddAsync(transaksi);
            await appDbContext.DetailProduk.AddRangeAsync(transaksi.DetailProduk);
            await appDbContext.DetailLayanan.AddRangeAsync(transaksi.DetailLayanan);
            int result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> UpdateAsync(Transaksi transaksi)
    {
        try
        {
            Transaksi model = (await appDbContext.Transaksi.Include(x => x.DetailProduk).Include(x => x.DetailLayanan).FirstOrDefaultAsync(x => x.Id == transaksi.Id))!;

            foreach (var dp in transaksi.DetailProduk)
            {
                dp.IdTransaksi = transaksi.Id;
            }

            foreach (var dl in transaksi.DetailLayanan)
            {
                dl.IdTransaksi = transaksi.Id;
            }

            appDbContext.DetailProduk.RemoveRange(model.DetailProduk);
            appDbContext.DetailLayanan.RemoveRange(model.DetailLayanan);

            await appDbContext.DetailProduk.AddRangeAsync(transaksi.DetailProduk);
            await appDbContext.DetailLayanan.AddRangeAsync(transaksi.DetailLayanan);

            if (model != null)
            {
                model.IdUser = transaksi.IdUser;
                model.IdCustomer = transaksi.IdCustomer;
                model.Tanggal = transaksi.Tanggal;
                model.BiayaProduk = transaksi.BiayaProduk;
                model.BiayaLayanan = transaksi.BiayaLayanan;
                model.Bayar = transaksi.Bayar;
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
            Transaksi model = (await appDbContext.Transaksi.FirstOrDefaultAsync(x => x.Id == id))!;
            if (model != null)
            {
                appDbContext.Transaksi.Remove(model);
            }
            int result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    #endregion Transaksi
}