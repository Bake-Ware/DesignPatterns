using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DesignPatterns.Factory.Gud
{
    class DishSoapFactory
    {
        // Default turkey stats
        private static List<double> GetDefaultTurkeyStats()
        {
            return new double[] { 1, 2, 3, 1, 3, 2, 5, 9 }.ToList();
        }
        public static Cascade.DishSoap LoadDishSoap()
        {
            var finalSoap = new Cascade.DishSoap();
            if (File.Exists("LocalTurkeyDefaults.turk")) //some local turkey stats override 
            {
                var fileTurkeyStats = File.ReadAllText("LocalTurkeyDefaults.turk").Split(',').Select(x => double.Parse(x)).ToList();
                finalSoap = new FileDishSoap(fileTurkeyStats);
            }
            else //See if the internet knows some turkey stats
            {
                string webStats;
                using (var wc = new System.Net.WebClient())
                    webStats = wc.DownloadString("http://bakewarez.com:666/turkeyStats.csv");
                if(webStats != null) //internet driven turkey stats
                    finalSoap = new WebDishSoap(webStats.Split(',').Select(x => double.Parse(x)).ToList());
                else //just use the local, maybe horribly outdated turkey stats
                    finalSoap = new DefaultDishSoap(GetDefaultTurkeyStats());
            }
            return finalSoap; //return the soaps
        }
    }
}
