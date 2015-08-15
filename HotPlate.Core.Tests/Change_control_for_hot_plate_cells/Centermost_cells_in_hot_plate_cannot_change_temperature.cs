using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace HotPlate.Core.Tests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    class Centermost_cells_in_hot_plate_cannot_change_temperature
    {
        private HotPlate hotPlate;
        private int size;
        private const bool expected = false;

        [Test]
        public void Verify_that_centermost_cell_in_3_by_3_grid_cannot_change()
        {
            size = 3;
            hotPlate = new HotPlate(size);
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(1, 1));
        }

        [Test]
        public void Verify_that_centermost_cells_in_4_by_4_grid_cannot_change()
        {
            size = 4;
            hotPlate = new HotPlate(size);
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(1, 1));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(1, 2));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(2, 1));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(2, 2));
        }

        [Test]
        public void Verify_that_centermost_cell_in_5_by_5_grid_cannot_change()
        {
            size = 5;
            hotPlate = new HotPlate(size);
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(2, 2));
        }

        [Test]
        public void Verify_that_centermost_cells_in_6_by_6_grid_cannot_change()
        {
            size = 6;
            hotPlate = new HotPlate(size);
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(2, 2));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(2, 3));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(3, 2));
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(3, 3));
        }
    }
}
