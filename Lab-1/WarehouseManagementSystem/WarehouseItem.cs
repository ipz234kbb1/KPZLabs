namespace WarehouseManagementSystem;

public class WarehouseItem
{
    public Product Product { get; private set; }
    public int Quantity { get; private set; }
    public DateTime LastDeliveryDate { get; private set; }
        
    public WarehouseItem(Product product, int quantity, DateTime lastDeliveryDate)
    {
        Product = product ?? throw new ArgumentNullException(nameof(product));
        Quantity = quantity;
        LastDeliveryDate = lastDeliveryDate;
    }
        
    public void AddQuantity(int quantity)
    {
        if (quantity < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be positive");
        }
        Quantity += quantity;
        LastDeliveryDate = DateTime.Now;
    }
        
    public bool RemoveQuantity(int quantity)
    {
        if (quantity < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity), "Quantity must be positive");
        }
            
        if (Quantity < quantity)
        {
            return false;
        }
            
        Quantity -= quantity;
        return true;
    }
        
    public override string ToString()
    {
        return $"{Product} | Quantity: {Quantity} | Last Delivery: {LastDeliveryDate.ToShortDateString()}";
    }
}
