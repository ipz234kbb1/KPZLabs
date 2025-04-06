namespace Flyweight;
using System;
using System.Collections.Generic;
public class LightTextNodeFlyweightFactory
{
    private Dictionary<string, LightTextNode> _textCache = new Dictionary<string, LightTextNode>();
    
    public LightTextNode GetTextNode(string text)
    {
        if (!_textCache.ContainsKey(text))
        {
            _textCache[text] = new LightTextNode(text);
        }
            
        return _textCache[text];
    }
    
    public int GetCachedTextNodeCount()
    {
        return _textCache.Count;
    }
}