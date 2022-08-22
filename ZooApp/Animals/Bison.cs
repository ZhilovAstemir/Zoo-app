namespace ZooLab.Animals
{
    public class Bison : Mammal
    {
        public override int RequiredSpaceSqFt => 1000;

        public override string FavoriteFood => new Grass().ToString();

        public override bool IsFriendlyWith(Animal animal)
        {
            Elephant elephant = new Elephant();
            return elephant.ToString() == animal.ToString();
        }
    }
}
