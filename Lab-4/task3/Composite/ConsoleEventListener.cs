using System;

namespace Composite;

public class ConsoleEventListener : IEventListener
{
    private string _name;

    public ConsoleEventListener(string name)
    {
        _name = name;
    }

    public void OnEvent(string eventType, LightElementNode element)
    {
        Console.WriteLine($"[{_name}] Event '{eventType}' triggered on element {element.OuterHTML}");
    }
} 