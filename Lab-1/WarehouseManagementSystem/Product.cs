using System;

namespace WarehouseManagementSystem
{
    public class Product
    {
        public string Name { get; private set; }
        public string MeasureUnit { get; private set; }
        public Money Price { get; private set; }
        public ProductCategory Category { get; private set; }
        
        public Product(string name, string measureUnit, Money price, ProductCategory category = ProductCategory.Other)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            MeasureUnit = measureUnit ?? throw new ArgumentNullException(nameof(measureUnit));
            Price = price ?? throw new ArgumentNullException(nameof(price));
            Category = category;
        }
        
        public void ReducePrice(decimal percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percentage), "Percentage must be between 0 and 100");
            }
            
            decimal currentAmount = Price.GetAmount();
            decimal newAmount = currentAmount * (1 - percentage / 100);
            
            int wholePart = (int)Math.Floor(newAmount);
            int fractionalPart = (int)Math.Round((newAmount - wholePart) * 100);
            
            Price.SetAmount(wholePart, fractionalPart);
        }
        
        public override string ToString()
        {
            return $"{Name} ({MeasureUnit}) - {Price.Display()} - Category: {Category}";
        }
    }
}