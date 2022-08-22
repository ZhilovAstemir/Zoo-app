using System.Collections.Generic;

namespace ZooLab.tests
{
    public class ZooAppTests
    {
        [Fact]
        public void ShouldBeAbleToAddZooOnList()
        {
            ZooApp zooApp = new ZooApp();
            Zoo zoo = new Zoo(enclosures: new List<Enclosure>(), employees: new List<IEmployee>(), location: "IDK");
            zooApp.AddZoo(zoo);
        }
    }
}