namespace Prototype;

public class Virus : IPrototype<Virus>
{
    public string Name { get; set; }
    public string Species { get; set; }
    public double Weight { get; set; }
    public int Age { get; set; }
    public List<Virus> Children { get; set; }

    public Virus(string name, string species, double weight, int age)
    {
        Name = name;
        Species = species;
        Weight = weight;
        Age = age;
        Children = new List<Virus>();
    }

    public void AddChild(Virus child)
    {
        Children.Add(child);
    }

    public Virus Clone()
    {
        Virus clone = new Virus(Name, Species, Weight, Age);
        foreach (var child in Children)
        {
            clone.AddChild(child.Clone());
        }
        return clone;
    }

    public void Display(string indent = "")
    {
        Console.WriteLine($"{indent}Вірус: {Name}, Вид: {Species}, Вага: {Weight}, Вік: {Age}");
        foreach (var child in Children)
        {
            child.Display(indent + "  ");
        }
    }
}