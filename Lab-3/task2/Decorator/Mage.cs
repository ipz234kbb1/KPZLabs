namespace Decorator;

public class Mage : IHero
{
    public string GetDescription() => "Mage";
    public void Attack() => Console.WriteLine("Mage casts a fireball!");
}