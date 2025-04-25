using rice_store.models;

public class WarehouseDTO
{
    public int Id { get; set; }
    public string BatchNumber { get; set; }
    public int MinThreshold { get; set; }
    public DateTime ExpirationDate { get; set; }
    public decimal totalInboundQuantity { get; set; }
    public decimal totalSalesQuantity { get; set; }

    public Product Product { get; set; }
    public Inventory Inventory { get; set; }
}
