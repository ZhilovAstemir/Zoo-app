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
    public class PenguinTests
    {
        [Fact]
        public void ShouldBeAbleToFriendshipWithPenguin()
        {
            Penguin penguin = new Penguin();
            Penguin penguinSecond = new Penguin();
            Assert.True(penguin.IsFriendlyWith(penguinSecond));
        }
        [Fact]
        public void ShouldNotBeAbleToFriendshipWithAnotherAnimals()
        {
            Penguin penguin = new Penguin();
            Bison bison = new Bison();
            Assert.False(penguin.IsFriendlyWith(bison));
        }

        [Fact]
        public void ShouldBeAbleToSitInThisEnclosure()
        {
            Penguin penguin = new Penguin();
            Enclosure enclosure = new Enclosure(
                name: "For Bird",
                animals: new List<Animal> { new Parrot() },
                parentZoo: null,
                squreFeet: 10);
            Assert.True(penguin.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldNotBeAbleToSitInThisEnclosure()
        {
            Penguin penguin = new Penguin();
            Enclosure enclosure = new Enclosure(
                name: "For Bird",
                animals: new List<Animal> { new Parrot() },
                parentZoo: null,
                squreFeet: 9);
            Assert.False(penguin.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldBeAbleToEatHisFavoriteFood()
        {
            Penguin penguin = new Penguin();
            Vegetable vegetable = new Vegetable();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: penguin.ToString());
            penguin.Feed(vegetable, zooKeeper);
            Assert.Equal(DateTime.Now.ToShortTimeString(), penguin.FeedTimes[0].FeedT.ToShortTimeString());
        }
    }
}
