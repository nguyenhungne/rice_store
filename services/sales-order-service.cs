using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using rice_store.models;
using rice_store.services.type;

public interface ISalesOrderService
{
    Task<IEnumerable<SalesOrder>> GetAllSalesOrdersAsync(SalesOrdersFilter? filter = null);
    Task<SalesOrder> GetSalesOrderByIdAsync(int id);
    Task<SalesOrder> AddSalesOrderAsync(SalesOrder salesOrder);
    Task<List<SalesReportDTO>> GetFilteredSalesDataAsync(int startMonth, int endMonth, int year);
    Task<SalesOrder> UpdateSalesOrderAsync(SalesOrder salesOrder);
    Task DeleteSalesOrderAsync(int id);
}

public class SalesOrderService : ISalesOrderService
{
    private readonly ISalesOrderRepository _salesOrderRepository;

    public SalesOrderService(ISalesOrderRepository salesOrderRepository)
    {
        _salesOrderRepository = salesOrderRepository;
    }

    public async Task<IEnumerable<SalesOrder>> GetAllSalesOrdersAsync(SalesOrdersFilter? filter = null)
    {
        return await _salesOrderRepository.GetAllSalesOrdersAsync(filter);
    }

    public async Task<List<SalesReportDTO>> GetFilteredSalesDataAsync(int startMonth, int endMonth, int year)
    {
        return await _salesOrderRepository.GetFilteredSalesDataAsync(startMonth, endMonth, year);
    }

    public async Task<SalesOrder> GetSalesOrderByIdAsync(int id)
    {
        return await _salesOrderRepository.GetSalesOrderByIdAsync(id);
    }

    public async Task<SalesOrder> AddSalesOrderAsync(SalesOrder salesOrder)
    {
        return await _salesOrderRepository.AddSalesOrderAsync(salesOrder);
    }

    public async Task<SalesOrder> UpdateSalesOrderAsync(SalesOrder salesOrder)
    {
        return await _salesOrderRepository.UpdateSalesOrderAsync(salesOrder);
    }

    public async Task DeleteSalesOrderAsync(int id)
    {
        await _salesOrderRepository.DeleteSalesOrderAsync(id);
    }
}
