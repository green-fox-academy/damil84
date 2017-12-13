using System;
using Apples;
using NUnit.Framework;

namespace AppleTesting
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var apples = new Program();
            string a = apples.GetApple();
            Assert.AreEqual("apple", a);
        }
    }
}
