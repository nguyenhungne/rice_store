using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using rice_store.data;
using rice_store.models;
using rice_store.services.type;

public class SalesOrderRepository : ISalesOrderRepository
{
    private readonly AppDbContext _context;

    public SalesOrderRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SalesOrder>> GetAllSalesOrdersAsync(SalesOrdersFilter? filter = null)
    {
        var query = _context.SalesOrder.Include(s => s.Customer)
                                    .IgnoreQueryFilters();

        if (filter != null)
        {
            if (filter.CustomerId.HasValue)
            {
                query = query.Where(s => s.CustomerId == filter.CustomerId.Value);
            }

            if (filter.StartDate.HasValue && filter.EndDate.HasValue)
            {
                query = query.Where(s => s.OrderDate >= filter.StartDate.Value && s.OrderDate <= filter.EndDate.Value);
            }
            else if (filter.StartDate.HasValue)
            {
                query = query.Where(s => s.OrderDate >= filter.StartDate.Value);
            }
            else if (filter.EndDate.HasValue)
            {
                query = query.Where(s => s.OrderDate <= filter.EndDate.Value);
            }
        }

        return await query.ToListAsync();
    }

    public async Task<SalesOrder> GetSalesOrderByIdAsync(int id)
    {
        return await _context.SalesOrder
                             .Include(s => s.Customer)
                             .FirstOrDefaultAsync(s => s.Id == id)
                             ?? throw new InvalidOperationException($"SalesOrder with ID {id} not found.");
    }

    public async Task<SalesOrder> AddSalesOrderAsync(SalesOrder salesOrder)
    {
        _context.SalesOrder.Add(salesOrder);
        await _context.SaveChangesAsync();
        return salesOrder;
    }

    public async Task<SalesOrder> UpdateSalesOrderAsync(SalesOrder salesOrder)
    {
        var existingOrder = await _context.SalesOrder.FindAsync(salesOrder.Id);
        if (existingOrder == null)
        {
            throw new InvalidOperationException($"SalesOrder with ID {salesOrder.Id} not found.");
        }

        existingOrder.OrderDate = salesOrder.OrderDate;
        existingOrder.PaymentMethod = salesOrder.PaymentMethod;
        existingOrder.Status = salesOrder.Status;
        existingOrder.CustomerId = salesOrder.CustomerId;

        await _context.SaveChangesAsync();
        return existingOrder;
    }

    public async Task DeleteSalesOrderAsync(int id)
    {
        var order = await _context.SalesOrder.FindAsync(id) ?? throw new InvalidOperationException($"SalesOrder with ID {id} not found.");
        _context.SalesOrder.Remove(order);
        await _context.SaveChangesAsync();
    }

    public async Task updateTotalAmountSaleOrderAsync(decimal totalAmount, int saleOrderId, string rankNow)
    {
        // T�m ??n h�ng theo ID
        var saleOrder = await _context.SalesOrder.FindAsync(saleOrderId);

        if (saleOrder == null)
        {
            throw new Exception($"Kh�ng t�m th?y ??n h�ng v?i ID = {saleOrderId}");
        }

        // C?p nh?t gi� tr? TotalAmount
        saleOrder.Total_amount = totalAmount;
        saleOrder.Status = rankNow;

        // L?u thay ??i v�o database
        await _context.SaveChangesAsync();
    }

    public async Task<decimal> GetTotalAmountByCustomerIdAsync(int customerId)
    {
        return await _context.SalesOrder
            .Where(o => o.CustomerId == customerId)
            .SumAsync(o => o.Total_amount);
    }

    public async Task<List<SalesReportDTO>> GetFilteredSalesDataAsync(int startMonth, int endMonth, int year)
    {
        var query = from so in _context.SalesOrder
                    join sod in _context.SalesOrderDetail on so.Id equals sod.SalesOrderId
                    where so.OrderDate.Month >= startMonth && so.OrderDate.Month <= endMonth && so.OrderDate.Year == year
                    group new { so, sod } by so.OrderDate.Month into grouped
                    select new SalesReportDTO
                    {
                        Month = grouped.Key,
                        TotalAmount = grouped.Sum(x => x.sod.Quantity * x.sod.UnitPrice)
                    };

        return await query.ToListAsync();
    }
}
