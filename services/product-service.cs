using rice_store.models;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProductsAsync(ProductFilter filter);
    Task<Product> GetProductByIdAsync(int id);
    Task<Product> AddProductAsync(Product product);
    Task<Product> UpdateProductAsync(Product product);
    Task DeleteProductAsync(int id);
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
    public async Task<Product> AddProductAsync(Product product)
    {
        return await _productRepository.AddProductAsync(product);
    }

    public async Task<Product> UpdateProductAsync(Product product)
    {
        return await _productRepository.UpdateProductAsync(product);
    }

    public async Task DeleteProductAsync(int id)
    {
        await _productRepository.DeleteProductAsync(id);
    }
}
