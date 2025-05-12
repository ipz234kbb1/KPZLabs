namespace Composite;

public class NetworkImageStrategy : IImageLoadingStrategy
{
    public string LoadImage(string href)
    {
        if (Uri.TryCreate(href, UriKind.Absolute, out Uri? uri) && 
            (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps))
        {
            return $"<img src='{href}' alt='Image from network' />";
        }
        return $"<img src='placeholder.png' alt='Invalid URL' />";
    }
} 