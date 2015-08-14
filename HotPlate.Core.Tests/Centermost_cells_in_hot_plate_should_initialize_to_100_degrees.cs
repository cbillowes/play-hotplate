using NUnit.Framework;

namespace HotPlate.Core.Tests
{
    [TestFixture]
    class Centermost_cells_in_hot_plate_should_initialize_to_100_degrees
    {
        private HotPlate hotPlate;
        private int size;
        private readonly int expected = 100;

        [Test]
        public void Verify_only_center_cell_in_3_by_3()
        {
            size = 3;
            hotPlate = new HotPlate(size);
            Assert.AreEqual(expected, hotPlate[1, 1]);
        }

        [Test]
        public void Verify_first_center_cell_in_4_by_4()
        {
            hotPlate = Create_4_by_4_hot_plate();
            Assert.AreEqual(expected, hotPlate[1, 1]);
        }

        [Test]
        public void Verify_second_center_cell_in_4_by_4()
        {
            hotPlate = Create_4_by_4_hot_plate();
            Assert.AreEqual(expected, hotPlate[1, 2]);
        }

        [Test]
        public void Verify_third_center_cell_in_4_by_4()
        {
            hotPlate = Create_4_by_4_hot_plate();
            Assert.AreEqual(expected, hotPlate[2, 1]);
        }

        [Test]
        public void Verify_fourth_center_cell_in_4_by_4()
        {
            hotPlate = Create_4_by_4_hot_plate();
            Assert.AreEqual(expected, hotPlate[2, 2]);
        }

        [Test]
        public void Verify_only_center_cell_in_5_by_5()
        {
            size = 5;
            hotPlate = new HotPlate(size);
            Assert.AreEqual(expected, hotPlate[2, 2]);
        }

        private HotPlate Create_4_by_4_hot_plate()
        {
            size = 4;
            return new HotPlate(size);
        }
    }
}
