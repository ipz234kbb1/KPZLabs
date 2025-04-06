namespace Proxy;

public class SmartTextChecker : ITextReader
{
    private ITextReader _reader;

    public SmartTextChecker(ITextReader reader)
    {
        _reader = reader;
    }

    public char[][] ReadText(string filePath)
    {
        Console.WriteLine($"Відкриття файлу: {filePath}");
        char[][] content = _reader.ReadText(filePath);
        Console.WriteLine("Файл успішно прочитано.");
        Console.WriteLine($"Закриття файлу: {filePath}");
        
        int totalLines = content.Length;
        int totalChars = 0;
        foreach (var line in content)
        {
            totalChars += line.Length;
        }
        Console.WriteLine($"Загальна кількість рядків: {totalLines}");
        Console.WriteLine($"Загальна кількість символів: {totalChars}");

        return content;
    }
}