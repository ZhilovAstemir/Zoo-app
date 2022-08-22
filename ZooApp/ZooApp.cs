namespace ZooLab
{
    public class ZooApp
    {
        public List<Zoo> zoos = new List<Zoo>();
        public void AddZoo(Zoo zoo)
        {
            zoos.Add(zoo);
        }
    }
}