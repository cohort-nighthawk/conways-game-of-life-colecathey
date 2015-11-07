using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace LifeTest
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        public void CellAssureCellIsAlive()
        {
            /* arrange */
            Cell my_cell = new Cell();
            int cell_neighbor = 3;
            /* end arrange */

            /* act */
            /* end act */

            /* assert */
            Assert.IsTrue(my_cell.IsAlive(cell_neighbor));
            /* end assert */

        }

        [TestMethod]
        public void CellAssureCellIsDeadFromTooFew()
        {
            /* arrange */
            Cell my_cell = new Cell();
            int cell_neighbor = 1;
            /* end arrange */

            /* act */
            /* end act */

            /* assert */
            Assert.IsFalse(my_cell.IsAlive(cell_neighbor));
            /* end assert */
        }

        [TestMethod]
        public void CellAssureCellIsDeadFromTooMany()
        {
            /* arrange */
            Cell my_cell = new Cell();
            int cell_neighbor = 5;
            /* end arrange */

            /* act */
            /* end act */

            /* assert */
            Assert.IsFalse(my_cell.IsAlive(cell_neighbor));
            /* end assert */
        }
    }
}
