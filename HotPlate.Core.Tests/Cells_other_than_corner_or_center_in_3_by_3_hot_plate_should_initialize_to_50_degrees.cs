using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace HotPlate.Core.Tests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    class Cells_other_than_corner_or_center_in_3_by_3_hot_plate_should_initialize_to_50_degrees
    {
        private HotPlate hotPlate;
        private readonly int size = 3;
        private readonly int expected = 50;

        [SetUp]
        public void Setup()
        {
            hotPlate = new HotPlate(size);
        }

        [Test]
        public void Verify_top()
        {
            Assert.AreEqual(expected, hotPlate[0, 1]);
        }

        [Test]
        public void Verify_left()
        {
            Assert.AreEqual(expected, hotPlate[1, 0]);
        }

        [Test]
        public void Verify_right()
        {
            Assert.AreEqual(expected, hotPlate[1, 2]);
        }

        [Test]
        public void Verify_bottom()
        {
            Assert.AreEqual(expected, hotPlate[2, 1]);
        }
    }
}
