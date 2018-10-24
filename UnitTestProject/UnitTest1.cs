using System;
using CITP280.playerclass;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Barbarian barbarian = new Barbarian();
            Assert.AreEqual(20, barbarian.GetClassAbilitiesTableList().Count);
            Assert.AreEqual(20, barbarian.ClassDataTableRows().Count);
        }
    }
}
