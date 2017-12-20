using System;
using Exercise_Sum;
using NUnit.Framework;

namespace SumTesting
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethodIs3()
        {
            var sumtest = new Program();
            int result = sumtest.SummingMachine();
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestMethodIs2()
        {
            var sumtest = new Program();
            int result = sumtest.SummingMachine();
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TestMethodIs1()
        {
            var sumtest = new Program();
            int result = sumtest.SummingMachine();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void TestMethodIs0()
        {
            var sumtest = new Program();
            int result = sumtest.SummingMachine();
            Assert.AreEqual(0, result);
        }

        [Test]
        public void TestMethodIsNull()
        {
            var sumtest = new Program();
            int result = sumtest.SummingMachineIsNull();
            Assert.AreEqual(null, result);
        }
    }

}

