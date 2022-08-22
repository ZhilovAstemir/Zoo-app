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
    public class ElephantTests
    {
        [Fact]
        public void ShouldBeAbleToFriendshipWithElephant()
        {
            Elephant elephant = new Elephant();
            Elephant elephantSecond = new Elephant();
            Assert.True(elephant.IsFriendlyWith(elephantSecond));
        }
        [Fact]
        public void ShouldNotBeAbleToFriendshipWithAnotherAnimals()
        {
            Elephant elephant = new Elephant();
            Bison bison = new Bison();
            Assert.False(elephant.IsFriendlyWith(bison));
        }

        [Fact]
        public void ShouldBeAbleToSitInThisEnclosure()
        {
            Elephant elephant = new Elephant();
            Enclosure enclosure = new Enclosure(
                name: "For Bird", 
                animals: new List<Animal> { new Parrot() }, 
                parentZoo: null, 
                squreFeet: 1000);
            Assert.True(elephant.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldNotBeAbleToSitInThisEnclosure()
        {
            Elephant elephant = new Elephant();
            Enclosure enclosure = new Enclosure(
                name: "For Bird", 
                animals: new List<Animal> { new Parrot() }, 
                parentZoo: null, 
                squreFeet: 999);
            Assert.False(elephant.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldBeAbleToEatHisFavoriteFood()
        {
            Elephant elephant = new Elephant();
            Grass grass = new Grass();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: elephant.ToString());
            elephant.Feed(grass, zooKeeper);
            Assert.Equal(DateTime.Now.ToShortTimeString(), elephant.FeedTimes[0].FeedT.ToShortTimeString());
        }
    }
}
