using System.Diagnostics;

using rice_store.models;
using rice_store.services.type;
using rice_store.utils;

public interface ISalesOrderDetailService
{
    Task<IEnumerable<SalesOrderDetail>> GetAllSalesOrderDetailsAsync();
    Task<SalesOrderDetail> GetSalesOrderDetailByIdAsync(int id);
    Task<IEnumerable<SalesOrderDetail>> GetSalesOrderDetailsByWarehouseIdAsync(int warehouseId);
    Task<SalesOrderDetail> AddSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail);
    Task<List<SalesOrderDetail>> AddInvoicesAsync(AddingSalesOrderDetailData addingSalesOrdersDetailData);
    Task<SalesOrderDetail> UpdateSalesOrderDetailAsync(SalesOrderDetail salesOrderDetail);
    Task DeleteSalesOrderDetailAsync(int id);
    Task<IEnumerable<SalesOrderDetail>> GetAllSalesOrderDetailByOrderID(int OrderId);

    Task<IEnumerable<InvoiceDetailDTO>> GetAllSalesOrderDetailByOrderIDAndWarehouseID(int orderId, IEnumerable<int> warehouseIds);
}

public class SalesOrderDetailService : ISalesOrderDetailService
{
    private readonly ISalesOrderDetailRepository _salesOrderDetailRepository;
    private readonly ISalesOrderRepository _salesOrderRepository;
    private readonly ICustomerRepository _customerRepository;
    private readonly IPurchaseOrderDetailRepository _purchaseOrderDetailRepository;

    public SalesOrderDetailService(ISalesOrderDetailRepository salesOrderDetailRepository, ISalesOrderRepository salesOrderRepository, ICustomerRepository customerRepository, IPurchaseOrderDetailRepository purchaseOrderDetailRepository)
    {
        _salesOrderDetailRepository = salesOrderDetailRepository;
        _salesOrderRepository = salesOrderRepository;
        _customerRepository = customerRepository;
        _purchaseOrderDetailRepository = purchaseOrderDetailRepository;
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

    public async Task<List<SalesOrderDetail>> AddInvoicesAsync(AddingSalesOrderDetailData addingSalesOrdersDetailData)
    {
        List<SalesOrderDetail> salesOrderDetails = new List<SalesOrderDetail>();
        //foreach (AddingSalesOrderDetailData detailData in addingSalesOrdersDetailData)
        //{

        //    AddingSalesOrder addingSalesOrder = detailData.salesOrder;
        //    AddingSalesOrderDetail addingSalesOrderDetail = detailData.salesOrderDetail;

        //    SalesOrder createdSalesOrder = await _salesOrderRepository.AddSalesOrderAsync(new SalesOrder
        //    {
        //        OrderDate = addingSalesOrder.orderDate,
        //        PaymentMethod = addingSalesOrder.paymentMethod,
        //        Status = "Completed",
        //        CustomerId = addingSalesOrder.customerId
        //    });

        //    SalesOrderDetail salesOrderDetail = await _salesOrderDetailRepository.AddSalesOrderDetailAsync(new SalesOrderDetail
        //    {
        //       // Quantity = addingSalesOrderDetail.quantity,
        //        UnitPrice = addingSalesOrderDetail.unitPrice,
        //        SalesOrderId = createdSalesOrder.Id,
        //        WarehouseId = addingSalesOrderDetail.warehouseId
        //    });

        //    salesOrderDetails.Add(salesOrderDetail);
        //}

        AddingSalesOrder addingSalesOrder = addingSalesOrdersDetailData.salesOrder;


        SalesOrder newOrder = await _salesOrderRepository.AddSalesOrderAsync(new SalesOrder
        {
            OrderDate = addingSalesOrder.orderDate,
            PaymentMethod = addingSalesOrder.paymentMethod,
            Status = "Completed",
            CustomerId = addingSalesOrder.customerId
        });

        foreach (AddingSalesOrderDetail detail in addingSalesOrdersDetailData.salesOrderDetail)
        {
            SalesOrderDetail salesOrderDetail = await _salesOrderDetailRepository.AddSalesOrderDetailAsync(new SalesOrderDetail
            {
                Quantity = detail.quantity,
                UnitPrice = detail.unitPrice,
                SalesOrderId = newOrder.Id,
                WarehouseId = detail.warehouseId
            });
            salesOrderDetails.Add(salesOrderDetail);
        }

        IEnumerable<SalesOrderDetail> listOrderDetails = await _salesOrderDetailRepository.GetAllSalesOrderDetailByOrderID(newOrder.Id);

        int customerId = addingSalesOrder.customerId ?? -1;


        //tinh tien------------------------
        decimal totalAmount = 0;

        foreach (SalesOrderDetail orderItem in listOrderDetails)
        {
            totalAmount += (orderItem.Quantity * orderItem.UnitPrice);
        }

        Customer customer = await _customerRepository.GetCustomerByIdAsync(customerId);

        string customerRank = customer != null ? customer.Rank : "Không có";

        decimal totalAmountNew = CustomerUtils.GetTotalAmountAfterDiscount(totalAmount, customerRank);

        await _salesOrderRepository.updateTotalAmountSaleOrderAsync(totalAmountNew, newOrder.Id);


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

    public async Task<IEnumerable<InvoiceDetailDTO>> GetAllSalesOrderDetailByOrderIDAndWarehouseID(int orderId, IEnumerable<int> warehouseIds)
    {
        List<InvoiceDetailDTO> invoiceDetails = new List<InvoiceDetailDTO>();

        foreach (int warehouseId in warehouseIds)
        {
            IEnumerable<SalesOrderDetail> salesOrderDetails = await _salesOrderDetailRepository.GetAllSalesOrderDetailByOrderIDAndWarehouseID(orderId, warehouseId);
            decimal totalAmount = 0;
            decimal totalQuantity = 0;

            foreach (SalesOrderDetail salesOrderDetail in salesOrderDetails)
            {
                totalAmount += salesOrderDetail.Quantity * salesOrderDetail.UnitPrice;
                totalQuantity += salesOrderDetail.Quantity;
            }
            invoiceDetails.Add(new InvoiceDetailDTO
            {
                ProductName = salesOrderDetails.First().Warehouse.Product.Name,
                Quantity = totalQuantity.ToString(),
                UnitPrice = salesOrderDetails.First().UnitPrice.ToString(),
                TotalPrice = totalAmount.ToString(),
            });
        }
        return invoiceDetails;
    }

    public async Task<IEnumerable<SalesOrderDetail>> GetAllSalesOrderDetailByOrderID(int OrderId)
    {
        return await _salesOrderDetailRepository.GetAllSalesOrderDetailByOrderID(OrderId);
    }



}
