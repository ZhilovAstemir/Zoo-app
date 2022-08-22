using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZooLab.Animals;

namespace ZooLab.tests
{
    public class EnclosureTests
    {
        [Fact]
        public void ShouldBeAbleToCreateEnclosure()
        {
            Enclosure enclosure = new Enclosure(name: "For Bird", animals: new List<Animal> { new Parrot() }, parentZoo: null, squreFeet: 10);     
        }
    }
}
