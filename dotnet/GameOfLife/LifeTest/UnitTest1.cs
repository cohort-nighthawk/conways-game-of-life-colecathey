using System;
using System.Security.Cryptography.X509Certificates;
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
            var world = new World();
            WorldSize();
            Assert.AreEqual(2, World.WorldSize());

        }

        [TestMethod]
        public void CellIsAlive()
        {
            var cell = new Cell();
            Assert.AreEqual(true, Cell.IsAlive());
        }
    }
}
