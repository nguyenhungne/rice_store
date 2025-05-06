using rice_store.data;
using rice_store.models;
using Microsoft.EntityFrameworkCore;

public class SupplierRepository : ISupplierRepository
{
    private readonly AppDbContext _context;

    public SupplierRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync(SupplierFilter? filter = null)
    {
        var query = _context.Supplier
            .Where(s => !s.IsDeleted)
            .AsQueryable();

        if (filter != null)
        {
            if (!string.IsNullOrEmpty(filter.Name))
            {
                string name = filter.Name.ToLower();
                query = query.Where(s => s.Name.ToLower().Contains(name));
            }

            if (!string.IsNullOrEmpty(filter.Email))
            {
                string email = filter.Email.ToLower();
                query = query.Where(s => s.Email.ToLower().Contains(email));
            }

            if (!string.IsNullOrEmpty(filter.Phone))
            {
                string phone = filter.Phone.ToLower();
                query = query.Where(s => s.Phone.ToLower().Contains(phone));
            }
        }

        return await query.ToListAsync();
    }

    public async Task<Supplier> GetSupplierByIdAsync(int id)
    {
        return await _context.Supplier
            .FirstOrDefaultAsync(s => s.Id == id)
            ?? throw new InvalidOperationException($"Supplier with ID {id} not found.");
    }

    public async Task<Supplier> AddSupplierAsync(Supplier supplier)
    {
        if (_context.Supplier.Any(s => s.Name == supplier.Name))
        {
            throw new InvalidOperationException("Supplier with this name already exists.");
        }

        _context.Supplier.Add(supplier);
        await _context.SaveChangesAsync();
        return supplier;
    }

    public async Task<Supplier> UpdateSupplierAsync(Supplier supplier)
    {
        var existingSupplier = await _context.Supplier.FindAsync(supplier.Id);
        if (existingSupplier == null)
        {
            throw new InvalidOperationException($"Supplier with ID {supplier.Id} not found.");
        }

        existingSupplier.Name = supplier.Name;
        existingSupplier.Address = supplier.Address;
        existingSupplier.Phone = supplier.Phone;
        existingSupplier.Email = supplier.Email;

        await _context.SaveChangesAsync();
        return existingSupplier;
    }

    public async Task DeleteSupplierAsync(int id)
    {
        var supplier = await _context.Supplier.FindAsync(id);
        if (supplier == null)
        {
            throw new InvalidOperationException($"Supplier with ID {id} not found.");
        }

        try
        {
            _context.Supplier.Remove(supplier);
            await _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            //roll back state entity
            _context.Entry(supplier).State = EntityState.Unchanged;
            throw;
        }
    }

    public async Task<bool> CheckEmailExistsAsync(string email)
    {
        return await _context.Supplier.AnyAsync(s => s.Email == email);
    }
}
