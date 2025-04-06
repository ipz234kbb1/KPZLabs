using System;
namespace Adapter;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Console Logger ===");
        ILogger consoleLogger = new Logger();
        consoleLogger.Log("Це лог повідомлення.");
        consoleLogger.Error("Це повідомлення про помилку.");
        consoleLogger.Warn("Це попереджувальне повідомлення.");

        Console.WriteLine("\n=== File Logger (Adapter) ===");
        FileWriter fileWriter = new FileWriter("log.txt");
        ILogger fileLogger = new FileLoggerAdapter(fileWriter);
        fileLogger.Log("Лог у файл");
        fileLogger.Error("Помилка у файл");
        fileLogger.Warn("Попередження у файл");

        Console.WriteLine("Повідомлення записані у 'log.txt'.");
    }
}