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

    public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
    {
        return await _context.Supplier.ToListAsync();
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

        _context.Supplier.Remove(supplier);
        await _context.SaveChangesAsync();
    }
}
