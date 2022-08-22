namespace ZooLab.Animals
{
    public class Snake : Reptile
    {
        public override int RequiredSpaceSqFt => 2;

        public override string FavoriteFood => new Meet().ToString();

        public override bool IsFriendlyWith(Animal animal)
        {
            return animal.ToString() == ToString();
        }
    }
}
