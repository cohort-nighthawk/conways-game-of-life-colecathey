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
            life.Cell(2, 3);
            Assert.AreEqual(WorldSize(3), true);

        }
    }
}
