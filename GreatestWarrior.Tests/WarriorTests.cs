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
    }
}