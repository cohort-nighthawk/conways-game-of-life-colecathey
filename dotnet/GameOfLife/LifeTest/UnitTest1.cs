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
        public void TestWorldSize()
        {
            var world = new World();
             world.WorldSize(2);
            Assert.AreEqual(2, World.Size);

        }

        [TestMethod]
        public void CellIsAlive()
        {
            var cell = new Cell();
            cell.Neighbors = 3;
            cell.IsAlive(cell.Neighbors);
            Assert.AreNotSame(false, cell.AliveCell);
        }
    }
}
