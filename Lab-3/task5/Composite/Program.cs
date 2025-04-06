using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var table = new LightElementNode("table");
            table.AddCssClass("data-table");
            table.AddCssClass("striped");
            
            var thead = new LightElementNode("thead");
            var headerRow = new LightElementNode("tr");
            
            string[] headers = { "ID", "Name", "Position", "Department" };
            foreach (var header in headers)
            {
                var th = new LightElementNode("th");
                th.AddChild(new LightTextNode(header));
                headerRow.AddChild(th);
            }
            
            thead.AddChild(headerRow);
            table.AddChild(thead);
            
            var tbody = new LightElementNode("tbody");
            
            TableBuilder.AddTableRow(tbody, "1", "John Smith", "Developer", "IT");
            TableBuilder.AddTableRow(tbody, "2", "Jane Doe", "Manager", "HR");
            TableBuilder.AddTableRow(tbody, "3", "Bob Johnson", "Designer", "Marketing");
            
            table.AddChild(tbody);
            
            Console.WriteLine("Table HTML Output:");
            Console.WriteLine(table.RenderOuterHTML());
            
            Console.WriteLine("\nInner HTML of tbody:");
            Console.WriteLine(tbody.RenderInnerHTML());
            
            Console.WriteLine($"\nTable child count: {table.ChildCount}");
            Console.WriteLine($"Table header row child count: {headerRow.ChildCount}");
            Console.WriteLine($"Table body child count: {tbody.ChildCount}");
            
            Console.ReadLine();
        }
    }
}