using rice_store.models;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync(ProductFilter filter);
    Task<Product> GetProductByIdAsync(int id);
}
