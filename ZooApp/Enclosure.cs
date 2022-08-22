using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLab
{
    public class Enclosure
    {
        public string Name { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public Zoo ParentZoo { get; set; }
        public int SqureFeet { get; set; }

        public Enclosure(string name, List<Animal> animals, Zoo parentZoo, int squreFeet)
        {
            Name = name;
            Animals = animals;
            ParentZoo = parentZoo;
            SqureFeet = squreFeet;
        }
    }
}
