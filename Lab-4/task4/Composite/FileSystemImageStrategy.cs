using System;
using System.IO;

namespace Composite;

public class FileSystemImageStrategy : IImageLoadingStrategy
{
    public string LoadImage(string href)
    {
        if (File.Exists(href))
        {
            var fileInfo = new FileInfo(href);
            return $"Image loaded from file system: {fileInfo.Name} (Size: {fileInfo.Length} bytes)";
        }
        
        return "File not found - using placeholder image";
    }
} 