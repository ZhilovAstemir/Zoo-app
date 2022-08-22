using ZooLab.Medicines;

namespace ZooLab
{
    public class Veterinarian : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? AnimalExperiences { get; set; }

        public Veterinarian(string firstName, string lastName,string animalExperiences)
        {
            FirstName = firstName;
            LastName = lastName;
            AnimalExperiences = animalExperiences;
        }

        public void AddAnimalExperience(Animal animal)
        {
            AnimalExperiences = animal.ToString();
        }

        public bool HasAnimalExperience(Animal animal)
        {
            return animal.ToString() == AnimalExperiences;
        }

        public bool HeelAnimal(Animal animal)
        {
            if (animal.IsStick() && (animal.ToString() == AnimalExperiences))
            {
                animal.Heal(new Antibiotics());
                return true;
            }
            return false;
        }
    }
}
