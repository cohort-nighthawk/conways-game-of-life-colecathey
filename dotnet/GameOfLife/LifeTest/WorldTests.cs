using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace LifeTest
{
    [TestClass]
    public class WorldTests
    {
        [TestMethod]
        public void WorldAssureWorldCanInstance()
        {
            /* arrange */
            World test_world = new World();
            /* end arrange */

            /* act */
            var actual = test_world.BuildWorldSize();
            /* end act */

            /* assert */
            Assert.AreEqual(actual, 10);
            /* end assert */
        }

        [TestMethod]
        public void WorldAssureYouCanPlaceCell()
        {
            /* arrange */
            World test_world = new World();
            /* end arrange */

            /* act */
            /* end act */

            /* assert */

            /* end assert */
        }
    }
}
