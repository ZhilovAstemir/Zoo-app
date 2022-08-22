namespace ZooLab
{
    public class Zoo
    {
        public List<Enclosure> Enclosures { get; set; } = new List<Enclosure>();
        public List<IEmployee> Employees { get; set; } = new List<IEmployee>();
        public string? Location { get; set; }

        public Zoo(List<Enclosure> enclosures, List<IEmployee> employees, string? location)
        {
            Enclosures = enclosures;
            Employees = employees;
            Location = location;
        }

        public void AddEnclosure(string name, int squreFeet)
        {
            Enclosure enclosure = new Enclosure(name: name, animals: new List<Animal>(), parentZoo: this, squreFeet: squreFeet );
            Enclosures.Add(enclosure);
        }

        public void FindAvailableEnclosure(Animal animal)
        {
            bool IsHave = false;
            foreach (var enclosure in Enclosures)
            {
                if((animal.RequiredSpaceSqFt <= enclosure.SqureFeet)
                    &&
                    (!enclosure.Animals.Any()))
                { 
                    enclosure.Animals.Add(animal);
                    IsHave = true;
                    break;
                }
                // TODO: Реализовать проверку
                //else
                //{
                //    List<Animal> animals = enclosure.Animals;
                //    if ((animals.Count == enclosure.Animals.Count)&& (animal.RequiredSpaceSqFt <= enclosure.SqureFeet))
                //    {
                //        enclosure.Animals.Add(animal);
                //        IsHave = true;
                //        break;
                //    }
                //}
            }
            if(!IsHave)
            throw new Exception("No have avalible enclosure");
        }

        public void HireEmployee(IEmployee employee)
        {
            if (!string.IsNullOrWhiteSpace(employee.FirstName))
                Employees.Add(employee);
            else throw new Exception(ErrorMessages.NoNeededExperienceException);
        }

        public void FeedAnimals(DateTime dateTime)
        {
            List<Food> foods = new List<Food>() { new Grass(), new Meet(), new Vegetable() };
            foreach (var enclosure in Enclosures)
            {
                foreach(var animal in enclosure.Animals)
                {
                    foreach (var employees in Employees) 
                    {
                        if(employees is ZooKeeper)
                            if(((ZooKeeper)employees).AnimalExperiences == animal.ToString())
                                animal.Feed(foods.First(f => f.ToString() == animal.FavoriteFood), (ZooKeeper)employees);
                    }
                }
            }
        }

        public void HealAnimals()
        {
            foreach (var enclosure in Enclosures)
            {
                foreach (var animal in enclosure.Animals)
                {
                    foreach (var employees in Employees)
                    {
                        if(employees is Veterinarian)
                        ((Veterinarian)employees).HeelAnimal(animal);
                    }
                }
            }
        }
    }
}
