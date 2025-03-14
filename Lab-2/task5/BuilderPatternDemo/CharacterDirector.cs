using System.Collections.Generic;

namespace BuilderPatternDemo
{
    public class CharacterDirector
    {
        public Hero ConstructHero(HeroBuilder builder)
        {
            return builder
                .SetName("Aurora")
                .SetHeight(1.75)
                .SetBuild("Athletic")
                .SetHairColor("Blonde")
                .SetEyeColor("Blue")
                .SetClothes("Armor and Cape")
                .SetInventory(new List<string> { "Sword", "Shield", "Healing Potion" })
                .AddGoodDeed("Rescued villagers")
                .AddGoodDeed("Defeated the dark wizard")
                .Build();
        }
        
        public Enemy ConstructEnemy(EnemyBuilder builder)
        {
            return builder
                .SetName("Drakon")
                .SetHeight(2.10)
                .SetBuild("Muscular")
                .SetHairColor("Black")
                .SetEyeColor("Red")
                .SetClothes("Dark Robes")
                .SetInventory(new List<string> { "Dagger", "Poison", "Spellbook" })
                .AddEvilDeed("Destroyed a town")
                .AddEvilDeed("Conjured dark magic")
                .Build();
        }
    }
}