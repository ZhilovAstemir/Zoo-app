using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.Animals;
using ZooLab.Foods;

namespace ZooLab.tests
{
    public class ParrotTests
    {
        [Fact]
        public void ShouldBeAbleToFriendshipWithParrotBisonElephantTurtle()
        {
            Parrot parrot = new Parrot();
            Parrot parrotSeccond = new Parrot();
            Bison bison = new Bison();
            Elephant elephant = new Elephant(); 
            Turtle turtle = new Turtle();
            Assert.True(parrot.IsFriendlyWith(parrotSeccond));
            Assert.True(parrot.IsFriendlyWith(bison));
            Assert.True(parrot.IsFriendlyWith(elephant));
            Assert.True(parrot.IsFriendlyWith(turtle));
        }

        [Fact]
        public void ShouldNotBeAbleToFriendshipWithAnotherAnimals()
        {
            Parrot parrot = new Parrot();
            Lion lion = new Lion();
            Assert.False(parrot.IsFriendlyWith(lion));
        }

        [Fact]
        public void ShouldBeAbleToSitInThisEnclosure()
        {
            Parrot parrot = new Parrot();
            Enclosure enclosure = new Enclosure(
                name: "For Bird",
                animals: new List<Animal> { new Parrot() },
                parentZoo: null,
                squreFeet: 5);
            Assert.True(parrot.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldNotBeAbleToSitInThisEnclosure()
        {
            Parrot parrot = new Parrot();
            Enclosure enclosure = new Enclosure(
                name: "For Bird",
                animals: new List<Animal> { new Parrot() },
                parentZoo: null,
                squreFeet: 4);
            Assert.False(parrot.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldBeAbleToEatHisFavoriteFood()
        {
            Parrot parrot = new Parrot();
            Vegetable vegetable = new Vegetable();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: parrot.ToString());
            parrot.Feed(vegetable, zooKeeper);
            Assert.Equal(DateTime.Now.ToShortTimeString(), parrot.FeedTimes[0].FeedT.ToShortTimeString());
        }
    }
}
