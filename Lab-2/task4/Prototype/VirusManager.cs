namespace Prototype;

public class VirusManager
{
    public static Virus CreateVirusFamily()
    {
        Virus parent = new Virus("ILOVEYOU", "Черв'як", 0.01, 2);
        Virus child1 = new Virus("Melissa", "Макровірус", 0.008, 1);
        Virus child2 = new Virus("Mydoom", "Троян", 0.007, 1);
        Virus grandChild = new Virus("WannaCry", "Вимагач", 0.006, 0);

        child1.AddChild(grandChild);
        parent.AddChild(child1);
        parent.AddChild(child2);

        return parent;
    }
}
