using System;
using System.Collections.Generic;

namespace DesignPatterns.Factory.Gud
{
    public class DefaultDishSoap : Cascade.DishSoap
    {
        public DefaultDishSoap(List<double> list) : base(list) { }
        public override Cascade.DishSoap WhatIAm()
        {
            Console.WriteLine("I'm a default dish soap");
            return this;
        }
    }
}
