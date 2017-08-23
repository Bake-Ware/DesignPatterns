using DesignPatterns.Strategy.Gud;
using System;
using System.Linq;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Header
            using (var mrClean = new Cascade.DishSoap())
                mrClean
                    .BackgroundColor(ConsoleColor.White)
                    .ForeColor(ConsoleColor.Black)
                    .WriteLine(new string('<', 17) + "TURKINATOR" + new string('>', 17))
                    .ResetColors()
                    .Newline();
            #endregion
            //MEAT GOES HERE

            #region Strategy Pattern
            var thisATurkeyYo = new double[] { 1, 2, 3, 1, 3, 2, 5, 9 }.ToList();
            #region Strategy Bad Version

            Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Bad way"); Console.ResetColor();
            var badinator = new Strategy.Bad.Mathinator();
            Console.Write("         Turkey: ");
            foreach (var turk in thisATurkeyYo.OrderBy(x => x).ToList())
                Console.Write(turk + " ");
            Console.Write("\n");
            Console.WriteLine("  Median Turkey: " + badinator.MathinateAverageByMedian(thisATurkeyYo));
            Console.WriteLine("Mean Ass Turkey: " + badinator.MathinateAverageByMean(thisATurkeyYo));
            Console.WriteLine("\n");

            #endregion
            #region Strategy Less Bad Version

            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Gud way"); Console.ResetColor();
            var gudinator = new Strategy.Gud.Mathinator();
            Console.Write("         Turkey: ");
            foreach (var turk in thisATurkeyYo.OrderBy(x => x).ToList())
                Console.Write(turk + " ");
            Console.Write("\n");
            Console.WriteLine("  Median Turkey: " + gudinator.Mathinate(thisATurkeyYo, new Medianator()));
            Console.WriteLine("Mean Ass Turkey: " + gudinator.Mathinate(thisATurkeyYo, new Meaninator()));
            Console.WriteLine("\n");

            #endregion
            #endregion

            #region Cascade Pattern

            new Cascade.DishSoap()
                .ForeColor(ConsoleColor.Cyan)
                .WriteLine("Clean way")
                .ResetColors()
                .SetList(thisATurkeyYo)
                .Newline()
                .Median()
                .Mean()
                .Newline()
                ;

            #endregion

            #region Factory Pattern
                #region Super bad way

            var oneBadDishSoapSon = Cascade.DishSoap.CreateBadDishSoap(thisATurkeyYo);

            oneBadDishSoapSon
                .ForeColor(ConsoleColor.DarkRed).BackgroundColor(ConsoleColor.Yellow)
                .WriteLine("Super bad way")
                .ResetColors()
                .Newline()
                .Median()
                .Mean()
                .Newline()
                ;

                #endregion
                #region Bad way

            var moarBadDishSoap = Factory.Bad.DishSoapFactory.LoadDishSoap();
            moarBadDishSoap
                .ForeColor(ConsoleColor.Gray).BackgroundColor(ConsoleColor.DarkRed)
                .WriteLine("Bad way")
                .ResetColors()
                .Newline()
                .Median()
                .Mean()
                .Newline()
                ;

                #endregion
                #region Gud way

            var gudDishSoap = Factory.Gud.DishSoapFactory.LoadDishSoap();
            gudDishSoap
                .ForeColor(ConsoleColor.Blue).BackgroundColor(ConsoleColor.White)
                .WriteLine("Gud way")
                .ResetColors()
                .WhatIAm()
                .Newline()
                .Median()
                .Mean()
                .Newline()
                ;

                #endregion
            #endregion

            //MEAT GOES HERE
            Console.WriteLine("Press the any key to exit");
            Console.ReadKey();
        }
    }
}
