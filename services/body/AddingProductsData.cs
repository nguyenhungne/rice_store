using rice_store.models;

public class AddingWarehouseData
{
    public int productId { get; set; }
    public int inventoryId { get; set; }
    public string batchNumber { get; set; }
    public int minThreshold { get; set; }
    public DateTime expirationDate { get; set; }
    public string productName { get; set; }
}

public class AddingPurchaseOrderDetailData
{
    public int quantity { get; set; }
    public decimal unitPrice { get; set; }
}

public class AddingPurchaseOrderData
{
    public int supplierId { get; set; }
    public string supplierName { get; set; }
    public DateTime orderDate { get; set; }
}

public class AddingProductsData
{
    public AddingWarehouseData warehouse { get; set; }
    public AddingPurchaseOrderDetailData purchaseOrderDetail { get; set; }
    public AddingPurchaseOrderData purchaseOrder { get; set; }
}
