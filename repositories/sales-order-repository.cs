using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using rice_store.data;
using rice_store.models;

public class SalesOrderRepository : ISalesOrderRepository
{
    private readonly AppDbContext _context;

    public SalesOrderRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<SalesOrder>> GetAllSalesOrdersAsync()
    {
        return await _context.SalesOrder
                             .Include(s => s.Customer) // Optional: Include related customer data
                             .ToListAsync();
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

    public async Task updateTotalAmountSaleOrderAsync(decimal totalAmount, int saleOrderId)
    {
        // Tìm ??n hàng theo ID
        var saleOrder = await _context.SalesOrder.FindAsync(saleOrderId);

        if (saleOrder == null)
        {
            throw new Exception($"Không tìm th?y ??n hàng v?i ID = {saleOrderId}");
        }

        // C?p nh?t giá tr? TotalAmount
        saleOrder.Total_amount = totalAmount;

        // L?u thay ??i vào database
        await _context.SaveChangesAsync();
    }
}
