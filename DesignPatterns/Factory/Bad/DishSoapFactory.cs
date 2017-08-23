using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Factory.Bad
{
    public static class DishSoapFactory
    {
        // Default turkey stats
        private static List<double> GetTurkeyStats()
        {
            string webStats;
            using (var wc = new System.Net.WebClient())
                webStats = wc.DownloadString("http://bakewarez.com:666/turkeyStats.csv");
            return webStats.Split(',').Select(x => double.Parse(x)).ToList();
        }
        public static Cascade.DishSoap LoadDishSoap()
        {
            return new Cascade.DishSoap(GetTurkeyStats());
        }
    }
}
