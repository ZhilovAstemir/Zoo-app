using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLab;
using ZooLab.Animals;

namespace ZooAppConsole
{
    public class ZooConsole
    {
        public static int ConsoleMain(ZooApp zooApp)
        {
            Console.WriteLine(" 1.Look all information about all Zoos. \n" +
                " 2.Hire new Employee \n" +
                " 3.Feed all animals \n" +
                " 4.Heal all anmals \n" +
                " 5.All sick animals \n" +
                " 6.Last time of feed" +
                " 7.Exit");

            switch (Console.ReadLine())
            {
                //case "1":
                //    {
                //        Console.Clear();
                //        ConsoleAllInformation(zooApp);
                //        break;
                //    }
                case "2":
                    {
                        //Console.Clear();
                        ConsoleHireNewEmployee(zooApp);
                        break;
                    }
                case "3":
                    {
                        Console.Clear();
                        ConsoleFeedAllAnimals(zooApp);
                        break;
                    }
                case "4":
                    {
                        Console.Clear();
                        ConsoleHealAllAnimals(zooApp);
                        break;
                    }
                //case "5":
                //    {
                //        Console.Clear();
                //        ConsoleIsSickAnimals(zooApp);
                //        break;
                //    }
                //case "6":
                //{
                //    Console.Clear();
                //    ConsoleLastTimeOfFeed(zooApp);
                //    break;
                //}
                case "7":
                    {
                        break;
                    }
                default:
                    {
                        Console.Clear();
                        Console.WriteLine("\nNo valid command! \n");
                        return 0;
                    }
            }

            return 0;

        }

        //public static int ConsoleAllInformation(ZooApp zooApp)
        //{
        //    foreach (var zoo in zooApp.zoos)
        //    {
        //        Console.WriteLine("Zoo on {0}", zoo.Location);
        //        foreach (var enc in zoo.Enclosures)
        //        {
        //            Console.WriteLine(" Name: {0} \n" +
        //                " Squre: {1}", enc.Name, enc.SqureFeet);
        //            Console.WriteLine(" Name: {0}\n", enc.Animals[0].ToString());
        //        }

        //        foreach (var emp in zoo.Employees)
        //        {
        //            Console.WriteLine(" First Name: {0} \n" +
        //                " Last Name: {1}", emp.FirstName, emp.LastName);
        //        }

        //        Console.WriteLine();
        //    }
        //    Console.ReadLine();
        //    return 0;
        //}

        public static int ConsoleHireNewEmployee(ZooApp zooApp)
        {
            Console.WriteLine("Enter first name new employee:\n");
            // TODO: Добавить валидаторы на введение данных о сотруднике
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name new employee:\n");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter loccation of zoo:\n");
            foreach (var loc in zooApp.zoos) Console.WriteLine("Location: {0} \n", loc.Location);
            string loccation = Console.ReadLine();

            foreach (var zoo in zooApp.zoos)
            {
                if (zoo.Location == loccation)
                    zoo.HireEmployee(ChoseEmployee(firstName: firstName, lastName: lastName));
            }

            return 0;
        }

        public static string ChoseAnimal()
        {
            Console.WriteLine("Animal experience:\n" +
                " 1.Bison \n" +
                " 2.Lion \n" +
                " 3.Elephant \n" +
                " 4.Parrot \n" +
                " 5.Penguin \n" +
                " 6.Snake \n" +
                " 7.Turle\n");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Bison animal = new Bison();
                        return animal.ToString();
                    }
                case "2":
                    {
                        Lion animal = new Lion();
                        return animal.ToString();
                    }
                case "3":
                    {
                        Elephant animal = new Elephant();
                        return animal.ToString();
                    }
                case "4":
                    {
                        Parrot animal = new Parrot();
                        return animal.ToString();
                    }
                case "5":
                    {
                        Penguin animal = new Penguin();
                        return animal.ToString();
                    }
                case "6":
                    {
                        Snake animal = new Snake();
                        return animal.ToString();
                    }
                case "7":
                    {
                        Turtle animal = new Turtle();
                        return animal.ToString();
                    }
                default:
                    {
                        Bison animal = new Bison();
                        return animal.ToString();
                    }
            }
        }

        public static IEmployee ChoseEmployee(string firstName, string lastName)
        {
            Console.WriteLine("Chose profession: \n" +
                " 1.Veterinarian \n" +
                " 2.ZooKeeper");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        Veterinarian veterinarian = new Veterinarian(firstName: firstName, lastName: lastName, animalExperiences: ChoseAnimal());
                        return veterinarian;
                    }
                case "2":
                    {
                        ZooKeeper zooKeeper = new ZooKeeper(firstName: firstName, lastName: lastName, animalExperiences: ChoseAnimal());
                        return zooKeeper;
                    }
                default:
                    {
                        Veterinarian veterinarian = new Veterinarian(firstName: firstName, lastName: lastName, animalExperiences: ChoseAnimal());
                        return veterinarian;
                    }
            }
        }

        //public static int ConsoleIsSickAnimals(ZooApp zooApp)
        //{
        //    foreach (var zoo in zooApp.zoos)
        //    {
        //        Console.WriteLine("\n Zoo on {0} \n", zoo.Location);
        //        foreach (var enclosure in zoo.Enclosures)
        //        {
        //            if (enclosure.Animals[0].IsSick)
        //            {
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.WriteLine("Name: {0} \n" +
        //                    " IsSick: {1} \n", enclosure.Animals[0], enclosure.Animals[0].IsSick);
        //                Console.ResetColor();
        //            }
        //            else
        //            {
        //                Console.ForegroundColor = ConsoleColor.Green;
        //                Console.WriteLine("In {0} all animals is heal!\n", enclosure.Name);
        //                Console.ResetColor();
        //            }
        //        }
        //    }
        //    return ConsoleMain(zooApp);
        //}

        public static int ConsoleHealAllAnimals(ZooApp zooApp)
        {
            foreach (var zoo in zooApp.zoos)
            {
                zoo.HealAnimals();
            }
            Console.WriteLine("All Animal is Heal!");
            return 0;
        }

        public static int ConsoleFeedAllAnimals(ZooApp zooApp)
        {
            foreach (var zoo in zooApp.zoos)
            {
                zoo.FeedAnimals(DateTime.Now);
            }
            Console.WriteLine("All Animal is feed!");
            return 0;
        }

        //public static int ConsoleLastTimeOfFeed(ZooApp zooApp)
        //{
        //    foreach (var zoo in zooApp.zoos)
        //    {
        //        Console.WriteLine("Zoo on {0}\n", zoo.Location);
        //        foreach (var enclosure in zoo.Enclosures)
        //        {
        //            Console.WriteLine("Animal name: {0}\n", enclosure.Animals[0]);
        //            if (enclosure.Animals[0].FeedTimes.Count > 0)
        //            {
        //                Console.ForegroundColor = ConsoleColor.Green;
        //                Console.WriteLine("Last time of feed {0}\n", enclosure.Animals[0].FeedTimes.Last().FeedT);
        //                Console.ResetColor();
        //            }
        //            else
        //            {
        //                Console.ForegroundColor = ConsoleColor.Red;
        //                Console.WriteLine("Animal is hangry!");
        //                Console.ResetColor();
        //            }
        //        }
        //    }

        //    return ConsoleMain(zooApp);
        //}

    }
}

