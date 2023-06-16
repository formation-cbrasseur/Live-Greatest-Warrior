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

        public void UpdateRank()
        {
            var actualEnumValue = (int) Decimal.Truncate(Level / 10) + 1;
            Rank = (Rank) actualEnumValue;
        }

        public string Battle(int enemyLevel)
        {
            if (Level - enemyLevel >= 2)
            {
                return "Easy fight";
            } 
            else if (Level - enemyLevel == 1) 
            {
                Experience += 5;
                return "Good fight";
            }
            else if (Level == enemyLevel)
            {
                Experience += 10;
                return "Good fight";
            }
            else if (Level - enemyLevel <= -5)
            {
                // Boolean fin de jeu
                return "Battle lost";
            }
            else if (Level - enemyLevel < 0)
            {
                Experience += 20 * (Level - enemyLevel) * (Level - enemyLevel);
                return "Intense fight";
            }

            return "Case unhandled";
        }

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
