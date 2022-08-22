using FluentValidation.TestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.Animals;
using ZooLab.Foods;
using ZooLab.Validators;

namespace ZooLab.tests
{
    public class ZooKeeperTests
    {
        ZooKeeperValidators _zooKeeperValidators = new ZooKeeperValidators();

        [Fact]
        public void ShouldBeAbleToCreated()
        {
            Bison bison = new Bison();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: bison.ToString());
        }

        [Fact]
        public void ShouldNotBeAbleToCreated()
        {
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "", lastName: "", animalExperiences: "");

            var result = _zooKeeperValidators.TestValidate(zooKeeper);
            result.ShouldHaveValidationErrorFor(x => x.FirstName);
            result.ShouldHaveValidationErrorFor(x => x.LastName);
            result.ShouldHaveValidationErrorFor(x => x.AnimalExperiences);
        }

        [Fact]
        public void ShouldBeAbleToAddAnimalExperience()
        {
            Bison bison = new Bison();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: "");
            zooKeeper.AddAnimalExperience(bison);
            Assert.Equal(zooKeeper.AnimalExperiences, bison.ToString());
        }

        [Fact]
        public void ShouldHasAnimalExperience()
        {
            Bison bison = new Bison();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: bison.ToString());
            Assert.True(zooKeeper.HasAnimalExperience(bison));
        }

        [Fact]
        public void ShouldNotHasAnimalExperience()
        {
            Bison bison = new Bison();
            Lion lion = new Lion();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: bison.ToString());
            Assert.False(zooKeeper.HasAnimalExperience(lion));
        }

        [Fact]
        public void ShouldToHeelAnimal()
        {
            Bison bison = new Bison();
            bison.IsSick = true;
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: bison.ToString());
            Assert.True(zooKeeper.FeedAnimal(bison));
        }

        [Fact]
        public void ShouldNotToHeelAnimal()
        {
            Bison bison = new Bison();
            Lion lion = new Lion();
            bison.IsSick = false;
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: lion.ToString());
            Assert.False(zooKeeper.FeedAnimal(bison));
        }

        [Fact]
        public void ShouldBeAbleToFeedABisonHisFavoriteFoodAndToWriteThis()
        {
            Bison bison = new Bison();
            Grass grass = new Grass();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: bison.ToString());
            bison.Feed(grass, zooKeeper);
            Assert.Equal(DateTime.Now.ToShortTimeString(), bison.FeedTimes[0].FeedT.ToShortTimeString());
        }

        [Fact]
        public void ShouldNotBeAbleToFeedABison()
        {
            Bison bison = new Bison();
            Lion lion = new Lion();
            Meet meet = new Meet();
            ZooKeeper zooKeeper = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: bison.ToString());           
            Assert.Throws<Exception>(() =>bison.Feed(meet, zooKeeper));
            ZooKeeper zooKeeper1 = new ZooKeeper(firstName: "John", lastName: "Smith", animalExperiences: lion.ToString());
            Assert.Throws<Exception>(() => bison.Feed(meet, zooKeeper1));
        }
    }
}
