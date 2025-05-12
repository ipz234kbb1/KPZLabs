namespace Composite;

public class FileSystemImageStrategy : IImageLoadingStrategy
{
    public string LoadImage(string href)
    {
        if (File.Exists(href))
        {
            return $"<img src='{href}' alt='Image from file system' />";
        }
        return $"<img src='placeholder.png' alt='Image not found' />";
    }
} 