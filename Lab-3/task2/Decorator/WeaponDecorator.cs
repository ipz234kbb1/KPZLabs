namespace Decorator;

public class WeaponDecorator : HeroDecorator
{
    public WeaponDecorator(IHero hero) : base(hero) { }

    public override string GetDescription() => _hero.GetDescription() + ", wielding a mighty Weapon";
    public override void Attack() 
    {
        _hero.Attack();
        Console.WriteLine("The weapon enhances the attack power!");
    }
}
