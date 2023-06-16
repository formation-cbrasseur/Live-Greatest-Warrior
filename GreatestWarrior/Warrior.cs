using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestWarrior
{
    public class Warrior
    {
        public int Level { get; set; }
        public int Experience { get; set; }
        public Rank Rank { get; set; }
        public List<string> Achievments { get; set; }
        public int ExperienceByLevel = 100;

        public Warrior()
        {
            Level = 1;
            Experience = 100;
            Rank = Rank.Pushover;
            Achievments = new List<string>();
        }

        public void UpdateLevel()
        {
            if (Experience <= 10000)
                Level = (int)Decimal.Truncate(Experience / ExperienceByLevel);
            else
                Level = 100;
        }

        //public void Battle(int level)
        //{

        //}
        
        public void Training(string achievment, int experienceEarned)
        {
            Experience += experienceEarned;
            Achievments.Add(achievment);
        }

        public int CountAchievments()
        {
            return Achievments.Count;
        }
    }
}
