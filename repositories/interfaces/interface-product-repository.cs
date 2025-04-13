using rice_store.models;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync(ProductFilter filter);
    Task<Product> GetProductByIdAsync(int id);
    Task<Product> AddProductAsync(Product product);
    Task<Product> UpdateProductAsync(Product product);
    Task DeleteProductAsync(int id);
}
