namespace Salon.Shared.Repositories;

/// <summary>
/// GET Includable :
/// <br/>
/// • One to Many - <see cref="DetailLayanan"/>
/// </summary>
public interface ILayananRepository
{
    #region Layanan

    Task<List<Layanan>> GetAsync(List<string> includes = null!);

    Task<Layanan> FindAsync(string id, List<string> includes = null!);

    Task<bool> AddAsync(Layanan layanan);

    Task<bool> UpdateAsync(Layanan layanan);

    Task<bool> DeleteAsync(string id);

    #endregion Layanan
}

public class LayananRepository(AppDbContext appDbContext) : ILayananRepository
{
    #region Layanan

    public async Task<List<Layanan>> GetAsync(List<string> includes = null!)
    {
        try
        {
            IQueryable<Layanan> models = appDbContext.Layanan;

            if (includes != null)
            {
                if (includes.Contains(nameof(DetailLayanan))) models = models.Include(x => x.DetailLayanan);
            }

            return await models.OrderBy(x => x.Nama).ToListAsync();
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<Layanan> FindAsync(string id, List<string> includes = null!)
    {
        try
        {
            IQueryable<Layanan> model = appDbContext.Layanan;

            if (includes != null)
            {
                if (includes.Contains(nameof(DetailLayanan))) model = model.Include(x => x.DetailLayanan);
            }

            return (await model.FirstOrDefaultAsync(x => x.Id == id))!;
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<bool> AddAsync(Layanan layanan)
    {
        try
        {
            layanan.Id = GenerateId(await appDbContext.Layanan.Select(x => x.Id).ToListAsync(), 3, "L");
            var model = await appDbContext.Layanan.AddAsync(layanan);
            int result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> UpdateAsync(Layanan layanan)
    {
        try
        {
            Layanan model = (await appDbContext.Layanan.FirstOrDefaultAsync(x => x.Id == layanan.Id))!;
            if (model != null)
            {
                model.Nama = layanan.Nama;
                model.Tarif = layanan.Tarif;
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
            Layanan model = (await appDbContext.Layanan.FirstOrDefaultAsync(x => x.Id == id))!;
            if (model != null)
            {
                bool removable = await appDbContext.Layanan.Include(x => x.DetailLayanan).AnyAsync(x => x.Id == id && x.DetailLayanan.Count == 0);
                if (!removable) return false;
                appDbContext.Layanan.Remove(model);
            }
            int result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    #endregion Layanan
}