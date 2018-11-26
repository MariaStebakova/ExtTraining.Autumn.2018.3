using System.Collections.Generic;
using No3.Solution.FirstSolution;
using No3.Solution.SecondSolution;
using NUnit.Framework;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean_ByFirstSolution()
        {
            FirstSolution.Calculator calculator = new FirstSolution.Calculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, Methods.Mean);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_ByFirstSolution()
        {
            FirstSolution.Calculator calculator = new FirstSolution.Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, Methods.Median);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMean_BySecondSolution()
        {
            SecondSolution.Calculator calculator = new SecondSolution.Calculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, new MeanCalculator());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_BySecondSolution()
        {
            SecondSolution.Calculator calculator = new SecondSolution.Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, new MedianCalculator());

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}