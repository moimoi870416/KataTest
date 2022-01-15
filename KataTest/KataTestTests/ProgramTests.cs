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
    }
}