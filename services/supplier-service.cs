using rice_store.models;

public interface ISupplierService
{
    Task<IEnumerable<Supplier>> GetAllSuppliersAsync(SupplierFilter? filter = null);
    Task<Supplier> GetSupplierByIdAsync(int id);
    Task<Supplier> AddSupplierAsync(Supplier supplier);
    Task<Supplier> UpdateSupplierAsync(Supplier supplier);
    Task DeleteSupplierAsync(int id);

    Task<bool> CheckEmailExistsAsync(string email);
}

public class SupplierService : ISupplierService
{
    private readonly ISupplierRepository _supplierRepository;

    public SupplierService(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }

    public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync(SupplierFilter? filter = null)
    {
        return await _supplierRepository.GetAllSuppliersAsync(filter);
    }

    public async Task<Supplier> GetSupplierByIdAsync(int id)
    {
        return await _supplierRepository.GetSupplierByIdAsync(id);
    }

    public async Task<Supplier> AddSupplierAsync(Supplier supplier)
    {
        return await _supplierRepository.AddSupplierAsync(supplier);
    }

    public async Task<Supplier> UpdateSupplierAsync(Supplier supplier)
    {
        return await _supplierRepository.UpdateSupplierAsync(supplier);
    }

    public async Task DeleteSupplierAsync(int id)
    {
        await _supplierRepository.DeleteSupplierAsync(id);
    }

    public async Task<bool> CheckEmailExistsAsync(string email)
    {
        return await _supplierRepository.CheckEmailExistsAsync(email);
    }
}
