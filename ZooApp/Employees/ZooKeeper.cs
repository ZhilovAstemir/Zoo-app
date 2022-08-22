using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab
{
    public class ZooKeeper : IEmployee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string AnimalExperiences { get; set; }

        public ZooKeeper(string firstName, string lastName, string animalExperiences)
        {
            FirstName = firstName;
            LastName = lastName;
            AnimalExperiences = animalExperiences;
        }

        public void AddAnimalExperience(Animal animal) => AnimalExperiences = animal.ToString();

        public bool HasAnimalExperience(Animal animal)
        {
            return animal.ToString() == AnimalExperiences;
        }

        public bool FeedAnimal(Animal animal)
        {
            return animal.ToString() == AnimalExperiences;
        }
    }
}
