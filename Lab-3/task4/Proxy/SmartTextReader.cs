namespace Proxy;

public class SmartTextReader : ITextReader
{
    public char[][] ReadText(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("Файл не знайдено", filePath);
        }
        
        string[] lines = File.ReadAllLines(filePath);
        char[][] result = new char[lines.Length][];

        for (int i = 0; i < lines.Length; i++)
        {
            result[i] = lines[i].ToCharArray();
        }

        return result;
    }
}