namespace Decorator;

public abstract class HeroDecorator : IHero
{
    protected IHero _hero;

    public HeroDecorator(IHero hero)
    {
        _hero = hero;
    }

    public virtual string GetDescription() => _hero.GetDescription();
    public virtual void Attack() => _hero.Attack();
}