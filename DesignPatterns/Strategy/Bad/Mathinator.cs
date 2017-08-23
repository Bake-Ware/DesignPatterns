using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Strategy.Bad
{
    public class Mathinator
    {
        public double MathinateAverageByMean(List<double> values)
        {
            return values.Sum() / values.Count;
        }

        public double MathinateAverageByMedian(List<double> values)
        {
            var sorty = values.OrderBy(x => x).ToList();
            if (sorty.Count % 2 == 1) //that's odd...
                return sorty[(sorty.Count - 1) / 2];
            var halfSorty = sorty.Count / 2;
            return (sorty[halfSorty - 1] + sorty[halfSorty]) / 2;
        }
    }
}
