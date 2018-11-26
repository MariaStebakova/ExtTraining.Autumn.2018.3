using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class Calculator
    {
        public delegate double AveragingMethod(List<double> doubles);

        public double CalculateAverage(List<double> values, AveragingMethod averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException(nameof(averagingMethod));
            }

            return averagingMethod(values);
        }
    }

    //Выбрано решение использования делегатов тк оно на субъектвный взгляд самое подходящее, тк
    //необходимо просто выполнить определенный метод
}
