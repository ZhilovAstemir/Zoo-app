using System;
using System.Collections.Generic;
using Xunit;
using ZooLab.Animals;
using ZooLab.Foods;

namespace ZooLab.tests
{
    public class TurtleTests
    {
        [Fact]
        public void ShouldBeAbleToFriendshipWithTurtleParrotBisonElephant()
        {
            Turtle turtle = new Turtle();
            Parrot parrot = new Parrot();
            Bison bison = new Bison();
            Elephant elephant = new Elephant();
            Turtle turtleSecond = new Turtle();
            Assert.True(turtle.IsFriendlyWith(parrot));
            Assert.True(turtle.IsFriendlyWith(bison));
            Assert.True(turtle.IsFriendlyWith(elephant));
            Assert.True(turtle.IsFriendlyWith(turtleSecond));
        }
        [Fact]
        public void ShouldNotBeAbleToFriendshipWithAnotherAnimals()
        {
            Turtle turtle = new Turtle();
            Lion lion = new Lion();
            Assert.False(turtle.IsFriendlyWith(lion));
        }

        [Fact]
        public void ShouldBeAbleToSitInThisEnclosure()
        {
            Turtle turtle = new Turtle();
            Enclosure enclosure = new Enclosure(
                name: "For Bird",
                animals: new List<Animal> { new Parrot() },
                parentZoo: null,
                squreFeet: 5);
            Assert.True(turtle.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldNotBeAbleToSitInThisEnclosure()
        {
            Turtle turtle = new Turtle();
            Enclosure enclosure = new Enclosure(
                name: "For Bird",
                animals: new List<Animal> { new Parrot() },
                parentZoo: null,
                squreFeet: 4);
            Assert.False(turtle.RequiredSpaceSqFt <= enclosure.SqureFeet);
        }

        [Fact]
        public void ShouldBeAbleToEatHisFavoriteFood()
        {
            Turtle turtle = new Turtle();
            Grass grass = new Grass();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: turtle.ToString());
            turtle.Feed(grass, zooKeeper);
            Assert.Equal(DateTime.Now.ToShortTimeString(), turtle.FeedTimes[0].FeedT.ToShortTimeString());
        }
    }
}
