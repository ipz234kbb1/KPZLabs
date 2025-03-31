using System;
using System.Collections.Generic;
using System.Linq;

namespace WarehouseManagementSystem
{
    public class Warehouse
    {
        private readonly Dictionary<string, WarehouseItem> _inventory;
        
        public Warehouse()
        {
            _inventory = new Dictionary<string, WarehouseItem>();
        }
        
        public bool AddProduct(Product product, int quantity)
        {
            if (product == null || quantity <= 0)
            {
                return false;
            }
            
            if (_inventory.TryGetValue(product.Name, out WarehouseItem? existingItem) && existingItem != null)
            {
                existingItem.AddQuantity(quantity);
            }
            else
            {
                _inventory[product.Name] = new WarehouseItem(product, quantity, DateTime.Now);
            }
            
            return true;
        }

        public bool RemoveProduct(string productName, int quantity)
        {
            if (string.IsNullOrEmpty(productName) || quantity <= 0)
            {
                return false;
            }
            
            if (!_inventory.TryGetValue(productName, out WarehouseItem? item) || item == null)
            {
                return false;
            }
            
            return item.RemoveQuantity(quantity);
        }
        
        public List<WarehouseItem> GetInventory()
        {
            return _inventory.Values.ToList();
        }
        public WarehouseItem? FindProduct(string productName)
        {
            if (string.IsNullOrEmpty(productName))
            {
                return null;
            }
            
            _inventory.TryGetValue(productName, out WarehouseItem? item);
            return item;
        }
    }
}