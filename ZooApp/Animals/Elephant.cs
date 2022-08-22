namespace ZooLab.Animals
{
    public class Elephant : Mammal
    {
        public override int RequiredSpaceSqFt => 1000;

        public override string FavoriteFood => new Grass().ToString();

        public override bool IsFriendlyWith(Animal animal)
        {
            return animal.ToString() == ToString();
        }
    }
}
