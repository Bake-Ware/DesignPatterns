using DesignPatterns.Strategy.Gud;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Cascade
{
    public class DishSoap : IDisposable
    {
        List<double> _list { get; set; }
        public DishSoap ForeColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            return this;
        }
        public DishSoap BackgroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            return this;
        }
        public DishSoap ResetColors()
        {
            Console.ResetColor();
            return this;
        }
        public DishSoap WriteLine(string text)
        {
            Console.WriteLine(text);
            return this;
        }
        public DishSoap Newline()
        {
            Console.Write("\n");
            return this;
        }

        //*params nerd
        //public DishSoap SetList(params double[] list)
        //{
        //    return SetList(list.ToList());
        //}
        public DishSoap SetList(params double[] list) => SetList(list.ToList()); //*expression body nerd (C# 6.0+/VS 2015+ only)

        public DishSoap SetList(List<double> list)
        {
            _list = list;
            Console.Write("          _list: ");
            foreach (var ist in _list.OrderBy(x => x).ToList())
                Console.Write(ist + " ");
            return this;
        }
        public DishSoap Mean()
        {
            Console.WriteLine(" Mean Ass _list: " + Average(new Meaninator()));
            return this;
        }
        public DishSoap Median()
        {
            Console.WriteLine("   Median _list: " + Average(new Medianator()));
            return this;
        }
        private double Average(IMathinatorMethod method)
        {
            return new Mathinator().MathinateAverage(_list, method);
        }

        #region Factory Support
        public DishSoap() { }
        public DishSoap(List<double> list) //* internal means public to assembly, but private to anything outside of it
        {
            _list = list;
        }
        public static DishSoap CreateBadDishSoap(List<double> list)
        {
            return new DishSoap(list);
        }
        public virtual DishSoap WhatIAm()
        {
            return this;
        }
        #endregion

        #region IDisposable Support
        private bool disposedValue = false; 

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this._list = null;
                }
                disposedValue = true;
            }
        }

        ~DishSoap() {
          Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion


    }
}
