using System.Reflection;

namespace GreatestWarrior.Tests
{
    [TestClass]
    public class WarriorTests
    {
        private Warrior _warrior;

        [TestInitialize]
        public void Init()
        {
            _warrior = new Warrior();
        }

        [TestMethod]
        public void CreateWarrior_LevelShouldBeOne()
        {
            Assert.AreEqual(1, _warrior.Level);
        }

        [TestMethod]
        public void CreateWarrior_ExperieneSHould100()
        {
            Assert.AreEqual(100, _warrior.Experience);
        }

        [TestMethod]
        public void CreateWarrior_RankShouldBePushover()
        {
            Assert.AreEqual(Rank.Pushover, _warrior.Rank);
        }

        [TestMethod]
        public void CreateWarrior_AchievmentsShouleBeEmpty()
        {
            Assert.AreEqual(0, _warrior.CountAchievments());
        }

        [TestMethod]
        [DataRow(100, 1)]
        [DataRow(500, 5)]
        [DataRow(555, 5)]
        [DataRow(789, 7)]
        [DataRow(8500, 85)]
        [DataRow(10000, 100)]
        [DataRow(11000, 100)]
        public void WarriorLevel_ShouldBeBasedOnExperience(int actualExperience, int expectedLevel)
        {
            _warrior.Experience = actualExperience;
            _warrior.UpdateLevel();

            Assert.AreEqual(expectedLevel, _warrior.Level);
        }
    }
}