using System;
using System.Collections.Generic;

namespace WarehouseManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            var uahMoney = new UahMoney(100, 50);
            var dollarMoney = new Money(25, 99, "$");
            
            Console.WriteLine("Приклад роботи з валютами:");
            Console.WriteLine($"Гривня: {uahMoney.Display()}");
            Console.WriteLine($"Долар: {dollarMoney.Display()}");
            Console.WriteLine();
            var laptop = new Product("Laptop", "pcs", new Money(1000, 0, "$"), ProductCategory.Electronics);
            var flour = new Product("Flour", "kg", new UahMoney(30, 50), ProductCategory.Food);
            var shirt = new Product("Shirt", "pcs", new Money(25, 99, "$"), ProductCategory.Clothing);
            Console.WriteLine("Продукти:");
            Console.WriteLine(laptop);
            Console.WriteLine(flour);
            Console.WriteLine(shirt);
            Console.WriteLine();
            Console.WriteLine("Зменшення ціни на товари:");
            laptop.ReducePrice(10);
            flour.ReducePrice(5);
            Console.WriteLine($"{laptop.Name} після знижки 10%: {laptop.Price.Display()}");
            Console.WriteLine($"{flour.Name} після знижки 5%: {flour.Price.Display()}");
            Console.WriteLine();
            
            var warehouse = new Warehouse();
            
            Console.WriteLine("Додавання товарів на склад:");
            warehouse.AddProduct(laptop, 10);
            warehouse.AddProduct(flour, 50);
            warehouse.AddProduct(shirt, 30);

            var inventory = warehouse.GetInventory();
            Console.WriteLine("Інвентар:");
            foreach (var item in inventory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
            var reporting = new Reporting();
            
            var invoiceItems = new List<InvoiceItem>
            {
                new InvoiceItem(laptop, 2),
                new InvoiceItem(flour, 5)
            };
            
            var incomingInvoice = reporting.GenerateIncomingInvoice(invoiceItems, "IN-2025-001");
            Console.WriteLine("Прибуткова накладна:");
            Console.WriteLine(incomingInvoice);
            Console.WriteLine();
            
            warehouse.RemoveProduct("Laptop", 1);
            
            var outgoingItems = new List<InvoiceItem>
            {
                new InvoiceItem(laptop, 1)
            };
            var outgoingInvoice = reporting.GenerateOutgoingInvoice(outgoingItems, "OUT-2025-001");
            Console.WriteLine("Видаткова накладна:");
            Console.WriteLine(outgoingInvoice);
            Console.WriteLine();
            
            var inventoryReport = reporting.GenerateInventoryReport(warehouse.GetInventory());
            Console.WriteLine("Звіт про інвентаризацію:");
            Console.WriteLine(inventoryReport);
        }
    }
}