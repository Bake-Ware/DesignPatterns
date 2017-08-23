using System;
using System.Collections.Generic;

namespace DesignPatterns.Factory.Gud
{
    public class FileDishSoap : Cascade.DishSoap
    {
        public FileDishSoap(List<double> list) : base(list) { }
        public override Cascade.DishSoap WhatIAm()
        {
            Console.WriteLine("I'm a file dish soap");
            return this;
        }
    }
}
