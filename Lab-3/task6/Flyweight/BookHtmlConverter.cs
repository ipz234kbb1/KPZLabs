namespace Flyweight;
using System;
using System.IO;
using System.Text;
    public class BookHtmlConverter
    {
        private LightElementNode _rootElement;
        public void ConvertBookToHtml(string filePath)
        {
            _rootElement = new LightElementNode("div");
            _rootElement.AddCssClass("book-content");
            
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
            bool isFirstLine = true;
            
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;
                
                if (isFirstLine)
                {
                    var titleElement = new LightElementNode("h1");
                    titleElement.AddChild(new LightTextNode(line));
                    _rootElement.AddChild(titleElement);
                    isFirstLine = false;
                }
                else if (line.Length < 20)
                {
                    var subtitleElement = new LightElementNode("h2");
                    subtitleElement.AddChild(new LightTextNode(line));
                    _rootElement.AddChild(subtitleElement);
                }
                else if (line.StartsWith(" ") || line.StartsWith("\t"))
                {
                    var quoteElement = new LightElementNode("blockquote");
                    quoteElement.AddChild(new LightTextNode(line.Trim()));
                    _rootElement.AddChild(quoteElement);
                }
                else
                {
                    var paragraphElement = new LightElementNode("p");
                    paragraphElement.AddChild(new LightTextNode(line));
                    _rootElement.AddChild(paragraphElement);
                }
            }
        }
        
        public void ConvertBookToHtmlWithFlyweight(string filePath)
        {
            var elementFactory = new LightElementFlyweightFactory();
            var textFactory = new LightTextNodeFlyweightFactory();
            
            _rootElement = elementFactory.GetElement("div");
            _rootElement.AddCssClass("book-content");
            
            string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);
            bool isFirstLine = true;
            
            foreach (string line in lines)
            {
                if (string.IsNullOrEmpty(line))
                    continue;
                
                if (isFirstLine)
                {
                    var titleElement = elementFactory.GetElement("h1");
                    titleElement.AddChild(textFactory.GetTextNode(line));
                    _rootElement.AddChild(titleElement);
                    isFirstLine = false;
                }
                else if (line.Length < 20)
                {
                    var subtitleElement = elementFactory.GetElement("h2");
                    subtitleElement.AddChild(textFactory.GetTextNode(line));
                    _rootElement.AddChild(subtitleElement);
                }
                else if (line.StartsWith(" ") || line.StartsWith("\t"))
                {
                    var quoteElement = elementFactory.GetElement("blockquote");
                    quoteElement.AddChild(textFactory.GetTextNode(line.Trim()));
                    _rootElement.AddChild(quoteElement);
                }
                else
                {
                    var paragraphElement = elementFactory.GetElement("p");
                    paragraphElement.AddChild(textFactory.GetTextNode(line));
                    _rootElement.AddChild(paragraphElement);
                }
            }
            Console.WriteLine($"Unique element types cached: {elementFactory.GetCachedElementCount()}");
            Console.WriteLine($"Unique text nodes cached: {textFactory.GetCachedTextNodeCount()}");
        }
        
        public LightElementNode GetRootElement()
        {
            return _rootElement;
        }
        
        public string GetHtml()
        {
            return _rootElement?.RenderOuterHTML() ?? string.Empty;
        }
    }