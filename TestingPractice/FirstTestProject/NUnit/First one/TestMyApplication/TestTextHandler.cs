using FirstTestProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestMyApplication
{
    [TestFixture]
    [TestClass]
    public class TestTextHandler
    {
        TextHandler th = new TextHandler();

        [Test]
        public void TestMakeUpperCase()
        {
            NUnit.Framework.Assert.AreEqual("DAMIL", th.MakeUpperCase("Damil"));
        }

        [Test]
        public void TestMakeLowerCase()
        {
            NUnit.Framework.Assert.AreEqual("damil", th.MakeLowerCase("Damil"));
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestUnfinishedMethod()
        {
            th.UnfinishedMethod("Damil");
        }

    }
}
