using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

// ReSharper disable CheckNamespace
namespace HotPlate.Core.Tests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    class Cornermost_cells_in_a_hot_plate_are_cold_and_should_be_0_degrees
    {
        private HotPlate hotPlate;
        private readonly int size = 3;
        private readonly int expected = 0;

        [SetUp]
        public void Setup()
        {
            hotPlate = new HotPlate(size);
        }

        [Test]
        public void Verify_top_left()
        {
            Assert.AreEqual(expected, hotPlate[0, 0]);
        }

        [Test]
        public void Verify_top_right()
        {
            Assert.AreEqual(expected, hotPlate[0, 2]);
        }

        [Test]
        public void Verify_bottom_left()
        {
            Assert.AreEqual(expected, hotPlate[2, 0]);
        }

        [Test]
        public void Verify_bottom_right()
        {
            Assert.AreEqual(expected, hotPlate[2, 2]);
        }
    }
}
