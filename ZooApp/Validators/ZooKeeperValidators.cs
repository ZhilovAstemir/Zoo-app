using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab.Validators
{
    public class ZooKeeperValidators : AbstractValidator<ZooKeeper>
    {
        public ZooKeeperValidators()
        {
            RuleFor(r => r.FirstName)
                .NotEmpty().WithMessage(ErrorMessages.FirstNameIsClear);
            RuleFor(r => r.LastName)
                .NotEmpty().WithMessage(ErrorMessages.LastNameIsClear);
            RuleFor(r => r.AnimalExperiences)
                //.Must(r => ValidateAnimals(animalExperiences)).WithMessage(ErrorMessages.NoNeededExperienceException);
                .NotEmpty().WithMessage(ErrorMessages.NoNeededExperienceException);
        }
    }
}
