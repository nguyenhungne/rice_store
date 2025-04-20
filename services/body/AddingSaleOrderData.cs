using rice_store.models;

public class AddingSalesOrder
{
    public int? customerId { get; set; }
    public DateTime orderDate { get; set; }
    public string paymentMethod { get; set; }
    public string status { get; set; }
}

public class AddingSalesOrderDetail
{
    public int warehouseId { get; set; }
    public int quantity { get; set; }
    public decimal unitPrice { get; set; }
}

public class AddingSalesOrderDetailData
{
    public required AddingSalesOrder salesOrder { get; set; }
    public required AddingSalesOrderDetail salesOrderDetail { get; set;}
}
