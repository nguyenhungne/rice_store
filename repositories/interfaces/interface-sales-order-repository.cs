using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using rice_store.models;
using rice_store.services.type;

public interface ISalesOrderRepository
{
    Task<IEnumerable<SalesOrder>> GetAllSalesOrdersAsync(SalesOrdersFilter? filter = null);
    Task<SalesOrder> GetSalesOrderByIdAsync(int id);
    Task<SalesOrder> AddSalesOrderAsync(SalesOrder salesOrder);
    Task<SalesOrder> UpdateSalesOrderAsync(SalesOrder salesOrder);
    Task<List<SalesReportDTO>> GetFilteredSalesDataAsync(int startMonth, int endMonth, int year);

    Task updateTotalAmountSaleOrderAsync(decimal totalAmount, int saleOrderId);
    Task DeleteSalesOrderAsync(int id);
    Task<decimal> GetTotalAmountByCustomerIdAsync(int customerId);


}
