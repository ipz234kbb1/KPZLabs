namespace WarehouseManagementSystem;

public class InvoiceItem
{
    public Product Product { get; }
    public int Quantity { get; }
    public Money Price { get; }
        
    public InvoiceItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
        Price = product.Price.Clone();
    }
}