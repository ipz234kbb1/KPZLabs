using System;
using System.IO;
using System.Net;
namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "romeo_and_juliet.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Downloading the book...");
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://www.gutenberg.org/cache/epub/1513/pg1513.txt", filePath);
                }
                Console.WriteLine("Book downloaded successfully.");
            }
            
            Console.WriteLine("\n--- Converting book to HTML without Flyweight pattern ---");
            long initialMemory = MemoryUsageHelper.GetCurrentMemoryUsage();
            Console.WriteLine($"Initial memory usage: {MemoryUsageHelper.FormatMemorySize(initialMemory)}");
            
            var converter = new BookHtmlConverter();
            converter.ConvertBookToHtml(filePath);
            
            long afterStandardMemory = MemoryUsageHelper.GetCurrentMemoryUsage();
            Console.WriteLine($"Memory usage after standard conversion: {MemoryUsageHelper.FormatMemorySize(afterStandardMemory)}");
            Console.WriteLine($"Memory increase: {MemoryUsageHelper.FormatMemorySize(afterStandardMemory - initialMemory)}");
            
            string standardHtml = converter.GetHtml();
            Console.WriteLine($"\nHTML Preview:\n{standardHtml}");
            
            GC.Collect();
            GC.WaitForPendingFinalizers();
            
            Console.WriteLine("\n--- Converting book to HTML with Flyweight pattern ---");
            long beforeFlyweightMemory = MemoryUsageHelper.GetCurrentMemoryUsage();
            Console.WriteLine($"Memory usage before flyweight conversion: {MemoryUsageHelper.FormatMemorySize(beforeFlyweightMemory)}");
            
            converter = new BookHtmlConverter();
            converter.ConvertBookToHtmlWithFlyweight(filePath);
            
            long afterFlyweightMemory = MemoryUsageHelper.GetCurrentMemoryUsage();
            Console.WriteLine($"Memory usage after flyweight conversion: {MemoryUsageHelper.FormatMemorySize(afterFlyweightMemory)}");
            Console.WriteLine($"Memory increase with flyweight: {MemoryUsageHelper.FormatMemorySize(afterFlyweightMemory - beforeFlyweightMemory)}");
            
            string flyweightHtml = converter.GetHtml();
            Console.WriteLine($"\nHTML Preview with flyweight:\n{flyweightHtml}");
            
            long standardMemoryUsage = afterStandardMemory - initialMemory;
            long flyweightMemoryUsage = afterFlyweightMemory - beforeFlyweightMemory;
            double savingsPercentage = 100 - ((double)flyweightMemoryUsage / standardMemoryUsage * 100);
            
            Console.WriteLine("\n--- Memory Usage Comparison ---");
            Console.WriteLine($"Standard implementation: {MemoryUsageHelper.FormatMemorySize(standardMemoryUsage)}");
            Console.WriteLine($"Flyweight implementation: {MemoryUsageHelper.FormatMemorySize(flyweightMemoryUsage)}");
            Console.WriteLine($"Memory savings: {savingsPercentage:F2}%");
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}