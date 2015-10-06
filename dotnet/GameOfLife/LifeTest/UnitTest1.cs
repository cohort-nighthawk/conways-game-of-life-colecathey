using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace LifeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WorldSize()
        {
            var life = new Life();
            life.WorldSize(2);
            Assert.AreEqual(2, life.Size);

        }
    }
}
