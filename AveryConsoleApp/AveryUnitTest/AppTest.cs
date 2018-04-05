using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AveryBL;

namespace AveryUnitTest
{
    [TestClass]
    public class AppTest
    {
        [TestMethod]
        public void TestAdd()
        {
            Utility util = new Utility();

            Assert.AreEqual(11, util.Add(5, 6));

        }
    }
}
