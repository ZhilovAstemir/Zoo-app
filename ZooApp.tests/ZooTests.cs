using System;
using System.Collections.Generic;
using ZooLab.Animals;

namespace ZooLab.tests
{
    public class ZooTests
    {
        [Fact]
        public void ShouldBeAbleToCreateZoo()
        {
            Bison bison = new Bison();
            Veterinarian veterinarian = new Veterinarian(firstName: "Valery", lastName: "Yee", animalExperiences: bison.ToString());
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "Valery", lastName: "Yee", animalExperiences: bison.ToString());
            //Enclosure enclosure = new Enclosure(name: "For Someone", animals: new List<Animal> { bison },parentZoo: ZooLab.this, );
            Zoo zoo = new Zoo(enclosures: new List<Enclosure> { null }, employees: new List<IEmployee> { veterinarian, zooKeeper }, location:"IDK");           
        }

        [Fact]
        public void ShouldBeAbleToAddNewEnclosure()
        {
            Zoo zoo = new Zoo(enclosures: new List<Enclosure>(), employees: new List<IEmployee>(), location: "IDK");
            zoo.AddEnclosure("Some Name", 1000);
            Assert.Equal("Some Name", zoo.Enclosures[0].Name);
        }

        [Fact]
        public void ShouldBeAbleToFindAvailableEnclosure()
        {
            Zoo zoo = new Zoo(enclosures: new List<Enclosure>(), employees: new List<IEmployee>(), location: "IDK");
            zoo.AddEnclosure("Some Name", 1000);
            zoo.AddEnclosure("Some Name", 5);
            zoo.AddEnclosure("Some Name", 2);
            Bison bison = new Bison();
            bison.ID = 0;
            Parrot parrot = new Parrot();
            parrot.ID = 1;
            Snake snake = new Snake();
            snake.ID = 2;
            Elephant elephant = new Elephant();
            elephant.ID = 3;
            zoo.FindAvailableEnclosure(bison);
            zoo.FindAvailableEnclosure(parrot);
            zoo.FindAvailableEnclosure(snake);
            //zoo.FindAvailableEnclosure(elephant);
            Assert.Equal(0, zoo.Enclosures[0].Animals[0].ID);
            Assert.Equal(1, zoo.Enclosures[1].Animals[0].ID);
            Assert.Equal(2, zoo.Enclosures[2].Animals[0].ID);
            //Assert.Equal(3, zoo.Enclosures[0].Animals[1].ID);
        }

        [Fact]
        public void ShouldNotBeAbleToFindAvailableEnclosure()
        {
            Zoo zoo = new Zoo(enclosures: new List<Enclosure>(), employees: new List<IEmployee>(), location: "IDK");
            zoo.AddEnclosure("Some Name", 1000);
            Lion lion = new Lion();
            Lion lion2 = new Lion();
            zoo.FindAvailableEnclosure(lion);
            Assert.Throws<Exception>(() => zoo.FindAvailableEnclosure(lion2));
        }

        [Fact]
        public void ShouldBeAbleToHireEmployee()
        {
            Zoo zoo = new Zoo(enclosures: new List<Enclosure>(), employees: new List<IEmployee>(), location: "IDK");
            Bison bison = new Bison();
            Veterinarian veterinarian = new Veterinarian(firstName: "Valery", lastName: "Yee", animalExperiences: bison.ToString());
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "Harry", lastName: "Yee", animalExperiences: bison.ToString());
            zoo.HireEmployee(veterinarian);
            zoo.HireEmployee(zooKeeper);
            Assert.Equal("Valery", zoo.Employees[0].FirstName);
            Assert.Equal("Harry", zoo.Employees[1].FirstName);
        }

        [Fact]
        public void ShouldNotBeAbleToHireEmployee()
        {
            Zoo zoo = new Zoo(enclosures: new List<Enclosure>(), employees: new List<IEmployee>(), location: "IDK");
            Bison bison = new Bison();
            Veterinarian veterinarian = new Veterinarian(firstName: "", lastName: "Yee", animalExperiences: "");
            Assert.Throws<Exception>(() => zoo.HireEmployee(veterinarian));
        }

        [Fact]
        public void ShouldBeAbleToFeedAnimals()
        {
            Bison bison = new Bison();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "Harry", lastName: "Yee", animalExperiences: bison.ToString());
            Zoo zoo = new Zoo(enclosures: new List<Enclosure>(), employees: new List<IEmployee>() { zooKeeper }, location: "IDK");
            zoo.AddEnclosure("Some Name", 1000);
            zoo.AddEnclosure("Some Name", 1000);           
            zoo.FindAvailableEnclosure(bison);
            Bison bison2 = new Bison();
            zoo.FindAvailableEnclosure(bison2);
            DateTime date = DateTime.Now;
            zoo.FeedAnimals(dateTime: date);
            Assert.Equal(date.Hour, bison.FeedTimes[0].FeedT.Hour);
            Assert.Equal(date.Hour, bison2.FeedTimes[0].FeedT.Hour);
        }

        [Fact]
        public void ShouldbeAbleToHealAnimals()
        {
            Bison bison = new Bison();
            Veterinarian veterinarian = new Veterinarian(firstName: "Harry", lastName: "Yee", animalExperiences: bison.ToString());
            Zoo zoo = new Zoo(enclosures: new List<Enclosure>(), employees: new List<IEmployee>() { veterinarian }, location: "IDK");
            zoo.AddEnclosure("Some Name", 1000);
            zoo.AddEnclosure("Some Name", 1000);
            zoo.FindAvailableEnclosure(bison);
            Bison bison2 = new Bison();
            zoo.FindAvailableEnclosure(bison2);
            bison.IsSick = true;
            bison2.IsSick = true;
            zoo.HealAnimals();
            Assert.False(bison.IsStick());
            Assert.False(bison2.IsStick());
        }

        [Fact]
        public void ShouldNotbeAbleToHealAnimals()
        {
            Bison bison = new Bison();
            Veterinarian veterinarian = new Veterinarian(firstName: "Harry", lastName: "Yee", animalExperiences: bison.ToString());
            Zoo zoo = new Zoo(enclosures: new List<Enclosure>(), employees: new List<IEmployee>() { veterinarian }, location: "IDK");
            zoo.AddEnclosure("Some Name", 1000);
            zoo.AddEnclosure("Some Name", 1000);
            zoo.FindAvailableEnclosure(bison);
            Lion lion = new Lion();
            zoo.FindAvailableEnclosure(lion);
            bison.IsSick = true;
            lion.IsSick = true;
            zoo.HealAnimals();
            Assert.False(bison.IsStick());
            Assert.True(lion.IsStick());
        }
    }
}
