using rice_store.models;

public interface ISalesOrderDetailService
{
    Task<IEnumerable<SalesOrderDetail>> GetAllSalesOrderDetailsAsync();
    Task<SalesOrderDetail> GetSalesOrderDetailByIdAsync(int id);
    Task<IEnumerable<SalesOrderDetail>> GetSalesOrderDetailsByWarehouseIdAsync(int warehouseId);
    Task<SalesOrderDetail> AddSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail);
    Task<List<SalesOrderDetail>> AddInvoicesAsync(List<AddingSalesOrderDetailData> addingSalesOrdersDetailData);
    Task<SalesOrderDetail> UpdateSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail);
    Task DeleteSalesOrderDetailAsync(int id);
}

public class SalesOrderDetailService : ISalesOrderDetailService
{
    private readonly ISalesOrderDetailRepository _salesOrderDetailRepository;
    private readonly ISalesOrderRepository _salesOrderRepository;

    public SalesOrderDetailService(ISalesOrderDetailRepository salesOrderDetailRepository, ISalesOrderRepository salesOrderRepository)
    {
        _salesOrderDetailRepository = salesOrderDetailRepository;
        _salesOrderRepository = salesOrderRepository;
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

    public async Task<List<SalesOrderDetail>> AddInvoicesAsync(List<AddingSalesOrderDetailData> addingSalesOrdersDetailData)
    {
        List<SalesOrderDetail> salesOrderDetails = new List<SalesOrderDetail>();
        foreach (AddingSalesOrderDetailData detailData in addingSalesOrdersDetailData)
        {

            AddingSalesOrder addingSalesOrder = detailData.salesOrder;
            AddingSalesOrderDetail addingSalesOrderDetail = detailData.salesOrderDetail;

            SalesOrder createdSalesOrder = await _salesOrderRepository.AddSalesOrderAsync(new SalesOrder
            {
                OrderDate = addingSalesOrder.orderDate,
                PaymentMethod = addingSalesOrder.paymentMethod,
                Status = "Completed",
                CustomerId = addingSalesOrder.customerId
            });

            SalesOrderDetail salesOrderDetail = await _salesOrderDetailRepository.AddSalesOrderDetailAsync(new SalesOrderDetail
            {
                Quantity = addingSalesOrderDetail.quantity,
                UnitPrice = addingSalesOrderDetail.unitPrice,
                SalesOrderId = createdSalesOrder.Id,
                WarehouseId = addingSalesOrderDetail.warehouseId
            });

           salesOrderDetails.Add(salesOrderDetail);
        }

        return salesOrderDetails;
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
