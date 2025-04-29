using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using rice_store.models;

public interface ISalesOrderRepository
{
    Task<IEnumerable<SalesOrder>> GetAllSalesOrdersAsync();
    Task<SalesOrder> GetSalesOrderByIdAsync(int id);
    Task<SalesOrder> AddSalesOrderAsync(SalesOrder salesOrder);
    Task<SalesOrder> UpdateSalesOrderAsync(SalesOrder salesOrder);

    Task updateTotalAmountSaleOrderAsync(decimal totalAmount, int saleOrderId);
    Task DeleteSalesOrderAsync(int id);
    Task<decimal> GetTotalAmountByCustomerIdAsync(int customerId);


}
