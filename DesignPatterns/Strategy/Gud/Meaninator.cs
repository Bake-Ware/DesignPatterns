using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Strategy.Gud
{
    public class Meaninator : IMathinatorMethod
    {
        public double MathinateFor(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}
