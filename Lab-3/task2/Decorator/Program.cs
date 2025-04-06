namespace Decorator;
public class Program
{
    public static void Main(string[] args)
    {
        IHero hero = new Paladin();
        Console.WriteLine("Base hero: " + hero.GetDescription());
        hero.Attack();

        Console.WriteLine("\nAdding inventory items using decorators:");

        hero = new ArmorDecorator(hero);
        Console.WriteLine("After adding armor: " + hero.GetDescription());
        hero.Attack();

        hero = new WeaponDecorator(hero);
        Console.WriteLine("After adding weapon: " + hero.GetDescription());
        hero.Attack();

        hero = new ArtifactDecorator(hero);
        Console.WriteLine("After adding artifact: " + hero.GetDescription());
        hero.Attack();
        
        Console.WriteLine("\nCreating a Mage with multiple inventory items:");
        IHero mage = new Mage();
        mage = new WeaponDecorator(mage);
        mage = new ArmorDecorator(mage);
        mage = new ArtifactDecorator(mage);
        mage = new ArmorDecorator(mage); 
        Console.WriteLine("Mage description: " + mage.GetDescription());
        mage.Attack();
    }
}