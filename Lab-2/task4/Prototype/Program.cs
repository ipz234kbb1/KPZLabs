namespace Prototype;
class Program
{
    static void Main()
    {
        Virus parent = VirusManager.CreateVirusFamily();
        Console.WriteLine("Оригінальне сімейство вірусів:");
        parent.Display();

        Virus clonedParent = parent.Clone();
        Console.WriteLine("\nКлоноване сімейство вірусів:");
        clonedParent.Display();
    }
}