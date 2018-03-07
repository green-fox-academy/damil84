using FirstTestProject;
using NUnit.Framework;

namespace TestMyApplication
{
    [TestFixture]
    public class TestMathsHandler
    {
        [Test]
        public void TestAdd()
        {
            var mh = new MathsHandler();
            Assert.AreEqual(20, mh.Add(8, 12));
        }

        [Test]
        public void TestSub()
        {
            var mh = new MathsHandler();
            Assert.AreEqual(-4, mh.Sub(8, 12));
        }
    }
}