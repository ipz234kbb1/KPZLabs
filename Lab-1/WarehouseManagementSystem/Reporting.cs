using System;
using System.Collections.Generic;
using System.Linq;

namespace WarehouseManagementSystem
{
    public class Reporting
    {
        public string GenerateIncomingInvoice(List<InvoiceItem> items, string invoiceNumber)
        {
            return GenerateInvoice(items, invoiceNumber, "INCOMING");
        }

        public string GenerateOutgoingInvoice(List<InvoiceItem> items, string invoiceNumber)
        {
            return GenerateInvoice(items, invoiceNumber, "OUTGOING");
        }

        private string GenerateInvoice(List<InvoiceItem> items, string invoiceNumber, string type)
        {
            decimal totalUah = 0;
            decimal totalUsd = 0;
            
            string header = $"{type} INVOICE #{invoiceNumber}\nDate: {DateTime.Now.ToShortDateString()}\n" +
                           $"----------------------------------------\n" +
                           $"Product                  Qty    Price\n" +
                           $"----------------------------------------";
            string body = "";
            
            foreach (var item in items)
            {
                body += $"\n{item.Product.Name.PadRight(25)} {item.Quantity.ToString().PadLeft(3)} {item.Price.Display().PadLeft(10)}";
                decimal itemTotal = item.Price.GetAmount() * item.Quantity;
                
                if (item.Price is UahMoney)
                {
                    totalUah += itemTotal;
                }
                else
                {
                    totalUsd += itemTotal;
                }
            }
            
            string totalString = "";
            if (totalUsd > 0)
            {
                int wholeUsd = (int)Math.Floor(totalUsd);
                int fractionalUsd = (int)Math.Round((totalUsd - wholeUsd) * 100);
                Money usdMoney = new Money(wholeUsd, fractionalUsd, "$");
                totalString += usdMoney.Display();
            }
            
            if (totalUah > 0)
            {
                if (totalUsd > 0) totalString += " + ";
                int wholeUah = (int)Math.Floor(totalUah);
                int fractionalUah = (int)Math.Round((totalUah - wholeUah) * 100);
                Money uahMoney = new UahMoney(wholeUah, fractionalUah);
                totalString += uahMoney.Display();
            }
            
            string footer = $"----------------------------------------\n" +
                           $"TOTAL: {totalString}\n" +
                           $"----------------------------------------";
            
            return $"{header}{body}\n{footer}";
        }

        public string GenerateInventoryReport(List<WarehouseItem> inventory)
        {
            string report = "INVENTORY REPORT\n" +
                         "Date: " + DateTime.Now.ToShortDateString() + "\n" +
                         "----------------------------------------\n" +
                         "Product                  Qty    Last Delivery\n" +
                         "----------------------------------------";
            
            foreach (var item in inventory)
            {
                report += $"\n{item.Product.Name.PadRight(25)} {item.Quantity.ToString().PadLeft(3)} {item.LastDeliveryDate.ToShortDateString().PadLeft(15)}";
            }
            
            report += "\n----------------------------------------\n" +
                    "Total Products: " + inventory.Count + "\n" +
                    "Total Items: " + inventory.Sum(i => i.Quantity) + "\n" +
                    "----------------------------------------";
            
            return report;
        }
    }
}