namespace ZooLab.Animals
{
    public class Lion : Mammal
    {
        public override int RequiredSpaceSqFt => 1000;

        public override string FavoriteFood => new Meet().ToString();

        public override bool IsFriendlyWith(Animal animal)
        {
            return ToString() == animal.ToString();
        }
    }
}
