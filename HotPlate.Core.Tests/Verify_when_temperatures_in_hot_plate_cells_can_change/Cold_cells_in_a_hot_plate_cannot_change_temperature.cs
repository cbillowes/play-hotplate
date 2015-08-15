using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
// ReSharper disable CheckNamespace

namespace HotPlate.Core.Tests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    class Cold_cells_in_hot_plate_cannot_change_temperature
    {
        private HotPlate hotPlate;
        private const int size = 3;
        private const bool expected = false;

        [SetUp]
        public void Setup()
        {
            hotPlate = new HotPlate(size);
        }

        [Test]
        public void Verify_top_left()
        {
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(0, 0));
        }

        [Test]
        public void Verify_top_right()
        {
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(0, 2));
        }

        [Test]
        public void Verify_bottom_left()
        {
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(2, 0));
        }

        [Test]
        public void Verify_bottom_right()
        {
            Assert.AreEqual(expected, hotPlate.CanCellValueChange(2, 2));
        }
    }
}
