using System;

namespace Composite;

public class NetworkImageStrategy : IImageLoadingStrategy
{
    public string LoadImage(string href)
    {
        if (Uri.TryCreate(href, UriKind.Absolute, out Uri? uri) && 
            (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
        {
            return $"Image loaded from network: {uri.Host}{uri.PathAndQuery}";
        }
        
        return "Invalid URL - using placeholder image";
    }
} 