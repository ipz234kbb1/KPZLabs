using System.Collections.Generic;

namespace BuilderPatternDemo
{
    public class Hero
    {
        public string Name { get; set; }
        public double Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothes { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> GoodDeeds { get; set; } = new List<string>();

        public override string ToString()
        {
            return $"Hero: {Name}\n" +
                   $"Height: {Height} m, Build: {Build}\n" +
                   $"Hair: {HairColor}, Eyes: {EyeColor}\n" +
                   $"Clothes: {Clothes}\n" +
                   $"Inventory: [{string.Join(", ", Inventory)}]\n" +
                   $"Good Deeds: [{string.Join(", ", GoodDeeds)}]";
        }
    }
}