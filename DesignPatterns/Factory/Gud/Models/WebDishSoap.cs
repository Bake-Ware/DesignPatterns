using System;
using System.Collections.Generic;

namespace DesignPatterns.Factory.Gud
{
    public class WebDishSoap : Cascade.DishSoap
    {
        public WebDishSoap(List<double> list) : base(list) { }
        public override Cascade.DishSoap WhatIAm()
        {
            Console.WriteLine("I'm a web dish soap");
            return this;
        }
    }
}
