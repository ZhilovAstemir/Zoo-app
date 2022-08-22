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
    public class BisonTests
    {
        [Fact]
        public void ShouldBeAbleToFriendshipWithElephant()
        {
            Bison bison = new Bison();
            bison.ID = 0;
            Elephant elephant = new Elephant();
            Assert.True(bison.IsFriendlyWith(elephant));
        }
        [Fact]
        public void ShouldNotBeAbleToFriendshipWithAnotherAnimals()
        {
            Bison bison = new Bison();
            Lion lion = new Lion();
            Assert.False(bison.IsFriendlyWith(lion));
        }

        [Fact]
        public void ShouldBeAbleToSitInThisEnclosure()
        {
            Bison bison = new Bison();
            Enclosure enclosure = new Enclosure(
                name: "For Bird", 
                animals: new List<Animal> { new Parrot() }, 
                parentZoo: null, 
                squreFeet: 1000);
            enclosure.SqureFeet = 1000;
            Assert.True(bison.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldNotBeAbleToSitInThisEnclosure()
        {
            Bison bison = new Bison();
            Enclosure enclosure = new Enclosure(
                name: "For Bird", 
                animals: new List<Animal> { new Parrot() }, 
                parentZoo: null, 
                squreFeet: 999);
            Assert.False(bison.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldBeAbleToCreateFeedSchedule()
        {
            Bison bison = new Bison();
            bison.AddFeedSchedule(new List<int> { 1, 2, 3 });
            Assert.Equal(new List<int> { 1, 2, 3 }, bison.FeedSchedule);
        }

        [Fact]
        public void ShouldBeAbleToStick()
        {
            Bison bison = new Bison();
            bison.IsSick = true;
            Assert.True(bison.IsStick());
        }

        [Fact]
        public void ShouldBeAbleToEatHisFavoriteFood()
        {
            Bison bison = new Bison();
            Grass grass = new Grass();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: bison.ToString());
            bison.Feed(grass, zooKeeper);
            Assert.Equal(DateTime.Now.ToShortTimeString(), bison.FeedTimes[0].FeedT.ToShortTimeString());
        }
    }
}
