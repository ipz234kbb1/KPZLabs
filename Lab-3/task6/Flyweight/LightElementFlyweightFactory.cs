namespace Flyweight;

public class LightElementFlyweightFactory
{
    private Dictionary<string, LightElementNode> _elementCache = new Dictionary<string, LightElementNode>();
    public LightElementNode GetElement(string tagName, bool isBlock = true, bool isSelfClosing = false)
    {
        string key = $"{tagName}:{isBlock}:{isSelfClosing}";
            
        if (!_elementCache.ContainsKey(key))
        {
            _elementCache[key] = new LightElementNode(tagName, isBlock, isSelfClosing);
        }
            
        return CloneElement(_elementCache[key]);
    }
    
    private LightElementNode CloneElement(LightElementNode source)
    {
        var clone = new LightElementNode(source.TagName, source.IsBlock, source.IsSelfClosing);
        foreach (var cssClass in source.GetCssClasses())
        {
            clone.AddCssClass(cssClass);
        }
        return clone;
    }
    
    public int GetCachedElementCount()
    {
        return _elementCache.Count;
    }
}