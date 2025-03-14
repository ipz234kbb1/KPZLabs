using System.Collections.Generic;

namespace BuilderPatternDemo
{
    public class HeroBuilder : ICharacterBuilder<Hero>
    {
        private Hero _hero = new Hero();

        public ICharacterBuilder<Hero> SetName(string name)
        {
            _hero.Name = name;
            return this;
        }

        public ICharacterBuilder<Hero> SetHeight(double height)
        {
            _hero.Height = height;
            return this;
        }

        public ICharacterBuilder<Hero> SetBuild(string build)
        {
            _hero.Build = build;
            return this;
        }

        public ICharacterBuilder<Hero> SetHairColor(string hairColor)
        {
            _hero.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder<Hero> SetEyeColor(string eyeColor)
        {
            _hero.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder<Hero> SetClothes(string clothes)
        {
            _hero.Clothes = clothes;
            return this;
        }

        public ICharacterBuilder<Hero> SetInventory(List<string> inventory)
        {
            _hero.Inventory = inventory;
            return this;
        }

        public Hero Build()
        {
            return _hero;
        }
        
        public ICharacterBuilder<Hero> AddGoodDeed(string deed)
        {
            _hero.GoodDeeds.Add(deed);
            return this;
        }
        
        public ICharacterBuilder<Hero> AddEvilDeed(string deed)
        {
            return this; 
        }
    }
}