using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

// ReSharper disable once CheckNamespace
namespace HotPlate.Core.Tests
{
    [TestFixture]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    class When_the_temperature_for_a_hot_plate_changes_the_highest_difference_must_be_recorded
    {
        private const int size = 6;
        private HotPlate hotPlate;
        private TemperatureCalculator calculator;
        private float expected;

        [SetUp]
        public void Setup()
        {
            hotPlate = new HotPlate(size);
            calculator = new TemperatureCalculator();
        }

        [Test]
        public void Verify_the_highest_difference_after_the_first_iteration_for_a_6_by_6_hot_plate()
        {
            hotPlate.NextState(calculator);
            expected = 16.6666679f;
            Act_and_assert();
        }

        [Test]
        public void Verify_the_highest_difference_after_the_second_iteration_for_a_6_by_6_hot_plate()
        {
            
            hotPlate.NextState(calculator);
            hotPlate.NextState(calculator);
            expected = 3.125f;
            Act_and_assert();
        }

        private void Act_and_assert()
        {
            var actual = hotPlate.HighestDiff;
            Assert.AreEqual(expected, actual);
        }
    }
}
