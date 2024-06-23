namespace Salon.Shared.Repositories;

/// <summary>
/// GET Includable :
/// <br/>
/// • One to Many - <see cref="Transaksi"/>
/// </summary>
public interface ICustomerRepository
{
    #region Customer

    Task<List<Customer>> GetAsync(List<string> includes = null!);

    Task<Customer> FindAsync(string id, List<string> includes = null!);

    Task<bool> AddAsync(Customer customer);

    Task<bool> UpdateAsync(Customer customer);

    Task<bool> DeleteAsync(string id);

    #endregion Customer
}

public class CustomerRepository(AppDbContext appDbContext) : ICustomerRepository
{
    #region Customer

    public async Task<List<Customer>> GetAsync(List<string> includes = null!)
    {
        try
        {
            IQueryable<Customer> models = appDbContext.Customer;

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

    public async Task<Customer> FindAsync(string id, List<string> includes = null!)
    {
        try
        {
            IQueryable<Customer> model = appDbContext.Customer;

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

    public async Task<bool> AddAsync(Customer customer)
    {
        try
        {
            customer.Id = GenerateId(await appDbContext.Customer.Select(x => x.Id).ToListAsync(), 5, "C");
            var model = await appDbContext.Customer.AddAsync(customer);
            int result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<bool> UpdateAsync(Customer customer)
    {
        try
        {
            Customer model = (await appDbContext.Customer.FirstOrDefaultAsync(x => x.Id == customer.Id))!;
            if (model != null)
            {
                model.Nama = customer.Nama;
                model.JenisKelamin = customer.JenisKelamin;
                model.TanggalLahir = customer.TanggalLahir;
                model.Alamat = customer.Alamat;
                model.Telepon = customer.Telepon;
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
            Customer model = (await appDbContext.Customer.FirstOrDefaultAsync(x => x.Id == id))!;
            if (model != null)
            {
                bool removable = await appDbContext.Customer.Include(x => x.Transaksi).AnyAsync(x => x.Id == id && x.Transaksi.Count == 0);
                if (!removable) return false;
                appDbContext.Customer.Remove(model);
            }
            int result = await appDbContext.SaveChangesAsync();
            return result > 0;
        }
        catch (Exception)
        {
            return false;
        }
    }

    #endregion Customer
}