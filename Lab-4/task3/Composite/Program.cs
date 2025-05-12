using System;
using System.Collections.Generic;

namespace Composite;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Завдання 3. ===");
        var div = new LightElementNode("div", "block", false);
        var button = new LightElementNode("button", "inline", false);
        button.AddChild(new LightTextNode("Click me!"));
        div.AddChild(button);
        
        var paragraph = new LightElementNode("p", "block", false);
        paragraph.AddChild(new LightTextNode("Hover over me!"));
        div.AddChild(paragraph);

        var clickListener = new ConsoleEventListener("Button Click Listener");
        var mouseoverListener = new ConsoleEventListener("Paragraph Mouseover Listener");

        button.AddEventListener("click", clickListener);
        paragraph.AddEventListener("mouseover", mouseoverListener);
        
        Console.WriteLine("\nHTML Structure:");
        Console.WriteLine(div.OuterHTML);

        Console.WriteLine("\nEvent simulation:");
        button.Click();
        paragraph.MouseOver();

        Console.WriteLine("\nUnsubscribing from events:");
        button.RemoveEventListener("click", clickListener);
        button.Click(); 

        Console.WriteLine("\nDone.");
    }
}