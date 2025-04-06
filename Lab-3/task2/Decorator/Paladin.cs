namespace Decorator;

public class Paladin : IHero
{
    public string GetDescription() => "Paladin";
    public void Attack() => Console.WriteLine("Paladin strikes with holy power!");
}