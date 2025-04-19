using rice_store.models;

public interface ISupplierService
{
    Task<IEnumerable<Supplier>> GetAllSuppliersAsync();
    Task<Supplier> GetSupplierByIdAsync(int id);
    Task<Supplier> AddSupplierAsync(Supplier supplier);
    Task<Supplier> UpdateSupplierAsync(Supplier supplier);
    Task DeleteSupplierAsync(int id);
}

public class SupplierService : ISupplierService
{
    private readonly ISupplierRepository _supplierRepository;

    public SupplierService(ISupplierRepository supplierRepository)
    {
        _supplierRepository = supplierRepository;
    }

    public async Task<IEnumerable<Supplier>> GetAllSuppliersAsync()
    {
        return await _supplierRepository.GetAllSuppliersAsync();
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
}
