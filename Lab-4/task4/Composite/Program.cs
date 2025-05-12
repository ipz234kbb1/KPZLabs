using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Завдання 4: Паттерн Стратегія ===");
            var div = new LightElementNode("div", "block", false);
            div.AddChild(new LightTextNode("Image Gallery:"));
            
            var fileSystemStrategy = new FileSystemImageStrategy();
            var networkStrategy = new NetworkImageStrategy();
            
            var localImage1 = new LightImageNode("C:\\images\\local1.jpg", fileSystemStrategy);
            var localImage2 = new LightImageNode("D:\\photos\\vacation.jpg", fileSystemStrategy);
            var networkImage1 = new LightImageNode("https://example.com/image1.jpg", networkStrategy);
            var networkImage2 = new LightImageNode("https://images.example.org/photo.png", networkStrategy);
            
            div.AddChild(localImage1);
            div.AddChild(localImage2);
            div.AddChild(networkImage1);
            div.AddChild(networkImage2);
            
            Console.WriteLine("\nHTML Structure:");
            Console.WriteLine(div.OuterHTML);
            
            Console.WriteLine("\nChanging loading strategy for an image:");
            Console.WriteLine($"Before: {localImage1.OuterHTML}");
            localImage1.SetLoadingStrategy(networkStrategy);
            Console.WriteLine($"After: {localImage1.OuterHTML}");
            
            Console.WriteLine("\nDone.");
        }
    }
}