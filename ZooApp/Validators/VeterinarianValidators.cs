using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLab.Animals;

namespace ZooLab.Validators
{
    public class VeterinarianValidators : AbstractValidator<Veterinarian>
    {
        public VeterinarianValidators()
        {
            RuleFor(r => r.FirstName)
                .NotEmpty().WithMessage(ErrorMessages.FirstNameIsClear);
            RuleFor(r => r.LastName)
                .NotEmpty().WithMessage(ErrorMessages.LastNameIsClear);
            RuleFor(r => r.AnimalExperiences)
                //.Must(r => ValidateAnimals(animalExperiences)).WithMessage(ErrorMessages.NoNeededExperienceException);
                .NotEmpty().WithMessage(ErrorMessages.NoNeededExperienceException);
        }

        //public bool ValidateAnimals(string haveExperiences)
        //{
        //    List<string> animals = new List<string>() { new Bison().ToString(), new Elephant().ToString(), new Lion().ToString(), new Parrot().ToString(), new Penguin().ToString(), new Snake().ToString(), new Turtle().ToString() };
        //    return animals.Any(x => x.Equals(haveExperiences));
        //}
    }
}
