namespace Composite;

public class LightImageNode : LightNode
{
    private string _href;
    private IImageLoadingStrategy _loadingStrategy;

    public LightImageNode(string href, IImageLoadingStrategy loadingStrategy)
    {
        _href = href;
        _loadingStrategy = loadingStrategy;
    }

    public void SetLoadingStrategy(IImageLoadingStrategy strategy)
    {
        _loadingStrategy = strategy;
    }

    public override string OuterHTML
    {
        get
        {
            return _loadingStrategy.LoadImage(_href);
        }
    }
} 