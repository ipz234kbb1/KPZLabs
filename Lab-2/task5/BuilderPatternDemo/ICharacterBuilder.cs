using System.Collections.Generic;

namespace BuilderPatternDemo
{
    public interface ICharacterBuilder<T>
    {
        ICharacterBuilder<T> SetName(string name);
        ICharacterBuilder<T> SetHeight(double height);
        ICharacterBuilder<T> SetBuild(string build);
        ICharacterBuilder<T> SetHairColor(string hairColor);
        ICharacterBuilder<T> SetEyeColor(string eyeColor);
        ICharacterBuilder<T> SetClothes(string clothes);
        ICharacterBuilder<T> SetInventory(List<string> inventory);
        T Build();
        ICharacterBuilder<T> AddGoodDeed(string deed);
        ICharacterBuilder<T> AddEvilDeed(string deed);
    }
}