using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTest.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public Program Program = new Program();
        [TestMethod()]
        public void StringAverage_enter_zero_nine_five_two_four_get_four()
        {

            Assert.AreEqual("four", Program.StringAverage("zero nine five two"));
        }
        [TestMethod()]
        public void StringAverage_enter_empty_get_na()
        {
            Assert.AreEqual("n/a", Program.StringAverage(""));

        }
        [TestMethod()]
        public void  StringAverage_enter_one_ten_four_get_na()
        {
            Assert.AreEqual("n/a", Program.StringAverage("one ten"));
        }
        [TestMethod()]
        public void StringAverage_enter_two_apple_four_get_na()
        {

            Assert.AreEqual("n/a", Program.StringAverage("two apple"));
        }
        [TestMethod()]
        public void DeadAntCountTest_enter_null_return_zero()
        {
            Assert.AreEqual(0, Program.DeadAntCount(null));
        }
        [TestMethod()]
        public void DeadAntCountTest_enter_antantant_return_zero()
        {
            Assert.AreEqual(0, Program.DeadAntCount("ant ant ant"));
        }
        [TestMethod()]
        public void DeadAntCountTest_enter_ant_return_one()
        {
            Assert.AreEqual(1, Program.DeadAntCount("a n t"));
        }
        [TestMethod()]
        public void DeadAntCountTest_enter_aaannnttt_return_three()
        {
            Assert.AreEqual(3, Program.DeadAntCount("a a a  nnn tt t"));
        }
        [TestMethod()]
        public void DeadAntCountTest_enter_antananttaantnt_return_two()
        {
            Assert.AreEqual(2, Program.DeadAntCount("ant anantt aantnt"));
        }
        [TestMethod()]
        public void DeadAntCountTest_enter_antananttaantnt_return_three()
        {
            Assert.AreEqual(3, Program.DeadAntCount("ant ana ntt aantnt"));
        }
    }
}