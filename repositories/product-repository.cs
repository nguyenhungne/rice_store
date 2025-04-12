using rice_store.data;
using rice_store.models;
using Microsoft.EntityFrameworkCore;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _context.Product
            .Include(p => p.Category) // Include related Category
            .ToListAsync();
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _context.Product
            .Include(p => p.Category) // Include related Category
            .FirstOrDefaultAsync(p => p.Id == id)
            ?? throw new InvalidOperationException($"Product with ID {id} not found.");
    }
}
