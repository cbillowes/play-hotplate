using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

// ReSharper disable once CheckNamespace
namespace HotPlate.Core.Tests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    class The_next_state_of_a_hot_plate_should_change_all_cells_that_are_neither_hot_nor_cold_to_the_average_of_its_four_adjacent_cells
    {
        [Test]
        public void Verify_next_state_of_3_by_3_hot_plate()
        {
            var size = 3;
            var hotPlate = new HotPlate(size);
            var cellTemperatureCalculator = new CellTemperatureCalculator();
            hotPlate.NextState(cellTemperatureCalculator);

            var expected = new float[,]
            {
                {  0f,  25f,  0f},
                { 25f, 100f, 25f},
                {  0f,  25f,  0f}
            };
            var actual = hotPlate.Current;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Verify_57th_turn_of_6_by_6_hot_plate()
        {
            var size = 6;
            var hotPlate = new HotPlate(size);
            var cellTemperatureCalculator = new CellTemperatureCalculator();
            var expected = new float[,]
            {
                {  0.00f,  33.33f,  49.99f,  49.99f,  33.33f,   0.00f },
                { 33.33f,  50.00f,  66.66f,  66.66f,  50.00f,  33.33f },
                { 49.99f,  66.66f, 100.00f, 100.00f,  66.66f,  49.99f },
                { 49.99f,  66.66f, 100.00f, 100.00f,  66.66f,  49.99f },
                { 33.33f,  50.00f,  66.66f,  66.66f,  50.00f,  33.33f },
                {  0.00f,  33.33f,  49.99f,  49.99f,  33.33f,   0.00f }
            };
            for (int i = 0; i < 1500; i++)
            {
                hotPlate.NextState(cellTemperatureCalculator);
                if (expected == hotPlate.Current)
                    break;
            }
            float[,] actual = hotPlate.Current;
            Assert.AreEqual(expected, actual);
        }
    }
}
