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
    public class LionTests
    {
        [Fact]
        public void ShouldBeAbleToFriendshipWithLion()
        {
            Lion lion = new Lion();
            Lion lionSecond = new Lion();
            Assert.True(lion.IsFriendlyWith(lionSecond));
        }
        [Fact]
        public void ShouldNotBeAbleToFriendshipWithAnotherAnimals()
        {
            Lion lion = new Lion();
            Bison bison = new Bison();         
            Assert.False(lion.IsFriendlyWith(bison));
        }

        [Fact]
        public void ShouldBeAbleToSitInThisEnclosure()
        {
            Lion lion = new Lion();
            Enclosure enclosure = new Enclosure(
                name: "For Bird", 
                animals: new List<Animal> { new Parrot() }, 
                parentZoo: null, 
                squreFeet: 1000);
            Assert.True(lion.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldNotBeAbleToSitInThisEnclosure()
        {
            Lion lion = new Lion();
            Enclosure enclosure = new Enclosure(
                name: "For Bird", 
                animals: new List<Animal> { new Parrot() },
                parentZoo: null, 
                squreFeet: 999);
            Assert.False(lion.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldBeAbleToEatHisFavoriteFood()
        {
            Lion lion = new Lion();
            Meet meet = new Meet();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: lion.ToString());
            lion.Feed(meet, zooKeeper);
            Assert.Equal(DateTime.Now.ToShortTimeString(), lion.FeedTimes[0].FeedT.ToShortTimeString());
        }
    }
}
