using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.SecondSolution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, ICalculator calculator)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (calculator == null)
            {
                throw new ArgumentNullException(nameof(calculator));
            }

            return calculator.AveragingMethod(values);
        }
    }
}
