namespace Decorator;

public class ArmorDecorator : HeroDecorator
{
    public ArmorDecorator(IHero hero) : base(hero) { }

    public override string GetDescription() => _hero.GetDescription() + ", with Armor";
    public override void Attack() 
    {
        _hero.Attack();
        Console.WriteLine("The armor provides extra protection!");
    }
}