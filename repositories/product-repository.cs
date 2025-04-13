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
    if (!string.IsNullOrEmpty(filter.CategoryId.ToString()))
    {
       query = query.Where(p => p.Category.Id == filter.CategoryId);
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

    public async Task<Product> AddProductAsync(Product product)
    {
        if (_context.Product.Any(p => p.Name == product.Name))
        {
            throw new InvalidOperationException("Product already exists.");
        }

        _context.Product.Add(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<Product> UpdateProductAsync(Product product)
    {
        var existingProduct = await _context.Product.FindAsync(product.Id);
        if (existingProduct == null)
        {
            throw new InvalidOperationException($"Product with ID {product.Id} not found.");
        }

        existingProduct.Name = product.Name;
        existingProduct.Origin = product.Origin;
        existingProduct.Weight = product.Weight;
        existingProduct.PurchasePrice = product.PurchasePrice;
        existingProduct.SellingPrice = product.SellingPrice;
        existingProduct.ExpirationDate = product.ExpirationDate;
        existingProduct.CategoryId = product.CategoryId;

        await _context.SaveChangesAsync();
        return existingProduct;
    }

    public async Task DeleteProductAsync(int id)
    {
        Product product = await _context.Product.FindAsync(id) ?? throw new InvalidOperationException($"Product with ID {id} not found.");
        _context.Product.Remove(product);
        await _context.SaveChangesAsync();
    }
}
