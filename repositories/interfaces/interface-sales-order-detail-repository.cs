using rice_store.models;

public interface ISalesOrderDetailRepository
{
    Task<IEnumerable<SalesOrderDetail>> GetAllSalesOrderDetailsAsync();
    Task<SalesOrderDetail> GetSalesOrderDetailByIdAsync(int id);
    Task<IEnumerable<SalesOrderDetail>> GetSalesOrderDetailsByWarehouseIdAsync(int warehouseId);
    Task<SalesOrderDetail> AddSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail);
    Task<SalesOrderDetail> UpdateSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail);
    Task DeleteSalesOrderDetailAsync(int id);
}
