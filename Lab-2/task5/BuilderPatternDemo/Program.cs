using System;

namespace BuilderPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterDirector director = new CharacterDirector();
            
            HeroBuilder heroBuilder = new HeroBuilder();
            Hero hero = director.ConstructHero(heroBuilder);
            Console.WriteLine(hero);
            Console.WriteLine(new string('-', 50));

            EnemyBuilder enemyBuilder = new EnemyBuilder();
            Enemy enemy = director.ConstructEnemy(enemyBuilder);
            Console.WriteLine(enemy);

            Console.ReadLine();
        }
    }
}