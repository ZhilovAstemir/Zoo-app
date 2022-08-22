using ZooLab;
using ZooLab.Animals;

namespace ZooAppConsole
{
    public class CreateDate
    {
        public static void CreateAZoo(ZooApp zooApp)
        {
            Zoo zooFirst = new Zoo(enclosures: new List<Enclosure>(), employees: new List<IEmployee>(), location: "5/4");
            Zoo zooSecond = new Zoo(enclosures: new List<Enclosure>(), employees: new List<IEmployee>(), location: "8/2");
            zooApp.AddZoo(zooFirst);
            CreateEnclosures(zooFirst);
            CreateAnimals(zooFirst);
            CrateEmployee(zooFirst);
            zooApp.AddZoo(zooSecond);
            CreateEnclosures(zooSecond);
            CreateAnimals(zooSecond);
            CrateEmployee(zooSecond);
        }

        public static void CreateAnimals(Zoo zoo)
        {
            Bison bison = new Bison();
            bison.ID = 0;

            Elephant elephant = new Elephant();
            elephant.IsSick = true;
            elephant.ID = 1;

            Lion lion = new Lion();
            lion.ID = 2;

            Parrot parrot = new Parrot();
            parrot.IsSick = true;
            parrot.ID = 3;

            Penguin penguin = new Penguin();
            penguin.ID = 4;

            Snake snake = new Snake();
            snake.IsSick = true;
            snake.ID = 5;

            Turtle turtle = new Turtle();
            turtle.ID = 6;

            zoo.FindAvailableEnclosure(bison);
            zoo.FindAvailableEnclosure(elephant);
            zoo.FindAvailableEnclosure(lion);
            zoo.FindAvailableEnclosure(penguin);
            zoo.FindAvailableEnclosure(parrot);
            zoo.FindAvailableEnclosure(turtle);
            zoo.FindAvailableEnclosure(snake);

        }

        public static void CreateEnclosures(Zoo zoo)
        {
            zoo.AddEnclosure("With Bison", 1000);
            zoo.AddEnclosure("With Elephant", 1000);
            zoo.AddEnclosure("With Lion", 1000);
            zoo.AddEnclosure("With Penguin", 10);
            zoo.AddEnclosure("With Parrot", 5);
            zoo.AddEnclosure("With Turtle", 5);
            zoo.AddEnclosure("With Snake", 2);
        }

        public static void CrateEmployee(Zoo zoo)
        {
            Veterinarian veterinarian1 = new Veterinarian(firstName: "Ann", lastName: "H", animalExperiences: new Bison().ToString());
            Veterinarian veterinarian2 = new Veterinarian(firstName: "Fen", lastName: "R", animalExperiences: new Lion().ToString());
            Veterinarian veterinarian3 = new Veterinarian(firstName: "Den", lastName: "F", animalExperiences: new Elephant().ToString());
            Veterinarian veterinarian4 = new Veterinarian(firstName: "Ben", lastName: "S", animalExperiences: new Parrot().ToString());
            Veterinarian veterinarian5 = new Veterinarian(firstName: "Ten", lastName: "G", animalExperiences: new Penguin().ToString());
            Veterinarian veterinarian6 = new Veterinarian(firstName: "Len", lastName: "A", animalExperiences: new Snake().ToString());
            Veterinarian veterinarian7 = new Veterinarian(firstName: "Inn", lastName: "N", animalExperiences: new Turtle().ToString());

            ZooKeeper zooKeeper1 = new ZooKeeper(firstName: "Onn", lastName: "M", animalExperiences: new Bison().ToString());
            ZooKeeper zooKeeper2 = new ZooKeeper(firstName: "Uot", lastName: "O", animalExperiences: new Lion().ToString());
            ZooKeeper zooKeeper3 = new ZooKeeper(firstName: "Eri", lastName: "L", animalExperiences: new Elephant().ToString());
            ZooKeeper zooKeeper4 = new ZooKeeper(firstName: "Yo", lastName: "G", animalExperiences: new Parrot().ToString());
            ZooKeeper zooKeeper5 = new ZooKeeper(firstName: "Be", lastName: "R", animalExperiences: new Penguin().ToString());
            ZooKeeper zooKeeper6 = new ZooKeeper(firstName: "Hes", lastName: "P", animalExperiences: new Snake().ToString());
            ZooKeeper zooKeeper7 = new ZooKeeper(firstName: "Mek", lastName: "X", animalExperiences: new Turtle().ToString());

            zoo.HireEmployee(veterinarian1);
            zoo.HireEmployee(veterinarian2);
            zoo.HireEmployee(veterinarian3);
            zoo.HireEmployee(veterinarian4);
            zoo.HireEmployee(veterinarian5);
            zoo.HireEmployee(veterinarian6);
            zoo.HireEmployee(veterinarian7);

            zoo.HireEmployee(zooKeeper1);
            zoo.HireEmployee(zooKeeper2);
            zoo.HireEmployee(zooKeeper3);
            zoo.HireEmployee(zooKeeper4);
            zoo.HireEmployee(zooKeeper5);
            zoo.HireEmployee(zooKeeper6);
            zoo.HireEmployee(zooKeeper7);
        }
    }
}
