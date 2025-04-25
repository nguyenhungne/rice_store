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
    public decimal quantity { get; set; }
    public decimal unitPrice { get; set; }
    public int purchaseOrderDetailsId { get; set; }
}

public class AddingSalesOrderDetailData
{
    public required AddingSalesOrder salesOrder { get; set; }
    public required List<AddingSalesOrderDetail> salesOrderDetail { get; set;}
}
