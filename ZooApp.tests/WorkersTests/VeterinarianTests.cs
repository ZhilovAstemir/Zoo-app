using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.Animals;
using ZooLab.Validators;
using FluentValidation.TestHelper;

namespace ZooLab.tests
{
    public class VeterinarianTests
    {
        VeterinarianValidators _veterinarianValidators = new VeterinarianValidators();

        [Fact]
        public void ShouldBeAbleToCreated()
        {
            Bison bison = new Bison();
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Smith", animalExperiences: bison.ToString() );
        }

        [Fact]
        public void ShouldNotBeAbleToCreated()
        {
            Veterinarian veterinarian = new Veterinarian(firstName: "", lastName: "", animalExperiences: "");

            var result = _veterinarianValidators.TestValidate(veterinarian);
            result.ShouldHaveValidationErrorFor(x => x.FirstName);
            result.ShouldHaveValidationErrorFor(x => x.LastName);
            result.ShouldHaveValidationErrorFor(x => x.AnimalExperiences);
        }

        [Fact]
        public void ShouldBeAbleToAddAnimalExperience()
        {
            Bison bison = new Bison();
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Smith", animalExperiences: "");
            veterinarian.AddAnimalExperience(bison);
            Assert.Equal(veterinarian.AnimalExperiences, bison.ToString());
        }

        [Fact]
        public void ShouldHasAnimalExperience()
        {
            Bison bison = new Bison();
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Smith", animalExperiences: bison.ToString());
            Assert.True(veterinarian.HasAnimalExperience(bison));
        }

        [Fact]
        public void ShouldNotHasAnimalExperience()
        {
            Bison bison = new Bison();
            Lion lion = new Lion();
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Smith", animalExperiences: bison.ToString());
            Assert.False(veterinarian.HasAnimalExperience(lion));
        }

        [Fact]
        public void ShouldToHeelAnimal()
        {
            Bison bison = new Bison();
            bison.IsSick = true;
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Smith", animalExperiences: bison.ToString());
            Assert.True(veterinarian.HeelAnimal(bison));
            Assert.False(bison.IsSick);
        }

        [Fact]
        public void ShouldNotToHeelAnimal()
        {
            Bison bison = new Bison();
            Lion lion = new Lion();
            bison.IsSick = false;
            Veterinarian veterinarian = new Veterinarian(firstName: "John", lastName: "Smith", animalExperiences: lion.ToString());
            Assert.False(veterinarian.HeelAnimal(bison));
        }

        
    }
}
