using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new TextEditor();

            Console.WriteLine("Simple Text Editor Demo");
            Console.WriteLine("Commands: write <text>, undo, exit");

            while (true)
            {
                Console.Write("\nEnter command: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                if (input.ToLower().StartsWith("write "))
                {
                    string text = input.Substring(6);
                    editor.Write(text);
                    Console.WriteLine($"Current content: {editor.GetContent()}");
                }
                else if (input.ToLower() == "undo")
                {
                    editor.Undo();
                    Console.WriteLine($"Content after undo: {editor.GetContent()}");
                }
                else
                {
                    Console.WriteLine("Unknown command");
                }
            }
        }
    }
} 