namespace Decorator;

public class ArtifactDecorator : HeroDecorator
{
    public ArtifactDecorator(IHero hero) : base(hero) { }

    public override string GetDescription() => _hero.GetDescription() + ", blessed by an Artifact";
    public override void Attack() 
    {
        _hero.Attack();
        Console.WriteLine("The artifact grants magical enhancements!");
    }
}