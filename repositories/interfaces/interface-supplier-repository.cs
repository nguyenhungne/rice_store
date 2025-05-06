using rice_store.models;

public interface ISupplierRepository
{
    Task<IEnumerable<Supplier>> GetAllSuppliersAsync(SupplierFilter? filter = null);
    Task<Supplier> GetSupplierByIdAsync(int id);
    Task<Supplier> AddSupplierAsync(Supplier supplier);
    Task<Supplier> UpdateSupplierAsync(Supplier supplier);
    Task DeleteSupplierAsync(int id);
    Task<bool> CheckEmailExistsAsync(string email);
}
