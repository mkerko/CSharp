using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Polynomial> polynomials = (List<Polynomial>) Polynomial.RandomList(2);
            Polynomial.PrintList(polynomials);
            var nn = polynomials.First();
            polynomials.RemoveAt(0);
            Polynomial prod = polynomials.Aggregate(nn, (a, b) => Polynomial.Sum(a, b));
            Console.WriteLine("result = " + prod);
        }
    }
}