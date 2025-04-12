using rice_store.models;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProductsAsync(ProductFilter filter);
    Task<Product> GetProductByIdAsync(int id);
}

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync(ProductFilter filter)
    {
        return await _productRepository.GetAllProductsAsync(filter);
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        return await _productRepository.GetProductByIdAsync(id);
    }
}
