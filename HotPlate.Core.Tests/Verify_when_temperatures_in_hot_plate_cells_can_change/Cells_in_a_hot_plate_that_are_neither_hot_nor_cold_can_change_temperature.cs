using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace HotPlate.Core.Tests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    class Only_cells_that_are_not_hot_or_cold_can_change_temperature
    {
        private int size;
        private HotPlate hotPlate;
        private const bool expected = true;

        [Test]
        public void Verify_in_3_by_3()
        {
            size = 3;
            hotPlate = new HotPlate(size);
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(0, 1));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(1, 0));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(1, 2));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(2, 1));
        }

        [Test]
        public void Verify_in_4_by_4()
        {
            size = 4;
            hotPlate = new HotPlate(size);
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(0, 1));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(0, 2));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(1, 0));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(1, 3));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(3, 1));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(3, 2));
        }
    }
}
