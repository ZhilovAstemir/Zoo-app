namespace ZooLab.Animals
{
    public class Penguin : Bird
    {
        public override int RequiredSpaceSqFt => 10;

        public override string FavoriteFood => new Vegetable().ToString();

        public override bool IsFriendlyWith(Animal animal)
        {
            return animal.ToString() == ToString();
        }
    }
}
