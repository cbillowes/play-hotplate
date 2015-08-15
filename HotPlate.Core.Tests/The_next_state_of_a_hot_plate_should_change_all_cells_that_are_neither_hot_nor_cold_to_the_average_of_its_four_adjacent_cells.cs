using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

// ReSharper disable once CheckNamespace
namespace HotPlate.Core.Tests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    class The_next_state_of_a_hot_plate_should_change_all_cells_that_are_neither_hot_nor_cold_to_the_average_of_its_four_adjacent_cells
    {
        private int size;
        private HotPlate hotPlate;
        private float[,] expected;

        [Test]
        public void Verify_next_state_of_3_by_3_hot_plate()
        {
            size = 3;
            expected = new [,]
            {
                {           0f, 33.3333321f,          0f },
                {  33.3333321f,        100f, 33.3333321f },
                {           0f, 33.3333321f,          0f }
            };
            Act_and_assert();
        }

        [Test]
        public void Verify_next_state_of_6_by_6_hot_plate()
        {
            size = 6;
            expected = new [,]
            {
                {          0f,   33.3333321f,     50f,   50f, 33.3333321f,           0f },
                { 33.3333321f,           50f,   62.5f, 62.5f,         50f,  33.3333321f },
                {         50f,         62.5f,    100f,  100f,       62.5f,          50f },
                {         50f,         62.5f,    100f,  100f,       62.5f,          50f },
                { 33.3333321f,           50f,   62.5f, 62.5f,         50f,  33.3333321f },
                {          0f,   33.3333321f,     50f,   50f, 33.3333321f,           0f }
            };
            Act_and_assert();
        }

        private void Act_and_assert()
        {
            hotPlate = new HotPlate(size);
            hotPlate.NextState();
            var actual = hotPlate.Current;
            Assert.AreEqual(expected, actual);
        }
    }
}
