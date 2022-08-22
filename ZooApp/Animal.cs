using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLab.Animals;

namespace ZooLab
{
    public abstract class Animal
    {
        public abstract int RequiredSpaceSqFt { get; }
        public abstract string FavoriteFood { get; }
        public List<FeedTime> FeedTimes { get; } = new List<FeedTime>();
        public List<int> FeedSchedule { get; set; } = new List<int>();
        public bool IsSick { get; set; } = false;
        public int ID { get; set; }

        public abstract bool IsFriendlyWith(Animal animal);

        public void Feed(Food food, ZooKeeper zooKeeper)
        {
            if (zooKeeper.AnimalExperiences == ToString())  
                if(FavoriteFood == food.ToString())
                    {
                        DateTime date = DateTime.Now;
                        FeedTime feedTime = new FeedTime() { FeedT = date, FeedByZooKeeper = zooKeeper };
                        FeedTimes.Add(feedTime);
                    }
                else
                throw new Exception (FavoriteFood + " is not " + food.ToString());
            else
            throw new Exception(zooKeeper.AnimalExperiences + " is not " + ToString());
        }

        public bool IsStick()
        {
            return IsSick;
        }

        public void AddFeedSchedule(List<int> hours)
        {
            FeedSchedule = hours;
        }

        public void Heal(Medicine medicine)
        {
            IsSick = false;
        }

    }
}
