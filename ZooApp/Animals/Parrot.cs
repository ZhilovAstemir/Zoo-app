namespace ZooLab.Animals
{
    public class Parrot : Bird
    {
        public override int RequiredSpaceSqFt => 5;

        public override string FavoriteFood => new Vegetable().ToString();

        public override bool IsFriendlyWith(Animal animal)
        {
            Turtle turtle = new Turtle();
            Bison bison = new Bison();
            Elephant elephant = new Elephant();
            List<Animal> animals = new List<Animal>() { turtle, bison, elephant, this };
            return animals.Any(a => a.ToString() == animal.ToString());
        }
    }
}
