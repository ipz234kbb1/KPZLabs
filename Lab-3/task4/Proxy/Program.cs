namespace Proxy;
class Program
{
    static void Main(string[] args)
    {
        string filePath = "example.txt";
        File.WriteAllLines(filePath, new string[] 
        { 
            "Привіт, світ!", 
            "Це тестовий файл." 
        });
        
        ITextReader reader = new SmartTextReader();
        char[][] text = reader.ReadText(filePath);
        Console.WriteLine("Вміст файлу через SmartTextReader:");
        foreach (var line in text)
        {
            Console.WriteLine(new string(line));
        }
        Console.WriteLine();
        
        ITextReader loggingReader = new SmartTextChecker(new SmartTextReader());
        Console.WriteLine("Вміст файлу через SmartTextChecker:");
        char[][] textWithLogging = loggingReader.ReadText(filePath);
        Console.WriteLine();
        
        ITextReader lockedReader = new SmartTextReaderLocker(new SmartTextReader(), "example");
        Console.WriteLine("Спроба прочитати файл через SmartTextReaderLocker:");
        char[][] lockedText = lockedReader.ReadText(filePath);

        if (lockedText != null)
        {
            foreach (var line in lockedText)
            {
                Console.WriteLine(new string(line));
            }
        }
        Console.WriteLine();

        File.Delete(filePath);
    }
}