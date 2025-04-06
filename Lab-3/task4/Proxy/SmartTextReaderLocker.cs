namespace Proxy;
using System.Text.RegularExpressions;
public class SmartTextReaderLocker : ITextReader
{
    private ITextReader _reader;
    private Regex _regex;
    
    public SmartTextReaderLocker(ITextReader reader, string pattern)
    {
        _reader = reader;
        _regex = new Regex(pattern, RegexOptions.Compiled);
    }

    public char[][] ReadText(string filePath)
    {
        if (_regex.IsMatch(filePath))
        {
            Console.WriteLine("Access denied!");
            return null;
        }
        return _reader.ReadText(filePath);
    }
}