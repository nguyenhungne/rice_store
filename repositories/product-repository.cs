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

    public async Task<IEnumerable<Product>> GetAllProductsAsync(ProductFilter filter)
{
    var query = _context.Product.AsQueryable();

    // Apply filter for Product ID (Mã SP) if provided
    if (!string.IsNullOrEmpty(filter.ProductId))
    {
        query = query.Where(p => p.Id.ToString().Contains(filter.ProductId));
    }

    // Apply filter for Product Name (Tên SP) if provided
    if (!string.IsNullOrEmpty(filter.ProductName))
    {
        query = query.Where(p => p.Name.Contains(filter.ProductName));
    }

    // Apply filter for Category Name (Loại SP) if provided
    if (!string.IsNullOrEmpty(filter.CategoryName))
    {
        query = query.Where(p => p.Category.Name.Contains(filter.CategoryName));
    }

    // Include the related Category data
    return await query.Include(p => p.Category).ToListAsync();
}

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _context.Product
            .Include(p => p.Category) // Include related Category
            .FirstOrDefaultAsync(p => p.Id == id)
            ?? throw new InvalidOperationException($"Product with ID {id} not found.");
    }
}
