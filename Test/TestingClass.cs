using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamApp;

namespace Test
{
    [TestClass]
    public class TestingClass
    {
        [TestMethod]
        public void TestingMethod()
        {
            DoWork work = new DoWork();
            int x = 9;
            int y = 21;
            int expected = 30;
        }
    }
}
