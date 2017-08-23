using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Factory.Bad
{
    public static class DishSoapFactory
    {
        // Default turkey stats
        private static List<double> GetDefaultTurkeyStats()
        {
            return new double[] { 1, 2, 3, 1, 3, 2, 5, 9 }.ToList();
        }
        public static Cascade.DishSoap LoadDishSoap()
        {
            return new Cascade.DishSoap(GetDefaultTurkeyStats());
        }
    }
}
