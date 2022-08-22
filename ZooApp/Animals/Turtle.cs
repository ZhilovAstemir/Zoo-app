namespace ZooLab.Animals
{
    public class Turtle : Reptile
    {
        public override int RequiredSpaceSqFt => 5;

        public override string FavoriteFood => new Grass().ToString();

        public override bool IsFriendlyWith(Animal animal)
        {
            Parrot parrot = new Parrot();
            Bison bison = new Bison();
            Elephant elephant = new Elephant();
            List<Animal> animals = new List<Animal>() {parrot, bison, elephant, this};
            return animals.Any(a => a.ToString() == animal.ToString());
        }
    }
}
