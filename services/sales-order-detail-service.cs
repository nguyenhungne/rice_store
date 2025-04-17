using rice_store.models;

public interface ISalesOrderDetailService
{
    Task<IEnumerable<SalesOrderDetail>> GetAllSalesOrderDetailsAsync();
    Task<SalesOrderDetail> GetSalesOrderDetailByIdAsync(int id);
    Task<IEnumerable<SalesOrderDetail>> GetSalesOrderDetailsByWarehouseIdAsync(int warehouseId);
    Task<SalesOrderDetail> AddSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail);
    Task<SalesOrderDetail> UpdateSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail);
    Task DeleteSalesOrderDetailAsync(int id);
}

public class SalesOrderDetailService : ISalesOrderDetailService
{
    private readonly ISalesOrderDetailRepository _salesOrderDetailRepository;

    public SalesOrderDetailService(ISalesOrderDetailRepository salesOrderDetailRepository)
    {
        _salesOrderDetailRepository = salesOrderDetailRepository;
    }

    public async Task<IEnumerable<SalesOrderDetail>> GetAllSalesOrderDetailsAsync()
    {
        return await _salesOrderDetailRepository.GetAllSalesOrderDetailsAsync();
    }

    public async Task<SalesOrderDetail> GetSalesOrderDetailByIdAsync(int id)
    {
        return await _salesOrderDetailRepository.GetSalesOrderDetailByIdAsync(id)
            ?? throw new InvalidOperationException($"SalesOrderDetail with ID {id} not found.");
    }

    public async Task<IEnumerable<SalesOrderDetail>> GetSalesOrderDetailsByWarehouseIdAsync(int warehouseId)
    {
        return await _salesOrderDetailRepository.GetSalesOrderDetailsByWarehouseIdAsync(warehouseId);
    }

    public async Task<SalesOrderDetail> AddSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail)
    {
        return await _salesOrderDetailRepository.AddSalesOrderDetailAsync(salesOrderDetail);
    }

    public async Task<SalesOrderDetail> UpdateSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail)
    {
        var existingSalesOrderDetail = await _salesOrderDetailRepository.GetSalesOrderDetailByIdAsync(salesOrderDetail.Id);
        if (existingSalesOrderDetail == null)
        {
            throw new InvalidOperationException($"SalesOrderDetail with ID {salesOrderDetail.Id} not found.");
        }

        existingSalesOrderDetail.Quantity = salesOrderDetail.Quantity;
        existingSalesOrderDetail.UnitPrice = salesOrderDetail.UnitPrice;
        existingSalesOrderDetail.SalesOrderId = salesOrderDetail.SalesOrderId;
        existingSalesOrderDetail.WarehouseId = salesOrderDetail.WarehouseId;

        return await _salesOrderDetailRepository.UpdateSalesOrderDetailAsync(existingSalesOrderDetail);
    }

    public async Task DeleteSalesOrderDetailAsync(int id)
    {
        var salesOrderDetail = await _salesOrderDetailRepository.GetSalesOrderDetailByIdAsync(id);
        if (salesOrderDetail == null)
        {
            throw new InvalidOperationException($"SalesOrderDetail with ID {id} not found.");
        }

        await _salesOrderDetailRepository.DeleteSalesOrderDetailAsync(id);
    }
}
