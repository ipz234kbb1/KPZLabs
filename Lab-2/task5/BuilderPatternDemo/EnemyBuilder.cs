using System.Collections.Generic;

namespace BuilderPatternDemo
{
    public class EnemyBuilder : ICharacterBuilder<Enemy>
    {
        private Enemy _enemy = new Enemy();

        public ICharacterBuilder<Enemy> SetName(string name)
        {
            _enemy.Name = name;
            return this;
        }

        public ICharacterBuilder<Enemy> SetHeight(double height)
        {
            _enemy.Height = height;
            return this;
        }

        public ICharacterBuilder<Enemy> SetBuild(string build)
        {
            _enemy.Build = build;
            return this;
        }

        public ICharacterBuilder<Enemy> SetHairColor(string hairColor)
        {
            _enemy.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder<Enemy> SetEyeColor(string eyeColor)
        {
            _enemy.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder<Enemy> SetClothes(string clothes)
        {
            _enemy.Clothes = clothes;
            return this;
        }

        public ICharacterBuilder<Enemy> SetInventory(List<string> inventory)
        {
            _enemy.Inventory = inventory;
            return this;
        }

        public Enemy Build()
        {
            return _enemy;
        }
        
        public ICharacterBuilder<Enemy> AddGoodDeed(string deed)
        {
            return this; 
        }

        public ICharacterBuilder<Enemy> AddEvilDeed(string deed)
        {
            _enemy.EvilDeeds.Add(deed);
            return this;
        }
    }
}