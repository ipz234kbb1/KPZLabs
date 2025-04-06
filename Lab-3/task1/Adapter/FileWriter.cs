namespace Adapter;

public class FileWriter
{
    private string filePath;

    public FileWriter(string path)
    {
        filePath = path;
    }

    public void Write(string text)
    {
        File.AppendAllText(filePath, text);
    }

    public void WriteLine(string text)
    {
        File.AppendAllText(filePath, text + "\n");
    }
}