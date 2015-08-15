using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

// ReSharper disable once CheckNamespace
namespace HotPlate.Core.Tests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    class A_given_cell_value_should_change_to_the_average_of_its_four_adjacent_cells
    {
        private float[,] cells;
        private CellTemperatureCalculator cellTemperatureCalculator;
        private int row;
        private int column;
        private float actual;
        private float expected;

        [SetUp]
        public void Setup()
        {
            cells = new float[,]
            {
                {10f, 20f, 30f},
                {40f, 50f, 60f},
                {70f, 80f, 90f}
            };
            cellTemperatureCalculator = new CellTemperatureCalculator();
        }

        [Test]
        public void Verify_first_cell_in_first_row()
        {
            row = 1;
            column = 1;
            expected = 15;
            Act_and_assert();
        }

        [Test]
        public void Verify_second_cell_in_first_row()
        {
            row = 1;
            column = 2;
            expected = 22.5f;
            Act_and_assert();
        }

        [Test]
        public void Verify_third_cell_in_first_row()
        {
            row = 1;
            column = 3;
            expected = 20;
            Act_and_assert();
        }

        [Test]
        public void Verify_first_cell_in_second_row()
        {
            row = 2;
            column = 1;
            expected = 32.5f;
            Act_and_assert();
        }

        [Test]
        public void Verify_third_cell_in_last_row()
        {
            row = 3;
            column = 3;
            expected = 35f;
            Act_and_assert();
        }

        private void Act_and_assert()
        {
            actual = cellTemperatureCalculator.GetAverage(cells, row - 1, column - 1);
            Assert.AreEqual(expected, actual);
        }
    }
}
