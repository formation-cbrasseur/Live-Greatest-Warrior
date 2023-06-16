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

        public Warrior()
        {
            Level = 1;
            Experience = 100;
            Rank = Rank.Pushover;
            Achievments = new List<string>();
        }

        public int CountAchievments()
        {
            return Achievments.Count;
        }
    }
}
