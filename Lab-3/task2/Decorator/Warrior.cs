namespace Decorator;

public class Warrior : IHero
{
    public string GetDescription() => "Warrior";
    public void Attack() => Console.WriteLine("Warrior attacks with sword!");
}