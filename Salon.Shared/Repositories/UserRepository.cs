using static Salon.Shared.Extensions.EncryptionHelper;

namespace Salon.Shared.Repositories;

/// <summary>
/// GET Includable :
/// <br/>
/// • One to Many - <see cref="Transaksi"/>
/// </summary>
public interface IUserRepository
{
    Task<List<User>> GetAsync(List<string> includes = null!);

    Task<User> FindAsync(string id, List<string> includes = null!);

    Task<User> LoginAsync(string id, string password);

    Task<bool> AddAsync(User user);

    Task<bool> UpdateAsync(User user);

    Task<bool> DeleteAsync(string id);
}

public class UserRepository(AppDbContext appDbContext) : IUserRepository
{
    public async Task<List<User>> GetAsync(List<string> includes = null!)
    {
        try
        {
            IQueryable<User> models = appDbContext.User;

            if (includes != null)
            {
                if (includes.Contains(nameof(Transaksi))) models = models.Include(x => x.Transaksi);
            }

            return await models.OrderBy(x => x.Nama).ToListAsync();
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<User> FindAsync(string id, List<string> includes = null!)
    {
        try
        {
            IQueryable<User> model = appDbContext.User;

            if (includes != null)
            {
                if (includes.Contains(nameof(Transaksi))) model = model.Include(x => x.Transaksi);
            }

            return (await model.FirstOrDefaultAsync(x => x.Id == id))!;
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<User> LoginAsync(string id, string password)
    {
        try
        {
            IQueryable<User> model = appDbContext.User;

            return (await model.FirstOrDefaultAsync(x => x.Id == id && x.Password == Encrypt(password)))!;
        }
        catch (Exception)
        {
            return null!;
        }
    }

    public async Task<bool> AddAsync(User user)
    {
        try
        {
            user.Password = Encrypt(user.Password);
            var model = await appDbContext.User.AddAsync(user);
            int result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> UpdateAsync(User user)
    {
        try
        {
            User model = (await appDbContext.User.FirstOrDefaultAsync(x => x.Id == user.Id))!;
            if (model != null)
            {
                model.Password = Encrypt(user.Password);
                model.Nama = user.Nama;
                model.JenisKelamin = user.JenisKelamin;
                model.Telepon = user.Telepon;
                model.JenisUser = user.JenisUser;
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
            User model = (await appDbContext.User.FirstOrDefaultAsync(x => x.Id == id))!;
            if (model != null)
            {
                appDbContext.User.Remove(model);
            }
            int result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }
}