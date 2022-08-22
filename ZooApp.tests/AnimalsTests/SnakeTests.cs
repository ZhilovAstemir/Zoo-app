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
    public class SnakeTests
    {
        [Fact]
        public void ShouldBeAbleToFriendshipWithSnake()
        {
            Snake snake = new Snake();
            Snake snakeSecond = new Snake();
            Assert.True(snake.IsFriendlyWith(snakeSecond));
        }

        [Fact]
        public void ShouldNotBeAbleToFriendshipWithAnotherAnimals()
        {
            Snake snake = new Snake();
            Lion lion = new Lion();
            Assert.False(snake.IsFriendlyWith(lion));
        }

        [Fact]
        public void ShouldBeAbleToSitInThisEnclosure()
        {
            Snake snake = new Snake();
            Enclosure enclosure = new Enclosure(
                name: "For Bird",
                animals: new List<Animal> { new Parrot() },
                parentZoo: null,
                squreFeet: 2);
            Assert.True(snake.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldNotBeAbleToSitInThisEnclosure()
        {
            Snake snake = new Snake();
            Enclosure enclosure = new Enclosure(
                name: "For Bird",
                animals: new List<Animal> { new Parrot() },
                parentZoo: null,
                squreFeet: 1);
            Assert.False(snake.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldBeAbleToEatHisFavoriteFood()
        {
            Snake snake = new Snake();
            Meet meet = new Meet();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: snake.ToString());
            snake.Feed(meet, zooKeeper);
            Assert.Equal(DateTime.Now.ToShortTimeString(), snake.FeedTimes[0].FeedT.ToShortTimeString());
        }
    }
}
